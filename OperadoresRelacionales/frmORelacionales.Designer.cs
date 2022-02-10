namespace CursoCharp.OperadoresRelacionales
{
    partial class frmORelacionales
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnmayor = new System.Windows.Forms.Button();
            this.btnmenor = new System.Windows.Forms.Button();
            this.btnmayorigual = new System.Windows.Forms.Button();
            this.btnmenorigual = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.btndiferente = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel1.Controls.Add(this.btnmayor);
            this.flowLayoutPanel1.Controls.Add(this.btnmenor);
            this.flowLayoutPanel1.Controls.Add(this.btnmayorigual);
            this.flowLayoutPanel1.Controls.Add(this.btnmenorigual);
            this.flowLayoutPanel1.Controls.Add(this.igual);
            this.flowLayoutPanel1.Controls.Add(this.btndiferente);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(239, 200);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 63);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnmayor
            // 
            this.btnmayor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(14)))));
            this.btnmayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmayor.Location = new System.Drawing.Point(3, 3);
            this.btnmayor.Name = "btnmayor";
            this.btnmayor.Size = new System.Drawing.Size(41, 29);
            this.btnmayor.TabIndex = 0;
            this.btnmayor.Text = ">";
            this.btnmayor.UseVisualStyleBackColor = false;
            this.btnmayor.Click += new System.EventHandler(this.btnmayor_Click);
            // 
            // btnmenor
            // 
            this.btnmenor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(14)))));
            this.btnmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmenor.Location = new System.Drawing.Point(50, 3);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(41, 29);
            this.btnmenor.TabIndex = 0;
            this.btnmenor.Text = "<";
            this.btnmenor.UseVisualStyleBackColor = false;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // btnmayorigual
            // 
            this.btnmayorigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(14)))));
            this.btnmayorigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmayorigual.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmayorigual.Location = new System.Drawing.Point(97, 3);
            this.btnmayorigual.Name = "btnmayorigual";
            this.btnmayorigual.Size = new System.Drawing.Size(41, 29);
            this.btnmayorigual.TabIndex = 1;
            this.btnmayorigual.Text = ">=";
            this.btnmayorigual.UseVisualStyleBackColor = false;
            this.btnmayorigual.Click += new System.EventHandler(this.btnmayorigual_Click);
            // 
            // btnmenorigual
            // 
            this.btnmenorigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(14)))));
            this.btnmenorigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenorigual.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmenorigual.Location = new System.Drawing.Point(144, 3);
            this.btnmenorigual.Name = "btnmenorigual";
            this.btnmenorigual.Size = new System.Drawing.Size(41, 29);
            this.btnmenorigual.TabIndex = 0;
            this.btnmenorigual.Text = "<=";
            this.btnmenorigual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmenorigual.UseVisualStyleBackColor = false;
            this.btnmenorigual.Click += new System.EventHandler(this.btnmenorigual_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(14)))));
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.igual.Location = new System.Drawing.Point(191, 3);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(41, 29);
            this.igual.TabIndex = 2;
            this.igual.Text = "==";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // btndiferente
            // 
            this.btndiferente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(14)))));
            this.btndiferente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiferente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndiferente.Location = new System.Drawing.Point(238, 3);
            this.btndiferente.Name = "btndiferente";
            this.btndiferente.Size = new System.Drawing.Size(41, 29);
            this.btndiferente.TabIndex = 3;
            this.btndiferente.Text = "!=";
            this.btndiferente.UseVisualStyleBackColor = false;
            this.btndiferente.Click += new System.EventHandler(this.diferente_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.lblresultado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblresultado.Location = new System.Drawing.Point(251, 286);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(18, 19);
            this.lblresultado.TabIndex = 17;
            this.lblresultado.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(146, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Resultado:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(239, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(239, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 14;
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtnumero2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtnumero2.Location = new System.Drawing.Point(239, 173);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(200, 13);
            this.txtnumero2.TabIndex = 13;
            // 
            // txtnumero1
            // 
            this.txtnumero1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtnumero1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumero1.ForeColor = System.Drawing.Color.White;
            this.txtnumero1.Location = new System.Drawing.Point(239, 109);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(200, 13);
            this.txtnumero1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(114, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(114, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label4.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(171, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(473, 40);
            this.label4.TabIndex = 19;
            this.label4.Text = "Operadores Relacionales ";
            // 
            // frmORelacionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmORelacionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmORelacionales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnmayor;
        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Button btnmenorigual;
        private System.Windows.Forms.Button btnmayorigual;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button btndiferente;
        private System.Windows.Forms.Label label4;
    }
}