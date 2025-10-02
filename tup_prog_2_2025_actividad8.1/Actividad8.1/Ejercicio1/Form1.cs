using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Cuenta cuenta;
        List<Cuenta> cuentas = new List<Cuenta>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            double importe = Convert.ToDouble(tbImporte.Text);

            Cuenta cuenta = new Cuenta(nombre,dni,importe);


            cuentas.Sort();
            int idx = cuentas.IndexOf(cuenta);
            if (idx > 0)
            {
                cuentas[idx].Nombre = nombre;
                cuentas[idx].Importe += importe;

            }
            else
            {
                cuentas.Add(cuenta);
            }
            btnActualizar.PerformClick();
        }
    }
}
