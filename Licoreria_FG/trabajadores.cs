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
    public partial class trabajadores : Form
    {
        clsConexion cnx = new clsConexion();
        public trabajadores()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void trabajadores_Load(object sender, EventArgs e)
        {
            string sqlstr = "Select * from trabajadores";
            cnx.cargar(dtgEmpleados, sqlstr);
        }
    }
}
