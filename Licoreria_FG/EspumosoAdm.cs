using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Licoreria_FG
{
    public partial class EspumosoAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public EspumosoAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void EspumosoAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from VEspumoso";
            cnx.cargar(dtgvEspumoso, sqlstr);
        }

        private void dtgvEspumoso_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvEspumoso.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvEspumoso.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvEspumoso.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvEspumoso.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
