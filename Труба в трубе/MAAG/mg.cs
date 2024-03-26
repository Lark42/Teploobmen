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

            char type;

            Console.Write("Введите t1i - начальную температуру горячего теплоносителя: ");
            double t1i = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите t1ii - конечную температуру горячего теплоносителя: ");
            double t1ii = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите t2i - начальную температуру холодного теплоносителя: ");
            double t2i = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите t2ii - конечную температуру холодного теплоносителя: ");
            double t2ii = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберете тип схемы: Прямоточная - 1, противоток - 2, перекрестная - 3 ");
            type = Convert.ToChar(Console.ReadLine());

            if (type == '1')
            {

                var F = pi * dнар * L;

                Console.WriteLine("Площадь поверхности теплообменников труба в трубе = " + F);

                var o = (t1i - t2i) / (t1ii - t2ii);

                var dt = ((t1i - t2i) - (t1ii - t2ii)) / Math.Log(o);

                Console.WriteLine("Средняя логарифмическая разность температур = " + dt);

                Console.Write("Введите Vг - массовый расход горячего теплоносителя: ");
                double Vг = Convert.ToDouble(Console.ReadLine());

                var Vх = 2.7; //массовый расход холодного теплоносителя

                Console.WriteLine("Массовый расход холодного теплоносителя = " + Vх);

                var t1 = (t1i - t1ii) / 2;
                Console.WriteLine("Средняя температура горячего потока = " + t1);

                var t2 = (t2ii - t2i) / 2;
                Console.WriteLine("Средняя температура холодного потока = " + t2);

                Console.Write("Введите cг - удельную теплоемкость горячей воды ");
                double cг = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите cх - удельную теплоемкость холодной воды ");
                double cх = Convert.ToDouble(Console.ReadLine());

                double Qг = Vг * cг * (t1ii - t1i); //кол-во теплоты, отданное горячим теплоносителем
                Console.WriteLine("Кол-во теплоты, отданное горячим теплоносителем = " + Qг);

                double Qх = Vх * cх * (t2ii - t2i); //кол-во теплоты, полученное холодным теплоносителем
                Console.WriteLine("Кол-во теплоты, полученное холодным теплоносителем = " + Qх);

                double k = Qх / (dt * F); //коэффициент теплопередачи
                Console.WriteLine("Коэффициент теплопередачи = " + k);


            }
            else if (type == '2')
            {
                var F = pi * dнар * L;

                Console.WriteLine("Площадь поверхности теплообменников труба в трубе = " + F);

                var o = (t1i - t2ii) / (t1ii - t2i);

                var dt = ((t1i - t2ii) - (t1ii - t2i)) / Math.Log(o);
                Console.WriteLine("Средняя логарифмическая разность температур = " + dt);

                Console.Write("Введите Vг - массовый расход горячего теплоносителя:");
                double Vг = Convert.ToDouble(Console.ReadLine());

                var Vх = 2.7; //массовый расход холодного теплоносителя
                Console.WriteLine("Массовый расход холодного теплоносителя = " + Vх);

                var t1 = (t1i - t1ii) / 2;
                Console.WriteLine("Средняя температура горячего потока = " + t1);

                var t2 = (t2ii - t2i) / 2;
                Console.WriteLine("Средняя температура холодного потока = " + t2);

                Console.Write("Введите cг - удельную теплоемкость горячей воды ");
                double cг = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите cх - удельную теплоемкость холодной воды ");
                double cх = Convert.ToDouble(Console.ReadLine());

                double Qг = Vг * cг * (t1ii - t1i); //кол-во теплоты, отданное горячим теплоносителем
                Console.WriteLine("Кол-во теплоты, отданное горячим теплоносителем = " + Qг);

                double Qх = Vх * cх * (t2ii - t2i); //кол-во теплоты, полученное холодным теплоносителем
                Console.WriteLine("Кол-во теплоты, полученное холодным теплоносителем = " + Qх);

                double k = Qх / (dt * F); //коэффициент теплопередачи
                Console.WriteLine("Коэффициент теплопередачи = " + k);

            }
            else if (type == '3')
            {
                var F = pi * dнар * L;
                Console.WriteLine("Площадь поверхности теплообменников труба в трубе = " + F);

                var dt = ((t1i - t2i) + (t1ii - t2ii)) / 2;
                Console.WriteLine("Средняя логарифмическая разность температур = " + dt);

                Console.Write("Введите Vг - массовый расход горячего теплоносителя: ");
                double Vг = Convert.ToDouble(Console.ReadLine());

                var Vх = 2.7; //массовый расход холодного теплоносителя
                Console.WriteLine("Массовый расход холодного теплоносителя = " + Vх);

                var t1 = (t1i - t1ii) / 2;
                Console.WriteLine("Средняя температура горячего потока = " + t1);

                var t2 = (t2ii - t2i) / 2;
                Console.WriteLine("Средняя температура холодного потока = " + t2);

                Console.Write("Введите cг - удельную теплоемкость горячей воды ");
                double cг = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите cх - удельную теплоемкость холодной воды ");
                double cх = Convert.ToDouble(Console.ReadLine());

                double Qг = Vг * cг * (t1ii - t1i); //кол-во теплоты, отданное горячим теплоносителем
                Console.WriteLine("Кол-во теплоты, отданное горячим теплоносителем = " + Qг);

                double Qх = Vх * cх * (t2ii - t2i); //кол-во теплоты, полученное холодным теплоносителем
                Console.WriteLine("Кол-во теплоты, полученное холодным теплоносителем = " + Qх);

                double k = Qх / (dt * F); //коэффициент теплопередачи
                Console.WriteLine("Коэффициент теплопередачи = " + k);
            }



















        }
}
}