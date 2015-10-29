using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black_jack
{
    public partial class playerView : UserControl
    {
        
        public playerController _playerController;
        public playerView(playerController initPlayerController)
        {
            InitializeComponent();
            _playerController = initPlayerController;
        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            _playerController.hitMe();
            update();                      //update kaarwaarde (labels == waarde van model)
            
            
        }
          

        private void btnPass_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            _playerController.playerPassed();
        }

        private void playerTotal_Click(object sender, EventArgs e)
        {

        }

        private void playerView_Load(object sender, EventArgs e)
        {
            _playerController.loadKaarten();
            _playerController.updateTotalScore();
            lblIdentity.Text = "Player: " + _playerController._playerModel._playerIdentity.ToString();
            update();
        }

        private void update()
        {
            playerCard1.Text = _playerController._playerModel.kaartWaarden[0].ToString();
            playerCard2.Text = _playerController._playerModel.kaartWaarden[1].ToString();
            playerCard3.Text = _playerController._playerModel.kaartWaarden[2].ToString();
            playerCard4.Text = _playerController._playerModel.kaartWaarden[3].ToString();
            playerCard5.Text = _playerController._playerModel.kaartWaarden[4].ToString();
            playerCard6.Text = _playerController._playerModel.kaartWaarden[5].ToString();
            playerTotal.Text = _playerController._playerModel.huidigeScore.ToString();

            //if (_playerController._playerModel.isPassed)
            //{
            //    btnHit.Enabled = false;
            //}

            btnHit.Enabled = !_playerController._playerModel.isPassed;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
