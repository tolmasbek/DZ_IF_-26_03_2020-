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
            decimal stoimost = 0m;

            Console.Write("sum_purchase = ");
            sumPurchase = decimal.Parse(Console.ReadLine());

            if(sumPurchase < 500)
            {
                stoimost = sumPurchase;
                Console.WriteLine("Stoimost vashey pokepki = " + stoimost + " No discount");
            }else if(sumPurchase >= 500)
            {
                discount = (sumPurchase * 3) / 100;
                stoimost = sumPurchase - discount;
                Console.WriteLine(stoimost + " so skidkoy 3 %");
                
            }else if(sumPurchase >= 1000)
            {
                discount = (sumPurchase * 5) / 100;
                stoimost = sumPurchase - discount;
                Console.WriteLine(stoimost + " so skidkoy 5 %");
            }
            
            
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
            int n2 = 1;
            int n3 = 15;
            int n4 = 0;
            
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

                Console.Write("Vvedite a = ");
            a = int.Parse(Console.ReadLine());
                Console.Write("Vvedite b = ");
            b = int.Parse(Console.ReadLine());
                Console.Write("Vvedite c = ");
            c = int.Parse(Console.ReadLine());
            
            if(b > a)
            {
                pusto = a;
                    a = b; 
                    b = pusto;
            }
            if(c > a)
            {
                pusto = a; 
                    a = c; 
                    c = pusto;
            }
            if(c > b)
            {
                pusto = b; 
                    b = c; 
                    c = pusto;
            }
            Console.WriteLine(a + " >= " + b + " >= " + c);

            ////////////////////////////////////////////////////////////////////////////////////////
            // У меня не получилось по своему, сначало я хотел найти максимум, среднее, минимум и
            // в конце поменять местами, 
            // но вот так короче сделать недодумался
            // если честно я посмотрел с инета на другом языке
            // 
            /////////////////////////////////////////////////////////////////////////////////////////
            
            Console.ReadKey();
        }
    }
}