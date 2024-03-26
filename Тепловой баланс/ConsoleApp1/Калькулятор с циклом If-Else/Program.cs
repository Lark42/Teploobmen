using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор_с_циклом_If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double T1н;
                double T1к;
                double T2н;
                double T2к;
                double res;
                double t1;
                double t2;
                double po1;
                double cp1;
                double po2;
                double cp2;

                Console.WriteLine("Введите температуру первого носителя на входе: ");
                T1н = Convert.ToDouble(Console.ReadLine());
                   
                Console.WriteLine("Введите температуру первого носителя на выходе: ");
                T1к = Convert.ToDouble(Console.ReadLine());

                t1 = (T1н + T1к) / 2;

                Console.WriteLine("Введите температуру второго носителя на входе: ");
                T2н = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите температуру второго носителя на выходе: ");
                T2к = Convert.ToDouble(Console.ReadLine());

                t2 = (T2н + T2к) / 2;


                if (t1 == 0)
                {
                    po1 = 1.293;
                    cp1 = 1.005;
                    
                    if (t2 == 0)
                    {
                        po2 = 1.293;
                        cp2 = 1.005;


                    }

                }
                else if (oper == '-')
                {
                    res = a - b;
                    Console.WriteLine("Разность чисел " + a + " и " + b + " равна " + res);
                }
                else if (oper == '*')
                {
                    res = a * b;
                    Console.WriteLine("Произведение чисел " + a + " и " + b + " равно " + res);
                }
                else if (oper == '/')
                {
                    if (b == 0)
                    {
                        res = a / b;
                        Console.WriteLine("Частное чисел " + a + " и " + b + " равно " + res);
                    }
                    else
                    {
                        Console.WriteLine("Я в ступоре!");
                    }
                    
                }
                Console.ReadLine();


            }
                
            }
        }
}
