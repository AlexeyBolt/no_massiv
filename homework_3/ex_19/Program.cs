/* Варинат Google
Console.Clear();
Console.WriteLine("Введите пятизначное число : ");
 string input = (Console.ReadLine()!);

Console.Write("{0}", (input.ToLower() == (new string(input.ToLower().Reverse().ToArray()))) ? "Палиндром" : "Не палиндром");
Console.ReadKey();  */

Console.Clear();
Console.WriteLine("Введите пятизначное число : ");
int num = int.Parse(Console.ReadLine()!);
if(num<0)
{
    num=num*-1;
}
if(num >= 10000 && num <= 99999)
{
    int ch1 = num/1000;
    int end2 = num%100/10;
    int end1 = num%10;

    if(ch1 == (end1 * 10 + end2))
    {
        Console.WriteLine("Это палиндром"); 
    }

    else 
    {
        Console.WriteLine("Это не палиндром");
    }
}
 else 
{
    Console.WriteLine("Это не пятизначное число");
}


