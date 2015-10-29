using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_jack
{
    public partial class blackJack : Form
    {
        computerController _computerController;
        gameController _gameController;

        int _numberOfPlayers = 4;
        int yPosPlayer;
        bool everyonePassed = false;
        List<playerController> _playerList = new List<playerController>();

        public blackJack()
        {
            InitializeComponent();
            _computerController = new computerController();
            _gameController = new gameController();
        }

        private void blackJack_Load(object sender, EventArgs e)
        {
            computerView huidigeComputerView = _computerController._computerView;
            yPosPlayer = huidigeComputerView.Height;
            Controls.Add(huidigeComputerView);
            loadPlayers();  //load players in list
            drawPlayers();  //draw the players on the stage
            timer1.Start();
            lblWinMessage.Text = "";
        }

        private void loadPlayers()
        {
            for (int playerNumber = 0; playerNumber < _numberOfPlayers; playerNumber++)
            {
                playerController huidigePlayer = new playerController();
                _playerList.Add(huidigePlayer);
            }
        }

        private void drawPlayers()
        {
            for (int playerNumber = 0; playerNumber < _numberOfPlayers; playerNumber++)
            {
                playerView huidigePlayerView = _playerList[playerNumber]._playerView;
                int xPosPlayer = _playerList[playerNumber]._playerView.Width * playerNumber;
                huidigePlayerView.Location = new Point(xPosPlayer, yPosPlayer);
                huidigePlayerView._playerController._playerModel._playerIdentity = playerNumber+1;
                Controls.Add(huidigePlayerView);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            everyonePassed = _gameController.CheckIfPassed(_playerList);

            if(everyonePassed)
            {
                _computerController.throwCards();
                _computerController._computerView.updateCards();
                _gameController.WhoWon(_playerList, _computerController._computerModel.huidigeScore);
                lblWinMessage.Text = _gameController._gameModel.endWinner;
            }
        }
    }
}
