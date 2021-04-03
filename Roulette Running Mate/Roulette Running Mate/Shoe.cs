using Roulette_Running_Mate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette_Running_Mate
{
    public class Shoe
    {
        public List<Outcome> Hands { get; set; }
        public decimal HighestBetAmountLost { get; set; }
        public Result LastResult { get; set; }
        public decimal LastBetAmount { get; set; }
        public Outcome LastOutcomeChoice { get; set; }
        public bool IsInContinuationPattern { get; set; }
        public bool IsInLossRecoveryPattern { get; set; }
        public decimal Bankroll { get; set; }

        public Shoe()
        {
            this.Hands = new List<Outcome>();
        }
    }
}
