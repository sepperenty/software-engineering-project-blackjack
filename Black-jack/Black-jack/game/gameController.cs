using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_jack
{
  public  class gameController
    {
        public string WhoWon(List<playerController> playerlist)
        {
            int winningScore = 0;
            string winner = "";

            for(int i = 0; i < playerlist.Count; i++)
            {
                int huidigePlayerScore = playerlist[i]._playerModel._huidigeScore;
                if (winningScore < huidigePlayerScore)
                {
                    winningScore = huidigePlayerScore;
                    winner = "player " + i.ToString() + " won";
                }


            }

            return winner;
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
