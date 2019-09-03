using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sortServer.Services
{
    public class Quick_Sort
    {
        public List<List<int>> steps;

        public Quick_Sort()
        {
            this.steps = new List<List<int>>();
        }
        public void QuickSort(int[] arr, int left, int right)
        {
            this.steps.Add(new List<int>(arr));

            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}