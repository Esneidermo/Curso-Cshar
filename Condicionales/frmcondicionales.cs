using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCharp.Condicionales
{
    public partial class frmcondicionales : Form
    {
        public frmcondicionales()
        {
            InitializeComponent();
        }
        int numero;
        private void button1_Click(object sender, EventArgs e)
        {
            asignar();
            calculo();
        }

        private void calculo ()
        {
            if (numero >0)
            {
                lblresult.Text = "El numero es positivo";
            }
            else if(numero<0)
            {
                lblresult.Text = "El numero es negativo";
            }
            else 
            {
                lblresult.Text = "El numero es cero ";
            }

        }
        private void asignar()
        {

            numero = Convert.ToInt32(txtnumero.Text);
        }
    }
}
