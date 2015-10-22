using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
  public  class gameController
    {
        public gameView _gameVieuw;
        public gameModel _gameModel;
        public gameController()
        {
            _gameVieuw = new gameView(this);
            _gameModel = new gameModel();
        }
    }
}
