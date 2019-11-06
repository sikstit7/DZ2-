using System;

namespace ДЗ_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double resyltat;
            char oper;
            Console.WriteLine("введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
            if (oper == '+') 
            {
                resyltat = a + b;
                Console.WriteLine("Сумма равна:" + resyltat);
            }   else if (oper == '-')
            {
                resyltat = a - b;
                Console.WriteLine("Разность равна:" + resyltat);
            }   else if (oper == '*')
            {
                resyltat = a * b;
                Console.WriteLine("Производная равно:" + resyltat);
            }   else if (oper == '/')
            {
                resyltat = a / b;
                Console.WriteLine("Деление равно:" + resyltat);
            }   else
            {
                Console.WriteLine("Неизвестный оператор");
            }
            Console.ReadKey();
        }
    }
}