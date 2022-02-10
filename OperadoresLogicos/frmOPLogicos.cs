using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCharp.OperadoresLogicos
{
    public partial class frmOPLogicos : Form
    {
        public frmOPLogicos()
        {
            InitializeComponent();
        }
        int num1, num2;
        bool resul;
        private void btny_Click(object sender, EventArgs e)
        {
            Y();
        }
        private void o()
        {
            asignacion();
            if (num1 >2 ||num2 >6 )
            {
                resul = true;
            }
            else
            {
                resul = false;
            }
            lblresultado.Text = resul.ToString();
        }
        
        private void diferente() 
        {
            asignacion();
        if (!(num1 > 0) && num2 < 10)
            {
                resul = true;
            }
        else
            {
                resul = false;
            }
            lblresultado.Text = resul.ToString();
        }
        private void Y ()
        {
            asignacion();
            if (num1 > 0 && num2 <10)
            {
                resul = true;
            }
        else
            { 
                resul = false; 
            }
            lblresultado.Text = resul.ToString();
                
                    }

        private void btno_Click(object sender, EventArgs e)
        {
            o();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            diferente();
        }

        private void asignacion()
        {
            num1 = Convert.ToInt32(txtnumero1.Text);
            num2 = Convert.ToInt32(txtnumero2.Text);
        }
    }
}
