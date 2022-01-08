public static int[] GetFirstEvenNumbers(int count)
{
	int[] array = new int[count];
	for (int i = 0; i < array.Length; i++)
		array[i] = (i+1) * 2;
	return  array;
}
