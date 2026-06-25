using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaTaquillaCine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbTipoBoleto.Items.Add("Estudiante");
            cmbTipoBoleto.Items.Add("Adulto Mayor");
            cmbTipoBoleto.Items.Add("General");
            cmbTipoBoleto.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Boleto boleto = null;
            decimal precioBase = 80.00m;
            else if (cmbTipoBoleto.Text == "Adulto Mayor")
            {
                boleto = new BoletoAdultoMayor(precioBase, "INAPAM12345");
            }

            if (cmbTipoBoleto.Text == "Estudiante")
            {
                boleto = new BoletoEstudiante(precioBase, "20251052");
            }

        }
    }
}
