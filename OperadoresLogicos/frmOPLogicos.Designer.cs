namespace CursoCharp.OperadoresLogicos
{
    partial class frmOPLogicos
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
            this.btny = new System.Windows.Forms.Button();
            this.btno = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btny
            // 
            this.btny.BackColor = System.Drawing.Color.Lime;
            this.btny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btny.Location = new System.Drawing.Point(3, 3);
            this.btny.Name = "btny";
            this.btny.Size = new System.Drawing.Size(75, 23);
            this.btny.TabIndex = 0;
            this.btny.Text = "&&";
            this.btny.UseVisualStyleBackColor = false;
            this.btny.Click += new System.EventHandler(this.btny_Click);
            // 
            // btno
            // 
            this.btno.BackColor = System.Drawing.Color.Yellow;
            this.btno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btno.Location = new System.Drawing.Point(84, 3);
            this.btno.Name = "btno";
            this.btno.Size = new System.Drawing.Size(75, 23);
            this.btno.TabIndex = 1;
            this.btno.Text = "O(||)";
            this.btno.UseVisualStyleBackColor = false;
            this.btno.Click += new System.EventHandler(this.btno_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "!";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPERADORES LOGICOS ";
            // 
            // txtnumero1
            // 
            this.txtnumero1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtnumero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero1.ForeColor = System.Drawing.Color.White;
            this.txtnumero1.Location = new System.Drawing.Point(217, 124);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(200, 13);
            this.txtnumero1.TabIndex = 4;
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtnumero2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero2.ForeColor = System.Drawing.Color.White;
            this.txtnumero2.Location = new System.Drawing.Point(217, 186);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(200, 13);
            this.txtnumero2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero 2:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btny);
            this.flowLayoutPanel1.Controls.Add(this.btno);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(217, 235);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 30);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(217, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(217, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resultado :";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.White;
            this.lblresultado.Location = new System.Drawing.Point(217, 292);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(13, 17);
            this.lblresultado.TabIndex = 12;
            this.lblresultado.Text = "-";
            // 
            // frmOPLogicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label1);
            this.Name = "frmOPLogicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOPLogicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btny;
        private System.Windows.Forms.Button btno;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblresultado;
    }
}