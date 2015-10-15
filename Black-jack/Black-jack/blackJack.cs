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
        playerController _playerController;

        public blackJack()
        {
            InitializeComponent();
            _playerController = new playerController();
        }

        private void blackJack_Load(object sender, EventArgs e)
        {
            Controls.Add(_playerController._playerView);
        }
    }
}
