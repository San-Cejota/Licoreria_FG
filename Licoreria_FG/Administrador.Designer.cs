namespace Licoreria_FG
{
    partial class Administrador
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
            panel1 = new Panel();
            lbUsuarioAdm = new Label();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pcbTrabajadores = new PictureBox();
            pictureBox4 = new PictureBox();
            panelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            panelCaja = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTrabajadores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 76, 126);
            panel1.Controls.Add(lbUsuarioAdm);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.ForeColor = Color.Gainsboro;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 628);
            panel1.TabIndex = 0;
            // 
            // lbUsuarioAdm
            // 
            lbUsuarioAdm.AutoSize = true;
            lbUsuarioAdm.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsuarioAdm.ForeColor = Color.White;
            lbUsuarioAdm.Location = new Point(89, 117);
            lbUsuarioAdm.Name = "lbUsuarioAdm";
            lbUsuarioAdm.Size = new Size(0, 21);
            lbUsuarioAdm.TabIndex = 3;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.user;
            pictureBox6.Location = new Point(12, 104);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(71, 59);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.letras;
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 31, 32);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pcbTrabajadores);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(216, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 52);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.salida;
            pictureBox3.Location = new Point(691, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pcbTrabajadores
            // 
            pcbTrabajadores.Cursor = Cursors.Hand;
            pcbTrabajadores.Image = Properties.Resources.empleados;
            pcbTrabajadores.Location = new Point(80, 0);
            pcbTrabajadores.Name = "pcbTrabajadores";
            pcbTrabajadores.Size = new Size(62, 50);
            pcbTrabajadores.SizeMode = PictureBoxSizeMode.Zoom;
            pcbTrabajadores.TabIndex = 2;
            pcbTrabajadores.TabStop = false;
            pcbTrabajadores.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.cajero_automatico;
            pictureBox4.Location = new Point(16, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(96, 109, 128);
            panelContenedor.Controls.Add(pictureBox2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(216, 52);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(748, 521);
            panelContenedor.TabIndex = 3;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(195, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(361, 268);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelCaja
            // 
            panelCaja.BackColor = Color.FromArgb(220, 224, 230);
            panelCaja.Dock = DockStyle.Bottom;
            panelCaja.Location = new Point(216, 573);
            panelCaja.Name = "panelCaja";
            panelCaja.Size = new Size(748, 55);
            panelCaja.TabIndex = 2;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 628);
            Controls.Add(panelContenedor);
            Controls.Add(panelCaja);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Administrador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            Load += Administrador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTrabajadores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelContenedor;
        private PictureBox pictureBox2;
        private Panel panelCaja;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pcbTrabajadores;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        public Label lbUsuarioAdm;
    }
}