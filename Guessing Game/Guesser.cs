using System;
using System.Collections.Generic;
using System.Text;

namespace Guessing_Game {
    class Guesser {

        string nameToGuess;
        int tries;
        
        //constructor that takes the name to guess and the number of tries as parameters
        public Guesser(string nameToGuess, int tries) {
            this.nameToGuess = nameToGuess;
            this.tries = tries;
        } 
        

        public void PlayerGame() {
            //bool to check if the player has guessed the right answer
            bool guessedRight = false;

            //while you still have tries left and the right answer has not been entered
            while (tries > 0 && !guessedRight) {
                Console.WriteLine("Tries left: " + tries);
                Console.Write("Please guess a name: ");
                string guess = Console.ReadLine();

                //if guess is right
                if (guess.ToUpper() == nameToGuess.ToUpper()) {
                    Console.WriteLine("Correct! " + guess.ToUpper() + " is the right answer!");
                    guessedRight = true;
                }
                //if guess is wrong
                else if (guess.ToUpper() != nameToGuess.ToUpper()) {
                    Console.WriteLine("Incorrect, " + guess.ToUpper() + " is not the right answer. Try again.");
                    tries--;
                }
                Console.WriteLine("______________________________________________________");
            }

            //if the player guessed right
            if (guessedRight) {
                Console.WriteLine("Congratulations! Thanks for playing.");
            }
            //if the player has no guesses left
            else if (tries == 0) {
                Console.WriteLine("You lost. Better luck next time...");
            }
        }


    }
}
