using System;

namespace fall_2020_starter_code
{
    class Program
    {
        static void Main(string[] args)
        {
            int MenuOption;
            Console.WriteLine("Press ENTER to move throughout console");
            Console.ReadKey();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Choose a Menu Option");
                Console.WriteLine("1. Print Triangle");
                Console.WriteLine("2. Print Numbers Table");
                Console.WriteLine("3. Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out MenuOption))
                {
                    switch (MenuOption)
                    {
                        case 1:
                            Console.Clear();
                            int a;
                            int b;
                            int c;
                            for (a = 1; a <= 10; a++)
                            {
                                for (b = 1; b <= 10 - a; b++) { }
                                for (c = 1; c <= b; c++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine("");
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Clear();
                            int x;
                            int y;
                            int z;
                            for (x = 1; x <= 4; x++)
                            {
                                y = 0;
                                for (z = 1; z <= 11; z++)
                                {
                                    if (z == 1)
                                    {
                                        Console.Write(x + "\t");

                                    }
                                    else
                                    {
                                        Console.Write(x * y + "\t");
                                        y++;
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Environment.Exit(0);
                            Console.ReadKey();
                            break;
                        default:
                            if (MenuOption != 3)
                            {
                                Console.WriteLine("Invalid Input! Press any key to return to menu...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.ReadLine();
                                Console.WriteLine("Invalid Input! Press any key to return to menu...");
                                Console.Clear();
                                Console.ReadKey();
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input! Try again.");
                    Console.Write("");
                }
            } while (true);
        }
    }
}
