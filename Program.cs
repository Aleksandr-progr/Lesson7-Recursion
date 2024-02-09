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
                    // Задача 1: вывод натуральных чисел в промежутке от M до N
                    Console.WriteLine("Задача 1: Задайте значения M и N. Напишите программу, которая выведет ");
                    Console.WriteLine("все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.");
                    string firstText = "Введите значение М => ";
                    Console.Write(firstText);
                    int firstNumber = NumberInTerminal(0xFFFFFF, firstText, 1);
                    string secondText = "Введите значение N => ";
                    Console.Write(secondText);
                    int secondNumber = NumberInTerminal(0xFFFFFF, secondText, 1);
                    Console.WriteLine($"Числа от {firstNumber} до {secondNumber} => {ShowDigit(firstNumber, secondNumber)}");
                    break;

                case 2:
                    // Задача 2: вычисление функции Аккермана с помощью рекурсии
                    Console.WriteLine("Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
                    Console.WriteLine("Даны два неотрицательных числа m и n.");
                    string firstText2 = "Введите значение m => ";
                    Console.Write(firstText2);
                    int firstNumber2 = NumberInTerminal(0xFFFFFF, firstText2, 0);
                    string secondText2 = "Введите значение n => ";
                    Console.Write(secondText2);
                    int secondNumber2 = NumberInTerminal(0xFFFFFF, secondText2, 0);
                    Console.WriteLine($"Значение по фукнкции Аккермана ({firstNumber2},{secondNumber2}) = {Ack(firstNumber2, secondNumber2)}");
                    break;

                case 3:
                    // Задача 3: вывод элементов массива, начиная с конца
                    Console.WriteLine("Задача 3: Задайте произвольный массив. Выведете его элементы,");
                    Console.WriteLine("начиная с конца. Использовать рекурсию, не использовать циклы.");
                    int[] array = CreateArray(10, 10, 0);
                    Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
                    Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array, array.Length - 1))}]");
                    break;
            }
        }
