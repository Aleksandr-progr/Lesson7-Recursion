//Задача 1: выводит все натуральные числа в промежутке от M до N.
//Задача 2: вычисляет значение функции Аккермана с помощью рекурсии.
//Задача 3: выводит элементы массива, начиная с конца, с использованием рекурсии.
using System;

namespace Tasks 
{
    static class Program 
    {
        // Основная функция программы
        public static void Main(string[] args) 
        {
            Console.Clear();
            string stringLoad = "Введите номер задачи (от 1 до 3) => ";
            Console.Write(stringLoad);
            Tasks(NumberInTerminal(3, stringLoad, 1)); // Вызов функции Tasks с введенным пользователем номером задачи
        }

        // Функция для выполнения задач в зависимости от выбранного номера
        static void Tasks(int num) 
        {
            switch (num) 
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                default:
                    Console.WriteLine("Неверный номер задачи.");
                    break;
            }
        }

        // Задача 1: вывод натуральных чисел в промежутке от M до N
        static void Task1() 
        {
            Console.WriteLine("Задача 1: Задайте значения M и N. Напишите программу, которая выведет");
            Console.WriteLine("все натуральные числа в промежутке от M до N. Используйте рекурсию, а не циклы.");

            string firstText = "Введите значение М => ";
            Console.Write(firstText);
            int firstNumber = NumberInTerminal(0xFFFFFF, firstText, 1);

            string secondText = "Введите значение N => ";
            Console.Write(secondText);
            int secondNumber = NumberInTerminal(0xFFFFFF, secondText, 1);

            Console.WriteLine($"Числа от {firstNumber} до {secondNumber} => {ShowDigit(firstNumber, secondNumber)}");
        }

        // Задача 2: вычисление функции Аккермана с помощью рекурсии
        static void Task2() 
        {
            Console.WriteLine("Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
            Console.WriteLine("Даны два неотрицательных числа m и n.");

            string firstText = "Введите значение m => ";
            Console.Write(firstText);
            int firstNumber = NumberInTerminal(0xFFFFFF, firstText, 0);

            string secondText = "Введите значение n => ";
            Console.Write(secondText);
            int secondNumber = NumberInTerminal(0xFFFFFF, secondText, 0);

            Console.WriteLine($"Значение по функции Аккермана ({firstNumber},{secondNumber}) = {Ack(firstNumber, secondNumber)}");
        }

        // Задача 3: вывод элементов массива, начиная с конца
        static void Task3() 
        {
            Console.WriteLine("Задача 3: Задайте произвольный массив. Выведете его элементы,");
            Console.WriteLine("начиная с конца. Используйте рекурсию, а не циклы.");

            int[] array = CreateArray(10, 10, 0);
            Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
            Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array, array.Length - 1))}]");
        }

        // Функция создания массива с произвольными числами
        public static int[] CreateArray(int size, int max, int min) 
        {
            int[] array = new int[size];
            Random rand = new();
            for (int i = 0; i < size; i++) 
            {
                array[i] = rand.Next(min, max + 1);
            }
            return array;
        }

        // Функция для вывода массива в виде строки
        public static string PrintArray(int[] array) 
        {
            return string.Join(", ", array);
        }

        // Рекурсивная функция для перестановки элементов массива
        public static int[] ArraySwap(int[] array, int index) 
        {
            if (index <= 0) 
            {
                return array;
            }
            int temp = array[index];
            array[index] = array[array.Length - index - 1];
            array[array.Length - index - 1] = temp;
            return ArraySwap(array, index -= 2);
        }

        // Функция вычисления функции Аккермана
        public static int Ack(int m, int n) 
        {
            if (m == 0) 
            {
                return n + 1;
            } 
            else 
            {
                if (n == 0) 
                {
                    return Ack(m - 1, 1);
                } 
                else 
                {
                    return Ack(m - 1, Ack(m, n - 1));
                }
            }
        }

        // Функция для ввода числа в терминале с проверкой на корректность
        public static int NumberInTerminal(int numberDigits, string repeatString, int minValueSet) 
        {
            string ? numString = Console.ReadLine();
            int numInt = 0;
            while ((!Int32.TryParse(numString, out numInt))
                    || !(numInt >= minValueSet)
                    || !(numInt <= numberDigits)) 
            {
                Console.WriteLine("Ошибка ввода, повторите");
                Console.Write(repeatString);
                numString = Console.ReadLine();
            }
            return numInt;
        }

        // Функция для вывода натуральных чисел в промежутке от M до N
        public static string ShowDigit(int firstDigit, int secondDigit) 
        {
            if (firstDigit > secondDigit) 
            {
                return "";
            }
            return $"{firstDigit} " + ShowDigit(firstDigit + 1, secondDigit);
        }
    }
}
