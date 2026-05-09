using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class SortingForm : Form
    {
        Timer timer = new Timer();
        InsertionSort sorter;
        QuickSort quickSorter;
        int[] array;
        Random rand = new Random();


        public SortingForm()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;

            timer.Interval = 50;
            timer.Tick += Timer_Tick;

            array = null;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Generate Array First");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select Algorithm");
                return;
            }

            string selected =
                comboBox1.SelectedItem.ToString();

            if (selected == "Insertion Sort")
            {
                sorter = new InsertionSort(array);
                quickSorter = null;
            }

            else if (selected == "Quick Sort")
            {
                quickSorter = new QuickSort(array);
                sorter = null;
            }

            timer.Start();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();

            sorter = null;
            quickSorter = null;

            GenerateArray();

            lblComparisons.Text = "Comparisons: 0";

            panelDraw.Invalidate();

        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            timer.Stop();

            sorter = null;
            quickSorter = null;

            lblComparisons.Text = "Comparisons: 0";

            array = new int[50];

            GenerateArray();

            panelDraw.Invalidate();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void SortingForm_Load(object sender, EventArgs e)
        {
            
        }
        private void GenerateArray()
        {
            array = new int[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, panelDraw.Height);
            }

            panelDraw.Invalidate();
        }

       

        private void panelDraw_Click(object sender, EventArgs e)
        {

        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            if (array == null || array.Length == 0)
                return;

            Graphics g = e.Graphics;
            if (array == null) return;

            int width = panelDraw.Width / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                // 🔵 default color
                Brush brush = Brushes.Blue;

                // =========================
                // INSERTION SORT COLORS
                // =========================
                if (sorter != null)
                {
                    // 🟢 sorted bars
                    if (i <= sorter.sortedIndex)
                    {
                        brush = Brushes.Green;
                    }

                    // 🔴 current
                    if (i == sorter.currentIndex)
                    {
                        brush = Brushes.Red;
                    }

                    // 🟡 compare
                    if (i == sorter.compareIndex)
                    {
                        brush = Brushes.Yellow;
                    }
                }

                // =========================
                // QUICK SORT COLORS
                // =========================
                if (quickSorter != null)
                {
                    if (quickSorter.sorted[i])
                    {
                        brush = Brushes.Green;
                    }

                    // RED current
                    if (i == quickSorter.currentIndex)
                    {
                        brush = Brushes.Red;
                    }

                    // YELLOW compare
                    if (i == quickSorter.compareIndex)
                    {
                        brush = Brushes.Yellow;
                    }

                }

                int height = array[i];

                e.Graphics.FillRectangle(
                    brush,
                    i * width,
                    panelDraw.Height - height,
                    width - 2,
                    height
                );


            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (sorter != null)
            {
                sorter.Step();

                lblComparisons.Text =
                    "Comparisons: " + sorter.comparisons;

                if (sorter.done)
                    timer.Stop();
            }

            if (quickSorter != null)
            {
                quickSorter.Step();

                lblComparisons.Text =
                    "Comparisons: " + quickSorter.comparisons;

                if (quickSorter.done)
                {
                    panelDraw.Invalidate();

                    timer.Stop();
                }

            }

            panelDraw.Invalidate();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
