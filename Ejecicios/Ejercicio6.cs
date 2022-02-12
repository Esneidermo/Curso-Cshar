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
    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }
        public string titulo;
        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            lblejercicio6.Text = titulo;
            dibujartecladonumerico();
        }
        private void dibujartecladonumerico()
        {
            char[] numeros;
            numeros = "7894563210.".ToCharArray();
            fpanelnumerico.Controls.Clear();
            foreach (char num in numeros)
            {
                Button btnnumero = new Button();
                btnnumero.Text = num.ToString();
                btnnumero.Size = new Size(47, 47);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.White;
                btnnumero.BackColor = Color.Transparent;
                btnnumero.BackgroundImage =Properties.Resources._1644700688594;//añadir imagenes desde codigo selecionamos la raiz de proyecto damos clic derecho y en propiedades luego recours
                btnnumero.BackgroundImageLayout = ImageLayout.Stretch;//para que la imagen se adapte de acuerdo al boton 
                btnnumero.FlatAppearance.BorderSize = 0;
                btnnumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnnumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                fpanelnumerico.Controls.Add(btnnumero);

            }
        }
    }
}
