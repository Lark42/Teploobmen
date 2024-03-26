using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
            double a;
            double b;
            double res;
            char oper;

            Console.WriteLine("Введите число a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор: + , - , * , / ");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите число б: ");
            b = Convert.ToDouble(Console.ReadLine());

                switch (oper)
                {
                    case '+':
                        res = a + b;
                        Console.WriteLine("Сумма чисел " + a + " и " + b + " равна " + res);
                        break;

                    case '-':
                        res = a - b;
                        Console.WriteLine("Разность чисел " + a + " и " + b + " равна " + res);
                        break;

                    case '*':
                        res = a * b;
                        Console.WriteLine("Произведение чисел " + a + " и " + b + " равно " + res);
                        break;

                    case '/':
                        if (b != 0)
                        {
                            res = a / b;
                            Console.WriteLine("Частное чисел " + a + " и " + b + " равно " + res);
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                        }
                        break;

                    default:
                        Console.WriteLine("Я в ступоре");
                        break;
                }
                Console.ReadLine();

            }
        }
       



    }
}
        

