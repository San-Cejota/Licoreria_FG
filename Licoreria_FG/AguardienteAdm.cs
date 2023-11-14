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
    public partial class AguardienteAdm : Form
    {
        clsConexion cnx = new clsConexion();
        public AguardienteAdm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AguardienteAdm_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from Aguardiente";
            cnx.cargar(dtgvAguardiente, sqlstr);
        }

        private void dtgvAguardiente_DoubleClick(object sender, EventArgs e)
        {
            Caja c = Owner as Caja;
            c.label13.Text = dtgvAguardiente.CurrentRow.Cells[0].Value.ToString();
            c.lbNom.Text = dtgvAguardiente.CurrentRow.Cells[1].Value.ToString();
            c.lbTamaño.Text = dtgvAguardiente.CurrentRow.Cells[2].Value.ToString();
            c.lbPrecioo.Text = dtgvAguardiente.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
