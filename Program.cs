using System;

namespace DZ_if_26_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
             Задание 1
                Выучите основные конструкции и понятия, рассмотренные на уроке
            */
            Console.WriteLine("OK!");

            /*
                Задание 2
                    Написать программу вычисления стоимости покупки с учетом скидки. Скидка в 3%
                    предоставляется в том случае, если сумма покупки больше 500 сомони, в 5% - если
                    сумма больше 1000 сомони
            */

            decimal sumPurchase;
            decimal discount = 0;
            Console.Write("sum_purchase = ");
            sumPurchase = decimal.Parse(Console.Read());
            if(sumPurchase >= 500)
            {
                discount = (sumPurchase * 3) / 100;
            }
            if(sumPurchase >= 1000)
            {
                discount = (sumPurchase * 5) / 100;
            }
            Console.WriteLine(discount);
            
            Console.ReadKey();
        }
    }
}
