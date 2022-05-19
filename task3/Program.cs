void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

void MultiplyMatrix(int[,] matrix, int[,] matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix.GetLength(1); k++)
      {
        sum += matrix[i,k] * matrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.WriteLine("Введите количество строк (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [m,n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int[,] matrix2 = new int [n,m];
FillArray(matrix2);
PrintArray(matrix2);

int[,] resultMatrix = new int[m,m];

MultiplyMatrix(matrix, matrix2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);