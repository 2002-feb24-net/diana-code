using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLibrary
{
    public class RandomStrategy : IRPSStrategy
    {
        public string DecideMove(List<string> previousOutcomes)
        {
            string[] possibleMoves = { "R", "P", "S" };
            var random = new Random();
            return possibleMoves[random.Next(0, 3)];
            // (some random integer from 0 up to but not including 3)
        }
    }
}
