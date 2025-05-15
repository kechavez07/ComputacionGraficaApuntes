namespace tutoria
{
    partial class FrmFiguraNLados
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
            this.lblLados = new System.Windows.Forms.Label();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLados
            // 
            this.lblLados.AutoSize = true;
            this.lblLados.Location = new System.Drawing.Point(23, 31);
            this.lblLados.Name = "lblLados";
            this.lblLados.Size = new System.Drawing.Size(114, 16);
            this.lblLados.TabIndex = 0;
            this.lblLados.Text = "Número de lados:";
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(144, 31);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(100, 22);
            this.txtLados.TabIndex = 1;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(144, 86);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 2;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(26, 86);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(47, 16);
            this.lblRadio.TabIndex = 3;
            this.lblRadio.Text = "Radio:";
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(301, 31);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(455, 375);
            this.canvas.TabIndex = 4;
            this.canvas.TabStop = false;
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(93, 148);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 5;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // FrmFiguraNLados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.lblLados);
            this.Name = "FrmFiguraNLados";
            this.Text = "FrmFiguraNLados";
            this.Load += new System.EventHandler(this.FrmFiguraNLados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLados;
        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnGraficar;
    }
}