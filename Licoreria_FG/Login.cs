using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net;

namespace Licoreria_FG
{
    public partial class Login : Form
    {
        clsConexion con = new clsConexion();
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cnx;
        public void open()
        {
            string nombre_servidor = Dns.GetHostName();
            cnx = new SqlConnection("Data Source= "+nombre_servidor+"\\SQLEXPRESS;Initial Catalog=Licoreria;Integrated Security=True");
            cnx.Open();
            MessageBox.Show("Se creo una conexion");
        }

        
        public void logear(string usuario, string contrasena)
        {
            try
            {
                open();
                //cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombres, Tipo_usuario FROM Usuarioss WHERE Usuario = @usu AND Password = @pas", cnx );
                cmd.Parameters.AddWithValue("usu", usuario);
                cmd.Parameters.AddWithValue("pas", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        this.Hide();
                        Bienvenida welcome = new Bienvenida(dt.Rows[0][0].ToString());
                        welcome.ShowDialog();
                        Administrador admin = new Administrador();
                        admin.lbUsuarioAdm.Text = dt.Rows[0][0].ToString();
                        admin.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        this.Hide();
                        Bienvenida welcome = new Bienvenida(dt.Rows[0][0].ToString());
                        welcome.ShowDialog();
                        Usuario user = new Usuario();
                        user.lbMensaje.Text = dt.Rows[0][0].ToString();
                        user.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");

                    txtUser.Text = "";
                    txtContraseña.Text = "";
                    txtUser.Focus();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
            }
            finally
            {
               
            }
        }




        private void btnEntrar_Click(object sender, EventArgs e)
        {
            logear(this.txtUser.Text, this.txtContraseña.Text);

            //if (txtUser.Text == "Carlos")
            //{
            //    if (txtContraseña.Text == "2010")
            //    {
            //        if (radioButton1.Checked == true)
            //        {
            //            this.Hide();
            //            Bienvenida welcome = new Bienvenida();
            //            welcome.ShowDialog();
            //            Administrador admin = new Administrador();
            //            admin.Show();
            //        }
            //        if (radioButton2.Checked == true)
            //        {
            //            this.Hide();
            //            Bienvenida welcome = new Bienvenida();
            //            welcome.ShowDialog();
            //            Usuario user = new Usuario();
            //            user.Show();
            //        }

            //    }
            //    lbMensaje.Text = "Contraseña Incorrecta";
            //    txtUser.Text = "";
            //    txtContraseña.Text = "";
            //    txtUser.Focus();
            //}
            //lbMensaje.Text = "Usuario Incorrecto";
            //txtUser.Text = "";
            //txtContraseña.Text = "";
            //txtUser.Focus();


        }
        private void txtEnter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is PictureBox && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }
                if (ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }
        private void txtLeavel(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is PictureBox && ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.Black;
                    }

                }
                if (ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.Black;
                    }

                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}