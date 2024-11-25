using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int one, two; 
                double result;
                char sign;
                try
                {
                    Console.WriteLine("Вас приветствует калькулятор!");
                    Console.Write("Введите целое число. X = ");
                    one = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите целое число. Y = ");
                    two = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        Console.Write("Введите код операции\n    1. сложение\n    2. вычитание\n    3. произведение\n    4. частное\n ");
                        Console.Write("Ваш выбор: ");
                        sign = Convert.ToChar(Console.ReadLine());
                        if (sign == '1')
                        {
                            result = one + two;
                            
                            Console.WriteLine("Результат = " + result);
                            Console.ReadKey();
                        }
                        else if (sign == '2')
                        {
                            result = one - two;
                            Console.WriteLine("Результат = s" + result);
                            Console.ReadKey();
                        }
                        else if (sign == '3')
                        {
                            result = one * two;
                            Console.WriteLine("Результат = " + result);
                            Console.ReadKey();
                        }
                        else if (sign == '4')
                        {
                            result = ((double)one / two);
                            Console.WriteLine("Результат = {0:.00}", result);
                            Console.ReadKey();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Нет операции с указанным номером");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                }
                Console.ReadKey();

            }

        }
    }
}
    

