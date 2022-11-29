// Вид 1
void Method1()                    //Ничего не принимает и ничего не возвращает
{
    Console.WriteLine("Autor - Kindelik!!!");
}
Method1();

//Вид2
void Method2(string msg)           // Принимает, но не возваращает
{
    Console.WriteLine(msg);
}
Method2("String");

void Method21(string msg, int count)        // Принимает, проводит операции, но не возвращает
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;               //инкремент
    }
}

Method21(msg: "Текст", count: 5);          // Именованные аргументы, позволяет более четко определять, что куда, и позволяет не соблюдать последовательность

//Вид 3

int Method3()           //ничего не принимает, но возвращает
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "zZz");
Console.WriteLine(res);










































































