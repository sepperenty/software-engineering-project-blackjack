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
        

        public computerController()
        {
            _computerView = new computerView(this);
            _computerModel = new computerModel();
        }
    }
}
