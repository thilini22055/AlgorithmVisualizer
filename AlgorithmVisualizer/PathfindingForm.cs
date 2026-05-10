using AlgorithmVisualizer.Properties;
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

        int rows ;
        int cols ;

        string currentTool = "Wall";

        int pathSpeed = 50;

        Queue<Node> bfsQueue = new Queue<Node>();

        Timer timer = new Timer();

        

        public PathfindingForm()
        {
            InitializeComponent();

            rows = 20;
            cols = 20;

            CreateGrid();

            timer.Interval = pathSpeed;
            timer.Tick += timer1_Tick;

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


        private void btnClear_Click(object sender, EventArgs e)
        {
            CreateGrid();

            startNode = null;
            endNode = null;

            panelGrid.Invalidate();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (startNode == null || endNode == null)
            {
                MessageBox.Show("Place Start and End nodes.");
                return;
            }

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

        private void btnStartNode_Click(object sender, EventArgs e)
        {
            currentTool = "Start";
        }

        private void btnWellNode_Click(object sender, EventArgs e)
        {
            currentTool = "Wall";
        }

        private void btnEndNode_Click(object sender, EventArgs e)
        {
            currentTool = "End";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Setting form = new Setting(
                SettingContext.Pathfinding,
                sortingSize: 0,
                sortingSpeed: 0,
                pathSize: rows,
                pathSpeed: pathSpeed);

            if (form.ShowDialog() == DialogResult.OK)
            {
                ApplySettings(form.PathSize, form.PathSpeed);
            }
        }

  
        private void panelGrid_Paint(object sender, PaintEventArgs e)
        {
            if (rows <= 0 || cols <= 0 || grid == null)
                return;

            int w = Math.Max(1, panelGrid.ClientSize.Width);
            int h = Math.Max(1, panelGrid.ClientSize.Height);
            float cellW = (float)w / cols;
            float cellH = (float)h / rows;
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

                    float x = c * cellW;
                    float y = r * cellH;
                    g.FillRectangle(
                        brush,
                        x,
                        y,
                        Math.Max(1f, cellW - 1f),
                        Math.Max(1f, cellH - 1f));
                }
            }

        }

        private void panelGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (rows <= 0 || cols <= 0)
                return;

            float cellW = (float)panelGrid.ClientSize.Width / cols;
            float cellH = (float)panelGrid.ClientSize.Height / rows;
            int col = (int)(e.X / cellW);
            int row = (int)(e.Y / cellH);

            if (row >= rows || col >= cols || row < 0 || col < 0)
                return;

            Node node = grid[row, col];

            if (currentTool == "Start")
            {
                startNode = node;
            }
            else if (currentTool == "End")
            {
                endNode = node;
            }
            else if (currentTool == "Wall")
            {
                node.IsWall = true;
            }

            panelGrid.Invalidate();

        }

        private void timer1_Tick(object sender, EventArgs e)
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
        public void ApplySettings(int size, int speed)
        {
            pathSpeed = speed;
            timer.Stop();
            timer.Interval = Math.Max(10, pathSpeed);

            rows = Math.Max(1, size);
            cols = rows;

            startNode = null;
            endNode = null;
            bfsQueue.Clear();

            CreateGrid();
            panelGrid.Invalidate();
        }

        private void PathfindingForm_Load(object sender, EventArgs e)
        {
            panelGrid.Invalidate();
        }
    }
}
