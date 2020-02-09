﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero_automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtcantidad.Text);
            SByte n = 0; /* contador */
            String respuesta = "Respuesta: \n";

            /* Recorrer todos los valores en las dominaciones */

            lblrespuesta.Visible = true;

            foreach (double denominacion in denominaciones)
            {

                while (denominacion <= Math.Round (cantidad, 2)) {
                    n++;

                    cantidad -= denominacion;

                }

                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? "Billete" : "Monedas") + denominacion + "\n";

                }
                n = 0;

            }
            lblrespuesta.Text = respuesta;

        }

        private void btnpagar_Click_1(object sender, EventArgs e)
        {

            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.10, 0.05, 0.01 };

            //Convertimos los texbox de tipo texto a numerico

            double cantidad = double.Parse(txtpagar.Text);
            double pago = double.Parse(txtpago.Text);

            sbyte n = 0;

            double vuelto = pago - cantidad;

            string resp = "Vuelto: \n" ; // \n es un separador de espacio

            foreach (double denominacion in denominaciones)

            {

                while (denominacion <= Math.Round(vuelto, 2)) {
                n++;
                   

                vuelto -= denominacion;
                    
                }


                if (n > 0) 

               
                {

                    resp += n + (denominacion > 1 ? "Billete" : "Monedas") + denominacion + "\n";

                }


                if (pago < cantidad)

                {

                    resp = "Cancele completamente";

                }
   

            n = 0;

            }


            lblresp.Text = resp;

        }

       
    }
}
