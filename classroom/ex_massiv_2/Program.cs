Console.Clear();// находим элемент по номеру из массива
int [] array = {1,2,9,8,7,4,5,6,1,3,5,5};
int n = array.Length;

int find = 5;
int index = 0;

while(index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}








Console.WriteLine(n);