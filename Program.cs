using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CursoCharp.OperadoresAritmrticos;// agregar carpteta 
using CursoCharp.OperadoresRelacionales;
using CursoCharp.OperadoresLogicos;
using CursoCharp.Ejecicios;
using CursoCharp.Condicionales;
using CursoCharp.Listas;
namespace CursoCharp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmlista1 ());// formulario desde el que se desea iniciar 
        }
    }
}
