﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManConsole
{
    class ProgramUI
    {
         // 1.) Create Hangman [Main Menu]
            // 2.) User friendly and can interact with the [Main Menu] business logic
            // 3.) Keep an up to date collection
            
            // 1.0_(Main menu) conditionals will be: Booleans: While Loops, If else statements. Switch Cases: following CRUD process. Also a location where the user can rate the game. we will refactor in new content like levels & players - if we want to add those- using fields and constructs after the game is completed. 
            
            
            //1.1_(Main menu) Simple step by step process of how-to-play. Applying the Console.WriteLine operator. *This will most likely be the last thing we get to.
            
            //Creating the Game

            // Prototype 
         public void Run()
        {
            ListOfWordsTwo();
            RunMenu();
        }
        public void RunMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                 Console.WriteLine("Hello and Welcome to Hangman; where you'll play against family, friends, and aquintances. \n" +
                "Try and beat your highscore by pressing the timed option. \n" +
                "There will be new updated words every week, so the fun will never end, enjoy!");
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
                ListOfWords = new string[13]:
                Random randGuess = new Random();
                var aToZ = randGuess.Next(1, 13);
                string unknownWord = ListOfWords[aToZ]:
                char [] guess = new char[unknownWord.Length]:
                Console.WriteLine("Enter your guess here, please:");

                for(int g = 0; g < unknownWord.Length: g ++ )
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



                
                
              
            } 
            
            
            
        }
    }
}
