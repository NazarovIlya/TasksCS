﻿using _02_Sort;

Console.WriteLine("Сортировка пузырьком:\n".ToUpper());

int[] arr1 = { -97, 5, -1, 5, 8, -23, 56, -44 };
int[] arr2 = { -87, 7, -5, 5, 76, -43, 6, -4 };
int[] arr3 = { -4, 6, 15, -5, 54, -25, 26, -64 };
int[] arr4 = { 97, 3, -67, 55, 77, -21, 90, -80 };
int[] arr5 = { 0, 7, -24, 3, 9, -10, 70, -10 };

List<int[]> arrs  = new List<int[]>();

arrs.Add(arr1);
arrs.Add(arr2); 
arrs.Add(arr3);
arrs.Add(arr4);
arrs.Add(arr5);

Sort sort = new Sort();

foreach (var arr in arrs)
{
  Console.WriteLine($"Исходный массив: \t\t[ {string.Join(", ", arr)} ]");
  sort.BubbleSort(arr);
  Console.WriteLine($"Отсотрированный массив: \t[ {string.Join(", ", arr)} ]\n");
}