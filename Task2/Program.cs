using System;

namespace Task2
{
    internal class Program
    {
        enum Colors
        {
            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }
        static class MyClass
        {
           public static void Print(string stroka, int color)
           {
                Colors colors = (Colors)color;

                Console.ForegroundColor = (ConsoleColor)colors;
                Console.WriteLine("\n" + stroka);

                Console.ResetColor();
           }
        }
        static void Main(string[] args)
        {
            string text;
            int color;

            Console.Write("Введите текст: ");
            text = Console.ReadLine();

            Console.Write("Введите номер цвета(0-15): ");
            color = int.Parse(Console.ReadLine());

            MyClass.Print(text, color);

            Console.ReadKey();
        }
    }
}
