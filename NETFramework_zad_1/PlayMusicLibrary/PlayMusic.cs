using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayMusicLibrary
{
    public class PlayMusic
    {
        static int C = 264;
        static int D = 297;
        static int E = 330;
        static int F = 352;
        static int G = 396;
        static int A = 440;
        static int Bb = 466;
        static int B = 495;
        static int C2 = 528;

        static int note = 1000;
        static int half = 1000 / 2;
        static int quarter = 1000 / 4;
        static int eighth = 1000 / 8;

        public static void PlayScale()
        {
            Console.WriteLine("----------- Scale -----------");
            Thread.Sleep(2000);

            Console.Beep(C, quarter);
            Console.Beep(D, quarter);
            Console.Beep(E, quarter);
            Console.Beep(F, quarter);
            Console.Beep(G, quarter);
            Console.Beep(A, quarter);
            Console.Beep(B, quarter);
            Console.Beep(C2, half);
            Thread.Sleep(quarter);
            Console.Beep(C2, quarter);
            Console.Beep(B, quarter);
            Console.Beep(A, quarter);
            Console.Beep(G, quarter);
            Console.Beep(F, quarter);
            Console.Beep(E, quarter);
            Console.Beep(D, quarter);
            Console.Beep(C, half);
        }

        public static void PlayHappyBirthday()
        {
            Console.WriteLine("----------- Happy Birthday -----------");
            Thread.Sleep(2000);

            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, half);
            Thread.Sleep(eighth);
            Console.Beep(C, half);
            Thread.Sleep(eighth);
            Console.Beep(F, half);
            Thread.Sleep(eighth);
            Console.Beep(E, note);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(D, half);
            Thread.Sleep(eighth);
            Console.Beep(C, half);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(eighth);
            Console.Beep(F, note);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(quarter);
            Console.Beep(C, eighth);
            Thread.Sleep(eighth);
            Console.Beep(C2, half);
            Thread.Sleep(eighth);
            Console.Beep(A, half);
            Thread.Sleep(eighth);
            Console.Beep(F, quarter);
            Thread.Sleep(eighth);
            Console.Beep(F, eighth);
            Thread.Sleep(eighth);
            Console.Beep(E, half);
            Thread.Sleep(eighth);
            Console.Beep(D, note);
            Thread.Sleep(quarter);
            Console.Beep(Bb, eighth);
            Thread.Sleep(quarter);
            Console.Beep(Bb, eighth);
            Thread.Sleep(eighth);
            Console.Beep(A, half);
            Thread.Sleep(eighth);
            Console.Beep(F, half);
            Thread.Sleep(eighth);
            Console.Beep(G, half);
            Thread.Sleep(eighth);
            Console.Beep(F, note);
        }

        public static void PlayTetris()
        {
            Console.WriteLine("----------- Tetris -----------");
            Thread.Sleep(2000);

            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
            Thread.Sleep(50);
            Console.Beep(250, 500);
            Thread.Sleep(50);
            Console.Beep(350, 250);
            Console.Beep(300, 500);
        }

        public static void PlayRandom()
        {
            Console.WriteLine("----------- Random -----------");
            Thread.Sleep(2000);

            Random randomSounds = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.Beep(randomSounds.Next(1000) + 100, 100);
            }
        }
    }
}