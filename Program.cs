using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hello_World
{
    class Program
    {       
        static string Name;
        static void Main(string[] args) //Пафосна говорит:"Привет"
        {
            Console.WriteLine("Hello users");
            Console.ReadKey(true);
            TitlePage();
            // Console.ReadKey(true);
            //Console.WriteLine("The End");
            
        }
        static void CreateLoginAndPassword()
        {
           
            try
            {
                Console.WriteLine("What's your Name?");
                Name = Console.ReadLine();
                FileStream file = new FileStream("E:\\new_file_" + Name + ".txt", FileMode.CreateNew);// Name должен быть локальной переменной  
                Console.WriteLine("What's your password?");
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(Console.ReadLine());
                writer.Close();
                file.Close();
                Console.WriteLine("Press any key to go back");
                Console.ReadKey(true);
                TitlePage();
            }
            catch (Exception)
            {
                Console.WriteLine("This name is already taken");
                Console.WriteLine("Press any key to go back");
                Console.ReadKey(true);
                TitlePage();
                //Console.WriteLine("Try again");
                // CreateLoginAndPassword();
            }

        }
        static void TitlePage()
        {
           
            Console.WriteLine("Зарегестрируйтесь");
            Console.Write("Пользаватель один:");
            string Name = Console.ReadLine();
            Console.WriteLine("Привет " + Name);
            Console.Write("Пользаватель два:");
            string Name2 = Console.ReadLine();
            Console.WriteLine("Привет " + Name2);
            while (Console.ReadLine() != " good bye")
            {
                Console.Write(Name + ": ");
                Console.ReadLine();
                Console.Write(Name2 + ": ");
                Console.ReadLine();
            }   

        }








    }
    class Library
    {
        static string Name;
        static void CreateLoginAndPassword()
        {

            try
            {
                Console.WriteLine("What's your Name?");
                Name = Console.ReadLine();
                FileStream file = new FileStream("E:\\new_file_" + Name + ".txt", FileMode.CreateNew);// Name должен быть локальной переменной  
                Console.WriteLine("What's your password?");
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(Console.ReadLine());
                writer.Close();
                file.Close();
                Console.WriteLine("Press any key to go back");
                Console.ReadKey(true);
                TitlePage();
            }
            catch (Exception)
            {
                Console.WriteLine("This name is already taken");
                Console.WriteLine("Press any key to go back");
                Console.ReadKey(true);
                TitlePage();
                //Console.WriteLine("Try again");
                // CreateLoginAndPassword();
            }

        }
        static void LoginToTheSystem()
        {
            Console.WriteLine("What's your name?");
            Name = Console.ReadLine();
            FileStream file = new FileStream("E:\\new_file_" + Name + ".txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Console.WriteLine("What's your password?");
            if (Console.ReadLine() == reader.ReadLine())
            {

                Console.WriteLine("you are logged in");
                Message();
            }
            else
            {
                Console.WriteLine("Incorrect name or password");
                Console.WriteLine("Try again");
                LoginToTheSystem();
            }
            reader.Close();
            file.Close();



        }
        static void TitlePage()
        {

            Console.WriteLine("Do you want to login or register?");
            if (Console.ReadLine() == "register")
            {
                CreateLoginAndPassword();
            }
            else { LoginToTheSystem(); }
        }
        static void Message()
        {
            Console.WriteLine("receiver name:");
            string Name2 = Console.ReadLine();
            FileStream file = new FileStream("E:\\new_file_" + Name + Name2 + ".txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            while (Console.ReadLine() != " good bye")
            {
                writer.WriteLine("Name: " + Console.ReadLine());
            }
            writer.Close();
            file.Close();

        }
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
