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
        gameController _gameController;
        int _numberOfPlayers = 2;
        int yPosPlayer;
        List<playerController> playerList = new List<playerController>();

        public blackJack()
        {
            InitializeComponent();
            _gameController = new gameController();
        }

        private void blackJack_Load(object sender, EventArgs e)
        {
            gameView huidigGameVieuw = _gameController._gameVieuw;
            yPosPlayer = huidigGameVieuw.Height;
            Controls.Add(huidigGameVieuw);
            loadPlayers();
            drawPlayers();


        }

        private void loadPlayers()
        {
            for (int playerNumber = 0; playerNumber < _numberOfPlayers; playerNumber++)
            {
                playerController huidigePlayer = new playerController();
                playerList.Add(huidigePlayer);
            }
        }

        private void drawPlayers()
        {
            for (int playerNumber = 0; playerNumber < _numberOfPlayers; playerNumber++)
            {
                playerView huidigePlayerVieuw = playerList[playerNumber]._playerView;
                int xPosPlayer = playerList[playerNumber]._playerView.Width * playerNumber;
                huidigePlayerVieuw.Location = new Point(xPosPlayer, yPosPlayer);
                Controls.Add(huidigePlayerVieuw);
            }
        }
    }
}
