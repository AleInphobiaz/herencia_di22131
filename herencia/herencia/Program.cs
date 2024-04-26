using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    /*programa de herencia.Herencia es la caracteristica de pasar atributos y metodos a otros objetos o clases*/
    //clase mamá
    class Operacion
    {
        //guardalos espacios de memoria de 3 valores
     //modificador,    tipo de dato,      nombre
        protected          int            valor1;
        protected          int            valor2;
        protected          int            resultado;
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        // Este es un comentario 26-02-2024
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
