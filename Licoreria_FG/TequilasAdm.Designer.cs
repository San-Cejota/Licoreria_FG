namespace Licoreria_FG
{
    partial class TequilasAdm
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
            dtgvTequilas = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvTequilas).BeginInit();
            SuspendLayout();
            // 
            // dtgvTequilas
            // 
            dtgvTequilas.AllowUserToDeleteRows = false;
            dtgvTequilas.Anchor = AnchorStyles.None;
            dtgvTequilas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTequilas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTequilas.Location = new Point(50, 30);
            dtgvTequilas.Name = "dtgvTequilas";
            dtgvTequilas.RowHeadersVisible = false;
            dtgvTequilas.RowTemplate.Height = 25;
            dtgvTequilas.Size = new Size(555, 180);
            dtgvTequilas.TabIndex = 1;
            dtgvTequilas.DoubleClick += dtgvTequilas_DoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 47, 33);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(247, 247, 247);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TequilasAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 224, 230);
            ClientSize = new Size(650, 230);
            Controls.Add(button1);
            Controls.Add(dtgvTequilas);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TequilasAdm";
            Text = "TequilasAdm";
            Load += TequilasAdm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvTequilas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvTequilas;
        private Button button1;
    }
}