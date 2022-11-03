/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] massiv = new double[15];
rndarr(massiv);
Console.WriteLine("Массив вещественных чисел");
PrintArray(massiv);
double min = Int32.MaxValue;
double max = Int32.MinValue;
 
    for (int i = 0; i < massiv.Length; i++)
{  
        if(massiv[i] > max) 
        {
            max = massiv[i];
        }
        if(massiv[i] < min) 
        {
            min = massiv[i];
        }
}

Console.WriteLine($"всего {massiv.Length} чисел.");
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void rndarr(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}