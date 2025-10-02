using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            Cuenta cuenta = new Cuenta(nombre, dni, importe);


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

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (sr.EndOfStream == false)
                {
                    string linea = sr.ReadLine();
                    string dni = linea.Substring(0, 9);
                    string nombre = linea.Substring(9,10).Trim();
                    string importe = linea.Substring(19,9);
                    Cuenta c = new Cuenta(nombre, Convert.ToInt32(dni), Convert.ToDouble(importe));

                     
                 }
            }
        }
    }
}
