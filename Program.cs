using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {            
            while (true)
            {
                string e = Console.ReadLine();
                if (e == "Спасибо" || e == "спасибо")
                {
                    Console.WriteLine("Пока");
                    Console.ReadKey(true);
                    return;
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
                isPalindrom(word);
            }
        
        }
        static bool isPalindrom(string word)
        {
            int i = 0;       
            int quantityRepetitions = (word.Length - 1) / 2; //узнали сколько нам надо раз провести это действие
            for (int leftLetter = 0; leftLetter < quantityRepetitions; leftLetter++,i++)//проводим это действие
            { 
                int rightLetter = word.Length - 1 - i;// находим номер этой буквы
                if (word[leftLetter] != word[rightLetter])
                {
                    return false;
                }                   
            }
            return true;            
        }
    }  
}
