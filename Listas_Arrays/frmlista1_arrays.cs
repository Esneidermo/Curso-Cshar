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
        }
    }
