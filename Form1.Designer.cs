namespace Matemáticas
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
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnMedia_Aritmetica = new System.Windows.Forms.Button();
            this.btnEstandar = new System.Windows.Forms.Button();
            this.btnTipica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(31, 37);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(56, 20);
            this.lblSerie.TabIndex = 0;
            this.lblSerie.Text = "Serie:";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(97, 81);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(21, 20);
            this.lblRespuesta.TabIndex = 1;
            this.lblRespuesta.Text = "X";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(101, 37);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 2;
            // 
            // btnMedia_Aritmetica
            // 
            this.btnMedia_Aritmetica.Location = new System.Drawing.Point(12, 129);
            this.btnMedia_Aritmetica.Name = "btnMedia_Aritmetica";
            this.btnMedia_Aritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnMedia_Aritmetica.TabIndex = 3;
            this.btnMedia_Aritmetica.Text = "Cakcular X";
            this.btnMedia_Aritmetica.UseVisualStyleBackColor = true;
            this.btnMedia_Aritmetica.Click += new System.EventHandler(this.btnMedia_Aritmetica_Click);
            // 
            // btnEstandar
            // 
            this.btnEstandar.Location = new System.Drawing.Point(101, 129);
            this.btnEstandar.Name = "btnEstandar";
            this.btnEstandar.Size = new System.Drawing.Size(89, 49);
            this.btnEstandar.TabIndex = 4;
            this.btnEstandar.Text = "Cakcular Estandar";
            this.btnEstandar.UseVisualStyleBackColor = true;
            this.btnEstandar.Click += new System.EventHandler(this.btnEstandar_Click);
            // 
            // btnTipica
            // 
            this.btnTipica.Location = new System.Drawing.Point(196, 129);
            this.btnTipica.Name = "btnTipica";
            this.btnTipica.Size = new System.Drawing.Size(87, 49);
            this.btnTipica.TabIndex = 5;
            this.btnTipica.Text = "Cakcular Tipica";
            this.btnTipica.UseVisualStyleBackColor = true;
            this.btnTipica.Click += new System.EventHandler(this.btnTipica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 238);
            this.Controls.Add(this.btnTipica);
            this.Controls.Add(this.btnEstandar);
            this.Controls.Add(this.btnMedia_Aritmetica);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnMedia_Aritmetica;
        private System.Windows.Forms.Button btnEstandar;
        private System.Windows.Forms.Button btnTipica;
    }
}

