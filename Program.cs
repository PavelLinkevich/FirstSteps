using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class omg
    {
        static int u;
        static int p;
        static int w = 1;
        static bool a;

        static void Main(string[] args)
        {
            a = true;
            while (a == true)
            {
                string e = Console.ReadLine();
                if (e == "Спасибо")
                {
                    Console.WriteLine("Пока");
                    Console.ReadKey(true);
                    a = false;
                }
                if (e == "спасибо")
                {
                    Console.WriteLine("Пока");
                    Console.ReadKey(true);
                    a = false;
                }
                else
                {
                    string[] ArrayReadConsole = e.Split(' ');
                    palindrom(ArrayReadConsole);
                }
            }
        }

        static void palindrom(string[] ArrayReadConsole)
        {

            int LenClov = ArrayReadConsole.Length;   //Измерили колво слов   
            for (int p = 0; p < LenClov; p++)
            {
                string Clovo = ArrayReadConsole[p];   //Слово отдельный стринг не конст
                int LenClovo = Clovo.Length; //Узнали длину слова                  

                if (LenClovo % 2 == 1)
                {
                    p = 0;
                }
                int e4 = LenClovo / 2;
                for (int t = 0; t < e4; t++)
                {
                    p++;
                    int u = LenClovo - p;
                    if (Clovo[t] == Clovo[u])
                    {

                    }
                    else
                    {
                        Console.Write("не ");

                    }
                }
                Console.WriteLine("полиндром :" + Clovo);
            }
        }
    }
}
