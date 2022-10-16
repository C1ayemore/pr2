using System;


namespace negr_3
{


    class negr
    {
        static void PervayaProgramma()
        {
            Random r = new Random();
            int random = r.Next(0, 100);
            while (true)

            {
                Console.Write("Введите число: ");
                int result = Convert.ToInt32(Console.ReadLine());
                if (result > random)
                {
                    Console.WriteLine("\nВведите меньше\n");
                }
                else if (result < random)
                {
                    Console.WriteLine("\nВведите больше\n");
                }
                else
                {
                    Console.WriteLine("\nПоздравляем вы угадали число!\n");
                    break;
                }
            }
        }
        static void VtorayaProgramma()
        {
            int[,] b = new int[10, 10];
            for (int l = 1; l <= 10; l++)
            {
                for (int g = 1; g <= 10; g++)
                {
                    if (l > 0) Console.Write(l * g + "\t");
                    else Console.Write(g + "\t");
                }
                Console.WriteLine();


            }
        }
        static void TretyaProgramma()
        {
            while (true)
            {
                Console.Write("Введите число (0 для выхода): ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                    Console.WriteLine("Число должно быть натуральным");
                else if (num == 0)
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                else
                {
                    for (int f = 1; f < num; f++)
                    {
                        if ((num % f) == 0)
                        {
                            Console.Write(f + " ");

                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Список команд:\n1 - Угадай число\n2 - Таблица умножения\n3 - Делители числа\n4 - Выход из программы");
            int game;
            while (true)
            {
                Console.Write("Номер команды: ");
                game = Convert.ToInt32(Console.ReadLine());
                switch (game)
                {
                    case 1:
                        PervayaProgramma();
                        break;
                    case 2:
                        VtorayaProgramma();
                        break;
                    case 3:
                        TretyaProgramma();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }

    }
}