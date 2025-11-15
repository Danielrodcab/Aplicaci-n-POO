using CALCULODESCUENTOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULODESCUENTOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Tecnología");
            cbTipo.Items.Add("Alimento");
            cbTipo.Items.Add("General");
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido");
                return;
            }

            Producto producto = null;

            switch (cbTipo.SelectedItem?.ToString())
            {
                case "Tecnología":
                    producto = new Tecnologia(precio);
                    break;
                case "Alimento":
                    producto = new Alimento(precio);
                    break;
                case "General":
                    producto = new Producto(precio);
                    break;
                default:
                    MessageBox.Show("Seleccione un tipo de producto");
                    return;
            }

            decimal total = producto.CalcularPrecioFinal();
            MessageBox.Show($"Debug: total calculado = {total}");
            lblResultado.Text = $"Precio final: {total:C}";


        }

    }
}



