using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args) // Разбивает строку на слова через прбел
        {
            SingleWords(args);
            Console.ReadKey(true);



        }
        static void SingleWords(string[] args) // Разбивает строку на слова через прбел 
        {
            while (true)
            {
                string e = Console.ReadLine();
                string[] ArrayReadConsole = e.Split(' ');
                Words(ArrayReadConsole);
            }
        }
        static void Words(string[] ArrayReadConsole) //Отправляет по слову 
        {
            foreach (var word in ArrayReadConsole)
            {
                MirrorWords(word);
            }

        }
        static void MirrorWords(string word) //Переварачивает слова
        {
            int wordLength = word.Length-1;
            char[] arrayLetter = word.ToCharArray();
            char[] mirrorArrayLetter = word.ToCharArray();
            for (int GuantityActions = 0; GuantityActions < wordLength + 1; GuantityActions++)//Не получилось всунуть rightLetter //проводим это действие
            {
                int mirrorLetter = wordLength - GuantityActions;
                arrayLetter[GuantityActions] = mirrorArrayLetter[mirrorLetter];
                Console.Write(arrayLetter[GuantityActions]);
            }
            Console.Write(" ");
        }
    }
    class Library
    {
        static void SingleWords(string[] args) // Разбивает строку на слова через прбел 
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
        static void Words(string[] ArrayReadConsole) //Отправляет по слову 
        {
            foreach (var word in ArrayReadConsole)
            {
                CheckPalindrom(word);
            }

        }
        static bool CheckPalindrom(string word) //Находит полиндром 
        {
            int wordLength = word.Length - 1;
            int repetCount = wordLength / 2; //узнали сколько нам надо раз провести это действие
            for (int leftLetter = 0; leftLetter < repetCount; leftLetter++)//Не получилось всунуть rightLetter //проводим это действие
            {
                int rightLetter = wordLength - leftLetter;// находим номер этой буквы
                if (word[leftLetter] != word[rightLetter])
                {
                    return false;
                }
            }
            return true;
        }
        static void MirrorWords(string word) //Переварачивает слова 
        {
            int wordLength = word.Length - 1;
            char[] arrayLetter = word.ToCharArray();
            char[] mirrorArrayLetter = word.ToCharArray();
            for (int GuantityActions = 0; GuantityActions < wordLength + 1; GuantityActions++)//Не получилось всунуть rightLetter //проводим это действие
            {
                int mirrorLetter = wordLength - GuantityActions;
                arrayLetter[GuantityActions] = mirrorArrayLetter[mirrorLetter];
                Console.Write(arrayLetter[GuantityActions]);
            }
            Console.Write(" ");
        }


    }
}
