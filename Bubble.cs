using System;
namespace Sort
{
    class Bubble
    {
        private bool IsSorted;
        private int RepeatCount;
        public int SortCount
        {
            get { return RepeatCount; }
        }
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void ImprovedBubble(int[] dataArray)
        {
            IsSorted = false;
            RepeatCount = 0;
            while (!IsSorted)
            {
                IsSorted = true;
                for (int seq = 0; seq < dataArray.Length - 1; seq++)
                {
                    if (dataArray[seq] > dataArray[seq + 1])
                    {
                        Swap(ref dataArray[seq], ref dataArray[seq + 1]);
                        IsSorted = false;
                    }
                    RepeatCount++;
                }
            }
        }

        public void BubbleSort(int[] dataArray)
        {
            RepeatCount = 0;
            for(int cycle = 0; cycle<dataArray.Length; cycle++)
            { 
                for (int seq = 0; seq < dataArray.Length - 1; seq++)
                {
                    if (dataArray[seq] > dataArray[seq + 1])
                    {
                        Swap(ref dataArray[seq], ref dataArray[seq + 1]);
                    }
                    RepeatCount++;
                }
            }
        }
    }
}
