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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            SortingForm f = new SortingForm();
            f.Show();
        }

        private void btnPathfinding_Click(object sender, EventArgs e)
        {
            PathfindingForm f = new PathfindingForm();
            f.Show();
        }
    }
}
