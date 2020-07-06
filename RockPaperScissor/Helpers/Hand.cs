using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissor.Helpers
{
    public class Hand
    {
        public OptionsRPS Selection { get; set; }
        public OptionsRPS WinsAgainst { get; set; }
        public OptionsRPS LosesAgainst { get; set; }
        public string Image { get; set; }

        public GameStatus PlayAgainst(Hand opponentHand)
        {
            if (Selection==opponentHand.Selection)
            {
                return GameStatus.Draw;
            }
            if (LosesAgainst==opponentHand.Selection)
            {
                return GameStatus.Lose;
            }
            return GameStatus.Victory;
        }
    }
}
