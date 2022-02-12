namespace CursoCharp.Listas
{
    partial class frmlista1
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
            this.lstadatos = new System.Windows.Forms.ListView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelnumerico = new System.Windows.Forms.GroupBox();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.fpanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panelnumerico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstadatos
            // 
            this.lstadatos.HideSelection = false;
            this.lstadatos.Location = new System.Drawing.Point(66, 121);
            this.lstadatos.Name = "lstadatos";
            this.lstadatos.Size = new System.Drawing.Size(121, 162);
            this.lstadatos.TabIndex = 1;
            this.lstadatos.UseCompatibleStateImageBehavior = false;
            // 
            // btnagregar
            // 
            this.btnagregar.FlatAppearance.BorderSize = 2;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.ForeColor = System.Drawing.Color.Coral;
            this.btnagregar.Location = new System.Drawing.Point(205, 159);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 51);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.lstadatos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(34, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTAS-ARRAY";
            // 
            // panelnumerico
            // 
            this.panelnumerico.Controls.Add(this.txtpantalla);
            this.panelnumerico.Controls.Add(this.fpanel1);
            this.panelnumerico.ForeColor = System.Drawing.Color.White;
            this.panelnumerico.Location = new System.Drawing.Point(409, 9);
            this.panelnumerico.Name = "panelnumerico";
            this.panelnumerico.Size = new System.Drawing.Size(358, 307);
            this.panelnumerico.TabIndex = 4;
            this.panelnumerico.TabStop = false;
            this.panelnumerico.Text = "teclado numerico";
            // 
            // txtpantalla
            // 
            this.txtpantalla.Location = new System.Drawing.Point(41, 20);
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.Size = new System.Drawing.Size(192, 20);
            this.txtpantalla.TabIndex = 1;
            // 
            // fpanel1
            // 
            this.fpanel1.Location = new System.Drawing.Point(18, 68);
            this.fpanel1.Name = "fpanel1";
            this.fpanel1.Size = new System.Drawing.Size(327, 214);
            this.fpanel1.TabIndex = 0;
            // 
            // frmlista1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelnumerico);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmlista1";
            this.Text = "frmlista1";
            this.Load += new System.EventHandler(this.frmlista1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panelnumerico.ResumeLayout(false);
            this.panelnumerico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstadatos;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox panelnumerico;
        private System.Windows.Forms.FlowLayoutPanel fpanel1;
        private System.Windows.Forms.TextBox txtpantalla;
    }
}