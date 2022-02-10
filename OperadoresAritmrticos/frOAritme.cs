using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCharp.OperadoresAritmrticos
{
    public partial class frmOAritme : Form
    {
        public frmOAritme()
        {
            InitializeComponent();
        }
        double num1, num2, resul; // definiendo varibles 
        private void frmOAritme_Load(object sender, EventArgs e)
        {

        }
        private void btnResta_Click(object sender, EventArgs e) //boton resta
        {
            resta(); //llamar funcion resta
        }

        private void btnsuma_Click(object sender, EventArgs e) //boton suma
        {
            suma();//llamar funcion suma
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e) //boton multiplicar
        {
            multiplicar(); //llamar funcion multiplicar
        }

        private void suma() // funcion para sumar 
        {
            try
            {
                txtnumero2.Text = txtnumero2.Text.Replace(".", ",");
                txtnumero1.Text = txtnumero1.Text.Replace(".", ",");
                num1 = Convert.ToDouble(txtnumero1.Text);
                num2 = Convert.ToDouble(txtnumero2.Text);//capturando los numeros que se escriben en la caja de texto 

                resul = num1 + num2; //suma de los numero singresados en la caja de texto
                lblresultado.Text = resul.ToString(); //para poder mostrar el resultado en un string 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace); //para mostrar error 
            }
            
        }

        private void btndivision_Click(object sender, EventArgs e) // boton dividir
        {
            dividir(); //llarma la funcion
        }

        private void resta() // funcion para restar
        {
            txtnumero2.Text = txtnumero2.Text.Replace(".", ",");
            txtnumero1.Text = txtnumero1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);
            resul = num1 - num2;
            lblresultado.Text = resul.ToString();
        }
        private void multiplicar() //funcion para mutiplicar
        {
            txtnumero2.Text = txtnumero2.Text.Replace(".", ",");
            txtnumero1.Text = txtnumero1.Text.Replace(".", ",");
            txtnumero2.Text = txtnumero2.Text.Replace(".", ",");
            txtnumero1.Text = txtnumero1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);
            resul = num1 * num2;
            lblresultado.Text = resul.ToString();
        }
        private void dividir() // funcion para dividir 
        {

            txtnumero2.Text = txtnumero2.Text.Replace(".", ",");
            txtnumero1.Text = txtnumero1.Text.Replace(".", ",");
            num1 = Convert.ToDouble(txtnumero1.Text);
            num2 = Convert.ToDouble(txtnumero2.Text);
            resul =Convert.ToDouble(num1) /Convert.ToDouble(num2); //como es division lo convertimos a double para que muestre decimales 
            lblresultado.Text = resul.ToString();
        }
    }
    
}