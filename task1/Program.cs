/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int[] arrayInit(int size)
{
    Random rnd = new Random();
    int[] array = new int[size]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
int evenCounter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
int[] array = arrayInit(size);
Console.WriteLine($"В массиве [{string.Join(",", array)}]{evenCounter(array)} четных чисел");

