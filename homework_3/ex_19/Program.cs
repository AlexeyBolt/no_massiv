Console.Clear();
Console.WriteLine("Введите число");
string input = (Console.ReadLine()!);

Console.Write("{0}", (input.ToLower() == (new string(input.ToLower().Reverse().ToArray()))) ? "Палиндром" : "Не палиндром");
Console.ReadKey();