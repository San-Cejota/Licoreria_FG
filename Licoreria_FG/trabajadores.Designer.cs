namespace Licoreria_FG
{
    partial class trabajadores
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
            dtgEmpleados = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgEmpleados
            // 
            dtgEmpleados.AllowUserToAddRows = false;
            dtgEmpleados.AllowUserToDeleteRows = false;
            dtgEmpleados.Anchor = AnchorStyles.None;
            dtgEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmpleados.Location = new Point(65, 117);
            dtgEmpleados.Name = "dtgEmpleados";
            dtgEmpleados.ReadOnly = true;
            dtgEmpleados.RowTemplate.Height = 25;
            dtgEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpleados.Size = new Size(619, 229);
            dtgEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(210, 23);
            label1.Name = "label1";
            label1.Size = new Size(329, 37);
            label1.TabIndex = 1;
            label1.Text = "Nuestros empleados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.boton;
            pictureBox1.Location = new Point(763, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // trabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 109, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dtgEmpleados);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "trabajadores";
            Text = "trabajadores";
            Load += trabajadores_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgEmpleados;
        private Label label1;
        private PictureBox pictureBox1;
    }
}