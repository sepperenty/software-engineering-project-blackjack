using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
    public class playerModel
    {
        public int _huidigeScore = 0;
        public int[] _kaartenWaarde = new int[6];
        public int _hitCount = 1;
        public bool _isPassed = false;

        public int hitCount
        {
            get { return _hitCount; }
            set { _hitCount = value; }
        }
        public int[] kaartWaarden
        {
            get { return _kaartenWaarde; }
            set { _kaartenWaarde = value; }
        }
        public int huidigeScore
        {
            get { return _huidigeScore; }
            set { _huidigeScore = value; }
        }
        public bool isPassed
        {
            get { return _isPassed; }
            set { _isPassed = value; }
        }
    }
}
