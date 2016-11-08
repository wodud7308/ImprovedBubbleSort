using Sort;
using System;
namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            data[0] = 5;
            data[1] = 4;
            data[2] = 6;
            data[3] = 1;
            data[4] = 2;
            int[] dataClone = (int[])data.Clone();
            var bubble = new Bubble();

            bubble.ImprovedBubble(data);
            Console.WriteLine("RepeatCount : {0}", bubble.SortCount);
            bubble.BubbleSort(dataClone);
            Console.WriteLine("RepeatCount : {0}", bubble.SortCount);

            //*** result
            //RepeatCount : 16
            //RepeatCount : 20
        }
    }
}
