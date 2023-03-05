// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


//Метод, который конвертирует введенное в консоль любое вещественное отрицательное число
// в целое число без остатка

int convertNumberToInt (string message)
{
  Console.WriteLine (message);
  string str = Console.ReadLine() ?? String.Empty;
  double numberDouble = Math.Abs(Convert.ToDouble(str));
  int result = (int) numberDouble;
  System.Console.WriteLine($"Your number is reduced to: {result}");
  return result;
}

//Метод создает матрицу рандомных размеров (3,6) и заполняющий случайными вещественными числами

double [,] FillMatrix ()
{
  Random rnd = new Random();
  int rowIn = rnd.Next(3,6);
  int collIn = rnd.Next(3,6);
  double [,] resultMatrix = new double [rowIn, collIn];
  for (int i = 0; i < rowIn; i++)
  {
    for (int j = 0; j < collIn; j++)
    {
      resultMatrix [i,j] = (double) rnd.Next(-100,101)/10;
    }
  }
  return resultMatrix;
}


//Метод, выводит в консоль спойлер-матрицу

void ShowRealSpoilerMatrix (double [,] matrixIn)
{
  System.Console.WriteLine("Your matrix-spoiler:");
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      System.Console.Write("**\t");
    }
    System.Console.WriteLine();
  }
}

//Метод, выводит в консоль матрицу, с открытой ячейкой, к которой обращается пользоваетель

void ShowUseElementMatrix (double [,] matrixIn, int useRow, int useColl)
{
  if (useRow > matrixIn.GetLength(0)-1 || useColl > matrixIn.GetLength(1)-1)
  {
    System.Console.WriteLine("Error! There is no such number in the array, you have gone beyond the boundaries of the matrix!");
    return;
  }
  System.Console.WriteLine("Your matrix with open position:");
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      if (i == useRow && j == useColl)
      {
        System.Console.Write($"{matrixIn[i,j]}\t");
      }
      else
      {
        System.Console.Write("**\t");
      }
    }
    System.Console.WriteLine();
  }
}

//Метод, выводит в консоль матрицу, заполненную вещественными числами

void ShowRealMatrix (double [,] matrixIn)
{
  System.Console.WriteLine("Your matrix filled withrandom real numbers:");
  for (int i = 0; i < matrixIn.GetLength(0); i++)
  {
    for (int j = 0; j < matrixIn.GetLength(1); j++)
    {
      System.Console.Write($"{matrixIn[i,j]}\t");
    }
    System.Console.WriteLine();
  }
}

// Результирующий метод создания вещественной матрицы, размером, задаваемым пользователем

void MatrixSearchElement ()
{
  double [,] useMatrix = FillMatrix();
  ShowRealSpoilerMatrix (useMatrix);
  int numberRow = convertNumberToInt("Enter element ROW number of the real matrix");
  int numberColl = convertNumberToInt("Enter element COLUMN number of the real matrix");
  ShowUseElementMatrix(useMatrix, numberRow, numberColl);
  ShowRealMatrix (useMatrix);
}

// Точка входа в программу

MatrixSearchElement ();