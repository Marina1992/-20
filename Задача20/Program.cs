using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача20
{
    /*В приложении объявить тип делегата, который ссылается на метод.Требования к сигнатуре метода следующие:
        -метод получает входным параметром переменную типа double;
-       метод возвращает значение типа double, которое является результатом вычисления.

        Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        -  длину окружности по формуле D = 2 * π * R;
        -  площадь круга по формуле S = π* R²;
        -  объем шара.Формула V = 4 / 3 * π * R³.

          Методы должны быть объявлены как статические.
                        
         */
    class Program
    {


        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {

            // способ 1 
            MyDelegate myDelegate1 = Method1;

            if (myDelegate1 != null)
            {
                double r = myDelegate1(3.4);
                Console.WriteLine($"Радиус окружности:{r}");
            }
            // cпособ 2 (лямда) 
            MyDelegate myDelegate6 = R => R;

            Console.WriteLine("Радиус окружности способ 2 ( лямбда):" + myDelegate6(3.4));



            MyDelegate myDelegate2 = Method2;

            if (myDelegate2 != null)
            {
                double r = myDelegate2(3.4);
                Console.WriteLine($"Длина окружности :{r:f2}");
            }

            MyDelegate myDelegate7 = R => Method2(R);

            myDelegate7(3.4);
            Console.WriteLine($"Длина окружности  способ 2( лямбда): {myDelegate7(3.4):f2}");


            MyDelegate myDelegate3 = Method3;

            if (myDelegate3 != null)
            {
                double r = myDelegate3(3.4);
                Console.WriteLine($"Площадь круга  :{r:f2}");
            }

            MyDelegate myDelegate4 = Method4;

            if (myDelegate4 != null)
            {
                double r = myDelegate4(3.4);
                Console.WriteLine($"Объем шара  :{r:f2}");
            }



            Console.ReadKey();



        }

        static double Method1(double R)
        {

            return R;
        }

        static double Method2(double R)
        {

            double D = 2 * Math.PI * R;
            return D;

        }

        static double Method3(double R)
        {

            double S = Math.PI * Math.Pow(R, 2);
            return S;

        }

        static double Method4(double R)
        {

            double V = (4 / 3) * Math.PI * Math.Pow(R, 3);
            return V;

        }


    }
}
