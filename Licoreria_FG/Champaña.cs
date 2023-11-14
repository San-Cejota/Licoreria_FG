using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Licoreria_FG
{
    public partial class Champaña : Form
    {
        clsConexion cnx = new clsConexion();

        public Champaña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgChampañas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Champaña_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from VChampañas";
            cnx.cargar(dtgChampañas, sqlstr);
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgChampañas_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgChampañas.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgChampañas.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgChampañas.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgChampañas.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}