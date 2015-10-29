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
            _computerController.loadCards();
            updateCards();
            playerCard1.Text = '/'.ToString();
            playerTotal.Text = '/'.ToString();
        }


        private void btnTrowCards_Click(object sender, EventArgs e)
        {
            
        }

        public void updateCards()
        {

            playerCard1.Text = _computerController._computerModel.randomComputerKaarten[0].ToString();
            playerCard2.Text = _computerController._computerModel.randomComputerKaarten[1].ToString();
            playerCard3.Text = _computerController._computerModel.randomComputerKaarten[2].ToString();
            playerCard4.Text = _computerController._computerModel.randomComputerKaarten[3].ToString();
            playerCard5.Text = _computerController._computerModel.randomComputerKaarten[4].ToString();
            playerTotal.Text = _computerController._computerModel.huidigeScore.ToString();
            

        }
    }
}
