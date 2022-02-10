namespace CursoCharp
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
            this.lblholamundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblholamundo
            // 
            this.lblholamundo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblholamundo.CausesValidation = false;
            this.lblholamundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblholamundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblholamundo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblholamundo.Location = new System.Drawing.Point(0, 0);
            this.lblholamundo.Name = "lblholamundo";
            this.lblholamundo.Size = new System.Drawing.Size(800, 450);
            this.lblholamundo.TabIndex = 0;
            this.lblholamundo.Text = "Hola mundo";
            this.lblholamundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblholamundo.Click += new System.EventHandler(this.lblholamundo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblholamundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblholamundo;
    }
}

