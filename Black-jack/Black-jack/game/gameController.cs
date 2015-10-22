using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
  public  class gameController
    {
        public gameView _gameView;
        public gameModel _gameModel;
        

        public gameController()
        {
            _gameView = new gameView(this);
            _gameModel = new gameModel();
        }
    }
}
