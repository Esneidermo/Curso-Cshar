using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCharp.Listas
{
    public partial class frmlista1 : Form
    {
        public frmlista1()
        {
            InitializeComponent();
        }
        // LISTAS
        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregarArray();       
        }
        private void agregar()
        {
            List<string> nombres = new List<string>();// definir el tipo de datos
            nombres.Add("Esneider"); //0
            nombres.Add("Uzui");//1
            nombres.Add("kamado");//2
            nombres.Add("alguien mas");//3 son las posiciones de la lista
            // siempre empiezaa contar desde el cero 
            foreach (string data in nombres)//que tipo de datos se va a recorrer y se pone un nombre de variable
            {
                lstadatos.Items.Add(data);//se pone la variable que recorre toda la informacion de lalista
                   
            }
             
        
          }
         private void agregarArray()
        {
            string[] nombres = new string[4] { "Esneider", "Uzui", "Kamado", "alguien mas" };//arreglo-matriz se especifica el tipo y la cantidad 
            foreach(string data in nombres)
            {
                lstadatos.Items.Add(data);
            }
        }

        private void frmlista1_Load(object sender, EventArgs e)
        {
            Dibujarteclado();
        }
        private void Dibujarteclado()
        {
            char[] numeros;//tipo de dato char es que es tipo de carater unico sea una a, una b, un 0 o un 1 etc
            numeros = "0123456789".ToCharArray(); // como definimos tipo char entonces cada uno sera independiente 
            fpanel1.Controls.Clear();
            foreach(char num in numeros)
            {
                Button btnnumero = new Button();//creacion del boton 
                btnnumero.Text =num.ToString();
                btnnumero.Size = new Size(72,67);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.FromArgb(192, 192, 255);
                btnnumero.FlatAppearance.BorderSize = 3;//damos todo el diseño del boton 
                fpanel1.Controls.Add(btnnumero);//agregar el boton al panel 
                //los eventos clic se agregan despues de agregarlos al panel
                btnnumero.Click += Btnnumero_Click;//evento del boton 
                
            }
        }

        private void Btnnumero_Click(object sender, EventArgs e)//boton que creamos por codgio 
        {//aqui escribimos lo que quieres que haga cada vez que presionas uno de los botones virtuales 
            string numero = ((Button)sender).Text;//para recocnocer cuando has echo clic en el boton
            txtpantalla.Text += numero;//ponemos el += para que concatene los numeros que presione con el clic
        }
    }
    }
