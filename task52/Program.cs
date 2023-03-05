// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//Метод, заполняющий матрицу случайными целыми числами размером 5х5

int [,] FillMatrix ()
{
  int rowIn = 5;
  int collIn = 5;
  int [,] resultMatrix = new int [rowIn, collIn];
  Random rnd = new Random();
  for (int i = 0; i < rowIn; i++)
  {
    for (int j = 0; j < collIn; j++)
    {
      resultMatrix [i,j] = rnd.Next(1,10);
    }
  }
  return resultMatrix;
}

//Метод, выводит в консоль матрицу, заполненную целыми числами

void ShowRealMatrix (int [,] matrixIn)
{
  System.Console.WriteLine("Your matrix filled withrandom integer numbers:");
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      System.Console.Write($"{matrixIn[i,j]}\t");
    }
    System.Console.WriteLine();
  }
}

//Метод создает массив рассчита среднего арифметического числа каждого столбца матрицы

double [] AverageFillMatrix (int [,] matrixIn)
{
  double [] sumOfColummns = new double [matrixIn.GetLength(1)];
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      sumOfColummns[j] += (double) matrixIn [i,j];
    }
  }
  for (int i = 0; i < sumOfColummns.Length; i++)
  {
    sumOfColummns[i] /= sumOfColummns.Length;
  }
  return sumOfColummns;
}

//Метод выводит в консоль массив средних арифметических цифр столбцов матрицы

void ShowAverageColumnMatrix (double [] arrayIn)
{
  System.Console.WriteLine("Your values ​​of the arithmetic mean of the columns of the given matrix: ");
  for (int i = 0; i < arrayIn.Length; i++)
  {
    System.Console.Write($"{arrayIn[i]}\t");
   }
}

// Результирующий метод создания вещественной матрицы, размером, задаваемым пользователем

void SearchAverageColumnsMatrix ()
{
  int [,] useMatrix = FillMatrix();
  ShowRealMatrix (useMatrix);
  double [] averageArray = AverageFillMatrix (useMatrix);
  ShowAverageColumnMatrix (averageArray);
}

// Точка входа в программу

SearchAverageColumnsMatrix ();