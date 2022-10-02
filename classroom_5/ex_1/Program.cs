Console.Clear();

/* string[,]table=new string[2,5];
table[1,2]= "Slovo";
for (int row = 0; row < 2; row++)
{
    for (int col = 0; col < 5; col++)
    {
        Console.WriteLine($"-{table[row,col]}-");
    }
} */

int[,] matrix = new int[3,4];

void PrintArray(int[,]matr) //добавили метод для вывода печати
{
for (int rows = 0; rows < matr.GetLength(0); rows++)  // можно написать for (int rows = 0; rows < 3(строки); rows++)
{
    for (int colu = 0; colu < matr.GetLength(1); colu++) // можно написать for (int colu = 0; rows < 3(столбца); rows++)
    {
    Console.Write($"{matr[rows,colu]} ");
    }
    Console.WriteLine(); // чтоб выводилось корректно, следует добавить эту строчку
}
}
void FillArray(int[,]matr)
{
for (int rows = 0; rows < matr.GetLength(0); rows++)
{
   for (int colu = 0; colu < matr.GetLength(1); colu++)
   {
    matr[rows,colu]=new Random().Next(1,100);
   }
}
}
FillArray(matrix);
PrintArray(matrix);