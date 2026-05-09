using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AlgorithmVisualizer
{
    public partial class PathfindingForm : Form
    {
        Node[,] grid;

        Node startNode = null;
        Node endNode = null;

        int rows = 20;
        int cols = 20;

        int cellSize = 30;

        string currentTool = "Wall";

        Queue<Node> bfsQueue = new Queue<Node>();

        System.Windows.Forms.Timer timer =
            new System.Windows.Forms.Timer();


        public PathfindingForm()
        {
            InitializeComponent();
            InitializeComponent();

            CreateGrid();

            timer.Interval = 50;

            timer.Tick += Timer_Tick;

        }
        private void CreateGrid()
        {
            grid = new Node[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c] = new Node(r, c);
                }
            }

            panelGrid.Invalidate();
        }


        private void panelGrid_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Node node = grid[r, c];

                    Brush brush = Brushes.White;

                    // WALL
                    if (node.IsWall)
                        brush = Brushes.Black;

                    // VISITED
                    if (node.Visited)
                        brush = Brushes.DeepSkyBlue;

                    // FINAL PATH
                    if (node.IsPath)
                        brush = Brushes.Yellow;

                    // START NODE
                    if (node == startNode)
                        brush = Brushes.Green;

                    // END NODE
                    if (node == endNode)
                        brush = Brushes.Red;

                    g.FillRectangle(
                        brush,
                        c * cellSize,
                        r * cellSize,
                        cellSize - 1,
                        cellSize - 1
                    );
                }
            }

        }

        private void panelGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int col = e.X / cellSize;
            int row = e.Y / cellSize;

            if (row >= rows || col >= cols)
                return;

            Node node = grid[row, col];

            // START NODE
            if (currentTool == "Start")
            {
                startNode = node;
            }

            // END NODE
            else if (currentTool == "End")
            {
                endNode = node;
            }

            // WALL
            else if (currentTool == "Wall")
            {
                node.IsWall = true;
            }

            panelGrid.Invalidate();

        }

        private void panelGrid_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PathfindingForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
