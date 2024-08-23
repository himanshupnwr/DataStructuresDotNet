using System.Collections.Generic;

namespace DataStructuresDotNet
{
    internal class BubbleSort
    {

        //Worst-case performance O(n 2 ) {\displaystyle O(n^{ 2})} comparisons, O(n 2 ) {\displaystyle O(n^{ 2})} swaps
        //Best-case performance O(n ) {\displaystyle O(n)} comparisons, O( 1 ) {\displaystyle O(1)} swaps
        //Average performance O(n 2 ) {\displaystyle O(n^{ 2})} comparisons, O(n 2 ) {\displaystyle O(n^{ 2})} swaps
        //Worst-case space complexity O(n ) {\displaystyle O(n)} total, O( 1 ) {\displaystyle O(1)} auxiliary
        //Optimal No
        public void Sort<T>(T[] array) where T : IComparable
        {
            for(int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;
                for (int j = 0; j<array.Length; j++)
                {
                    if (array[j].CompareTo(array[j+1]) > 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j+1);
                    }
                }
                if(!isAnyChange)
                {
                    break;
                }
            }
        }

        private void Swap<T>(T[] array, int first, int second) where T : IComparable
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        //optimized bubble sort
        //The bubble sort algorithm can be optimized by observing that the n-th pass finds the n-th largest element
        //and puts it into its final place. So, the inner loop can avoid looking at the last n − 1 items
        //when running for the n-th time: 
        public void BubbleSortOptimized(int[] Array)
        {
            int length = Array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < length; i++)
                {
                    if (Array[i - 1] > Array[i])
                    {
                        // Swap A[i - 1] and A[i]
                        int temp = Array[i - 1];
                        Array[i - 1] = Array[i];
                        Array[i] = temp;

                        swapped = true;
                    }
                }
                length = length - 1;
            } while (swapped);
        }

    }
}
