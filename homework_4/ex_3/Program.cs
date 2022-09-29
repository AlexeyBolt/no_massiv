Console.Clear();

void FillArray(int[] collect)
    {
    int length = collect.Length;
    int index = 0;
        while(index < length)
        {
        collect[index] = new Random().Next(0, 10);
        index++;
        }


    }
void PrintArray(int[] col)
    {
        int count = col.Length;
        int pos = 0; 
        while(pos < count)
        {
            Console.Write($"{col[pos]} ");
            pos++;
        }
    }
int[] array = new int[8];
FillArray(array);
PrintArray(array);