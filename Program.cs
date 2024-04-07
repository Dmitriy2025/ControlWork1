string[] ThreeSymbolsArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];

    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

Console.Clear();

string[] array = { "dog", "zebra", "bat", "giraffe", "elephant", "cat", "bear", "fox" };
string[] newArray = ThreeSymbolsArray(array);

Console.WriteLine($"Исходный массив:\t[" + string.Join(", ", array) + "]");
Console.WriteLine($"Преобразованный массив:\t[" + string.Join(", ", newArray) + "]");

