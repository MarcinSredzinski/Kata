using KataConsole.Sorting.Visualization;


int[] toSort = new int[] { 1, 6, 8, 9, 4, 3 };
BubbleSortVisualization bsw = new BubbleSortVisualization(toSort);

bsw.Sort(ref toSort);

//Let's see. Still testing. And now it works. 
bsw.Visualize(toSort, 0); //ToDo remove.
                          //And another comment.
                          //And another