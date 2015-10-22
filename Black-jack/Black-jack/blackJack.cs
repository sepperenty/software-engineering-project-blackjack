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
        int _numberOfPlayers = 2;
        int yPosPlayer;
        List<playerController> playerList = new List<playerController>();

        public blackJack()
        {
            InitializeComponent();
           _computerController = new computerController();
        }

        private void blackJack_Load(object sender, EventArgs e)
        {
            computerView huidigeComputerView = _computerController._computerView;
            yPosPlayer = huidigeComputerView.Height;
            Controls.Add(huidigeComputerView);
            loadPlayers();  //load players in list
            drawPlayers();  //draw the players on the stage
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
                playerView huidigePlayerView = playerList[playerNumber]._playerView;
                int xPosPlayer = playerList[playerNumber]._playerView.Width * playerNumber;
                huidigePlayerView.Location = new Point(xPosPlayer, yPosPlayer);
                Controls.Add(huidigePlayerView);
            }
        }
    }
}
