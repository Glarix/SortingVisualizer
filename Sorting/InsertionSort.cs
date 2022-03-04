using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class InsertionSort : ISortStuff
    {
        readonly SolidBrush brushWhite = new SolidBrush(Color.White);
        readonly SolidBrush brushBlack = new SolidBrush(Color.Black);
        readonly SolidBrush brushRed = new SolidBrush(Color.Red);
        readonly SolidBrush brushGreen = new SolidBrush(Color.LightGreen);
        private bool slowed = false;

        public InsertionSort(bool slowed)
        {
            this.slowed = slowed;
        }

        public void CheckSorted(int[] Array, Graphics gr, int arrMaxVal, int barWidth)
        {
            for (int i = 0; i < Array.Count(); i++)
            {
                if (slowed)
                    Thread.Sleep(1);
                gr.FillRectangle(brushGreen, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
            }
        }

        public void SortArray(int[] Array, Graphics gr, int arrMaxVal, int barWidth)
        {
            for (int i = 1; i < Array.Count(); i++)
            {
                int index = i;
                int k = i - 1;

                while (k >= 0)
                {
                    if (Array[index] < Array[k])
                    {
                        gr.FillRectangle(brushRed, (index * barWidth), arrMaxVal - Array[index], barWidth, Array[index]);
                        gr.FillRectangle(brushRed, (k * barWidth), arrMaxVal - Array[k], barWidth, Array[k]);

                        if (slowed)
                            Thread.Sleep(20);
                        
                        gr.FillRectangle(brushBlack, (index * barWidth), arrMaxVal - Array[index], barWidth, Array[index]);
                        gr.FillRectangle(brushBlack, (k * barWidth), arrMaxVal - Array[k], barWidth, Array[k]);

                        int temp = Array[k];
                        Array[k] = Array[index];
                        Array[index] = temp;

                        gr.FillRectangle(brushWhite, (index * barWidth), arrMaxVal - Array[index], barWidth, Array[index]);
                        gr.FillRectangle(brushWhite, (k * barWidth), arrMaxVal - Array[k], barWidth, Array[k]);

                        index = k;
                    }

                    

                    if (Array[index] > Array[k])
                    {
                        gr.FillRectangle(brushGreen, (index * barWidth), arrMaxVal - Array[index], barWidth, Array[index]);
                        gr.FillRectangle(brushGreen, (k * barWidth), arrMaxVal - Array[k], barWidth, Array[k]);

                        if (slowed)
                            Thread.Sleep(100);

                        gr.FillRectangle(brushWhite, (index * barWidth), arrMaxVal - Array[index], barWidth, Array[index]);
                        gr.FillRectangle(brushWhite, (k * barWidth), arrMaxVal - Array[k], barWidth, Array[k]);
                        break;
                    }
                        
                        
                    k--;
                }
            }

            CheckSorted(Array, gr, arrMaxVal, barWidth);
        }
    }
}
