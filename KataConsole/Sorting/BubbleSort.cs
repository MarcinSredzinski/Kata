using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataConsole.Sorting
{
    public class BubbleSort
    {
        public void Sort(ref int[] toSort)
        {
            var isMoved = false;
            do
            {
                isMoved = false;
                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (toSort[i] > toSort[i + 1])
                    {
                        var lowerValue = toSort[i + 1];
                        toSort[i + 1] = toSort[i];
                        toSort[i] = lowerValue;
                        isMoved = true;
                    }
                }
            } while (isMoved);
        }
    }
}
