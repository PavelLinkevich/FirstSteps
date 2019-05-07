using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static bool Thanks = false;
        static int z=0;

        static void Main(string[] args)
        {
            
            while (Thanks == false)
            {
                string e = Console.ReadLine();
                if (e == "Спасибо" || e == "спасибо")
                {
                    Console.WriteLine("Пока");
                    Console.ReadKey(true);
                    Thanks = true;
                }
                else
                {
                    string[] ArrayReadConsole = e.Split(' ');
                    Words(ArrayReadConsole);
                }
            }
        }

        static void Words(string[] ArrayReadConsole)
        {
            foreach (var word in ArrayReadConsole)
            {
                palindrom(word);
            }
        
        }
        static void palindrom(string word)
        {
            int LengthWord = word.Length; //Узнали длину слова            
            int NumberActions = LengthWord / 2; //узнали сколько нам надо раз провести это действие
            for (int numberActionsTaken = 0; numberActionsTaken < NumberActions; numberActionsTaken++)
            {
                z++;
                int oppositeLetter = LengthWord - z;
                Console.WriteLine("z =" + z);

                if (word[numberActionsTaken] == word[oppositeLetter])
                {

                }
                else
                {
                    Console.Write("не ");
                    break;
                }
                Console.WriteLine("numberActionsTaken =" + word[numberActionsTaken]);
                Console.WriteLine("oppositeLetter =" + word[oppositeLetter]);
            }
            Console.WriteLine("полиндром :" + word);
            z = 0;
        }
    }  
}
