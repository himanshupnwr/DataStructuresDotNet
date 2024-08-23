namespace DataStructuresDotNet
{
    internal class QuickSort
    {
        //Quicksort is a divide-and-conquer algorithm. It works by selecting a 'pivot' element from the array and
        //partitioning the other elements into two sub-arrays, according to whether they are less than or greater than the pivot.
        //For this reason, it is sometimes called partition-exchange sort.[4] The sub-arrays are then sorted recursively.
        //This can be done in-place, requiring small additional amounts of memory to perform the sorting. 

        //Worst-case performance O(n 2 ) {\displaystyle O(n^{ 2})}
        //Best-case performance O(n log ⁡ n ) {\displaystyle O(n\log n)} (simple partition) or O(n ) {\displaystyle O(n)}
        //(three-way partition and equal keys)
        //Average performance O(n log ⁡ n ) {\displaystyle O(n\log n)}
        //Worst-case space complexity O(n ) {\displaystyle O(n)} auxiliary(naive) O(log ⁡ n ) {\displaystyle O(\log n)} auxiliary(Hoare 1962)
        // Optimal No

        public void Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort<T>(T[] array, int lower, int upper) where T : IComparable
        {
            if(lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
        }

        private int Partition<T>(T[] array, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[i];

            do
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }
                if (i >= j)
                {
                    break;
                }
                Swap(array, i, j);
            }
            while (i <= j);
            return j;
        }

        private void Swap<T>(T[] array, int first, int second) where T : IComparable
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
