using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licoreria_FG
{
    public partial class VinoBlancoAdm : Form
    {

        clsConexion cnx = new clsConexion();
        public VinoBlancoAdm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VinoBlancoAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from VBlanco";
            cnx.cargar(dtgvVBlanco, sqlstr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgvVBlanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            //Caja c = new Caja();
            //c.txtId1.Text = txtId.Text;
            //c.txtNom1.Text = txtNom.Text;
            //c.txtSize1.Text = txtSize.Text;
            //c.txtPrecio1.Text = txtPrice.Text;
            //this.Hide();

            // Obtén los valores de los TextBox
            //string id = txtId.Text;
            //string nom = txtNom.Text;
            //string size = txtSize.Text;
            //string precio = txtPrice.Text;
            //Caja c = new Caja();
            // Pasa los valores al formulario de la caja registradora
            //c.RecibirDatos(id, nom, size, precio);
            //c.Show();
            //this.Close();
            // Opcional: muestra el formulario de la caja registradora si no está visible

        }

        private void dtgvVBlanco_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvVBlanco.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvVBlanco.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvVBlanco.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvVBlanco.CurrentRow.Cells[3].Value.ToString();
            this.Close();

        }
    }
}

