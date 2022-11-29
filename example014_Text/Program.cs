// ==== Работа с текстом
// Дан текст.В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - Сказал князь, улыбаясь, - что, "
            + "ежели бы вас поСлали вместо нашего милого Винцегороде, "
            + "вы бы взяли приступом Согласие пруССкого короля. "
            + "Вы так краСноречивы. Вы дадите мне чаю? ";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i=0;i<length;i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result +$"{text[i]}";
    }

    return result;
}

Console.Clear();
Console.WriteLine(text);

string newText = Replace(text,' ','_');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText,'к','К');        //Не забывай значение в ' ' писать на том же языке, на котором и текст
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText,'С','с');
Console.WriteLine(newText);
Console.WriteLine();