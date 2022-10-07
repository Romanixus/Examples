

void Method1()
{
    Console.Clear();
    Console.WriteLine("Победа");
}//Не принимает аргументы и не возвращает
Method1();

void Method2(string msg, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
}// Принимает аргументы, но не возвращает
Method2("Ура!", 10);

int Method3()
{
    return DateTime.Now.Year;
}// Не принимает аргументы, но может возвращать
Console.WriteLine(Method3());

string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}//Принимает аргумент и возвращает
Console.WriteLine(Metod4(10, "Z0V!"));
/*
for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}// Таблица умножения
*/