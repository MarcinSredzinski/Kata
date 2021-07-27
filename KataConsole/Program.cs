using System;
using KataConsole.Sorting;
using KataConsole.Sorting.Measurements;
using KataConsole.Sorting.Visualization;


int[] toSort = { 1, 6, 8, 9, 4, 3 };
var bubbleSort = new BubbleSort();
var timeOfExecutionStore = new TimeOfExecutionDataStore();
bubbleSort
    //.Attach(new ConsoleVisualizationObserver())
    .Attach(new TimeOfExecutionMeasurement(timeOfExecutionStore));
bubbleSort.Sort(ref toSort);

Console.WriteLine($"Sorting took: {timeOfExecutionStore.ElapsedTime} ticks.");
