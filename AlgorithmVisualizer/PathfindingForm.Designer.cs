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
            this.components = new System.ComponentModel.Container();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnWellNode = new System.Windows.Forms.Button();
            this.btnEndNode = new System.Windows.Forms.Button();
            this.btnStartNode = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(46, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = " ▶  Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(260, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "🗑  Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWellNode
            // 
            this.btnWellNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnWellNode.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWellNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnWellNode.Location = new System.Drawing.Point(248, 68);
            this.btnWellNode.Name = "btnWellNode";
            this.btnWellNode.Size = new System.Drawing.Size(132, 47);
            this.btnWellNode.TabIndex = 3;
            this.btnWellNode.Text = "🟢 Well Node";
            this.btnWellNode.UseVisualStyleBackColor = false;
            this.btnWellNode.Click += new System.EventHandler(this.btnWellNode_Click);
            // 
            // btnEndNode
            // 
            this.btnEndNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEndNode.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndNode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEndNode.Location = new System.Drawing.Point(430, 68);
            this.btnEndNode.Name = "btnEndNode";
            this.btnEndNode.Size = new System.Drawing.Size(137, 47);
            this.btnEndNode.TabIndex = 4;
            this.btnEndNode.Text = "🟢 End Node";
            this.btnEndNode.UseVisualStyleBackColor = false;
            this.btnEndNode.Click += new System.EventHandler(this.btnEndNode_Click);
            // 
            // btnStartNode
            // 
            this.btnStartNode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStartNode.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNode.ForeColor = System.Drawing.Color.Green;
            this.btnStartNode.Location = new System.Drawing.Point(46, 68);
            this.btnStartNode.Name = "btnStartNode";
            this.btnStartNode.Size = new System.Drawing.Size(140, 47);
            this.btnStartNode.TabIndex = 5;
            this.btnStartNode.Text = "🟢 Start Node";
            this.btnStartNode.UseVisualStyleBackColor = false;
            this.btnStartNode.Click += new System.EventHandler(this.btnStartNode_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Silver;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(606, 72);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(151, 38);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "⚙️ Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.btnSettings);
            this.panelFooter.Controls.Add(this.btnStartNode);
            this.panelFooter.Controls.Add(this.btnEndNode);
            this.panelFooter.Controls.Add(this.btnWellNode);
            this.panelFooter.Controls.Add(this.btnClear);
            this.panelFooter.Controls.Add(this.btnStart);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 274);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(783, 130);
            this.panelFooter.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(783, 274);
            this.panelGrid.TabIndex = 1;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGrid_Paint);
            this.panelGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGrid_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PathfindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(783, 404);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelGrid);
            this.Name = "PathfindingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PathfindingForm";
            this.Load += new System.EventHandler(this.PathfindingForm_Load);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnWellNode;
        private System.Windows.Forms.Button btnEndNode;
        private System.Windows.Forms.Button btnStartNode;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Timer timer1;
    }
}