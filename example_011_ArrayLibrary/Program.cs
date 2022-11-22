void FillArray(int[] collection)            //Метод - Создать рандомный массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Положить новое рандомное число в индекс из диапозона 1-10
        index++;
    }
}

void PrintArray(int[] col)             //Метод - Вывести массив в терминал
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} " );
        position++;
    }
}

int Index0f(int[] collection, int find) //Метод - Example_010
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int pos = Index0f(array, 4);
Console.WriteLine(pos);
