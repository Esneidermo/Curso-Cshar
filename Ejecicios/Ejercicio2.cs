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
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        double radio;
        double area;
        double pi = Math.PI;
        double longitud;
        public string titulo;


        private void obtenerradio()
        {
            radio = Math.Sqrt(area / pi);
            lblresulradio.Text = radio.ToString(("N2"));
            lblradio1.Text = radio.ToString(("N2"));
            lblradio2.Text = radio.ToString(("N2"));//para que solo muestre dos decimales
        }
        
        private void obtnerlongitud() 
        {
            longitud = 2 * pi * radio;
            lblresullongitud.Text = longitud.ToString();
        }

        private void asignar ()
        {
            area = Convert.ToDouble(txtarea.Text);        }
        private void btncalcular_Click_1(object sender, EventArgs e)
        {
            asignar();
            obtenerradio();
            obtnerlongitud();

        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            lblejer2.Text = titulo;
        }

  
    }
}
