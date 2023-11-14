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
    public partial class AguaAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public AguaAdm()
        {
            InitializeComponent();
        }

        private void dtgvAgua_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvAgua.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvAgua.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvAgua.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvAgua.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void AguaAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from VBlanco";
            cnx.cargar(dtgvAgua, sqlstr);
        }
    }
}
