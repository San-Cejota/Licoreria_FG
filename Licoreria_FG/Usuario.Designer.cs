namespace Licoreria_FG
{
    partial class Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            lbMensaje = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            btnContacto = new Button();
            btnAlimentos = new Button();
            panelCervezas = new Panel();
            btnEnergizantes = new Button();
            btnCerveza_Nacional = new Button();
            btnCervezas = new Button();
            btnTequilas = new Button();
            panelLicores = new Panel();
            button8 = new Button();
            btnVodka = new Button();
            btnRon = new Button();
            btnLicores = new Button();
            panelVinos = new Panel();
            btnEspumoso = new Button();
            btnChampaña = new Button();
            btnVBlanco = new Button();
            btnVinos = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            panelCervezas.SuspendLayout();
            panelLicores.SuspendLayout();
            panelVinos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(96, 109, 128);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Location = new Point(216, 52);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(636, 522);
            panelContenedor.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(140, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(361, 268);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(220, 224, 230);
            panel2.Controls.Add(lbMensaje);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(216, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 52);
            panel2.TabIndex = 5;
            // 
            // lbMensaje
            // 
            lbMensaje.AutoSize = true;
            lbMensaje.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMensaje.Location = new Point(100, 19);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(0, 21);
            lbMensaje.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 23);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 3;
            label1.Text = "Hola,";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.salida;
            pictureBox3.Location = new Point(582, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 76, 126);
            panel1.Controls.Add(btnContacto);
            panel1.Controls.Add(btnAlimentos);
            panel1.Controls.Add(panelCervezas);
            panel1.Controls.Add(btnCervezas);
            panel1.Controls.Add(btnTequilas);
            panel1.Controls.Add(panelLicores);
            panel1.Controls.Add(btnLicores);
            panel1.Controls.Add(panelVinos);
            panel1.Controls.Add(btnVinos);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 628);
            panel1.TabIndex = 4;
            // 
            // btnContacto
            // 
            btnContacto.Dock = DockStyle.Top;
            btnContacto.FlatAppearance.BorderSize = 0;
            btnContacto.FlatStyle = FlatStyle.Flat;
            btnContacto.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnContacto.ForeColor = Color.White;
            btnContacto.Location = new Point(0, 566);
            btnContacto.Margin = new Padding(4);
            btnContacto.Name = "btnContacto";
            btnContacto.Padding = new Padding(10, 0, 0, 0);
            btnContacto.Size = new Size(216, 36);
            btnContacto.TabIndex = 20;
            btnContacto.Text = "Contacto";
            btnContacto.TextAlign = ContentAlignment.MiddleLeft;
            btnContacto.UseVisualStyleBackColor = true;
            btnContacto.Click += btnContacto_Click;
            // 
            // btnAlimentos
            // 
            btnAlimentos.Dock = DockStyle.Top;
            btnAlimentos.FlatAppearance.BorderSize = 0;
            btnAlimentos.FlatStyle = FlatStyle.Flat;
            btnAlimentos.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlimentos.ForeColor = Color.White;
            btnAlimentos.Location = new Point(0, 530);
            btnAlimentos.Margin = new Padding(4);
            btnAlimentos.Name = "btnAlimentos";
            btnAlimentos.Padding = new Padding(10, 0, 0, 0);
            btnAlimentos.Size = new Size(216, 36);
            btnAlimentos.TabIndex = 19;
            btnAlimentos.Text = "Alimentos";
            btnAlimentos.TextAlign = ContentAlignment.MiddleLeft;
            btnAlimentos.UseVisualStyleBackColor = true;
            btnAlimentos.Click += btnAlimentos_Click;
            // 
            // panelCervezas
            // 
            panelCervezas.BackColor = Color.FromArgb(86, 126, 187);
            panelCervezas.Controls.Add(btnEnergizantes);
            panelCervezas.Controls.Add(btnCerveza_Nacional);
            panelCervezas.Dock = DockStyle.Top;
            panelCervezas.Location = new Point(0, 440);
            panelCervezas.Name = "panelCervezas";
            panelCervezas.Size = new Size(216, 90);
            panelCervezas.TabIndex = 18;
            // 
            // btnEnergizantes
            // 
            btnEnergizantes.Dock = DockStyle.Top;
            btnEnergizantes.FlatAppearance.BorderSize = 0;
            btnEnergizantes.FlatStyle = FlatStyle.Flat;
            btnEnergizantes.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnergizantes.ForeColor = Color.White;
            btnEnergizantes.Location = new Point(0, 50);
            btnEnergizantes.Name = "btnEnergizantes";
            btnEnergizantes.Padding = new Padding(30, 0, 0, 0);
            btnEnergizantes.Size = new Size(216, 34);
            btnEnergizantes.TabIndex = 10;
            btnEnergizantes.Text = "Energizantes";
            btnEnergizantes.TextAlign = ContentAlignment.MiddleLeft;
            btnEnergizantes.UseVisualStyleBackColor = true;
            btnEnergizantes.Click += btnEnergizantes_Click;
            // 
            // btnCerveza_Nacional
            // 
            btnCerveza_Nacional.Dock = DockStyle.Top;
            btnCerveza_Nacional.FlatAppearance.BorderSize = 0;
            btnCerveza_Nacional.FlatStyle = FlatStyle.Flat;
            btnCerveza_Nacional.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerveza_Nacional.ForeColor = Color.Snow;
            btnCerveza_Nacional.Location = new Point(0, 0);
            btnCerveza_Nacional.Name = "btnCerveza_Nacional";
            btnCerveza_Nacional.Padding = new Padding(30, 0, 0, 0);
            btnCerveza_Nacional.Size = new Size(216, 50);
            btnCerveza_Nacional.TabIndex = 8;
            btnCerveza_Nacional.Text = "Nacionales e Importadas";
            btnCerveza_Nacional.TextAlign = ContentAlignment.MiddleLeft;
            btnCerveza_Nacional.UseVisualStyleBackColor = true;
            btnCerveza_Nacional.Click += btnCerveza_Nacional_Click;
            // 
            // btnCervezas
            // 
            btnCervezas.Dock = DockStyle.Top;
            btnCervezas.FlatAppearance.BorderSize = 0;
            btnCervezas.FlatStyle = FlatStyle.Flat;
            btnCervezas.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCervezas.ForeColor = Color.White;
            btnCervezas.Location = new Point(0, 404);
            btnCervezas.Margin = new Padding(4);
            btnCervezas.Name = "btnCervezas";
            btnCervezas.Padding = new Padding(10, 0, 0, 0);
            btnCervezas.Size = new Size(216, 36);
            btnCervezas.TabIndex = 17;
            btnCervezas.Text = "Cervezas y bebidas";
            btnCervezas.TextAlign = ContentAlignment.MiddleLeft;
            btnCervezas.UseVisualStyleBackColor = true;
            btnCervezas.Click += btnCervezas_Click;
            // 
            // btnTequilas
            // 
            btnTequilas.Dock = DockStyle.Top;
            btnTequilas.FlatAppearance.BorderSize = 0;
            btnTequilas.FlatStyle = FlatStyle.Flat;
            btnTequilas.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTequilas.ForeColor = Color.White;
            btnTequilas.Location = new Point(0, 368);
            btnTequilas.Margin = new Padding(4);
            btnTequilas.Name = "btnTequilas";
            btnTequilas.Padding = new Padding(10, 0, 0, 0);
            btnTequilas.Size = new Size(216, 36);
            btnTequilas.TabIndex = 15;
            btnTequilas.Text = "Tequilas";
            btnTequilas.TextAlign = ContentAlignment.MiddleLeft;
            btnTequilas.UseVisualStyleBackColor = true;
            btnTequilas.Click += btnTequilas_Click;
            // 
            // panelLicores
            // 
            panelLicores.BackColor = Color.FromArgb(86, 126, 187);
            panelLicores.Controls.Add(button8);
            panelLicores.Controls.Add(btnVodka);
            panelLicores.Controls.Add(btnRon);
            panelLicores.Dock = DockStyle.Top;
            panelLicores.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelLicores.ForeColor = Color.Snow;
            panelLicores.Location = new Point(0, 268);
            panelLicores.Name = "panelLicores";
            panelLicores.Size = new Size(216, 100);
            panelLicores.TabIndex = 14;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Top;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(0, 60);
            button8.Name = "button8";
            button8.Padding = new Padding(30, 0, 0, 0);
            button8.Size = new Size(216, 33);
            button8.TabIndex = 3;
            button8.Text = "Aguardientes";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // btnVodka
            // 
            btnVodka.Dock = DockStyle.Top;
            btnVodka.FlatAppearance.BorderSize = 0;
            btnVodka.FlatStyle = FlatStyle.Flat;
            btnVodka.Location = new Point(0, 30);
            btnVodka.Name = "btnVodka";
            btnVodka.Padding = new Padding(30, 0, 0, 0);
            btnVodka.Size = new Size(216, 30);
            btnVodka.TabIndex = 1;
            btnVodka.Text = "Vodka";
            btnVodka.TextAlign = ContentAlignment.MiddleLeft;
            btnVodka.UseVisualStyleBackColor = true;
            btnVodka.Click += btnVodka_Click;
            // 
            // btnRon
            // 
            btnRon.Dock = DockStyle.Top;
            btnRon.FlatAppearance.BorderSize = 0;
            btnRon.FlatStyle = FlatStyle.Flat;
            btnRon.Location = new Point(0, 0);
            btnRon.Name = "btnRon";
            btnRon.Padding = new Padding(30, 0, 0, 0);
            btnRon.Size = new Size(216, 30);
            btnRon.TabIndex = 0;
            btnRon.Text = "Rones";
            btnRon.TextAlign = ContentAlignment.MiddleLeft;
            btnRon.UseVisualStyleBackColor = true;
            btnRon.Click += btnRon_Click;
            // 
            // btnLicores
            // 
            btnLicores.Dock = DockStyle.Top;
            btnLicores.FlatAppearance.BorderSize = 0;
            btnLicores.FlatStyle = FlatStyle.Flat;
            btnLicores.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLicores.ForeColor = Color.White;
            btnLicores.Location = new Point(0, 232);
            btnLicores.Margin = new Padding(4);
            btnLicores.Name = "btnLicores";
            btnLicores.Padding = new Padding(10, 0, 0, 0);
            btnLicores.Size = new Size(216, 36);
            btnLicores.TabIndex = 13;
            btnLicores.Text = "Licores";
            btnLicores.TextAlign = ContentAlignment.MiddleLeft;
            btnLicores.UseVisualStyleBackColor = true;
            btnLicores.Click += btnLicores_Click;
            // 
            // panelVinos
            // 
            panelVinos.BackColor = Color.FromArgb(86, 126, 187);
            panelVinos.Controls.Add(btnEspumoso);
            panelVinos.Controls.Add(btnChampaña);
            panelVinos.Controls.Add(btnVBlanco);
            panelVinos.Dock = DockStyle.Top;
            panelVinos.Location = new Point(0, 136);
            panelVinos.Margin = new Padding(4);
            panelVinos.Name = "panelVinos";
            panelVinos.Size = new Size(216, 96);
            panelVinos.TabIndex = 12;
            // 
            // btnEspumoso
            // 
            btnEspumoso.Dock = DockStyle.Top;
            btnEspumoso.FlatAppearance.BorderSize = 0;
            btnEspumoso.FlatStyle = FlatStyle.Flat;
            btnEspumoso.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEspumoso.ForeColor = Color.Snow;
            btnEspumoso.Location = new Point(0, 60);
            btnEspumoso.Margin = new Padding(4);
            btnEspumoso.Name = "btnEspumoso";
            btnEspumoso.Padding = new Padding(30, 0, 0, 0);
            btnEspumoso.Size = new Size(216, 30);
            btnEspumoso.TabIndex = 2;
            btnEspumoso.Text = "Espumosos";
            btnEspumoso.TextAlign = ContentAlignment.MiddleLeft;
            btnEspumoso.UseVisualStyleBackColor = true;
            btnEspumoso.Click += btnEspumoso_Click;
            // 
            // btnChampaña
            // 
            btnChampaña.Dock = DockStyle.Top;
            btnChampaña.FlatAppearance.BorderSize = 0;
            btnChampaña.FlatStyle = FlatStyle.Flat;
            btnChampaña.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChampaña.ForeColor = Color.Snow;
            btnChampaña.Location = new Point(0, 30);
            btnChampaña.Margin = new Padding(4);
            btnChampaña.Name = "btnChampaña";
            btnChampaña.Padding = new Padding(30, 0, 0, 0);
            btnChampaña.Size = new Size(216, 30);
            btnChampaña.TabIndex = 1;
            btnChampaña.Text = "Champañas";
            btnChampaña.TextAlign = ContentAlignment.MiddleLeft;
            btnChampaña.UseVisualStyleBackColor = true;
            btnChampaña.Click += btnChampaña_Click;
            // 
            // btnVBlanco
            // 
            btnVBlanco.Dock = DockStyle.Top;
            btnVBlanco.FlatAppearance.BorderSize = 0;
            btnVBlanco.FlatStyle = FlatStyle.Flat;
            btnVBlanco.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVBlanco.ForeColor = Color.Snow;
            btnVBlanco.Location = new Point(0, 0);
            btnVBlanco.Margin = new Padding(4);
            btnVBlanco.Name = "btnVBlanco";
            btnVBlanco.Padding = new Padding(30, 0, 0, 0);
            btnVBlanco.Size = new Size(216, 30);
            btnVBlanco.TabIndex = 0;
            btnVBlanco.Text = "Blanco";
            btnVBlanco.TextAlign = ContentAlignment.MiddleLeft;
            btnVBlanco.UseVisualStyleBackColor = true;
            btnVBlanco.Click += btnVBlanco_Click;
            // 
            // btnVinos
            // 
            btnVinos.Dock = DockStyle.Top;
            btnVinos.FlatAppearance.BorderSize = 0;
            btnVinos.FlatStyle = FlatStyle.Flat;
            btnVinos.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVinos.ForeColor = Color.White;
            btnVinos.Location = new Point(0, 100);
            btnVinos.Margin = new Padding(4);
            btnVinos.Name = "btnVinos";
            btnVinos.Padding = new Padding(10, 0, 0, 0);
            btnVinos.Size = new Size(216, 36);
            btnVinos.TabIndex = 11;
            btnVinos.Text = "Vinos";
            btnVinos.TextAlign = ContentAlignment.MiddleLeft;
            btnVinos.UseVisualStyleBackColor = true;
            btnVinos.Click += btnVinos_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(216, 100);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.letras;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(220, 224, 230);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(216, 573);
            panel3.Name = "panel3";
            panel3.Size = new Size(635, 55);
            panel3.TabIndex = 8;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 628);
            Controls.Add(panel3);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuario";
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panelCervezas.ResumeLayout(false);
            panelLicores.ResumeLayout(false);
            panelVinos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel1;
        private Button btnAlimentos;
        private Panel panelCervezas;
        private Button btnEnergizantes;
        private Button btnCerveza_Nacional;
        private Button btnCervezas;
        private Button btnTequilas;
        private Panel panelLicores;
        private Button button8;
        private Button btnVodka;
        private Button btnRon;
        private Button btnLicores;
        private Panel panelVinos;
        private Button btnEspumoso;
        private Button btnChampaña;
        private Button btnVBlanco;
        private Button btnVinos;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnContacto;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label1;
        public Label lbMensaje;
    }
}