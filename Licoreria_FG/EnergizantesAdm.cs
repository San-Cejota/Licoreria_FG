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
    public partial class EnergizantesAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public EnergizantesAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgEnergizantes_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgEnergizantes.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgEnergizantes.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgEnergizantes.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgEnergizantes.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void EnergizantesAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from Energizantes";
            cnx.cargar(dtgEnergizantes, sqlstr);
        }
    }
}
