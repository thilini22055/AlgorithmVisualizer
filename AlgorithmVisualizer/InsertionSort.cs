using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer
{
    internal class InsertionSort
    {
        public int[] array;

        int i = 1;
        int j;
        int key;

        public bool done = false;

        public int comparisons = 0;
        public int currentIndex = -1;
        public int compareIndex = -1;

        // ✅ NEW FLAG
        bool isNewPass = true;
        public int sortedIndex = 0;

        public InsertionSort(int[] arr)
        {
            array = arr;
        }

        public void Step()
        {
            if (done) return;

            if (i >= array.Length)
            {
                done = true;

                sortedIndex = array.Length;

                // ✅ clear colors
                currentIndex = -1;
                compareIndex = -1;

                return;
            }

            if (isNewPass)
            {
                key = array[i];
                j = i - 1;
                isNewPass = false;
            }

            if (j >= 0)
            {
                currentIndex = i;
                compareIndex = j;
                comparisons++;

                if (array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                    return;
                }
            }

            array[j + 1] = key;

            sortedIndex = i; // ✅ mark sorted part

            i++;
            isNewPass = true;
        }

    }
}
