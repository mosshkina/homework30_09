// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework30_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Форточка");
            Console.Write("Введите длину форточки:");
            double dlina_f= double.Parse(Console.ReadLine());   
            Console.Write("введите ширину форточки:");
            double shirina_f = double.Parse(Console.ReadLine());
            Console.Write("Введите диаметр головы:");
            double diametr_f = double.Parse(Console.ReadLine());
             if(dlina_f-diametr_f>=1 && shirina_f - diametr_f >= 1)
            { Console.WriteLine("Вася сможет просунуть голову"); }
            else { Console.WriteLine("Вася не сможет просунуть голову"); }

            Console.WriteLine("Задача 2. Таблица умножения");

            Console.Write("Введите число n (1 <= n <= 9):");
            double num2 = double.Parse(Console.ReadLine());
            if (num2 >= 1 && num2 <= 9)
            {
                Console.WriteLine($"{num2}*1={num2 * 1}");
                Console.WriteLine($"{num2}*2={num2 * 2}");
                Console.WriteLine($"{num2}*3={num2 * 3}");
                Console.WriteLine($"{num2}*4={num2 * 4}");
                Console.WriteLine($"{num2}*5={num2 * 5}");
                Console.WriteLine($"{num2}*6={num2 * 6}");
                Console.WriteLine($"{num2}*7={num2 * 7}");
                Console.WriteLine($"{num2}*8={num2 * 8}");
                Console.WriteLine($"{num2}*9={num2 * 9}");
            }
            else { Console.WriteLine("Не удовлетворяет условию"); }


            Console.WriteLine("Задача 3. Бэнг Бум");
            Console.Write("Введите число:");
            double num3= double.Parse(Console.ReadLine());
            if (num3%3==0 && num3%5!=0) { Console.WriteLine("Бэнг"); }
            else if (num3 % 5 == 0 && num3 % 3 != 0) { Console.WriteLine("Бум"); }
            else if (num3 % 3 == 0 && num3 % 5 == 0) { Console.WriteLine("БэнгБум"); }
            else { Console.WriteLine("Мимо"); }

            Console.WriteLine("Задача 4. ЗАГЛАВНЫЕ БУКВЫ");
            Console.Write("Введите строку:");
            string stroka = Console.ReadLine();
            bool zaglav = true;
 
            for (int i = 0; i < stroka.Length; i++)
                if (stroka[i] == stroka.ToUpper()[i]) { zaglav = true; }
            else { zaglav = false;
                    break;
                }
            Console.WriteLine(zaglav);


            Console.WriteLine("Задача 5. овцы");
            Console.Write("Введите строку:");
            






        }
        }
}

