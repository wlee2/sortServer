using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sortServer.Services
{
    public class Sort<T>
    {
        public void BubbleSort<T>(T[] items, List<T[]> steps) where T: IComparable
        {
            for (int p = 0; p <= items.Length - 2; p++)
            {
                for (int i = 0; i <= items.Length - 2; i++)
                {
                    if (items[i].CompareTo(items[i + 1]) > 0)
                    {
                        List<T> stepsTemp = items.ToList();
                        steps.Add(stepsTemp.ToArray());

                        var temp = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = temp;

                    }
                }
            }
        }

        public void QuickSort<T>(T[] items, List<T[]> steps, int left, int right) where T : IComparable
        {

            int i, j;
            i = left; j = right;
            IComparable pivot = items[left];

            while (i <= j)
            {
                for (; (items[i].CompareTo(pivot) < 0) && (i.CompareTo(right) < 0); i++) ;
                for (; (pivot.CompareTo(items[j]) < 0) && (j.CompareTo(left) > 0); j--) ;

                if (i <= j)
                {
                    List<T> temp = items.ToList();
                    steps.Add(temp.ToArray());

                    swap(ref items[i++], ref items[j--]);
                    
                }
                    

            }
            if (left < j) QuickSort<T>(items, steps, left, j);
            if (i < right) QuickSort<T>(items, steps, i, right);
        }

        private void swap<T>(ref T x, ref T y)
        {
            //swapcount++;
            T temp = x;
            x = y;
            y = temp;
        }
    }
}