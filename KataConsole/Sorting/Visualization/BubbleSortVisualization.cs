using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KataConsole.Sorting.Visualization
{
    public class BubbleSortVisualization
    {
        private readonly string ClearingLine;

        public BubbleSortVisualization(int[] collection)
        {
            ClearingLine = CreateClearingLine(collection);
        }

        private string CreateClearingLine(int[] collection)
        {
            StringBuilder sb = new StringBuilder();
            int highestNumber = collection.Max();
            for (int j = 0; j < highestNumber; j++)
            {
                sb.Append("  ");
            }

            return sb.ToString();
        }
        public void Visualize(int[] toVisualize, int? lowerNumber)
        {
            foreach (var i in toVisualize)
            {
                int position = Array.IndexOf(toVisualize, i);
                Console.SetCursorPosition(0, position);
                StringBuilder toDisplay = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    if (j == 0)
                    {
                        toDisplay.Append(i);
                        toDisplay.Append(" ");
                    }
                    toDisplay.Append('-');
                }
                Console.WriteLine(ClearingLine);
                Console.SetCursorPosition(0, position);
                switch (lowerNumber)
                {
                    case null: 
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case { } intVal when intVal == lowerNumber:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case not null:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.ForegroundColor = lowerNumber == null ? ConsoleColor.DarkGreen : ConsoleColor.White;
                if (i == lowerNumber) Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine(toDisplay.ToString());
            }
            Thread.Sleep(1000);
        }

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
                        Visualize(toSort, lowerValue);
                    }
                }
            } while (isMoved);
            Visualize(toSort, null);
        }
    }
}
