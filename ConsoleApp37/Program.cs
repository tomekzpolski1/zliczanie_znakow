using System;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program zliczający ilość wystąpień znaku w tekście");
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();
            int licznikZnakow = 0;
            foreach (char litera in tekst)

            {
                if (litera == 'a')
                {
                    licznikZnakow++; 
                }
            }
            Console.WriteLine("Litera a wystąpiła {0} razy w podanym ciągu znaków", licznikZnakow);
        }
    }
}
