/*
Задача 36: Задайте одномерный массив,
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] RandomArray()
{   
    Random rnd = new Random();
    int size;
    size = rnd.Next(10, 20);
    int [] massiv = new int[size];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(-1000, 1000);
    }
    return massiv;
}
void PrintResult(int [] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");
    }
}
int SummElements(int [] massiv)
{
    int summ = 0;
    for (int i = 0; i < massiv.Length; i+=2)// запись для первого в списке 
    {
        summ = summ + massiv[i];
    }
    return summ;
}
int  [] arr = RandomArray();
PrintResult(arr);
Console.WriteLine();
int resultSumm = SummElements(arr);
Console.WriteLine($"Сумма элементов стоящих на нечётных позициях, но чётных индексах {resultSumm}");
