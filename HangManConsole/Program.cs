using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Where saved game data is stored
            ProgramUI game = new ProgramUI();
            game.Run();
        }
    }
}
