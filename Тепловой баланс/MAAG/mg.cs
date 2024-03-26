using System.Reflection.Metadata.Ecma335;
using System;
using System.Security.Cryptography;

namespace MAAG
{   
    // i = '
    internal class mg {
        static void Main(string[] args)
        {
            var Dвн = 0.02; //Внутренний диаметр наружней трубы

            var dнар = 0.012; //наружный диаметр внутренней трубы

            var dвн = 0.01; //для расчета круглой одиночной трубы

            var pi = 3.1415926535; //число пи

            var L = 0.37; // длина внутренней трубы

            Console.WriteLine("Введите число cp1:");
            double cp1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число cp2:");
            double cp2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Ti1:");
            double Ti1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Tii1:");
            double Tii1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Ti2:");
            double Ti2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число Tii2:");
            double Tii2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число p1:");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число p2:");
            double p2 = Convert.ToDouble(Console.ReadLine());

            double T1 = (Ti1 + Tii1)/2;

            double T2 = (Ti2 + Tii2) / 2;

            Console.WriteLine("Введите число k:");
            double k = Convert.ToDouble(Console.ReadLine());

            var F = pi* dнар *L;

            var f = (pi/4)* (Math.Pow (Dвн,2) - Math.Pow (dнар,2)); //площадь поперечного сечения канала

            var dT = ((Ti1 - Tii1) + (Ti2 - Tii2)) / 2; //средняя разность температур

            double Q = k * dT * F;

            double G1 = p1 * w * f;

            double G2 = p2 * w * f;

            double Q1 = G1 * cp1 * (Ti1 - Tii1);

            double Q2 = G2 * cp2 * (Ti2 - Tii2);

            double Qпот = Q1 - Q2;










        }
}
}