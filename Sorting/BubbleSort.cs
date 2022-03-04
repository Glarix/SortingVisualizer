using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSort : ISortStuff
    {

        SolidBrush brushWhite = new SolidBrush(Color.White);
        SolidBrush brushBlack = new SolidBrush(Color.Black);
        SolidBrush brushRed = new SolidBrush(Color.Red);
        SolidBrush brushGreen = new SolidBrush(Color.LightGreen);
        bool sorted = false;
        bool slowed = false;

        public BubbleSort(bool slowed)
        {
            this.slowed = slowed;
        }

        public void CheckSorted(int[] Array, Graphics gr, int arrMaxVal, int barWidth)
        {
            for (int i = 0; i < Array.Count(); i++)
            {
                gr.FillRectangle(brushGreen, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
                if (slowed)
                    Thread.Sleep(1);
            }
        }

        public void SortArray(int[] Array, Graphics gr, int arrMaxVal, int barWidth)
        {
            


            while (!sorted)
            {
                for (int i = 0; i < Array.Count() - 1; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        gr.FillRectangle(brushRed, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
                        gr.FillRectangle(brushRed, ((i + 1) * barWidth), arrMaxVal - Array[i], barWidth, Array[i + 1]);

                        if (slowed)
                            Thread.Sleep(15);
                        
                        gr.FillRectangle(brushBlack, (i * barWidth), 0, barWidth, arrMaxVal);
                        gr.FillRectangle(brushBlack, ((i + 1) * barWidth), 0, barWidth, arrMaxVal);

                        int temp = Array[i + 1];
                        Array[i + 1] = Array[i];
                        Array[i] = temp;

                        gr.FillRectangle(brushGreen, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
                        gr.FillRectangle(brushGreen, ((i + 1) * barWidth), arrMaxVal - Array[i + 1], barWidth, Array[i + 1]);

                        if (slowed)
                            Thread.Sleep(40);
                        
                        gr.FillRectangle(brushWhite, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
                        gr.FillRectangle(brushWhite, ((i + 1) * barWidth), arrMaxVal - Array[i + 1], barWidth, Array[i + 1]);
                    }
                }

                sorted = IsSorted(Array);
            }

            CheckSorted(Array, gr, arrMaxVal, barWidth);
        }


        private bool IsSorted(int[] Array)
        {
            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] > Array[i + 1])
                    return false;
            }
            return true;
        }
    }
}
