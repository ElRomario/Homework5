/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] arrayInit(int size)
{
    Random rnd = new Random();
    int[] array = new int[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
int notEvenCounter(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)counter +=array[i] ;
    }
    return counter;
}
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
int[] array = arrayInit(size);
Console.WriteLine($"В массиве [{string.Join(",", array)}] сумма нечетны чисел = {notEvenCounter(array)}");