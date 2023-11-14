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
    public partial class Caja : Form
    {


        public Caja()
        {
            InitializeComponent();
            Personalizar();
            lbMensaje.Visible = false;
        }
        private void Personalizar()
        {
            panelVinos.Visible = false;
            panelLicores.Visible = false;
            panelCervezas.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelVinos.Visible == true)
                panelVinos.Visible = false;
            if (panelLicores.Visible == true)
                panelLicores.Visible = false;
            if (panelCervezas.Visible == true)
                panelCervezas.Visible = false;
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form activar = null;
        private void openChildForm(Form childForm2)
        {
            if (activar != null)
                activar.Close();
            activar = childForm2;
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Fill;
            panelDatos.Controls.Add(childForm2);
            panelDatos.Tag = childForm2;
            childForm2.BringToFront();
            childForm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            DT_lista();
        }
        private DataGridView dtgvLista;
        public DataGridView DtgvLista1 { get => dtgvLista; set => dtgvLista = value; }
        public void DT_lista()
        {
            dtgvLista = DtgvLista1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Administrador adm = new Administrador();
            adm.lbUsuarioAdm.Text = lbMensaje.Text;
            adm.Show();
            this.Close();
        }
        string[,] ListaVenta = new string[200, 6];
        int fila = 0;
        private void btnAgg_Click(object sender, EventArgs e)
        {
            try
            {
                if (label13.Text != " " && lbNom.Text != " " && lbTamaño.Text != " " && lbPrecioo.Text != " ") ;
                {
                    ListaVenta[fila, 0] = label13.Text;
                    ListaVenta[fila, 1] = lbNom.Text;
                    ListaVenta[fila, 2] = lbTamaño.Text;
                    ListaVenta[fila, 3] = lbPrecioo.Text;
                    ListaVenta[fila, 4] = txtCant.Text;
                    ListaVenta[fila, 5] = (float.Parse(lbPrecioo.Text) * int.Parse(txtCant.Text)).ToString(); ;

                    dtgLista.Rows.Add(ListaVenta[fila, 0], ListaVenta[fila, 1], ListaVenta[fila, 2], ListaVenta[fila, 3], ListaVenta[fila, 4], ListaVenta[fila, 5]);
                    fila++;
                    label13.Text = "***";
                    lbNom.Text = "***";
                    lbTamaño.Text = "***";
                    lbPrecioo.Text = "***";
                    txtCant.Text = "";
                    txtCant.Focus();
                }
            }
            catch
            {
            }
            costoAPagar();
        }
        public void costoAPagar()
        {
            float costoTtl = 0;
            int cont = 0;
            cont = dtgLista.RowCount;

            for (int i = 0; i < cont; i++)
            {
                costoTtl += float.Parse(dtgLista.Rows[i].Cells[5].Value.ToString());
            }
            lbApagar.Text = costoTtl.ToString();

        }
        private void btnVinos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelVinos);
        }

        private void btnLicores_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelLicores);
        }

        private void btnTequilas_Click(object sender, EventArgs e)
        {
            TequilasAdm tequilas = new TequilasAdm();
            AddOwnedForm(tequilas);
            openChildForm((tequilas));
            tequilas.Show();
            hideSubMenu();
        }

        private void btnCervezas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelCervezas);
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            AlimentosAdm A = new AlimentosAdm();
            AddOwnedForm(A);
            openChildForm((A));
            A.Show();
            hideSubMenu();
        }

        private void btnVBlanco_Click(object sender, EventArgs e)
        {
            VinoBlancoAdm VB = new VinoBlancoAdm();
            AddOwnedForm(VB);
            openChildForm((VB));
            VB.Show();
            hideSubMenu();
        }

        private void btnChampaña_Click(object sender, EventArgs e)
        {
            Champaña ch = new Champaña();
            AddOwnedForm(ch);
            openChildForm((ch));
            ch.Show();
            hideSubMenu();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lbApagar.Text)).ToString();
            }
            catch
            {
                lbDevolucion.Text = "0.00";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEfectivo.Text == "")
            {
                MessageBox.Show("Intente nuevamente");
                txtEfectivo.Focus();
            }
            else
            {
                clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

                Ticket1.TextoCentro("Fake Gods Licores "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("Dirc: xxxx");
                Ticket1.TextoIzquierda("Tel: 3005758109 ");
                Ticket1.TextoIzquierda("Rnc: xxxx");
                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Fac:");
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoIzquierda("");
                clsFunciones.CreaTicket.LineasGuion();

                clsFunciones.CreaTicket.EncabezadoVenta();
                clsFunciones.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in dtgLista.Rows)
                {
                    // Articulo                     //Precio                                                                   cantidad                                                Subtotal
                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[4].Value.ToString()), double.Parse(r.Cells[5].Value.ToString())); //imprime una linea de descripcion
                }


                clsFunciones.CreaTicket.LineasGuion();
                Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
                Ticket1.AgregaTotales("Descuento", double.Parse("000")); // imprime linea con decuento total
                Ticket1.AgregaTotales("Iva ", double.Parse("000")); // imprime linea con ITBis total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", double.Parse(lbApagar.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lbDevolucion.Text));


                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);




                fila = 0;
                while (dtgLista.RowCount > 0)//limpia el dgv
                { dtgLista.Rows.Remove(dtgLista.CurrentRow); }
                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

                label13.Text = "***";
                lbNom.Text = "***";
                lbTamaño.Text = "***";
                lbPrecioo.Text = "***";
                txtCant.Text = "";
                lbApagar.Text = lbDevolucion.Text = "0.00";
                txtEfectivo.Text = "";
                txtCant.Focus();
                MessageBox.Show("Gracias por preferirnos");
            }


        }

        private void btnEspumoso_Click(object sender, EventArgs e)
        {
            EspumosoAdm espumoso = new EspumosoAdm();
            AddOwnedForm(espumoso);
            openChildForm((espumoso));
            espumoso.Show();
            hideSubMenu();
        }

        private void btnRon_Click(object sender, EventArgs e)
        {
            RonesAdm Ron = new RonesAdm();
            AddOwnedForm(Ron);
            openChildForm((Ron));
            Ron.Show();
            hideSubMenu();
        }

        private void btnVodka_Click(object sender, EventArgs e)
        {
            vodkaAdm VK = new vodkaAdm();
            AddOwnedForm(VK);
            openChildForm((VK));
            VK.Show();
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AguardienteAdm aguardiente = new AguardienteAdm();
            AddOwnedForm(aguardiente);
            openChildForm((aguardiente));
            aguardiente.Show();
            hideSubMenu();
        }

        private void btnCerveza_Nacional_Click(object sender, EventArgs e)
        {
            NacionalesAdm nacionales = new NacionalesAdm();
            AddOwnedForm(nacionales);
            openChildForm((nacionales));
            nacionales.Show();
            hideSubMenu();
        }
        private void btnEnergizantes_Click(object sender, EventArgs e)
        {
            EnergizantesAdm VK = new EnergizantesAdm();
            AddOwnedForm(VK);
            openChildForm((VK));
            VK.Show();
            hideSubMenu();
        }

        private void pcSalir_Click(object sender, EventArgs e)
        {
            Administrador adm = new Administrador();
            adm.lbUsuarioAdm.Text = lbMensaje.Text;
            adm.Show();
            this.Close(); 
        }
    }
}
