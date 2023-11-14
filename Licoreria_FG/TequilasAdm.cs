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
    public partial class TequilasAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public TequilasAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgvTequilas_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvTequilas.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvTequilas.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvTequilas.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvTequilas.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void TequilasAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from Tequilas";
            cnx.cargar(dtgvTequilas, sqlstr);
        }
    }
}
