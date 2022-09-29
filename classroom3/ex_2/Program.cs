Console.Clear();

string Met4(int count, string textinh)
{

string result = String.Empty; //   string result = "" ;
for(int i = 0; i < count; i++)
    {
        result = result + textinh;
    }
    return result;
}
string res = Met4(10, "гы");
Console.WriteLine(res);

string res1 = Met4(10, "xa");
Console.WriteLine(res1);