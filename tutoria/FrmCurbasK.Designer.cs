namespace tutoria
{
    partial class FrmCurbasK
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
            this.canva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canva)).BeginInit();
            this.SuspendLayout();
            // 
            // canva
            // 
            this.canva.Location = new System.Drawing.Point(22, 7);
            this.canva.Name = "canva";
            this.canva.Size = new System.Drawing.Size(400, 400);
            this.canva.TabIndex = 0;
            this.canva.TabStop = false;
            // 
            // FrmCurbasK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 419);
            this.Controls.Add(this.canva);
            this.Name = "FrmCurbasK";
            this.Text = "FrmCurbasK";
            this.Load += new System.EventHandler(this.FrmCurbasK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canva;
    }
}