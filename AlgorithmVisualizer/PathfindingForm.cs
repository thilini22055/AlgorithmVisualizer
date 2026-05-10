using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

            CreateGrid();

            timer.Interval = 50;

            timer.Tick += Timer_Tick;


        }

        private void panelGrid_Paint(object sender, PaintEventArgs e)
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

        private void btnStartNode_Click(object sender, EventArgs e)
        {
            currentTool = "Start";
        }

        private void btnWellNode_Click(object sender, EventArgs e)
        {
            currentTool = "Wall";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // check start and end
            if (startNode == null || endNode == null)
            {
                MessageBox.Show("Place Start and End nodes.");
                return;
            }

            // clear old visited/path
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c].Visited = false;
                    grid[r, c].IsPath = false;
                    grid[r, c].Parent = null;
                }
            }

            bfsQueue.Clear();

            startNode.Visited = true;

            bfsQueue.Enqueue(startNode);

            timer.Start();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CreateGrid();

            startNode = null;
            endNode = null;

            panelGrid.Invalidate();

        }

        private void btnEndNode_Click(object sender, EventArgs e)
        {
            currentTool = "End";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            if (bfsQueue.Count == 0)
            {
                timer.Stop();
                return;
            }

            Node current = bfsQueue.Dequeue();

            // FOUND END
            if (current == endNode)
            {
                timer.Stop();

                Node path = endNode;

                while (path != null)
                {
                    if (path != startNode && path != endNode)
                    {
                        path.IsPath = true;
                    }

                    path = path.Parent;
                }

                panelGrid.Invalidate();

                return;
            }

            int[,] directions =
            {
        { -1, 0 },
        { 1, 0 },
        { 0, -1 },
        { 0, 1 }
    };

            for (int i = 0; i < 4; i++)
            {
                int newRow = current.Row + directions[i, 0];
                int newCol = current.Col + directions[i, 1];

                if (newRow >= 0 && newRow < rows &&
                    newCol >= 0 && newCol < cols)
                {
                    Node neighbor = grid[newRow, newCol];

                    if (!neighbor.Visited && !neighbor.IsWall)
                    {
                        neighbor.Visited = true;

                        neighbor.Parent = current;

                        bfsQueue.Enqueue(neighbor);
                    }
                }
            }

            panelGrid.Invalidate();
        }
        }
    }
