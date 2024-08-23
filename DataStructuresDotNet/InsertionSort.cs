namespace DataStructuresDotNet
{
    internal class InsertionSort
    {
        //the time complexity is O(kn) when each element in the input is no more than k places away from its sorted position
        //does not change the relative order of elements with equal keys
        //only requires a constant amount O(1) of additional memory space

        //Worst-case performance	O ( n^2 ) {\displaystyle O(n^{2})} comparisons and swaps
        //Best-case performance	O ( n ) {\displaystyle O(n)} comparisons, O ( 1 ) {\displaystyle O(1)} swaps
        //Average performance	O ( n^2 ) {\displaystyle O(n^{2})} comparisons and swaps
        //Worst-case space complexity	O ( n ) {\displaystyle O(n)} total, O ( 1 ) {\displaystyle O(1)} auxiliary

        //Insertion sort runs in O(n) time in its best case and runs in O(n^2) in its worst and average cases. 

        //generic implementation
        public void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while(j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j-1);
                    j--;
                }
            }
        }

        private void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        //Non generic implementation
        public static void SimpleInsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
        }

        // Another implementation
        // Function to sort array
        // using insertion sort
        void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}