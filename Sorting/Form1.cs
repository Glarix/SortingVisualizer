using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting
{
    public partial class Form1 : Form
    {
        private SolidBrush brushWhite = new SolidBrush(Color.White);
        private SolidBrush brushBlack = new SolidBrush(Color.Black);
        public Graphics gr = null;
        public int[] Array;
        private Random _random = new Random();
        public int maxValue = 0;

        public int barWidth;

        private List<string> algorithms = new List<string>();
        private List<string> arraySize = new List<string>();

        public Form1()
        {
            InitializeComponent();

            AlgorithmComboBoxFill();
            ArraySizeComboBoxFill();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            gr = ArrayPanel.CreateGraphics();

            string arrayLen = ArraySizeComboBox.SelectedItem.ToString();

            int numOfBars = Int32.Parse(arrayLen);

            if (numOfBars < 71)
                SlowModeCheckBox.Enabled = true;
            else
            {
                SlowModeCheckBox.Enabled = false;
                SlowModeCheckBox.Checked = false;
            }
                
            
            barWidth = 980 / numOfBars;

            int elements = ArrayPanel.Width / barWidth;
            maxValue = ArrayPanel.Height;
            Array = new int[elements];

            gr.FillRectangle(brushBlack, 0, 0, ArrayPanel.Width, ArrayPanel.Height);

            
            for (int i = 0; i < elements; i++)
            {
                Array[i] = _random.Next(0, maxValue);
            }
            

            for (int i = 0; i < elements; i++)
            {
                gr.FillRectangle(brushWhite, i * barWidth, maxValue - Array[i], barWidth, maxValue);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            bool slowed = SlowModeCheckBox.Checked;
            int algorithmIndex = AlgorithmsComboBox.SelectedIndex;
            
            if (algorithmIndex == 0)
            {
                BubbleSort sort = new BubbleSort(slowed);
                if (maxValue > 0)
                {
                    sort.SortArray(Array, gr, maxValue, barWidth);
                }
            }else if (algorithmIndex == 1)
            {
                SelectionSort sort = new SelectionSort(slowed);
                if (maxValue > 0)
                {
                    sort.SortArray(Array, gr, maxValue, barWidth);
                }
            }else if (algorithmIndex == 2)
            {
                InsertionSort sort = new InsertionSort(slowed);
                if (maxValue > 0)
                {
                    sort.SortArray(Array, gr, maxValue, barWidth);
                }
            }else if (algorithmIndex == 3)
            {
                MergeSort sort = new MergeSort(slowed);
                if (maxValue > 0)
                {
                    sort.SortArray(Array, gr, maxValue, barWidth);
                }
            }

        }


        private void AlgorithmComboBoxFill()
        {
            algorithms.Add("BubbleSort");
            algorithms.Add("SelectionSort");
            algorithms.Add("InsertionSort");
            algorithms.Add("MergeSort");
            AlgorithmsComboBox.DataSource = algorithms;
        }

        private void ArraySizeComboBoxFill()
        {
            arraySize.Add("49");
            arraySize.Add("70");
            arraySize.Add("98");
            arraySize.Add("245");
            arraySize.Add("490");
            ArraySizeComboBox.DataSource = arraySize;
        }
    }
}
