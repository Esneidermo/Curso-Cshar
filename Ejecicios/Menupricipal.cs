using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CursoCharp.Ejecicios;

namespace CursoCharp.Ejecicios
{
    public partial class Menupricipal : Form
    {
        public Menupricipal()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            ejercicio1();
        }
        private void ejercicio1()
        {
            panelVisor.Controls.Clear();//para limpiar el panel y que pueda aparecer el ejercicio que aprete 
            Ejercicio1 ctl = new Ejercicio1(); // creando la variable para llamar el formulario
            ctl.titulo = btnE1.Text;
            ctl.Dock = DockStyle.Fill;// para que se expanda 
            panelVisor.Controls.Add(ctl);//para agregar el formulario al panel 
            ctl.Show();//llamando el formulario 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ejercicio2();
        }
        private void ejercicio2()
        {
            panelVisor.Controls.Clear();// para limpiar y que deje pasaar de paginas 
            Ejercicio2 ctrl = new Ejercicio2();
            ctrl.titulo = btnE2.Text;
            ctrl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctrl);
            ctrl.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            ejercicio3();
        }
        private void ejercicio3()
        {
            panelVisor.Controls.Clear();
            Ejercicio3 ctl = new Ejercicio3();
            ctl.titulo = btnE3.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnEje4_Click(object sender, EventArgs e)
        {
            ejercicio4();
        }
        private void ejercicio4()
        {
            panelVisor.Controls.Clear();
            Ejercicio4 ctl = new Ejercicio4();
            ctl.titulo = btnEje4.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ejercicio5();
        }
        private void ejercicio5()
        {
            panelVisor.Controls.Clear();
            Ejercicio5 ctl = new Ejercicio5();
            ctl.titulo = btn5.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void btnE6_Click(object sender, EventArgs e)
        {
            Ejercicio6();
        }
        private void Ejercicio6()
        {
            panelVisor.Controls.Clear();
            Ejercicio6 ctl = new Ejercicio6();
            ctl.titulo = btnE6.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
