using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManClassLibrary
{
    public class HangManClassLibrary
    {
        public enum ListOfWords
    {
            Ellevenfifty = 1,
            Software,
            Bootcamp,
            Developer,
            Indexhtml,
            Indexcss,
            Code,
            Challenges,
            Learninggym,
            Coffee,
            fuel,
            Csharp, 
            Functions,

    }
    public enum ListOfWordsTwo
    {
        Anxiety =1,
        flustered,
        Hoodwinked,
        Compitent,
        Irate,
        Boastful,
        Despair,
        Uplifting,
        energetic,
        Brainstorm,


    }

    public enum GameRating
    {
        Amazing = 1,
        Great,
        Good,
        Alright,
        Boring,
        Horrible
          
         
        // || StarRating: Stars (1 - 5)
        /* 5
         * 5.23
         * 5.1
         * 4
         * 4.5
         * etc
         */
    }
    public class GamePlay 
	{
         private string ListOfWords { get; }
         private string ListOfWordsTwo { get; }
        public string StartGame { get; set;}
        public string PlayNewVersion { get; set; }
         public double ScoreBoard { get; set; }
         public string Tutorial { get; set ;}
         public GameRating GameRating { get; set;}
         public string Creators { get; set;}
         public bool AgeGroup { get; set; }
         public string Dictionary { get; set;}
         

	}
    public GamePlay()
    {

    }
    public GamePlay( string listOfWords, string listOfWordsTwo, string startGame, string playNewVersion, double scoreBoard, string tutorial, GameRating gameRating, string creators, bool ageGroup, string dictionary)
    {
       ListOfWords = listOfWords;
       ListOfWordsTwo = listOfWordsTwo;
       StartGame = startGame;
       PLayNewVersion = playNewVersion;
       ScoreBoard = scoreBoard;
       Tutotorial = tutorial;
       GameRating = gameRating;
       Creators = creators;
       AgeGroup = ageGroup;
       Dictionary = dictionary; 
            

    }
    }
}
