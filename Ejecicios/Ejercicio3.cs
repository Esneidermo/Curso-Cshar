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
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        double peso;
        double altura;
        double imc;
        public string titulo;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            agsinar();
            IMC();
            condicionales();
        }
        private void agsinar()
        {
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
        }
        private void IMC()
        {
            imc = peso / Math.Pow(altura, 2);
            lblimc.Text = imc.ToString("N2");
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblejer3.Text = titulo;
        }

        private void condicionales()
        {
            if (imc < 18.5)
            {
                lblcondicion.Text = "por debajo";
            }
            if (imc >= 18.5 && imc <= 24.9)
            {
                lblcondicion.Text = "saludable";
            }
            if (imc > 25 && imc <= 29.9)
             {
                    lblcondicion.Text = "Sobre peso";
             }
            if(imc > 30) 
            {
                lblcondicion.Text = "Obeso";
            }
            
        }
    }
}