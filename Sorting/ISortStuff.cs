using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ISortStuff
    {
        void SortArray(int[] Array, Graphics gr, int arrMaxVal, int barWidth);

        void CheckSorted(int[] Array, Graphics gr, int arrMaxVal, int barWidth);
    }
}
