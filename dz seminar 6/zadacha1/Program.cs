/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] PromptArray(int[] arr) 
{
    int i = 0;
    while (i < arr.Length) 
    {
        arr[i] = int.Parse (Console.ReadLine());
        i++;
    }
    return arr;
}

void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int PositiveNumbers(int[] arr) 
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++) 
    {
        if (arr[i] > 0) 
        {
            num++;
        }
    }
    return num;
}

Console.WriteLine("Введи количество элементов: ");
int length = int.Parse (Console.ReadLine());

Console.WriteLine("Введи элементы:");
int[] array = new int[length];
PromptArray(array);

PrintArray(array);
Console.Write($"Количество чисел больше 0 = {PositiveNumbers(array)}");