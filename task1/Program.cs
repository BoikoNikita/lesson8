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

void SortArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1)-1; k++)
      {
       	if (matrix[i,k] < matrix[i,k + 1])
			{
				int temp = matrix[i,k + 1];
				matrix[i,k + 1] = matrix[i,k];
				matrix[i,k] = temp;
			}
      }
    }
  }
}

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m,n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortArray(matrix);
PrintArray(matrix);