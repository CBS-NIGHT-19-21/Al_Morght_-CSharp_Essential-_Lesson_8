using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу дату рождения: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            DateTime nextbirthday = new DateTime(DateTime.Now.Year, birthday.Month, birthday.Day);
            TimeSpan left;

            if (DateTime.Now.Month < birthday.Month)
                left = nextbirthday - DateTime.Now;
            else
                left = nextbirthday.AddYears(1) - DateTime.Now;
            
            Console.WriteLine("\nДо следующего для рождения осталось {0} дней.", left.Days);

            Console.ReadKey();
        }
    }
}
