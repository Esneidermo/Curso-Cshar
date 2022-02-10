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
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        double a;
        double b;
        double c;
        double resultado;
        public  string titulo;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void asignardatos()
        {
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
        }
        private void calcular()
        {
            asignardatos();
            resultado = ((c + 5) * (Math.Pow(b, 2) - 3 * a * c) * Math.Pow(a, 2)) / (4 * a);
            lblresultado.Text = resultado.ToString();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            lblejercicio1.Text = titulo;
        }
    }
}