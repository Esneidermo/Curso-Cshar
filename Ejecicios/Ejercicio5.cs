using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCharp.Ejecicios
{
    public partial class Ejercicio5 : UserControl
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }
        public string titulo;
        int n1;
        int n2;
        private void Ejercicio5_Load(object sender, EventArgs e)
        {
            titulo = lbltitulo.Text;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            asignacion();
            calcular();
        }
        private void asignacion()
        {
            n1 =Convert.ToInt32(txtnumero1.Text);
            n2 = Convert.ToInt32(txtnumero2.Text);
        }
        private void calcular()
        {
            if(n1%2==0 && n2%2==0)
            {
                lblresultado.Text = "ambos son pares ";
            }
             else if (n1%2==0 && n2%2!=0)
            {
                lblresultado.Text = "el nunero 1 es par " + n1;
            }
            else if (n1%2!=0 && n2%2==0)
            {
                lblresultado.Text = " el dos es par";
            }
            else
            {
                lblresultado.Text = "Ambos son impares";
            }
                        
        }
    }
}
