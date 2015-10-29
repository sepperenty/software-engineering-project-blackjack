using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
  public  class computerController
    {
        public computerView _computerView;
        public computerModel _computerModel;
        private int minCard = 0;
        private int maxCard = 14;
        private Random random = new Random();


        public computerController()
        {
            _computerView = new computerView(this);
            _computerModel = new computerModel();
        }

        public void throwCards()
        {

            for(int kaartNummer = 2; kaartNummer < 5; kaartNummer++)
            {
                //_computerModel.randomComputerKaarten[kaartNummer] = random.Next(minCard, maxCard);
                int huidigComputerTotaal = countScore();

                if(huidigComputerTotaal < 17)
                {
                    _computerModel.randomComputerKaarten[kaartNummer] = random.Next(minCard, maxCard);
                    _computerModel._huidigeScore = countScore();
                }
            }
        }
        
        public int countScore()
        {
            int huidigComputerTotaal = 0;

            for (int kaart = 0; kaart < _computerModel.randomComputerKaarten.Length; kaart++)
            {
                huidigComputerTotaal += _computerModel.randomComputerKaarten[kaart];
            }

            return huidigComputerTotaal;
        }



        public void loadCards()
        {
            for (int kaart = 0; kaart < 2; kaart++)
            {
                _computerModel.randomComputerKaarten[kaart] = random.Next(minCard, maxCard);
            }

            _computerModel._huidigeScore = countScore();
        }
    }
}
