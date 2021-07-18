using KataConsole.Sorting;
using KataConsole.Sorting.Visualization;


int[] toSort = new int[] { 1, 6, 8, 9, 4, 3 };
//ConsoleVisualizationObserver bsw = new ConsoleVisualizationObserver(toSort);
var bubbleSort = new BubbleSort();
bubbleSort.Attach(new ConsoleVisualizationObserver());
bubbleSort.Sort(ref toSort);
