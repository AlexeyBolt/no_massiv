Console.Clear();

Console.WriteLine("Введите координату X1");
Double x1 = Double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y1");
Double y1 = Double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X2");
Double x2 = Double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y2");
Double y2 = Double.Parse(Console.ReadLine()!);
//Double lenght = Math.Round(Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)),2);
//Console.WriteLine($"{lenght:f2}");
Double lenght = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
//Console.WriteLine($"{lenght:f2}");
Console.WriteLine($"{lenght:f3}");