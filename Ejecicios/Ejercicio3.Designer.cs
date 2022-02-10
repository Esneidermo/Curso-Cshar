namespace CursoCharp.Ejecicios
{
    partial class Ejercicio3
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblejer3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblcondicion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblejer3
            // 
            this.lblejer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblejer3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblejer3.ForeColor = System.Drawing.Color.White;
            this.lblejer3.Location = new System.Drawing.Point(0, 0);
            this.lblejer3.Name = "lblejer3";
            this.lblejer3.Size = new System.Drawing.Size(847, 53);
            this.lblejer3.TabIndex = 1;
            this.lblejer3.Text = "Ejercicio3";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(847, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Solucion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblcondicion);
            this.panel1.Controls.Add(this.lblimc);
            this.panel1.Controls.Add(this.btncalcular);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtaltura);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtpeso);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 235);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CursoCharp.Properties.Resources.Ejercicio_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(847, 134);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Peso=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Altura=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IMC=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Condicon=";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(163, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 4;
            // 
            // txtpeso
            // 
            this.txtpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpeso.ForeColor = System.Drawing.Color.White;
            this.txtpeso.Location = new System.Drawing.Point(91, 18);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(60, 13);
            this.txtpeso.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(91, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 2);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(94, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 2);
            this.panel4.TabIndex = 9;
            // 
            // txtaltura
            // 
            this.txtaltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.txtaltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaltura.ForeColor = System.Drawing.Color.White;
            this.txtaltura.Location = new System.Drawing.Point(94, 68);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(57, 13);
            this.txtaltura.TabIndex = 8;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncalcular.ForeColor = System.Drawing.Color.Black;
            this.btncalcular.Location = new System.Drawing.Point(227, 62);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(96, 45);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Location = new System.Drawing.Point(96, 119);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(10, 13);
            this.lblimc.TabIndex = 11;
            this.lblimc.Text = "-";
            // 
            // lblcondicion
            // 
            this.lblcondicion.AutoSize = true;
            this.lblcondicion.Location = new System.Drawing.Point(112, 153);
            this.lblcondicion.Name = "lblcondicion";
            this.lblcondicion.Size = new System.Drawing.Size(10, 13);
            this.lblcondicion.TabIndex = 12;
            this.lblcondicion.Text = "-";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblejer3);
            this.Name = "Ejercicio3";
            this.Size = new System.Drawing.Size(847, 474);
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblejer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblcondicion;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
