using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace labwork
{
    class Program
    {
        static void Main(string[] args)
        {
            double summ = 0; //очищаем значение суммы
            int n = 1; //задаем начальное значение членов ряда
            double xn = 0.1; //задаем значение переменной ряда
            double e = 0.00005; //задаем точность
            do // начать цикл
            {
                xn = (Math.Pow(-1, n - 1) * Math.Pow(xn, 2 * n - 1) / (2 * n - 1)); //вычисление n-го члена ряда
                summ += xn; //сумма членов ряда
                n++; //инкремент
            } while (Math.Abs(xn) > e); //цикл выполняется, пока верно условие
            Console.WriteLine($"Сумма членов рядa с заданной точностью равна: " + summ.ToString()); //вывод на консоль
            Console.ReadKey(); //ожтдание нажатие клавиши
        }
    }
}