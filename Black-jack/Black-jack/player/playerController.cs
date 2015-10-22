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
        static int seeder;
        Random _random = new Random(++seeder);
        
        public playerController()
        {
            _playerView = new playerView(this);
            _playerModel = new playerModel();
        }
        public playerView getPlayerView()
        {
            return _playerView;
        }

        public void hitMe()
        {  
            _playerModel.hitCount++;
            if (_playerModel.hitCount < 6)
            {
                _playerModel.kaartWaarden[_playerModel.hitCount] = _random.Next(0, 15);
            }
        }

        public void loadKaarten()
        {
            for(int kaart = 0; kaart < _playerModel.kaartWaarden.Length; kaart++)
            {
                _playerModel.kaartWaarden[kaart] = 0;
            }
            _playerModel.kaartWaarden[0] = _random.Next(0,15);
           
        }
    }
}
