using HangManClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManConsole
{
    public class ProgramUI
    {
        //HEAD
  

         // 1.) Create Hangman [Main Menu]
            // 2.) User friendly and can interact with the [Main Menu] business logic
            // 3.) Keep an up to date collection
            
            // 1.0_(Main menu) conditionals will be: Booleans: While Loops, If else statements. Switch Cases: following CRUD process. Also a location where the user can rate the game. we will refactor in new content like levels & players - if we want to add those- using fields and constructs after the game is completed. 
            
            
            //1.1_(Main menu) Simple step by step process of how-to-play. Applying the Console.WriteLine operator. *This will most likely be the last thing we get to.
            
            //Creating the Game

            // Prototype 
         public void Run()
        {
            //ListOfWordsTwo();
            RunMenu();
        }
        public void RunMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                
                Console.WriteLine("Hello and Welcome to Hangman; where you'll play against family, friends, and aquintances. \n" +
               "Try and beat your highscore by pressing the timed option. \n" +
               "There will be new updated words every week, so the fun will never end, enjoy!: \n" +
               "Enter the number of the option you would like to select: \n" +
               "1. StartGame \n" +
               "2. Play New Version \n" +
               "3. Score Board \n" +
               "4. Tutorial \n" +
               "5. Game Rating \n" +
               "6. Creators \n" +
               "7. Age Group \n" +
               "8. Dictionary \n" +
               "9. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        startGame();
                        break;
                    case "2":
                        playNewVersion();
                        break;
                    case "3":
                        scoreBoard();
                        break;
                    case "4":
                        tutorial();
                        break;
                    case "5":
                        gameRating();
                        break;
                    case "6":
                        creators();
                        break;
                    case "7":
                        ageGroup();
                        break;
                    case "8":
                        dictionary();
                        break;
                    case "9":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 9. \n" + "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }

                // Need to Reference the HangManClasLibrary.cs to ProgramUI.cs. we will put the Sources on the Console soon.
                
                /* StartGame - ListOfWords
                 * PLayNewVersion- ListOfwordsTwo add new features updating the game. [meaning delete the main listOfWords]
                 * ScoreBoard
                 * Tutorial
                 * GameRating
                 * Creators
                 * AgeGroup
                 * Dictionary
                 * Exit
                 */

                // We will construct the rest of the while loop (keepRunning) & also attempt to debug/test our gaming program. Once this is complete we should be all set. *High five*
            }
            {
                
                string[] listOfWords = new string[13];
                Random randGuess = new Random();
                var aToZ = randGuess.Next(1, 13);
                string unknownWord = listOfWords[aToZ];
                char[] guess = new char[unknownWord.Length];
                Console.WriteLine("Enter your guess here, please:");

                for(int g = 0; g < unknownWord.Length; g ++ )
                    guess[g] = '_';
                while (true)
                {
                    char userGuess = char.Parse(Console.ReadLine());
                    for (int p = 0; p < unknownWord.Length; p++)
                    {
                        if(userGuess == unknownWord[p])
                            guess[p] = userGuess;
                    }
                    Console.WriteLine(guess);
                }
                /*string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "unkownWord":
                        guess();
                        break;
                }
                    (// Incorrect character the user inputs Console.Writeline (("switch case")) [1 head, 2 neck, 3 torso, 4 leftArm, 5 rightArm, 6 rightLeg, 7 rightFoot, 8 leftLeg, 9 leftFoot, default, Console.Writline(("HangMan, Want to Retry?"]))
                foreach(// Complete answer the user inputs Console.Writline("Winner!!!"))*/


                
                
              
            } 
            
            
            
        }

        private void dictionary()
        {
            throw new NotImplementedException();
        }

        private void ageGroup()
        {
            throw new NotImplementedException();
        }

        private void creators()
        {
            throw new NotImplementedException();
        }

        private void gameRating()
        {
            throw new NotImplementedException();
        }

        private void tutorial()
        {
            throw new NotImplementedException();
        }

        private void scoreBoard()
        {
            throw new NotImplementedException();
        }

        private void playNewVersion()
        {
            throw new NotImplementedException();
        }

        private void startGame()
        {
            throw new NotImplementedException();
        }




        //603783ea2eb6e5acb9d02235171b699c7a648632
    }
}
