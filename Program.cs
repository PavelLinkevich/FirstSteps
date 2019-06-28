using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hello_World
{
    public class Program
    {
        static int a;
        static int b;
        static char[,] field;
        static void Main(string[] args) //Пафосна говорит:"Привет"
        {
            Createplayingfield();
            //Move1();
            //Twoplayers();
            //Createplayingfield();
            //char[,] fild = new char[3, 3];
            //fild[1, 0] = '1';
            //fild[1, 1] = '2';
            //fild[2, 0] = '3';
            //fild[2, 1] = '4';
            //for (int i = 1; i < 2; i++)
            //{
            //    for (int p = 0; p < 2; p++)
            //    {
            //        { Console.WriteLine( fild[i, p]); }
            //    }
            //}
            Console.ReadKey(true);
        }
        static void Createplayingfield()
        {
            Console.WriteLine("Привецтвую вас лUSERы");
            Console.ReadKey(true);
            //Console.WriteLine("Поле будет три на три");
            //Console.ReadKey(true);
            Console.WriteLine("Выберите размер поля");
            a = b = int.Parse(Console.ReadLine());
            char[,] field = new char[a, b];
            for (int i = 0; i < a; i++)
            {
                Console.Write(" /");
                for (int y = 0; y < a; y++)
                {
                    field[i, y] = ' ' ;
                    Console.Write(field[i, y]);
                    Console.Write(" /");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Поле готово");
            Startthegame(field);
        }
        //static char[,] field = new char[a, b];//?
        static void Startthegame(char[,] field)
        {
            //for (int t = 0; t < a; t++)
            //{
            //    Console.Write(" |");

            //    for (int y = 0; y < b; y++)
            //    {
            //        Console.Write(field[t, y] + "|");//?
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("1 или 2 игрока?");
            int Player = int.Parse(Console.ReadLine());
            if (Player == 1)
            {
                Oneplayer();
            }
            else { Twoplayers(); }
        }
        static void Oneplayer()
        {

        }
        static bool Win()
        {

            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[p, i-2] == 'X' && field[p, i-1] == 'X' && field[p, i] == 'X') { Console.WriteLine("Победа 1 игрока"); return true; }// 3 в ряд
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 0; p < b; p++)
                {
                    if (field[i-2, p] == 'X' && field[i-1, p] == 'X' && field[i, p] == 'X') { Console.WriteLine("Победа 1 игрока"); return true; }// 3  по вертикали
                }
            }

            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[i - 2, p - 2] == 'X' && field[i - 1, p - 1] == 'X' && field[i, p] == 'X') { Console.WriteLine("Победа 1 игрока"); return true; }// 3  по диаганали
                }
            }
            for (int i = 2; i < a; i++)
            {
                for (int p = 2; p < b; p++)
                {
                    if (field[p - 2, i] == 'X' && field[p - 1, i - 1] == 'X' && field[p, i - 2] == 'X') { Console.WriteLine("Победа 1 игрока"); return true; }
                }
            }
            return false;

        }
        //static bool Win2()
        //{
        //    if (field[0, 0] == 'O' && field[0, 1] == 'O' && field[0, 2] == 'O') { Console.WriteLine("Победа 2 игрока"); return true; }
        //    if (field[1, 0] == 'O' && field[1, 1] == 'O' && field[1, 2] == 'O') { Console.WriteLine("Победа 2 игрока"); return true; }
        //    if (field[2, 0] == 'O' && field[2, 1] == 'O' && field[2, 2] == 'O') { Console.WriteLine("Победа 2 игрока"); return true; }

        //    if (field[0, 0] == 'O' && field[1, 0] == 'O' && field[2, 0] == 'O') { Console.WriteLine("Победа 1 игрока"); return true; }
        //    if (field[0, 1] == 'O' && field[1, 1] == 'O' && field[2, 1] == 'O') { Console.WriteLine("Победа 1 игрока"); return true; }
        //    if (field[0, 2] == 'O' && field[1, 2] == 'O' && field[2, 2] == 'O') { Console.WriteLine("Победа 1 игрока"); return true; }

        //    if (field[0, 0] == 'O' && field[1, 1] == 'O' && field[2, 2] == 'O') { Console.WriteLine("Победа 2 игрока"); return true; }
        //    if (field[0, 2] == 'O' && field[1, 1] == 'O' && field[2, 0] == 'O') { Console.WriteLine("Победа 2 игрока"); return true; }
        //    return false;

        //}
        static void Twoplayers()
        {            
            while (true)
            {
                Move1(field);
                if (Win() != false)//|| Win2() != false)
                {
                    break;
                }
                //Move2();
            }

        }

        static void Move1(char[,] field)//Доработаю
        {
            Console.WriteLine("ход 1 игрока");
            Console.WriteLine("укажите столбик:");
            int move2 = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("укажите ряд:");
            int move = int.Parse(Console.ReadLine())-1;

            field[move, move2] = 'X';//!
            for (int t = 0; t < a; t++)
            {
                Console.Write(" |");

                for (int y = 0; y < b; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
            }


        }
        static void Move2(char[,] field)//Доработаю
        {
            Console.WriteLine("ход 2 игрока");
            Console.WriteLine("укажите столбик:");
            int move2 = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("укажите ряд:");
            int move = int.Parse(Console.ReadLine()) - 1;
            //int move3 = move - 1;
            //int move4 = move2 - 1;

            field[move, move2] = 'O';


            for (int t = 0; t < 4; t++)
            {
                Console.Write(" |");

                for (int y = 0; y < 4; y++)
                {
                    Console.Write(field[t, y] + "|");
                }
                Console.WriteLine();
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
