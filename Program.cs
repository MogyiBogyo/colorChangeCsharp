using System;

namespace csharpgyak2
{
    class Program
    {
        static ConsoleColor color = ConsoleColor.Blue;
        static int index = 0;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Title = "szín beállító";
            Console.CursorVisible = false;
            do
            {
                Kiir();
            } while (true);

        }
        static void Kiir()
        {
            for (int i = 0; i < 16; i++)
            {
                if(i == index)
                {
                    Console.BackgroundColor = color;
                    Console.WriteLine(((ConsoleColor)i).ToString().PadLeft(15));
                    Console.ResetColor();
                }
                else Console.WriteLine(((ConsoleColor)i).ToString().PadLeft(15));
            }
            Iranyitas();
            Console.Clear();
        }
        static void Iranyitas()
        {
            ConsoleKey ck = Console.ReadKey().Key;
            switch (ck)
            {
                case ConsoleKey.UpArrow:
                    if (index-- == -1) index = 15;
                    break;
                case ConsoleKey.DownArrow:
                    if (index++ == 16) index = 0;
                    break;
                case ConsoleKey.Enter:
                    color = (ConsoleColor)index;
                    break;
            }
        }
    }
}
