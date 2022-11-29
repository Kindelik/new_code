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
    while(i<count)
    {
        Console.WriteLine(msg);
        i++;               //инкремент
    }
}

Method21(msg: "Текст", count:5);          // Именованные аргументы, позволяет более четко определять, что куда, и позволяет не соблюдать последовательность