namespace Licoreria_FG
{
    partial class Caja
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
            dtgLista = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Tamaño = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cant = new DataGridViewTextBoxColumn();
            subTTl = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lbApagar = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            lbDevolucion = new Label();
            label5 = new Label();
            txtEfectivo = new TextBox();
            lb = new Label();
            label9 = new Label();
            label10 = new Label();
            btnAgg = new Button();
            lbNombre = new Label();
            lbPrecio = new Label();
            lbSize = new Label();
            label11 = new Label();
            lbID = new Label();
            label12 = new Label();
            panel3 = new Panel();
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
            button2 = new Button();
            label13 = new Label();
            lbNom = new Label();
            lbTamaño = new Label();
            lbPrecioo = new Label();
            panelDatos = new Panel();
            txtCant = new TextBox();
            pcSalir = new PictureBox();
            lbMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgLista).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelCervezas.SuspendLayout();
            panelLicores.SuspendLayout();
            panelVinos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcSalir).BeginInit();
            SuspendLayout();
            // 
            // dtgLista
            // 
            dtgLista.AllowUserToAddRows = false;
            dtgLista.AllowUserToDeleteRows = false;
            dtgLista.Anchor = AnchorStyles.None;
            dtgLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgLista.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dtgLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLista.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Tamaño, Precio, Cant, subTTl });
            dtgLista.Location = new Point(223, 212);
            dtgLista.Name = "dtgLista";
            dtgLista.ReadOnly = true;
            dtgLista.RowTemplate.Height = 25;
            dtgLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgLista.Size = new Size(546, 172);
            dtgLista.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Tamaño
            // 
            Tamaño.HeaderText = "Tamaño";
            Tamaño.Name = "Tamaño";
            Tamaño.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cant
            // 
            Cant.HeaderText = "Cantidad";
            Cant.Name = "Cant";
            Cant.ReadOnly = true;
            // 
            // subTTl
            // 
            subTTl.HeaderText = "SubTotal";
            subTTl.Name = "subTTl";
            subTTl.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(800, 36);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 2;
            label1.Text = "Total a pagar";
            // 
            // lbApagar
            // 
            lbApagar.AutoSize = true;
            lbApagar.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbApagar.ForeColor = Color.Red;
            lbApagar.Location = new Point(33, 6);
            lbApagar.Name = "lbApagar";
            lbApagar.Size = new Size(48, 24);
            lbApagar.TabIndex = 3;
            lbApagar.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Demi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(24, 26);
            label3.TabIndex = 4;
            label3.Text = "$";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Ivory;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbApagar);
            panel1.Location = new Point(773, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 33);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(800, 111);
            label4.Name = "label4";
            label4.Size = new Size(101, 24);
            label4.TabIndex = 6;
            label4.Text = "Devolución";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lbDevolucion);
            panel2.Location = new Point(773, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 35);
            panel2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Demi", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(24, 26);
            label7.TabIndex = 4;
            label7.Text = "$";
            // 
            // lbDevolucion
            // 
            lbDevolucion.AutoSize = true;
            lbDevolucion.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbDevolucion.ForeColor = Color.FromArgb(0, 192, 0);
            lbDevolucion.Location = new Point(33, 6);
            lbDevolucion.Name = "lbDevolucion";
            lbDevolucion.Size = new Size(48, 24);
            lbDevolucion.TabIndex = 3;
            lbDevolucion.Text = "0.00";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(816, 212);
            label5.Name = "label5";
            label5.Size = new Size(83, 24);
            label5.TabIndex = 7;
            label5.Text = "Efectivo:";
            // 
            // txtEfectivo
            // 
            txtEfectivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtEfectivo.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEfectivo.Location = new Point(810, 239);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(109, 26);
            txtEfectivo.TabIndex = 8;
            txtEfectivo.TextChanged += txtEfectivo_TextChanged;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb.Location = new Point(294, 40);
            lb.Name = "lb";
            lb.Size = new Size(63, 20);
            lb.TabIndex = 10;
            lb.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(294, 100);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 11;
            label9.Text = "Precio:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(294, 130);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 12;
            label10.Text = "Cantidad:";
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(294, 173);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(309, 23);
            btnAgg.TabIndex = 14;
            btnAgg.Text = "Agregar a la lista";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombre.Location = new Point(448, 102);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(0, 20);
            lbNombre.TabIndex = 15;
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrecio.ForeColor = Color.Black;
            lbPrecio.Location = new Point(669, 168);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(0, 20);
            lbPrecio.TabIndex = 16;
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSize.Location = new Point(556, 109);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(0, 20);
            lbSize.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(294, 70);
            label11.Name = "label11";
            label11.Size = new Size(64, 20);
            label11.TabIndex = 17;
            label11.Text = "Tamaño:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbID.Location = new Point(63, 44);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 20);
            lbID.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(294, 10);
            label12.Name = "label12";
            label12.Size = new Size(27, 20);
            label12.TabIndex = 19;
            label12.Text = "ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 76, 126);
            panel3.Controls.Add(btnAlimentos);
            panel3.Controls.Add(panelCervezas);
            panel3.Controls.Add(btnCervezas);
            panel3.Controls.Add(btnTequilas);
            panel3.Controls.Add(panelLicores);
            panel3.Controls.Add(btnLicores);
            panel3.Controls.Add(panelVinos);
            panel3.Controls.Add(btnVinos);
            panel3.Controls.Add(panelLogo);
            panel3.Dock = DockStyle.Left;
            panel3.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.ForeColor = Color.Gainsboro;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 628);
            panel3.TabIndex = 26;
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
            btnEnergizantes.ForeColor = Color.Snow;
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
            pictureBox1.Image = Properties.Resources.fg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(0, 192, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(798, 298);
            button2.Name = "button2";
            button2.Size = new Size(150, 59);
            button2.TabIndex = 26;
            button2.Text = "Vender";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(364, 10);
            label13.Name = "label13";
            label13.Size = new Size(36, 20);
            label13.TabIndex = 28;
            label13.Text = "***";
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbNom.Location = new Point(364, 40);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(36, 20);
            lbNom.TabIndex = 28;
            lbNom.Text = "***";
            // 
            // lbTamaño
            // 
            lbTamaño.AutoSize = true;
            lbTamaño.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTamaño.Location = new Point(364, 70);
            lbTamaño.Name = "lbTamaño";
            lbTamaño.Size = new Size(36, 20);
            lbTamaño.TabIndex = 28;
            lbTamaño.Text = "***";
            // 
            // lbPrecioo
            // 
            lbPrecioo.AutoSize = true;
            lbPrecioo.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrecioo.Location = new Point(364, 100);
            lbPrecioo.Name = "lbPrecioo";
            lbPrecioo.Size = new Size(36, 20);
            lbPrecioo.TabIndex = 28;
            lbPrecioo.Text = "***";
            // 
            // panelDatos
            // 
            panelDatos.BackColor = Color.FromArgb(220, 224, 230);
            panelDatos.Dock = DockStyle.Bottom;
            panelDatos.Location = new Point(216, 398);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(748, 230);
            panelDatos.TabIndex = 29;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(371, 126);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(58, 23);
            txtCant.TabIndex = 30;
            // 
            // pcSalir
            // 
            pcSalir.Cursor = Cursors.Hand;
            pcSalir.Image = Properties.Resources.boton;
            pcSalir.Location = new Point(925, 0);
            pcSalir.Name = "pcSalir";
            pcSalir.Size = new Size(39, 33);
            pcSalir.SizeMode = PictureBoxSizeMode.Zoom;
            pcSalir.TabIndex = 31;
            pcSalir.TabStop = false;
            pcSalir.Click += pcSalir_Click;
            // 
            // lbMensaje
            // 
            lbMensaje.AutoSize = true;
            lbMensaje.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbMensaje.Location = new Point(625, 9);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(0, 20);
            lbMensaje.TabIndex = 19;
            // 
            // Caja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 109, 128);
            ClientSize = new Size(964, 628);
            Controls.Add(pcSalir);
            Controls.Add(txtCant);
            Controls.Add(panelDatos);
            Controls.Add(lbPrecioo);
            Controls.Add(lbTamaño);
            Controls.Add(lbNom);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(panel3);
            Controls.Add(lbID);
            Controls.Add(lbMensaje);
            Controls.Add(label12);
            Controls.Add(lbSize);
            Controls.Add(label11);
            Controls.Add(lbPrecio);
            Controls.Add(lbNombre);
            Controls.Add(btnAgg);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lb);
            Controls.Add(txtEfectivo);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dtgLista);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Caja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caja";
            Load += Caja_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLista).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panelCervezas.ResumeLayout(false);
            panelLicores.ResumeLayout(false);
            panelVinos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcSalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lbApagar;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label7;
        private Label lbDevolucion;
        private Label label5;
        private TextBox txtEfectivo;
        private Label lb;
        private Label label9;
        private Label label10;
        private Button btnAgg;
        private Label label6;
        private Label label11;
        public Label lbNombre;
        public DataGridView dtgLista;
        public Label lbSize;
        public Label lbID;
        private Label label12;
        public Label lbPrecio;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tamaño;
        private DataGridViewTextBoxColumn Precio;
        private Panel panel3;
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
        private DataGridViewTextBoxColumn Cant;
        private DataGridViewTextBoxColumn subTTl;
        private Button button2;
        public Label label13;
        public Label lbTamaño;
        public Label lbPrecioo;
        public Label lbNom;
        private Panel panelDatos;
        private TextBox txtCant;
        private PictureBox pcSalir;
        public Label lbMensaje;
    }
}