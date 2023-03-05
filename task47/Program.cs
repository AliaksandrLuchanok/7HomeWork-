// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


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

//Метод, заполняющий матрицу случайными вещественными числами размером m*n

double [,] FillMatrix (int rowIn, int collIn)
{
  double [,] resultMatrix = new double [rowIn, collIn];
  Random rnd = new Random();
  for (int i = 0; i < rowIn; i++)
  {
    for (int j = 0; j < collIn; j++)
    {
      resultMatrix [i,j] = (double) rnd.Next(-100,101)/10;
    }
  }
  return resultMatrix;
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

void MatrixFillRandomRealNumbers ()
{
  int numberRow = convertNumberToInt("Enter the number of rows of the real matrix");
  int numberColl = convertNumberToInt("Enter the of columns array of the real matrix");
  double [,] useMatrix = FillMatrix(collIn:numberColl, rowIn:numberRow);
  ShowRealMatrix (useMatrix);
}

// Точка входа в программу

MatrixFillRandomRealNumbers ();