namespace tutoria
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kleberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figuraToolStripMenuItem,
            this.kleberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figuraToolStripMenuItem
            // 
            this.figuraToolStripMenuItem.Name = "figuraToolStripMenuItem";
            this.figuraToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.figuraToolStripMenuItem.Text = "figura";
            // 
            // kleberToolStripMenuItem
            // 
            this.kleberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curbaToolStripMenuItem,
            this.romboToolStripMenuItem});
            this.kleberToolStripMenuItem.Name = "kleberToolStripMenuItem";
            this.kleberToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.kleberToolStripMenuItem.Text = "kleber";
            // 
            // curbaToolStripMenuItem
            // 
            this.curbaToolStripMenuItem.Name = "curbaToolStripMenuItem";
            this.curbaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.curbaToolStripMenuItem.Text = "curba";
            this.curbaToolStripMenuItem.Click += new System.EventHandler(this.curbaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.romboToolStripMenuItem.Text = "rombo";
            this.romboToolStripMenuItem.Click += new System.EventHandler(this.romboToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figuraToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kleberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem;
    }
}