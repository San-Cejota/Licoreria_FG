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
    public partial class vodkaAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public vodkaAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void vodkaAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from Vodka";
            cnx.cargar(dtgvVodka, sqlstr);
        }

        private void dtgvVodka_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvVodka.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvVodka.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvVodka.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvVodka.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
