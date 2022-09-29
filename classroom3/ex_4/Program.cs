Console.Clear(); // программа для упорядочивания массива
int[] arr = {9,8,5,6,4,1,3,8,7,5,3};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}



void SelectionSort(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int minPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] < array[minPosition])
 {
 minPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temporary;
 }
}
PrintArray(arr);
SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);
