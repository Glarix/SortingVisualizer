using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class MergeSort : ISortStuff
    {
        private bool slowed = false;
        private int localBarWidth;
        private int localMaxVal;
        private Graphics localGr = null;

        readonly SolidBrush brushWhite = new SolidBrush(Color.White);
        readonly SolidBrush brushBlack = new SolidBrush(Color.Black);
        readonly SolidBrush brushRed = new SolidBrush(Color.Red);
        readonly SolidBrush brushGreen = new SolidBrush(Color.LightGreen);

        public MergeSort(bool slowed)
        {
            this.slowed = slowed;
        }

        public void SortArray(int[] Array, Graphics gr, int arrMaxVal, int barWidth)
        {
            int start = 0, end = Array.Length - 1;
            localBarWidth = barWidth;
            localMaxVal = arrMaxVal;
            localGr = gr;

            MyMergeSort(Array, start, end);

            CheckSorted(Array, gr, arrMaxVal, barWidth);
        }


        void MyMergeSort(int[] Array, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MyMergeSort(Array, start, mid);
                MyMergeSort(Array, mid + 1, end);
                MyMerge(Array, start, mid, end);
            }
        }

        void MyMerge(int[] Array, int start, int mid, int end)
        {
            int f = start, s = mid + 1;
            int i, j;


            int dim1 = mid - start + 1;
            int dim2 = end - mid;

            int[] L = new int[dim1];
            int[] R = new int[dim2];

            for (i = 0; i < dim1; i++)
                L[i] = Array[f + i];
            for (j = 0; j < dim2; j++)
                R[j] = Array[s + j];

            i = 0;
            j = 0;
            
            while(i < dim1 && j < dim2)
            {
                localGr.FillRectangle(brushRed, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);

                if (slowed)
                    Thread.Sleep(20);
                else
                    Thread.Sleep(1);
                
                localGr.FillRectangle(brushBlack, (f * localBarWidth), 0, localBarWidth, localMaxVal);
                if (L[i] < R[j])
                {                    
                    Array[f] = L[i];                   
                    i++;
                }
                else
                {
                    Array[f] = R[j];
                    j++;
                }
                localGr.FillRectangle(brushGreen, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);

                if (slowed)
                    Thread.Sleep(60);
                else
                    Thread.Sleep(1);

                localGr.FillRectangle(brushWhite, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);
                
                f++;
            }
            
            while(i < dim1)
            {
                localGr.FillRectangle(brushRed, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);

                if (slowed)
                    Thread.Sleep(20);
                

                localGr.FillRectangle(brushBlack, (f * localBarWidth), 0, localBarWidth, localMaxVal);
                Array[f] = L[i];

                localGr.FillRectangle(brushGreen, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);
                
                if (slowed)
                    Thread.Sleep(60);
                

                localGr.FillRectangle(brushWhite, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);
                i++;
                f++;
            }
            while (j < dim2)
            {
                localGr.FillRectangle(brushRed, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);

                if (slowed)
                    Thread.Sleep(20);
                

                localGr.FillRectangle(brushBlack, (f * localBarWidth), 0, localBarWidth, localMaxVal);
                Array[f] = R[j];

                localGr.FillRectangle(brushGreen, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);

                if (slowed)
                    Thread.Sleep(60);
                

                localGr.FillRectangle(brushWhite, (f * localBarWidth), localMaxVal - Array[f], localBarWidth, Array[f]);
                j++;
                f++;
            }

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
    }
}
