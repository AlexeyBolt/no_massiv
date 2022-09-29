/* - введите 2 числа, и возведите число 1 в степень 2го числа/*  */

Console.Clear();

Console.Write("Введите число   : ");
  int num = int.Parse(Console.ReadLine());
  Console.Write("Введите степень : ");
  int n = int.Parse(Console.ReadLine());
  int vstepeni=1;
  for(int i=0; i<n; i++) 
  {
   vstepeni*=num;
  }
  Console.WriteLine(vstepeni);
  Console.ReadKey();
  return 0;
