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
    public partial class Ejercicio4 : UserControl
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }
        public string titulo;
        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular()
        {
            double total = 0;
            string detalle = "";

            if(rbtl.Checked==true)
            {
                total += total + 200;
                detalle += "casaca talla L $200\r\n"; // += para que se almacene y no se pierda el detalle , \r\n para salto de linea 
            }
            if (rbbla.Checked==true)
            {
                total += 10;
                detalle += "color blanco\r\n";
            }
            if (rbrojo.Checked == true)
            {
                total += 20;
                detalle += "color rojo\r\n";
            }
            if (rbtm.Checked == true)
            {
                total += 100;
                detalle += "casaca talla M  100\r\n";
            }
            if (rbts.Checked == true)
            {
                total += 50;
                detalle += "casaca talla S  50\r\n";
            }
            detalle += "El total a pagar es de " + total + "\r\n"; // concatenar y poner salto de linea 
            txtdetalle.Text = detalle;
        }
    }
}
