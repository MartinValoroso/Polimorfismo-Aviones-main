using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviones.Core;
using Aviones.Core.Aviones;

namespace Aviones.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAvion(object sender, EventArgs e)
        {
            AvionComercial avioncomercial = new AvionComercial("Martín Valoroso", "Antonela Di Raimondo", 180, "Aerolineas Argentinas");

            MessageBox.Show($"Avion:\n{avioncomercial}");
        }
    }
}
