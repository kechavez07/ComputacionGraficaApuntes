namespace tutoria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEntr = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblPro = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tnSalir = new System.Windows.Forms.Button();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblPerim = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerim = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntr
            // 
            this.lblEntr.AutoSize = true;
            this.lblEntr.Location = new System.Drawing.Point(13, 13);
            this.lblEntr.Name = "lblEntr";
            this.lblEntr.Size = new System.Drawing.Size(49, 13);
            this.lblEntr.TabIndex = 0;
            this.lblEntr.Text = "Entradas";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(16, 41);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(56, 13);
            this.lblAncho.TabIndex = 1;
            this.lblAncho.Text = "Ancho (a):";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(19, 82);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(52, 13);
            this.lblLargo.TabIndex = 2;
            this.lblLargo.Text = "Largo (b):";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(79, 41);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 3;
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(79, 82);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 4;
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(16, 135);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(46, 13);
            this.lblPro.TabIndex = 5;
            this.lblPro.Text = "Proceso";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(15, 162);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(94, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tnSalir
            // 
            this.tnSalir.Location = new System.Drawing.Point(175, 162);
            this.tnSalir.Name = "tnSalir";
            this.tnSalir.Size = new System.Drawing.Size(75, 23);
            this.tnSalir.TabIndex = 8;
            this.tnSalir.Text = "Salir";
            this.tnSalir.UseVisualStyleBackColor = true;
            this.tnSalir.Click += new System.EventHandler(this.tnSalir_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(19, 215);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(41, 13);
            this.lblSalida.TabIndex = 9;
            this.lblSalida.Text = "Salidas";
            // 
            // lblPerim
            // 
            this.lblPerim.AutoSize = true;
            this.lblPerim.Location = new System.Drawing.Point(22, 251);
            this.lblPerim.Name = "lblPerim";
            this.lblPerim.Size = new System.Drawing.Size(54, 13);
            this.lblPerim.TabIndex = 10;
            this.lblPerim.Text = "Perimetro:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(25, 287);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 11;
            this.lblArea.Text = "Área:";
            // 
            // txtPerim
            // 
            this.txtPerim.Location = new System.Drawing.Point(79, 251);
            this.txtPerim.Name = "txtPerim";
            this.txtPerim.Size = new System.Drawing.Size(100, 20);
            this.txtPerim.TabIndex = 12;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(79, 287);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 13;
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(374, 41);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(300, 300);
            this.canvas.TabIndex = 14;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtPerim);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerim);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.tnSalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblPro);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblEntr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntr;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button tnSalir;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblPerim;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerim;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.PictureBox canvas;
    }
}

