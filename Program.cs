// Задача 1:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите количество строк массива: ");
//         int numRows;

//         while (!int.TryParse(Console.ReadLine(), out numRows) || numRows <= 0)
//         {
//             Console.WriteLine("Ошибка. Введите положительное число строк массива.");
//         }

//         Console.Write("Введите количество столбцов массива: ");
//         int numCols;

//         while (!int.TryParse(Console.ReadLine(), out numCols) || numCols <= 0)
//         {
//             Console.WriteLine("Ошибка. Введите положительное число столбцов массива.");
//         }

//         // Генерируем двумерный массив
//         int[,] randomNumbersArray = GenerateRandomNumbersArray(numRows, numCols);

//         Console.WriteLine("Сгенерированный массив:");
//         DisplayArray(randomNumbersArray);
//         Console.WriteLine("\t");  
//         // Получение позиции элемента от пользователя
//         Console.Write("\nВведите номер строки: ");
//         int row;

//         while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row >= numRows)
//         {
//             Console.WriteLine($"Ошибка. Введите номер строки (0 to {numRows - 1}).");
//         }

//         Console.Write("Введите номер столбца: ");
//         int col;

//         while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col >= numCols)
//         {
//             Console.WriteLine($"Ошибка. Введите номер столбца (0 to {numCols - 1}).");
//         }

//         // Получение и отображение значения в указанном элементе
//         int elementValue = GetElementValue(randomNumbersArray, row, col);
//         if (elementValue != int.MinValue)
//         {
//             Console.WriteLine($"\nЗначение элемента ({row}, {col}): {elementValue}");
//         }
//         else
//         {
//             Console.WriteLine($"\nТакого элемента нет ({row}, {col}).");
//         }
//     }

//     static int[,] GenerateRandomNumbersArray(int numRows, int numCols)
//     {
//         Random random = new Random();
//         int[,] numbersArray = new int[numRows, numCols];

//         for (int i = 0; i < numRows; i++)
//         {
//             for (int j = 0; j < numCols; j++)
//             {
//                 numbersArray[i, j] = random.Next(1, 100); // Генерируем случайное число в диапазоне от 1 до 100
//             }
//         }

//         return numbersArray;
//     }

//     static void DisplayArray(int[,] array)
//     {
//         int numRows = array.GetLength(0);
//         int numCols = array.GetLength(1);

//         for (int i = 0; i < numRows; i++)
//         {
//             for (int j = 0; j < numCols; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     static int GetElementValue(int[,] array, int row, int col)
//     {
//         int numRows = array.GetLength(0);
//         int numCols = array.GetLength(1);

//         if (row >= 0 && row < numRows && col >= 0 && col < numCols)
//         {
//             return array[row, col];
//         }
//         else
//         {
//             return int.MinValue; // Указывает на отсутствие такого элемента
//         }
//     }
// }


// Задача 2:
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.



// using System;

// class Program
// {
//     static void Main()
//     {
//         // Запрашиваем размер массива от пользователя
//         Console.Write("Введите количество строк массива: ");
//         int numRows;

//         while (!int.TryParse(Console.ReadLine(), out numRows) || numRows <= 0)
//         {
//             Console.WriteLine("Ошибка. Введите положительное число строк массива.");
//         }

//         Console.Write("Введите количество столбцов массива: ");
//         int numCols;

//         while (!int.TryParse(Console.ReadLine(), out numCols) || numCols <= 0)
//         {
//             Console.WriteLine("Ошибка. Введите положительное число столбцов массива.");
//         }

//         // Генерируем массив
//         int[,] array = CreateArray(numRows, numCols);
//         Console.WriteLine("\nСгенерированный массив:");
//         DisplayArray(array);

//         // Меняем местами первую и последнюю строки
//         SwapRows(array, 0, numRows - 1);

//         // Выводим изменённый массив
//         Console.WriteLine("\nИзменённый массив:");
//         DisplayArray(array);
        
//     }

//     static int[,] CreateArray(int numRows, int numCols)
//     {
//         Random random = new Random();
//         int[,] array = new int[numRows, numCols];

//         for (int i = 0; i < numRows; i++)
//         {
//             for (int j = 0; j < numCols; j++)
//             {
//                 array[i, j] = random.Next(1, 100); // Генерируем случайные числа от 1 до 100
//             }
//         }

//         return array;
//     }

//     static void SwapRows(int[,] array, int row1, int row2)
//     {
//         int numCols = array.GetLength(1);

//         for (int i = 0; i < numCols; i++)
//         {
//             int temp = array[row1, i];
//             array[row1, i] = array[row2, i];
//             array[row2, i] = temp;
//         }
//     }

//     static void DisplayArray(int[,] array)
//     {
//         int numRows = array.GetLength(0);
//         int numCols = array.GetLength(1);

//         for (int i = 0; i < numRows; i++)
//         {
//             for (int j = 0; j < numCols; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
        
//         }
//     }
// }


// Задача 3:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаём размер массива
//         Console.Write("Введите количество строк массива: ");
//         int numRows;

//         while (!int.TryParse(Console.ReadLine(), out numRows) || numRows <= 0)
//         {
//             Console.WriteLine("Ошибка. Введите положительное число строк массива.");
//         }

//         Console.Write("Введите количество столбцов массива: ");
//         int numCols;

//         while (!int.TryParse(Console.ReadLine(), out numCols) || numCols <= 0 || numCols == numRows)
//         {
//             Console.WriteLine("Ошибка. Введите положительное число столбцов массива (не совпадающее с количеством строк).");
//         }

//         // Генерируем массив
//         int[,] array = CreateArray(numRows, numCols);
//         Console.WriteLine("\nСгенерированный массив:");
//         DisplayArray(array);

//         // Находим строку с наименьшей суммой элементов
//         int minSumRowIndex = FindRowWithMinSum(array);

//         Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {minSumRowIndex}");
//     }

//     static int[,] CreateArray(int numRows, int numCols)
//     {
//         Random random = new Random();
//         int[,] array = new int[numRows, numCols];

//         for (int i = 0; i < numRows; i++)
//         {
//             for (int j = 0; j < numCols; j++)
//             {
//                 array[i, j] = random.Next(1, 10); // Генерируем числа от 1 до 10
//             }
//         }

//         return array;
//     }

//     static int FindRowWithMinSum(int[,] array)
//     {
//         int numRows = array.GetLength(0);
//         int numCols = array.GetLength(1);

//         int minSum = int.MaxValue;
//         int minSumRowIndex = -1;

//         for (int i = 0; i < numRows; i++)
//         {
//             int rowSum = 0;

//             for (int j = 0; j < numCols; j++)
//             {
//                 rowSum += array[i, j];
//             }

//             if (rowSum < minSum)
//             {
//                 minSum = rowSum;
//                 minSumRowIndex = i;
//             }
//         }

//         return minSumRowIndex;
//     }

//     static void DisplayArray(int[,] array)
//     {
//         int numRows = array.GetLength(0);
//         int numCols = array.GetLength(1);

//         for (int i = 0; i < numRows; i++)
//         {
//             for (int j = 0; j < numCols; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }