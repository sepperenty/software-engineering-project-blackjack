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
        gameController _gameController;

        public blackJack()
        {
            InitializeComponent();
            _playerController = new playerController();
            _gameController = new gameController();
        }

        private void blackJack_Load(object sender, EventArgs e)
        {
            gameView huidigGameVieuw = _gameController._gameVieuw;
            playerView huidigPlayerVieuw = _playerController._playerView;
            int yPos = huidigGameVieuw.Height;
            huidigPlayerVieuw.Location = new Point(0, yPos);

            Controls.Add(huidigGameVieuw);
            
            Controls.Add(huidigPlayerVieuw);
            
           
        }
    }
}
