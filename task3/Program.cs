/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

float[] arrayInit(int size)
{
    Random rnd = new Random();
    float[] array = new float[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

float maxAndMinDiffrence(float[] array)
{
    float max = array[0];
    float min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
float[] array = arrayInit(size);
Console.WriteLine($" в массиве [{string.Join(",", array)}] разница максимального и минимального значений = {maxAndMinDiffrence(array)}");
