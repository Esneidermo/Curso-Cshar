using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCharp.OperadoresRelacionales
{
    public partial class frmORelacionales : Form
    {
        public frmORelacionales()
        {
            InitializeComponent();
        }
        int numero1;
        int numero2;
        bool Resultado;
        private void btnmenorigual_Click(object sender, EventArgs e) // boton menorigual
        {
            menorigual();
        }
        private void menorigual()// funcion menor igual 
        {
            asignacion();
            if(numero1<=numero2)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            lblresultado.Text = Resultado.ToString();
        }

        private void btnmayor_Click(object sender, EventArgs e) //boton mayor 
        {
            mayorque();
        }

        private void mayorque() // funcion de mayor 
        {
            asignacion();
            if (numero1 > numero2)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            lblresultado.Text = Resultado.ToString();
        }
        private void asignacion() //funcion para signar 
        {
            numero1 = Convert.ToInt32(txtnumero1.Text);
            numero2 = Convert.ToInt32(txtnumero2.Text);

        }

        private void btnmenor_Click(object sender, EventArgs e) // boton menor que 
        {
            menorque();
        }
        private void menorque() //funcion menor que
        {
            asignacion();
            if (numero1 < numero2)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            lblresultado.Text = Resultado.ToString();
        }

        private void btnmayorigual_Click(object sender, EventArgs e)//boton mayor igual 
        {
            mayorigual();
        }
        private void mayorigual() //funcion mayorigual
        {
            asignacion();
            if(numero1>=numero2)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            lblresultado.Text = Resultado.ToString();
        }

        private void igual_Click(object sender, EventArgs e) // boton igual
        {
            figual();
        }
        private void figual() //funcion de igual 
        {
            asignacion();
            if(numero1 == numero2)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            lblresultado.Text = Resultado.ToString();
        }

        private void diferente_Click(object sender, EventArgs e) // boton diferente
        {
           fdiferente();
        }
        private void fdiferente()// funcion diferente 
        {
            asignacion();
            if (numero1 != numero2)
            {
                Resultado = true;
            }
            else
            {
                Resultado = false;
            }
            lblresultado.Text = Resultado.ToString();
        }
    }
}
