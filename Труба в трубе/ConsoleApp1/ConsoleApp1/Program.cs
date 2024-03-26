using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Введите число a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число c:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число z:");
            double z = Convert.ToDouble(Console.ReadLine());

            float r = a - b - c;

            float s = a + b + c;

            float u = a * b * c;

            double d = y / z;
            

            Console.WriteLine("Разность чисел a, b, c:");
            Console.WriteLine("r = {0}", r);

            Console.WriteLine("Сумма чисел a, b, c:");
            Console.WriteLine("s = {0}", s);

            Console.WriteLine("Произведение чисел a, b, c:");
            Console.WriteLine("u = {0}", u);

            Console.WriteLine("Частное чисел y и z:");
            Console.WriteLine("d = {0}", d);
            

            string da;
            da = Console. ReadLine();
            Console.WriteLine("Привет," + da);
            
            int a = 17;
            int b = 1;
            int c = 2;
            Console.WriteLine("Числа по возрастанию {1}, {2}, {0}", a, b, c); 
            */

            //1 дз
            /*
            Console.WriteLine("Введите число а");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число б");
            double b = Convert.ToDouble(Console.ReadLine());

            double d = (a + b) / 2;
            Console.WriteLine("Среднее арифметическое а и б = {0}", d);
            */

            //2 дз
            /*
            Console.WriteLine("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число б: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int res = a + b + c;
            int res2 = a * b * c;

            Console.WriteLine(res);
            Console.WriteLine(res2);
            */

            //3 дз

            double CO2 = 10.5;
            double W=30;
            double res;
            res = (CO2 * 100) / (100 + 0.1242 * W);
            Console.WriteLine(res);
        }
    }
}
