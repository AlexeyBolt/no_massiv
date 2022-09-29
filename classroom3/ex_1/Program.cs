// Вид 1
void Met1() // Создаем метод 1 и описываем его задачу
{
    Console.WriteLine("здесь был Тузик");
}
Met1(); // вызвали метод1


// Вид 2
void Met2(string messege)
{
    Console.WriteLine(messege);
}
Met2("Тузик всё...");

// Вид 3
int Met3 ()   //возвращаемый тип данных
{
    return DateTime.Now.DayOfYear;
}
int DayOfYear = Met3();
Console.WriteLine(DayOfYear);

//Вид 4 Методы, которые принимают и возвращают
string Met4(int count, string textinh)
{
int i=0;
string result = String.Empty; //   string result = "" ;
while (i < count)
    {
        result = result + textinh;
        i++;

    }
    return result;
}
string res = Met4(10, "гы");
Console.WriteLine(res);