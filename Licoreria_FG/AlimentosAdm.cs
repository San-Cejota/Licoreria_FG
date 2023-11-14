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
    public partial class AlimentosAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public AlimentosAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AlimentosAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from Alimentos";
            cnx.cargar(dtgvAlimentos, sqlstr);
        }

        private void dtgvAlimentos_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvAlimentos.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvAlimentos.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvAlimentos.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvAlimentos.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
