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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCler = new System.Windows.Forms.Button();
            this.btnWellNode = new System.Windows.Forms.Button();
            this.btnEndNode = new System.Windows.Forms.Button();
            this.btnStartNode = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(453, 330);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "▶ Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnCler
            // 
            this.btnCler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCler.Location = new System.Drawing.Point(569, 330);
            this.btnCler.Name = "btnCler";
            this.btnCler.Size = new System.Drawing.Size(75, 35);
            this.btnCler.TabIndex = 1;
            this.btnCler.Text = "❌ Clear";
            this.btnCler.UseVisualStyleBackColor = false;
            // 
            // btnWellNode
            // 
            this.btnWellNode.BackColor = System.Drawing.Color.Silver;
            this.btnWellNode.Location = new System.Drawing.Point(303, 330);
            this.btnWellNode.Name = "btnWellNode";
            this.btnWellNode.Size = new System.Drawing.Size(109, 35);
            this.btnWellNode.TabIndex = 2;
            this.btnWellNode.Text = "🟢 Well Node";
            this.btnWellNode.UseVisualStyleBackColor = false;
            // 
            // btnEndNode
            // 
            this.btnEndNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEndNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEndNode.Location = new System.Drawing.Point(155, 330);
            this.btnEndNode.Name = "btnEndNode";
            this.btnEndNode.Size = new System.Drawing.Size(119, 35);
            this.btnEndNode.TabIndex = 3;
            this.btnEndNode.Text = "🟢 End Node";
            this.btnEndNode.UseVisualStyleBackColor = false;
            // 
            // btnStartNode
            // 
            this.btnStartNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartNode.ForeColor = System.Drawing.Color.Green;
            this.btnStartNode.Location = new System.Drawing.Point(12, 330);
            this.btnStartNode.Name = "btnStartNode";
            this.btnStartNode.Size = new System.Drawing.Size(114, 35);
            this.btnStartNode.TabIndex = 4;
            this.btnStartNode.Text = "🟢 Start Node";
            this.btnStartNode.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Silver;
            this.btnSettings.Location = new System.Drawing.Point(686, 330);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(102, 35);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "⚙ Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(798, 297);
            this.panelGrid.TabIndex = 6;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint_1);
            this.panelGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "* Left Click to draw walls.Start Node and End Node  to set position.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PathfindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnStartNode);
            this.Controls.Add(this.btnEndNode);
            this.Controls.Add(this.btnWellNode);
            this.Controls.Add(this.btnCler);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PathfindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathfinding";
            this.Load += new System.EventHandler(this.PathfindingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCler;
        private System.Windows.Forms.Button btnWellNode;
        private System.Windows.Forms.Button btnEndNode;
        private System.Windows.Forms.Button btnStartNode;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.FlowLayoutPanel panelGrid;
        private System.Windows.Forms.Label label1;
    }
}