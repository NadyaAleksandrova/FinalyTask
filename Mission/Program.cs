//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина, которых меньше либо равна 3 символа.

Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());

string[] ArrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string item = Convert.ToString(Console.ReadLine());
    ArrayStrings[i] = item;
}

string[] ArrayStrings2 = new string[size];
int chainlength = 3;
int element = 0;

for (int j = 0; j < size; j++)
{
    if (ArrayStrings[j].Length <= chainlength)
    {
        ArrayStrings2[element] = ArrayStrings[j];
        element++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(ArrayStrings2);