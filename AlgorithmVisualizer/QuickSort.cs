using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmVisualizer
{
    internal class QuickSort
    {
        public bool[] sorted;
        public int[] array;

        public bool done = false;

        public int comparisons = 0;

        public int currentIndex = -1;
        public int compareIndex = -1;

        private Stack<Tuple<int, int>> stack =
            new Stack<Tuple<int, int>>();

        private int low;
        private int high;

        private int i;
        private int j;
        private int pivot;

        private bool partitionRunning = false;

        public QuickSort(int[] arr)
        {
            array = arr;

            sorted = new bool[arr.Length];

            stack.Push(new Tuple<int, int>(0, array.Length - 1));
        }

        public void Step()
        {
            if (done)
                return;

            // START NEW PARTITION
            if (!partitionRunning)
            {
                if (stack.Count == 0)
                {
                    for (int k = 0; k < sorted.Length; k++)
                    {
                        sorted[k] = true;
                    }

                    done = true;

                    return;
                }

                Tuple<int, int> range = stack.Pop();

                low = range.Item1;
                high = range.Item2;

                i = low - 1;
                j = low;

                pivot = array[high];

                partitionRunning = true;
            }

            // PARTITION STEP
            if (j < high)
            {
                currentIndex = j;

                compareIndex = high;

                comparisons++;

                if (array[j] < pivot)
                {
                    i++;

                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

                j++;

                return;
            }

            // FINAL PIVOT SWAP
            int temp2 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp2;

            int pivotIndex = i + 1;
            sorted[pivotIndex] = true;

            // LEFT SIDE
            if (pivotIndex - 1 > low)
            {
                stack.Push(
                    new Tuple<int, int>(low, pivotIndex - 1)
                );
            }

            // RIGHT SIDE
            if (pivotIndex + 1 < high)
            {
                stack.Push(
                    new Tuple<int, int>(pivotIndex + 1, high)
                );
            }

            partitionRunning = false;

            currentIndex = -1;
            compareIndex = -1;
        }
    }
}
