﻿string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)          // замена while 
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "zZz");
Console.WriteLine(res);







for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

























