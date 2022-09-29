Console.Clear();

void FillArray(int[] collect)
    {
    int length = collect.Length;
    int index = 0;
        while(index < length)
        {
        collect[index] = new Random().Next(0, 100);
        index++;
        }


    }
void PrintArray(int[] col)
    {
        int count = col.Length;
        int pos = 0; // pos вместо index
        while(pos < count)
        {
            Console.WriteLine(col[pos]);
            pos++;
        }
    }
int[] array = new int[10];
FillArray(array);
PrintArray(array);




