using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
    public class playerController               //aanmaken van view en model
    {
        public playerView _playerView;
        public playerModel _playerModel;
        
        public playerController()
        {
            _playerView = new playerView(this);
            _playerModel = new playerModel();
        }
        public playerView getPlayerView()
        {
            return _playerView;
        }
    }
}
