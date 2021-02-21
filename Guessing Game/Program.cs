using System;

namespace Guessing_Game {
    class Program {
        static void Main(string[] args) {

            //instantiate the guesser game with the name to guess and the number of tries as parameters 
            Guesser guesser = new Guesser("Allan", 3);

            guesser.PlayerGame();
        }
    }
}
