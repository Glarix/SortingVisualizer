using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class SelectionSort : ISortStuff
    {

        SolidBrush brushWhite = new SolidBrush(Color.White);
        SolidBrush brushBlack = new SolidBrush(Color.Black);
        SolidBrush brushRed = new SolidBrush(Color.Red);
        SolidBrush brushGreen = new SolidBrush(Color.LightGreen);
        bool slowed = false;

        public SelectionSort(bool slowed)
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
            int temp, smallest;
            for (int i = 0; i < Array.Count(); i++)
            {                   
                    smallest = i;
                    for (int j = i + 1; j < Array.Count(); j++)
                    {
                        if (Array[j] < Array[smallest])
                        {
                            smallest = j;
                        }
                    }

                gr.FillRectangle(brushRed, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
                gr.FillRectangle(brushRed, (smallest * barWidth), arrMaxVal - Array[i], barWidth, Array[smallest]);

                if (slowed)
                    Thread.Sleep(40);
                else
                    Thread.Sleep(1);

                gr.FillRectangle(brushBlack, (i * barWidth), 0, barWidth, arrMaxVal);
                gr.FillRectangle(brushBlack, (smallest * barWidth), 0, barWidth, arrMaxVal);

                temp = Array[smallest];
                Array[smallest] = Array[i];
                Array[i] = temp;


                gr.FillRectangle(brushGreen, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
                gr.FillRectangle(brushGreen, (smallest * barWidth), arrMaxVal - Array[smallest], barWidth, Array[smallest]);

                if (slowed)
                    Thread.Sleep(80);
                else
                    Thread.Sleep(1);

                gr.FillRectangle(brushWhite, (i * barWidth), arrMaxVal - Array[i], barWidth, Array[i]);
                gr.FillRectangle(brushWhite, (smallest * barWidth), arrMaxVal - Array[smallest], barWidth, Array[smallest]);
            }

            CheckSorted(Array, gr, arrMaxVal, barWidth);
        }
    }
}
