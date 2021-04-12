namespace Laba_1
{
    public class InsertSort
    {
        private static void swap(ref int first, ref int second)
        {
            {
                var temp = first;
                first = second;
                second = temp;
            }
        }
        
        public static void insert_sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j;
                for(j = i;(j > 0) && (array[j - 1] > key); j--)
                {
                    swap(ref array[j-1], ref array[j]);
                }
                array[j] = key;
            }
        }
    }
}