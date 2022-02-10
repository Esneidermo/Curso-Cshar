namespace CursoCharp.Ejecicios
{
    partial class Ejercicio4
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
            this.lblejercicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtm = new System.Windows.Forms.RadioButton();
            this.rbtl = new System.Windows.Forms.RadioButton();
            this.rbts = new System.Windows.Forms.RadioButton();
            this.rbrojo = new System.Windows.Forms.RadioButton();
            this.rbbla = new System.Windows.Forms.RadioButton();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtdetalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(807, 107);
            this.lblejercicio.TabIndex = 0;
            this.lblejercicio.Text = "Ejercicio4\r\nCrear un programa que permita elegir talla y color de casacas y muest" +
    "re el detalle en un texbox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 118);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Casacas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbts);
            this.groupBox1.Controls.Add(this.rbtl);
            this.groupBox1.Controls.Add(this.rbtm);
            this.groupBox1.Location = new System.Drawing.Point(135, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbbla);
            this.groupBox2.Controls.Add(this.rbrojo);
            this.groupBox2.Location = new System.Drawing.Point(380, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colores";
            // 
            // rbtm
            // 
            this.rbtm.AutoSize = true;
            this.rbtm.Location = new System.Drawing.Point(46, 67);
            this.rbtm.Name = "rbtm";
            this.rbtm.Size = new System.Drawing.Size(108, 23);
            this.rbtm.TabIndex = 0;
            this.rbtm.TabStop = true;
            this.rbtm.Text = "M ($ 100)";
            this.rbtm.UseVisualStyleBackColor = true;
            // 
            // rbtl
            // 
            this.rbtl.AutoSize = true;
            this.rbtl.Location = new System.Drawing.Point(46, 25);
            this.rbtl.Name = "rbtl";
            this.rbtl.Size = new System.Drawing.Size(99, 23);
            this.rbtl.TabIndex = 1;
            this.rbtl.TabStop = true;
            this.rbtl.Text = "L ($200)";
            this.rbtl.UseVisualStyleBackColor = true;
            // 
            // rbts
            // 
            this.rbts.AutoSize = true;
            this.rbts.Location = new System.Drawing.Point(46, 106);
            this.rbts.Name = "rbts";
            this.rbts.Size = new System.Drawing.Size(99, 23);
            this.rbts.TabIndex = 2;
            this.rbts.TabStop = true;
            this.rbts.Text = "S ($ 50)";
            this.rbts.UseVisualStyleBackColor = true;
            // 
            // rbrojo
            // 
            this.rbrojo.AutoSize = true;
            this.rbrojo.Location = new System.Drawing.Point(51, 25);
            this.rbrojo.Name = "rbrojo";
            this.rbrojo.Size = new System.Drawing.Size(63, 23);
            this.rbrojo.TabIndex = 2;
            this.rbrojo.TabStop = true;
            this.rbrojo.Text = "Rojo";
            this.rbrojo.UseVisualStyleBackColor = true;
            // 
            // rbbla
            // 
            this.rbbla.AutoSize = true;
            this.rbbla.Location = new System.Drawing.Point(51, 69);
            this.rbbla.Name = "rbbla";
            this.rbbla.Size = new System.Drawing.Size(81, 23);
            this.rbbla.TabIndex = 3;
            this.rbbla.TabStop = true;
            this.rbbla.Text = "Blanco";
            this.rbbla.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Location = new System.Drawing.Point(620, 271);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(96, 45);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtdetalle
            // 
            this.txtdetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtdetalle.Location = new System.Drawing.Point(135, 437);
            this.txtdetalle.Multiline = true;
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdetalle.Size = new System.Drawing.Size(445, 101);
            this.txtdetalle.TabIndex = 13;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.txtdetalle);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblejercicio);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio4";
            this.Size = new System.Drawing.Size(807, 698);
            this.Load += new System.EventHandler(this.Ejercicio4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblejercicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbts;
        private System.Windows.Forms.RadioButton rbtl;
        private System.Windows.Forms.RadioButton rbtm;
        private System.Windows.Forms.RadioButton rbbla;
        private System.Windows.Forms.RadioButton rbrojo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtdetalle;
    }
}
