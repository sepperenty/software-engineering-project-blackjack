using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
    public class computerModel
    {
        public int[] _randomComputerKaarten = new int[5];
        public int _huidigeScore = 0;

        public int huidigeScore
        {
            get { return _huidigeScore; }
            set { _huidigeScore = value; }
        }

        public int[] randomComputerKaarten
        {
            get { return _randomComputerKaarten; }
            set { _randomComputerKaarten = value; }
        }

    }
}
