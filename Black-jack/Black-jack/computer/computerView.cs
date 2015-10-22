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
    public partial class computerView : UserControl
    {
        public computerController _computerController;

        public computerView( computerController initComputerController)
        {
            InitializeComponent();
            _computerController = initComputerController;

        }

        private void computerView_Load(object sender, EventArgs e)
        {

        }
    }
}
