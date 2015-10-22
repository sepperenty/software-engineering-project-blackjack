using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
   public class computerModel
    {
        List<int> finalgameScore = new List<int>();

        public List<int> finaleScores
        {
            get { return finalgameScore; }
            set { finalgameScore = value; }
        }
    }
}
