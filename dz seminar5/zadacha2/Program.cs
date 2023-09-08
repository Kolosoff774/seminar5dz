﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0 

int[] CreateArrayRndInt(int size, int min, int max) {
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

double[] CreateArrayRndDouble(int size, int min, int max) {
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++) {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArrayDouble(double[] arr, int round) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}, ");
        else Console.Write($"{num}");
    }
    Console.Write("] -> ");
}

void PrintArray(int[] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] -> ");
}

int SumNotEvenNamber (int[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (i % 2 != 0) {
            sum += arr[i]; 
        }
    }
    return sum;
}

int[] array = CreateArrayRndInt(4, -100, 100);
PrintArray(array);

int result = SumNotEvenNamber(array);
Console.WriteLine(result);