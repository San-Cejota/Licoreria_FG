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
    public partial class NacionalesAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public NacionalesAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NacionalesAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from Cervezas";
            cnx.cargar(dtgvNacionales, sqlstr);
        }

        private void dtgvNacionales_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvNacionales.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvNacionales.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvNacionales.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvNacionales.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
