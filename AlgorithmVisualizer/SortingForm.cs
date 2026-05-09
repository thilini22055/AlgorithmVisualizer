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

        int[] array;
        Random rand = new Random();
        private object cmbAlgorithms;

        public SortingForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("Insertion Sort");
            comboBox1.SelectedIndex = 0;

            timer.Interval = 50;
            timer.Tick += Timer_Tick;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (array == null)
            {
                MessageBox.Show("Generate Array First");
                return;
            }

            sorter = new InsertionSort(array);

            timer.Start();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();

            sorter = null;

            GenerateArray();

            lblComparisons.Text = "Comparisons: 0";

            panelDraw.Invalidate();
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            timer.Stop();

            sorter = null;

            lblComparisons.Text = "Comparisons: 0";

            GenerateArray();

            panelDraw.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void SortingForm_Load(object sender, EventArgs e)
        {
            GenerateArray();
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

            int width = panelDraw.Width / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                Brush brush = Brushes.Blue;

                // =========================
                // INSERTION SORT COLORS
                // =========================
                if (sorter != null)
                {
                    // sorted part
                    if (i <= sorter.sortedIndex)
                        brush = Brushes.Green;

                    // current element
                    if (i == sorter.currentIndex)
                        brush = Brushes.Red;

                    // comparing element
                    if (i == sorter.compareIndex)
                        brush = Brushes.Yellow;
                }

                int height = array[i];

                g.FillRectangle(
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

            panelDraw.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
