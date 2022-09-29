Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (result < arg2) result = arg2;
if (arg3 > arg2) result = arg3;
return result;
}

int[] array = {99,10,12,28,56,950,1700,85,98};
array [0] = 12;
//Console.WriteLine(array[1]); // выводим в консоли элемент массива 1
int result = Max(Max(array[0], array[1], array[2]), Max(array[3],array[4],array[5]),Max(array[6],array[7],array[8]));
Console.WriteLine(result);