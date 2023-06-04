using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prostae_chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int a;
            int b = 3;
            bool status = true;

            while (true)
            {
                Console.WriteLine("Введите число:");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 2)
                {
                    Console.WriteLine(($"Число {number} является простым"));
                  
                }
                else
                {


                    if (number % 2 != 0)
                    {
                        a = (number + 1) / 2;

                        while (b < a)
                        {
                            if (number % b == 0)
                            {
                                status = false;
                                Console.WriteLine($"Число {number} является составным");                           
                                break;
                            }
                            b++;
                        }

                        b = 3;
                    }
                    else
                    {
                        Console.WriteLine($"Число {number} является составным");
                        status = false;
                      
                    }


                    if (status == true)
                    {
                        Console.WriteLine($"Число {number} является простым");
                       
                    }

                }
                   
                status = true;




            }


        }
    }
}
