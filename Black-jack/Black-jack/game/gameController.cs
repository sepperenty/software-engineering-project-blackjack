using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
  public  class gameController
    {
        public gameModel _gameModel  = new gameModel();

        public void WhoWon(List<playerController> playerlist, int computerScore)
        {
            int winningScore = 0;
            string winner = "";

            for (int i = 0; i < playerlist.Count; i++)
            {
                int huidigePlayerScore = playerlist[i]._playerModel._huidigeScore;
                if (winningScore < huidigePlayerScore && huidigePlayerScore <= 21)
                {
                    winningScore = huidigePlayerScore;
                    int winnerPlusOne = i + 1;
                    winner = "player " + winnerPlusOne.ToString() + " won";
                }
            } 

      

      
            if(computerScore > winningScore && computerScore <= 21)
            {
                _gameModel.endWinner = "computer won";
            }

            else if(winningScore > computerScore && computerScore <= 21)
            {
                _gameModel.endWinner = winner;
            }

            else
            {
                _gameModel.endWinner = "nobody won";
            }
        }

        public bool CheckIfPassed(List<playerController> playerlist)
        {
            bool isPassed = true;


            for (int i = 0; i < playerlist.Count; i++)
            {
                if(!playerlist[i]._playerModel.isPassed)
                {
                    isPassed = false;
                }
            }

            return isPassed;
        }
    }
}

