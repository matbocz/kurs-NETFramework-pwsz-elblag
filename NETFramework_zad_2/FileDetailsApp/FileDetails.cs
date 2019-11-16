using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDetailsApp
{
    class FileDetails
    {
        public static void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0, polish = 0;

            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                    if ("ĄĆĘŁŃÓŚŹŻąćęłńóśźż".IndexOf(current) != -1)
                    {
                        polish++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }

            Console.WriteLine("\n\nTotal no of characters: {0}", contents.Length);
            Console.WriteLine("Total no of vowels : {0}", vowels);
            Console.WriteLine("Total no of consonants: {0}", consonants);
            Console.WriteLine("Total no of lines : {0}", lines);
            Console.WriteLine("Total no of polish letters : {0}", polish);
        }

        public static void PlayMors(char[] contents)
        {
            Dictionary<string, string> Codes = new Dictionary<string, string>
            {
                {"a", ".- "}, {"b", "-... "}, {"c", "-.-. "}, {"d", "-.. "},
                {"e", ". "}, {"f", "..-. "}, {"g", "--. "}, {"h", ".... "},
                {"i", ".. "}, {"j", ".--- "}, {"k", "-.- "}, {"l", ".-.. "},
                {"m", "-- "}, {"n", "-. "}, {"o", "--- "}, {"p", ".--. "},
                {"q", "--.- "}, {"r", ".-. "}, {"s", "... "}, {"t", "- "},
                {"u", "..- "}, {"v", "...- "}, {"w", ".-- "}, {"x", "-..- "},
                {"y", "-.-- "}, {"z", "--.. "}, {"0", "-----"}, {"1", ".----"},
                {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."},
                {"6", "-...."}, {"7", "--..."}, {"8", "---.."}, {"9", "----."},
                {"ą", ".-.-"}, {"ć", "-.-.."}, {"ę", "..-.."}, {"ł",".-..-"},{"ń", "--.--"},
                {"ó", "---."},{"ś", "...-..."},{"ż","--..-."},{"ź", "--..-"}, {" ","------"}
            };

            Console.WriteLine("\n----------- Show & Play Mors -----------");

            foreach (char ch in contents)
            {
                string Delement = "";

                try
                {
                    Delement = Codes[ch.ToString()].Trim();
                }
                catch { continue; }

                Console.WriteLine("{0}: {1}", ch, Delement);

                foreach (char c2 in Delement.ToCharArray())
                {
                    if (c2 == '.')
                        Console.Beep(1000, 250);
                    else
                        Console.Beep(50, 250);

                    System.Threading.Thread.Sleep(50);
                }
            }
        }

        public static void PlayLetters(char[] contents)
        {
            Console.WriteLine("\n----------- Play Letters -----------");

            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    int i = "aąbcćdeęfghijklłmnńoóprsśtuwyzźż".IndexOf(current);

                    if (i != -1)
                    {
                        Console.Beep(AlfaNotes[i, 0], AlfaNotes[i, 1]);
                        Console.WriteLine("{0}: {1} {2}", current, AlfaNotes[i, 0], AlfaNotes[i, 1]);
                    }
                }
            }
        }

        static int[,] AlfaNotes = new int[,] {
                {500, 400}, {600, 200}, {700, 100}, {200, 900},
                {800, 100}, {300, 100}, {700, 400}, {100, 600},
                {230, 530}, {120, 320}, {120, 650}, {120, 340},
                {540, 120}, {760, 440}, {330, 120}, {410, 440},
                {650, 120}, {340, 140}, {660, 110}, {630, 530},
                {320, 430}, {110, 430}, {310, 110}, {440, 110},
                {110, 330}, {560, 110}, {320, 130}, {330, 550},
                {120, 560}, {570, 235}, {155, 234}, {255, 154},
                {144, 144}, {124, 555}, {134, 124}, {144, 124},
                {124, 144}, {124, 444}, {123, 123}, {123, 444}, {543, 233},
                {213, 123}, {333, 333}, {111, 333}, {222, 122}, {333, 111},
        };
    }
}
