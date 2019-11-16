using PlayMusicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

            Console.WriteLine("----------- Play music App -----------");
            Console.WriteLine("<Up>-Scale, <Down>-HappyBirthday, <Left>-Tetris, <Right>-Random");

            while (true)
            {
                Console.WriteLine("\n Press an <Arrow> key or <Esc> to exit: ");
                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow: PlayMusic.PlayScale(); break;
                    case ConsoleKey.DownArrow: PlayMusic.PlayHappyBirthday(); break;
                    case ConsoleKey.LeftArrow: PlayMusic.PlayTetris(); break;
                    case ConsoleKey.RightArrow: PlayMusic.PlayRandom(); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }
    }
}