namespace Licoreria_FG
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            panel1 = new Panel();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            pictureBox4 = new PictureBox();
            btnEntrar = new Button();
            pictureBox2 = new PictureBox();
            pbContraseña = new PictureBox();
            lblNombre = new Label();
            pictureBox3 = new PictureBox();
            pbNombre = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbContraseña).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbNombre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(39, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.Black;
            txtUser.Location = new Point(57, 135);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(166, 19);
            txtUser.TabIndex = 0;
            txtUser.Tag = "Nombre";
            txtUser.Enter += txtEnter;
            txtUser.Leave += txtLeavel;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(244, 248, 230);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(lblContraseña);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pbContraseña);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtUser);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pbNombre);
            panel1.Location = new Point(414, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 316);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.White;
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.Location = new Point(57, 198);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(166, 19);
            txtContraseña.TabIndex = 1;
            txtContraseña.Tag = "Contraseña";
            txtContraseña.Enter += txtEnter;
            txtContraseña.Leave += txtLeavel;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContraseña.Location = new Point(57, 177);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(97, 18);
            lblContraseña.TabIndex = 13;
            lblContraseña.Text = "Contraseña:";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(53, 188);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(177, 40);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(22, 13, 24);
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(242, 228, 249);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.FromArgb(242, 228, 249);
            btnEntrar.Location = new Point(97, 263);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(91, 32);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario;
            pictureBox2.Location = new Point(70, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pbContraseña
            // 
            pbContraseña.BackColor = Color.Black;
            pbContraseña.Location = new Point(51, 186);
            pbContraseña.Name = "pbContraseña";
            pbContraseña.Size = new Size(181, 44);
            pbContraseña.TabIndex = 12;
            pbContraseña.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(57, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 18);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Usuario:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(53, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(177, 40);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pbNombre
            // 
            pbNombre.BackColor = Color.Black;
            pbNombre.Location = new Point(51, 123);
            pbNombre.Name = "pbNombre";
            pbNombre.Size = new Size(181, 44);
            pbNombre.TabIndex = 8;
            pbNombre.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(86, 126, 187);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 44);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Demi", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(313, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 7;
            label3.Text = "Login";
            // 
            // pictureBox5
            // 
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.boton;
            pictureBox5.Location = new Point(747, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 76, 126);
            ClientSize = new Size(782, 446);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(pictureBox5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbContraseña).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbNombre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private Panel panel1;
        private Button btnEntrar;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label lblNombre;
        private PictureBox pictureBox3;
        private PictureBox pbNombre;
        private Label label3;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private PictureBox pictureBox4;
        private PictureBox pbContraseña;
        private PictureBox pictureBox5;
    }
}