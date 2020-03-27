using System;

namespace DZ_if_26_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
             o Задание 1
                o Выучите основные конструкции и понятия, рассмотренные на уроке
            */
            Console.WriteLine("OK!");

            /*
                o Задание 2
                    o Написать программу вычисления стоимости покупки с учетом скидки. Скидка в 3%
                    предоставляется в том случае, если сумма покупки больше 500 сомони, в 5% - если
                    сумма больше 1000 сомони
            */

            decimal sumPurchase;
            decimal discount = 0m;
            
            Console.Write("sum_purchase = ");
            sumPurchase = decimal.Parse(Console.ReadLine());
            if(sumPurchase < 500)
            {
                Console.WriteLine("Your sum purchase = " + sumPurchase + "\nNo discount");
            }
            if(sumPurchase >= 500)
            {
                discount = (sumPurchase * 3) / 100;
            }
            if(sumPurchase >= 1000)
            {
                discount = (sumPurchase * 5) / 100;
            }
            Console.WriteLine(discount);
            
            //////////////////////////////////////////////////////////////////////////////////////////////
            // На интенсиве была подобная задача, еще было такое условие, что скидкa не должна превышать 
            // указанной суммы.  
            //
            /////////////////////////////////////////////////////////////////////////////////////////////
            
            /*
                o Задание 3
                    o Даны четыре числа. Если они не образуют возрастающую последовательность,
                    вывести минимальный из них; если числа равны, найти их произведение, иначе
                    сообщение «Числа расположены по возрастанию».
            */

            int n1 = 5;
            int n2 = 10;
            int n3 = 15;
            int n4 = 25;
            
            int min = n1;
            int proizvedenie = n1 * n2 * n3 * n4;
            string message = "Числа расположены по возрастанию.";

            if((n1 < n2) && (n2 < n3) && (n3 < n4))
            {
                Console.WriteLine(message);
            }
            else if((n1 == n2) && (n2 == n3) && (n3 == n4))
            {
                Console.WriteLine(proizvedenie);
            }
            else
            {
                if((min < n2) && (min < n3) && (min < n4))
                {
                    min = n1;
                }
                if((n2 < min) && (n2 < n3) && (n2 < n4))
                {
                    min = n2;
                }
                if((n3 < min) && (n3 < n2) && (n3 < n4))
                {
                    min = n3;        
                }
                if((n4 < min) && (n4 < n2) && (n4 < n3))
                {
                    min = n4;
                }
                Console.WriteLine(min);
            }
            
            /*
                o Задание 4
                    o Запрашиваются три числа для переменных a, b, c. Значения переменных поменять
                    таким образом, чтобы a >= b >= c.
            */
            int a, b, c;
            int pusto = 0;

            int maxim, minim, sred;

                Console.WriteLine("Vvedite a = ");
            a = int.Parse(Console.ReadLine());
                Console.WriteLine("Vvedite b = ");
            b = int.Parse(Console.ReadLine());
                Console.WriteLine("Vvedite c = ");
            c = int.Parse(Console.ReadLine());

            if(a>b && a>c){
                maxim = a; 
            }else if(b>a && b>c){
                maxim = b;
            }else {
                maxim = c;
            }
            if(b>a && a>c){
                sred = a; 
            }else if(a>b && b>c){
                sred = b;
            }else {
                sred = c;
            }
            if(b>a && a<c){
                sred = a; 
            }else if(a>b && b>c){
                sred = b;
            }else {
                sred = c;
            }
             

            Console.WriteLine(maxim);


            Console.ReadKey();
        }
    }
}
