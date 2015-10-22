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
        //static int seeder;
        Random _random = new Random();          //seeder toevoegen???
        int totalScore;
        

        private int minCard = 1;
        private int maxCard = 14;

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
            _playerModel.hitCount++;        //hitCount bijhouden
            if (_playerModel.hitCount < 6)
            {
                _playerModel.kaartWaarden[_playerModel.hitCount] = _random.Next(minCard, maxCard); //bij iedere hit komt er een nieuwe random
            }
            updateTotalScore();
        }

        public void loadKaarten()
        {
            for(int kaart = 0; kaart < _playerModel.kaartWaarden.Length; kaart++)
            {
                _playerModel.kaartWaarden[kaart] = 0;           //initialisatie van de kaarten, allemaal op 0
            }
            _playerModel.kaartWaarden[0] = _random.Next(minCard, maxCard);  //eerste kaart krijgt meteen een random
            _playerModel.kaartWaarden[1] = _random.Next(minCard, maxCard);  //eerste kaart krijgt meteen een random
        }

        public void updateTotalScore()
        {
            int totalScore = 0;
            for(int i = 0; i<_playerModel.kaartWaarden.Length ; i++)
            {
                totalScore += _playerModel.kaartWaarden[i];
            }
            _playerModel.huidigeScore = totalScore;
        }

        public void playerPassed()
        {
            _playerModel.isPassed = true;

        }
    }
}
