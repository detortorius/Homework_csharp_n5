/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Сгенерирован массив из случайных положительных трёхзначных чисел имеет следующий вид");

int [] RandomArray()
{
    Random random = new Random();
    int size;
    size = random.Next(10, 20);
    int [] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 999);
    }
    return array;
}
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int parity(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {            
            if(array[i] % 2 == 0)
            count += 1;
        }
    return count;
}
int [] arr = RandomArray();
PrintArray(arr);
Console.WriteLine();
int countparity = parity(arr);
Console.WriteLine($"Количество чётных чисел в массиве = {countparity}");