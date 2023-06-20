Console.Clear();

static string[] FilterStrings(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];
            index++;
        }
    }

    return result;
}


Console.WriteLine("Введите массив строк через запятую:");
string[] array = Console.ReadLine().Split(',');

string[] filteredArray = FilterStrings(array);

Console.WriteLine("Результат:");
foreach (string str in filteredArray)
{
    Console.WriteLine(str);
}
