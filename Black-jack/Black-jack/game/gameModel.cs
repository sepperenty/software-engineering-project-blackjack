using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
   public class gameModel
    {
        public string _endWinner;

        public string endWinner
        {
            get { return _endWinner; }
            set { _endWinner = value; }
        }
    }
}
