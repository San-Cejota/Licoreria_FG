namespace Licoreria_FG
{
    partial class Champaña
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
            dtgChampañas = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgChampañas).BeginInit();
            SuspendLayout();
            // 
            // dtgChampañas
            // 
            dtgChampañas.AllowUserToDeleteRows = false;
            dtgChampañas.Anchor = AnchorStyles.None;
            dtgChampañas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgChampañas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgChampañas.Location = new Point(50, 36);
            dtgChampañas.Name = "dtgChampañas";
            dtgChampañas.RowHeadersVisible = false;
            dtgChampañas.RowTemplate.Height = 25;
            dtgChampañas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgChampañas.Size = new Size(548, 166);
            dtgChampañas.TabIndex = 0;
            dtgChampañas.CellContentClick += dtgChampañas_CellContentClick;
            dtgChampañas.DoubleClick += dtgChampañas_DoubleClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 47, 33);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(247, 247, 247);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Champaña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 224, 230);
            ClientSize = new Size(650, 230);
            Controls.Add(button1);
            Controls.Add(dtgChampañas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Champaña";
            Text = "Champaña";
            Load += Champaña_Load;
            ((System.ComponentModel.ISupportInitialize)dtgChampañas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgChampañas;
        private Button button1;
    }
}