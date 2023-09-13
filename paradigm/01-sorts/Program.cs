
int[] SortImperative(int[] inputArray){

	int[] QuickSort(int[] array, int minIndex, int maxIndex)
	{
		if (minIndex >= maxIndex) return array;
		int pivot = GetPivotIndex(array, minIndex, maxIndex);
		QuickSort(array, minIndex, pivot - 1);
		QuickSort(array, pivot + 1, maxIndex);
		return array;
	}


	int GetPivotIndex(int[] array, int minIndex, int maxIndex)
	{
		int pivotIndex = minIndex - 1;
		for (int i = minIndex; i <= maxIndex; i++)
		{
			if (array[i] < array[maxIndex])
			{
				pivotIndex++;
				Swap(array, i, pivotIndex);
			}
		}
		pivotIndex++;
		Swap(array, pivotIndex, maxIndex);
		return pivotIndex;
	}


	void Swap(int[] array, int leftValue, int rightValue)
	{
		int temp = array[leftValue];
		array[leftValue] = array[rightValue];
		array[rightValue] = temp;
	}

	return QuickSort(inputArray, 0, inputArray.Length - 1);
}

int[] SortDeclarative(int[] inputArray){
	Array.Sort(inputArray);
	return inputArray;
}

Console.Clear();
int[] arrFirst = { 8, 0, -4, 7, -2, 2, -9, 3 };
int[] arrSecond = { 80, 0, -40, 70, -20, 20, -90, 30 };
Console.WriteLine($"Исходный массив для метода SortImperative: \t\t[ {string.Join(", ", arrFirst)} ]");
Console.WriteLine($"Исходный массив для метода SortDeclarative: \t\t[ {string.Join(", ", arrSecond)} ]");
int[] resImperative = SortImperative(arrFirst);
Console.WriteLine($"Отсортированный массив методом SortImperative: \t\t[ {string.Join(", ", resImperative)} ]");
int[] resDeclarative = SortDeclarative(arrSecond);
Console.WriteLine($"Отсортированный массив методом SortDeclarative: \t[ {string.Join(", ", resDeclarative)} ]");