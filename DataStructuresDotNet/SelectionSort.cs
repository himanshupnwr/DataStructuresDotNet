using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDotNet
{
    internal class SelectionSort
    {
        //The algorithm divides the input list into two parts: a sorted sublist of items which is built up from
        //left to right at the front (left) of the list and a sublist of the remaining unsorted items that occupy
        //the rest of the list. Initially, the sorted sublist is empty and the unsorted sublist is the entire input list.
        //The algorithm proceeds by finding the smallest (or largest, depending on sorting order) element in the
        //unsorted sublist, exchanging (swapping) it with the leftmost unsorted element (putting it in sorted order),
        //and moving the sublist boundaries one element to the right. 

        //quadratic algorithms as per time complexity
        //good for only small data sets and places where is there memory constraints

        //Worst-case performance	O ( n 2 ) {\displaystyle O(n^{2})} comparisons, O ( n ) {\displaystyle O(n)} swaps
        //Best-case performance     O(n 2 ) {\displaystyle O(n^{ 2})} comparisons, O( 1 ) {\displaystyle O(1)} swap 
        //Average performance     O(n 2 ) {\displaystyle O(n^{ 2})} comparisons,  O(n ) {\displaystyle O(n)} swaps
        //Worst-case space complexity O( 1 ) {\displaystyle O(1)} auxiliary

        //Non generic implementation
        public int[]? NumArray { get; set; }
        public int[] SortArray()
        {
            var arrLength = NumArray.Length;

            for(var i = 0; i < arrLength; i++)
            {
                var smallestNum = NumArray[i];
                for(var j = i+1; j < arrLength; j++)
                {
                    if(NumArray[j] < NumArray[smallestNum])
                    {
                        smallestNum = j;
                    }
                }

                var temp = NumArray[smallestNum];
                NumArray[smallestNum] = NumArray[i]; 
                NumArray[i] = temp;
            }

            return NumArray;
        }

        //index swap implementation
        public static int[] SelectionSortIndexSwap(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var index = i;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[index])
                    {
                        index = j;
                    }
                }

                (array[i], array[index]) = (array[index], array[i]);
            }

            return array;
        }

        //Generic implementation
        public void SelectionSorting<T>(T[] array) where T:IComparable
        {
            for(int i = 0; i < array.Length;i++)
            {
                var index = i;
                T minValue = array[i];
                for(int j = i+1;j< array.Length;j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        index = j;
                        minValue = array[j];
                    }
                }
                Swap(array, i, index);
            }
        }

        private void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
