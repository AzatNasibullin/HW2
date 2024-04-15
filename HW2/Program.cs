class Program
{
    static void Main()
    {
        int[,] array = {
            {7, 3, 2},
            {4, 9, 6},
            {1, 8, 5}
        };

         int array1 = array.GetLength(0);
        int array2 = array.GetLength(1);
        int[] SortedArray = new int[array1 * array2];

        int index = 0;
        for (int i = 0; i < array1; i++)
        {
            for (int j = 0; j < array2; j++)
            {
                SortedArray[index] = array[i, j];
                index++;
            }
        }

        Array.Sort(SortedArray);

        index = 0;
        for (int i = 0; i < array1; i++)
        {
            for (int j = 0; j < array2; j++)
            {
                array[i, j] = SortedArray[index];
                index++;
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

//        for (int i = 0; i < array1; i++)
//        {
//            for (int j = 0; j < array2; j++)
//            {
//                Console.Write(array[i, j] + " ");
//            }
//            Console.WriteLine();
//        }
    }
}