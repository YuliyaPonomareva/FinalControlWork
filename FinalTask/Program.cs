/*
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []  
*/

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int count = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите элементы массива:");
string[] array = GetArray(count);
Console.WriteLine();
Console.WriteLine("Первый массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Измененный массив:");
string[] array1 = FromArray(array);
PrintArray(array1);

string[] GetArray(int count)
{
    string[] arr = new string[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string[] FromArray(string[] mass)
{
    string[] mass1 = new string[mass.Length];
    int size = 0;
    foreach (string el in mass)
    {
        if(el.Length<=3)
        {
            mass1[size] = el;
            size++;
        }
    }
    return mass1;
}
