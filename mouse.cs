using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mouse
{
    class Program
    {
        public static void leave()
        {
            Console.WriteLine(" ___________");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|           |");
            Console.WriteLine("|___________|");
        }
        public static void dead()
        {
            Console.WriteLine(" ___________");
            Console.WriteLine("|     |     |");
            Console.WriteLine("|     |     |");
            Console.WriteLine("|-----------|");
            Console.WriteLine("|     |     |");
            Console.WriteLine("|_____|_____|");
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int num_of_poison = rand.Next(0, 999);
            string num_result_binary = "";
            int num_result = 0;
            int[] mas_of_test_tube = new int[1000];
            for (short i = 0; i < 1000; i++)
            {
                mas_of_test_tube[i] = 0;
            }
            mas_of_test_tube[num_of_poison] = 1;
            num_of_poison++;
            int[] mas_of_mouse = new int[10];
            for (short i = 0; i < 10; i++)
            {
                mas_of_mouse[i] = 0;//zero - mouse is clear, one - mouse is sick
            }

            string num_test_tube_binary;
            char temp2;
            int temp3;
            for (short i = 0; i < 1000; i++)
            {
                num_test_tube_binary = Convert.ToString(i + 1, 2);
                if (num_test_tube_binary.Length < 10)
                {
                    while (num_test_tube_binary.Length < 10)
                    {
                        num_test_tube_binary = "0" + num_test_tube_binary;
                    }
                }
                for (short j = 0; j < 10; j++)
                {
                    temp2 = num_test_tube_binary[j];
                    temp3 = Convert.ToInt32(temp2);
                    if (temp3 == 49 && mas_of_mouse[j] == 0)
                        mas_of_mouse[j] = mas_of_test_tube[i];
                }
            }

            for (short i = 0; i < 10; i++)
            {
                if (mas_of_mouse[i] == 0)
                {
                    leave();
                    Console.WriteLine(i + 1);
                }
                if (mas_of_mouse[i] == 1)
                {
                    dead();
                    Console.WriteLine(i + 1);
                }
            }

            for (short i = 0; i < 10; i++)
            {
                num_result_binary = num_result_binary + Convert.ToString(mas_of_mouse[i]);
            }

            num_result = Convert.ToInt32(num_result_binary, 2);


            Console.WriteLine("Poison is here -> " + num_of_poison);
            Console.WriteLine("Program think that his binary code is " + num_result_binary);
            Console.WriteLine("That in decimal system is " + num_result);


            Console.ReadKey();
        }
    }
}
