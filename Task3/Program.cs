using System;

namespace Task3
{
    internal class Program
    {
        enum Post
        {
            Accountant = 140,
            Administrator = 160,
            Assistant = 120,
            Clerk = 80,
            Director = 180,
            Guard = 150
        }

        class Accauntant
        {
            public static bool AskForBonus(Post worker, int hours)
            {
                object position = Enum.Parse(typeof(Post), worker.ToString());
                Post post = (Post)position;

                if (hours > (int)post)
                    return true;
                else
                    return false;
            }
        }

        static void Main(string[] args)
        {
            bool flag;
            Post worker = Post.Accountant;

            flag = Accauntant.AskForBonus(worker, 144);

            if (flag == true)
                Console.WriteLine("Сотрудник на должности {0} превысил норму в {1} часов и заслуживает премии.", worker, (int)worker);
            else
                Console.WriteLine("Наработаных часо сотрудником {0} не достаточно для выделения премии.", worker);

            Console.ReadKey();
        }
    }
}
