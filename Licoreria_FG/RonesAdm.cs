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
    public partial class RonesAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public RonesAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RonesAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from Rones";
            cnx.cargar(dtgvRones, sqlstr);
        }

        private void dtgvRones_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvRones.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvRones.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvRones.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvRones.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
