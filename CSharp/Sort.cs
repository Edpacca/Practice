using System;

namespace PracticeCode
{
    class Sort
    {
        public static int[] SortArray1(int[] array)
        {
            int buffer;
            int sortIndex = 1;
            int indexBuffer = 1;
            int length = array.Length;

            while (sortIndex < length)
            {
                indexBuffer = sortIndex;

                while (indexBuffer > 0)
                {
                    if (array[indexBuffer] < array[indexBuffer - 1])
                    {
                        buffer = array[indexBuffer - 1];
                        array[indexBuffer - 1] = array[indexBuffer];
                        array[indexBuffer] = buffer;
                    }

                    indexBuffer--;
                }

                sortIndex++;
            }

            PrintArray(array);
            return array;
        }

        public static int[] SortArray(int[] array)
        {
            int buffer;
            int length = array.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        buffer = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = buffer;
                    }
                }
            }

            PrintArray(array);
            return array;
        }

        public static void PrintArray(int[] array)
        {
            foreach (var value in array)
                Console.WriteLine(value);
        }



    }
}
