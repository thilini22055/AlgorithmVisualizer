namespace AlgorithmVisualizer
{
    partial class PathfindingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGrid = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStartNode = new System.Windows.Forms.Button();
            this.btnWellNode = new System.Windows.Forms.Button();
            this.btnEndNode = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Black;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.ForeColor = System.Drawing.Color.White;
            this.panelGrid.Location = new System.Drawing.Point(12, 12);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(602, 216);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            this.panelGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseClick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(2, 251);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "▶ Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(109, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "🗑 Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStartNode
            // 
            this.btnStartNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartNode.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNode.ForeColor = System.Drawing.Color.Green;
            this.btnStartNode.Location = new System.Drawing.Point(213, 251);
            this.btnStartNode.Name = "btnStartNode";
            this.btnStartNode.Size = new System.Drawing.Size(131, 32);
            this.btnStartNode.TabIndex = 3;
            this.btnStartNode.Text = "🟢 Start Node";
            this.btnStartNode.UseVisualStyleBackColor = false;
            this.btnStartNode.Click += new System.EventHandler(this.btnStartNode_Click);
            // 
            // btnWellNode
            // 
            this.btnWellNode.BackColor = System.Drawing.Color.Cyan;
            this.btnWellNode.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWellNode.ForeColor = System.Drawing.Color.Navy;
            this.btnWellNode.Location = new System.Drawing.Point(350, 251);
            this.btnWellNode.Name = "btnWellNode";
            this.btnWellNode.Size = new System.Drawing.Size(129, 32);
            this.btnWellNode.TabIndex = 4;
            this.btnWellNode.Text = "🧱 Well Node";
            this.btnWellNode.UseVisualStyleBackColor = false;
            this.btnWellNode.Click += new System.EventHandler(this.btnWellNode_Click);
            // 
            // btnEndNode
            // 
            this.btnEndNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEndNode.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEndNode.Location = new System.Drawing.Point(485, 251);
            this.btnEndNode.Name = "btnEndNode";
            this.btnEndNode.Size = new System.Drawing.Size(129, 32);
            this.btnEndNode.TabIndex = 5;
            this.btnEndNode.Text = "\"🟢  End Node";
            this.btnEndNode.UseVisualStyleBackColor = false;
            this.btnEndNode.Click += new System.EventHandler(this.btnEndNode_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Silver;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(485, 289);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 36);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "⚙️ Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Left Click to draw walls.Click Start Node and End Node to set positions.";
            // 
            // PathfindingForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(626, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnEndNode);
            this.Controls.Add(this.btnWellNode);
            this.Controls.Add(this.btnStartNode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelGrid);
            this.Name = "PathfindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStartNode;
        private System.Windows.Forms.Button btnWellNode;
        private System.Windows.Forms.Button btnEndNode;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label1;
    }
}