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
    public partial class Setting : Form
    {
        public int SortingSize;
        private int sortingSpeed;
        public int SortingSpeed;

        public Setting(
            int currentSortingSize,
            int currentSortingSpeed,
            int currentPathSize,
            int currentPathSpeed
            )
        {
            InitializeComponent();
            numSortingSize.Minimum = 5;
            numSortingSize.Maximum = 100;
            numSortingSize.Value = currentSortingSize;

            trackSortingSpeed.Minimum = 1;
            trackSortingSpeed.Maximum = 500;
            trackSortingSpeed.Value = 250;


        }


        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortingSize = (int)numSortingSize.Value;
            SortingSpeed = Math.Max(1, trackSortingSpeed.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void numPathSize_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
