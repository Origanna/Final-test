// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] EnterArray()
{
    Console.WriteLine("Введите количество строк в массиве:");
    int size = int.Parse(Console.ReadLine());

    string[] array = new string[size];

    Console.WriteLine("Введите строки (по одной на каждой строке):");
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int CountNumOfElements(string[] array, int n)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] FillNewArray(string[] array, int n)
{
    string[] newArray = new string[CountNumOfElements(array, n)];
    for (int i = 0, index = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void PrintArray(string[] newArray)
{
    Console.WriteLine("Новый массив:");
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i < newArray.Length - 1)
            Console.Write($"{newArray[i]}, ");
        else
            Console.Write($"{newArray[i]}");
    }
    Console.Write("]");
}

string[] array = EnterArray();
string[] result = FillNewArray(array, 3);
int count = CountNumOfElements(array, 3);
string[] newArray = new string[count];
PrintArray(result);