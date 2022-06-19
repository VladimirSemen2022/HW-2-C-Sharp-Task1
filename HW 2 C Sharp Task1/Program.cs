//Задание 1
//Объявить одномерный(5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дроб -
//ных чисел с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а
//двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива
//А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, мини-
//мальный элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных элементов
//массива А, сумму нечетных столбцов массива В.

using System;

namespace HW_2_C_Sharp_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            double[] A = new double[size];
            double summA, summB, summAB, maxA, maxB, maxAB, minA, minB, minAB, prodA, prodB, prodAB, summEvenItemA, summOddColumnB;
            summA = summB =summAB = maxA = maxB = maxAB = minA = minB = minAB = summEvenItemA = summOddColumnB = 0;
            prodA = prodB = prodAB = 1;
            Console.WriteLine("Input 5 fractional numbers");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
                summA += A[i];
                prodA *= A[i];
                if (maxA < A[i])
                    maxA = A[i];
                if (i == 0)
                    minA = A[i];
                if (minA > A[i])
                    minA = A[i];
                if (i % 2 == 0)
                    summEvenItemA += A[i];
            }
            Random rand = new Random();
            int row = 3;
            int col = 4;
            double[,] B = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    B[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
                    summB += B[i, j];
                    prodB *= B[i, j];
                    if (maxB < B[i, j])
                        maxB = B[i, j];
                    if (i == 0 && j == 0)
                        minB = B[i, j];
                    if (minB > B[i, j])
                        minB = B[i, j];
                    if (j % 2 != 0)
                        summOddColumnB += B[i, j];
                }
            }
            Console.Write("\nArray A has next items - ");
            foreach (float items in A)
            {
                Console.Write($"{items} ");
            }
            Console.WriteLine($"\nFirst array has maximal number - {maxA}");
            Console.WriteLine($"\nFirst array has minimal number - {minA}");
            Console.WriteLine($"\nFirst array has summ numbers - {summA}");
            Console.WriteLine($"\nFirst array has summ numbers of even elements - {summEvenItemA}");
            Console.WriteLine($"\nFirst array has power of numbers - {prodA}");
            Console.WriteLine("\nSecond array has next items:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{B[i, j]} ");
                }
                Console.Write("\n");
            }
            Console.WriteLine($"\nSecond array has maximal number - {maxB}");
            Console.WriteLine($"\nSecond array has minimal number - {minB}");
            Console.WriteLine($"\nSecond array has summ numbers - {summB}");
            Console.WriteLine($"\nSecond array has summ numbers of odd columns - {summOddColumnB}");
            Console.WriteLine($"\nSecond array has power of numbers - {prodB}");
            summAB = summA + summB;
            prodAB = prodA * prodB;
            maxAB = (maxA > maxB) ? maxA : maxB;
            minAB = (minA < minB) ? minA : minB;
            Console.WriteLine($"\nSumm all numbers of both arrays is - {summAB}");
            Console.WriteLine($"\nMaximal number among items both arrays is - {maxAB}");
            Console.WriteLine($"\nMinimal number among items both arrays is - {minAB}");
            Console.WriteLine($"\nProduct all numbers of both arrays is - {prodAB}");
        }
    }
}
