﻿// See https://aka.ms/new-console-template for more information
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
            double dlina_f = double.Parse(Console.ReadLine());
            Console.Write("введите ширину форточки:");
            double shirina_f = double.Parse(Console.ReadLine());
            Console.Write("Введите диаметр головы:");
            double diametr_f = double.Parse(Console.ReadLine());
            if (dlina_f - diametr_f >= 1 && shirina_f - diametr_f >= 1)
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
            double num3 = double.Parse(Console.ReadLine());
            if (num3 % 3 == 0 && num3 % 5 != 0) { Console.WriteLine("Бэнг"); }
            else if (num3 % 5 == 0 && num3 % 3 != 0) { Console.WriteLine("Бум"); }
            else if (num3 % 3 == 0 && num3 % 5 == 0) { Console.WriteLine("БэнгБум"); }
            else { Console.WriteLine("Мимо"); }

            Console.WriteLine("Задача 4. ЗАГЛАВНЫЕ БУКВЫ");
            Console.Write("Введите строку:");
            string stroka = Console.ReadLine();
            bool zaglav = true; //Счетчик, определяющий верность строки на заглавные буквы

            for (int i = 0; i < stroka.Length; i++)
                if (stroka[i] == stroka.ToUpper()[i]) { zaglav = true; } //Проверка строки на заглавные буквы
                else { zaglav = false;
                    break;
                }
            Console.WriteLine(zaglav);


            Console.WriteLine("Задача 5. овцы");
            Console.Write("Введите число:");
            int ovcy = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= ovcy; i++)
            { Console.Write($"{i} овца... "); }
            Console.WriteLine(" ");


              Console.WriteLine("Задача 8. Куклы");
                int shetchikcucl=0;
                Console.WriteLine("Введите число эллементов массива:");
                int i81 = int.Parse(Console.ReadLine());
                string[] cucl = new string[i81];
         
            
                for (i81 = 0; i81 < (cucl.Length); i81++) //Прогон по массиву
                {


                    Console.WriteLine("Введите элемент массива:");
                    cucl[i81] = Console.ReadLine();
                }
                foreach (string n in cucl)
                { if (n == "Hello Kitty" || n == "Barbie doll" )
                    { shetchikcucl++; }
            }
            Console.WriteLine($"Количество кукол в сумке:{shetchikcucl}" );

            Console.WriteLine("Задача 6. Неотрицательные числа");

            try
            {
                Console.WriteLine("Введите число эллементов массива:");
                int i = int.Parse(Console.ReadLine());
                
                bool proverka = true;//счетчик до отричательного числа
                int[] massiv = new int[i];
                int i1 = 0;
                double sum = 0;
               
                while (i1 < i && proverka == true)
                {
                    
                    
                
                    for (i= 0; i < (massiv.Length); i++)
                    {
                        Console.WriteLine("Введите элемент массива:");
                        massiv[i] = int.Parse (Console.ReadLine());

                        if (massiv[i] < 0)
                        {
                            
                           proverka = false;  }

                        if (proverka==true)//Проверка на завершение последовательности
                        { sum += massiv[i];
                            i1++;
                        }
                        else { break; }
                    }
                }

                double srarifm = sum / i1;
               
                Console.WriteLine($"Среднее арифметическое чисел до отрицательного:{srarifm}");
            }
            catch (FormatException) { Console.WriteLine("Введите число!"); }
            finally
            {
                Console.WriteLine("Успешно!");
            }

            Console.WriteLine("Задача 7. Карты");
            try
            {
                Console.WriteLine("Введите достоинство карты:");
                int dost = int.Parse(Console.ReadLine());
                if (dost >= 6 && dost <= 14)
                {
                    if (dost == 6) { Console.WriteLine("Шестерка"); }
                    if (dost == 7) { Console.WriteLine("Cемерка"); }
                    if (dost == 8) { Console.WriteLine("Восьмерка"); }
                    if (dost == 9) { Console.WriteLine("Девятка"); }
                    if (dost == 10) { Console.WriteLine("Десятка"); }
                    if (dost == 11) { Console.WriteLine("Валет"); }
                    if (dost == 12) { Console.WriteLine("Дама"); }
                    if (dost == 13) { Console.WriteLine("Король"); }
                    if (dost == 14) { Console.WriteLine("Туз"); }
                }
                else { Console.WriteLine("Несуществующее значение"); }
            }
            catch (FormatException) { Console.WriteLine("Введите число!"); }

            Console.WriteLine("Задача 11. Порядок последовательности");
            int numm=10;
            int[] posled = new int[numm];
            bool proverka11 = true;
            int num11 = 0;
            while (num11 <= 10 && proverka11 == true)
            {



                for (numm = 0; numm < 10; numm++)
                {
                    Console.WriteLine("Введите элемент последовательности");
                    posled[numm] = int.Parse(Console.ReadLine());
                }
                for (numm = 2; numm <= 10; numm++)

                {
                    if (posled[numm - 1] > posled[numm])
                    {

                        proverka11 = false;
                        Console.WriteLine($"Последовательность нарушает {numm+1} элемент");//Прибавляем единицу для правильного определения номера 
                        break;
                    }
                    if (proverka11 == false) { break; }//Выход при нарушении последовательности
                }
            } if (proverka11 == true) { Console.WriteLine("Последовательность упорядочена"); }

                }
        } } 


