using System;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {


//<<<<<<< HEAD ВРАГ НАРОДА!!!
            Console.WriteLine("Вводи число А ");
            double A = Convert.ToDouble(Console.ReadLine());
//======= ЕЩЕ ОДИН!!!
            Console.WriteLine("Вводи число B ");
            double B = Convert.ToDouble(Console.ReadLine());
//>>>>>>> fun2 ЕЩЕ...

            double res1 = A + B;
            Console.WriteLine("Результатом сложения А и B будет" + Convert.ToString(res1));


            double res2 = A - B;
            Console.WriteLine("Результат вычитания А и В - " + Convert.ToString(res2));

        }
    }
}
