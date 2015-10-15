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

        }

        private void btnPass_Click(object sender, EventArgs e)
        {

        }
    }
}
