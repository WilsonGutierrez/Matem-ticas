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
            this.lblRespuesta_Serie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnMedia_Aritmetica = new System.Windows.Forms.Button();
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
            // lblRespuesta_Serie
            // 
            this.lblRespuesta_Serie.AutoSize = true;
            this.lblRespuesta_Serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta_Serie.Location = new System.Drawing.Point(97, 81);
            this.lblRespuesta_Serie.Name = "lblRespuesta_Serie";
            this.lblRespuesta_Serie.Size = new System.Drawing.Size(21, 20);
            this.lblRespuesta_Serie.TabIndex = 1;
            this.lblRespuesta_Serie.Text = "X";
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
            this.btnMedia_Aritmetica.Location = new System.Drawing.Point(59, 149);
            this.btnMedia_Aritmetica.Name = "btnMedia_Aritmetica";
            this.btnMedia_Aritmetica.Size = new System.Drawing.Size(75, 23);
            this.btnMedia_Aritmetica.TabIndex = 3;
            this.btnMedia_Aritmetica.Text = "Cakcular X";
            this.btnMedia_Aritmetica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 238);
            this.Controls.Add(this.btnMedia_Aritmetica);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblRespuesta_Serie);
            this.Controls.Add(this.lblSerie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblRespuesta_Serie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnMedia_Aritmetica;
    }
}

