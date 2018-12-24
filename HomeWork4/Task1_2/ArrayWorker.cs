using System;
using System.IO;


namespace Task1_2
{
    public static class ArrayWorker
    {
        public static int[] GetRandomArray(int min, int max, int count)
        {
            int[] result = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                result[i] = rnd.Next(min, max + 1);
            }
            return result;
        }

        public static int ResolveTask1(int[] arr, int divider)
        {
            int result = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % divider == 0 ^ arr[i+1] % divider == 0)
                {
                    result++;
                }
            }
            return result;
        }

        public static int[] GetArrayFromFile(string fileName)
        {
            try
            {
                var tempArr = File.ReadAllLines(fileName);
                int[] result = new int[tempArr.Length];
                for (int i = 0; i < tempArr.Length; i++)
                {
                    result[i] = int.Parse(tempArr[i]);
                }
                return result;  
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return new int[0];
            }

        }

    }
}
