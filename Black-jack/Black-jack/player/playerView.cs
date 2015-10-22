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
            update();
            //playerCard6.Text = _playerController._playerModel.kaartWaarden[5].ToString();

        }

      

        private void btnPass_Click(object sender, EventArgs e)
        {
          

        }

        private void playerTotal_Click(object sender, EventArgs e)
        {

        }

        private void playerView_Load(object sender, EventArgs e)
        {
            _playerController.loadKaarten();
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
        }
    }
}
