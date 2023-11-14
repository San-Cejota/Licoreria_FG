namespace Licoreria_FG
{
    partial class VinoBlancoAdm
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
            dtgvVBlanco = new DataGridView();
            button2 = new Button();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvVBlanco).BeginInit();
            SuspendLayout();
            // 
            // dtgvVBlanco
            // 
            dtgvVBlanco.AllowUserToAddRows = false;
            dtgvVBlanco.AllowUserToDeleteRows = false;
            dtgvVBlanco.Anchor = AnchorStyles.None;
            dtgvVBlanco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvVBlanco.BackgroundColor = SystemColors.ActiveCaption;
            dtgvVBlanco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVBlanco.Location = new Point(50, 30);
            dtgvVBlanco.Name = "dtgvVBlanco";
            dtgvVBlanco.RowHeadersVisible = false;
            dtgvVBlanco.RowTemplate.Height = 25;
            dtgvVBlanco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvVBlanco.Size = new Size(555, 180);
            dtgvVBlanco.TabIndex = 0;
            dtgvVBlanco.CellContentClick += dtgvVBlanco_CellContentClick;
            dtgvVBlanco.DoubleClick += dtgvVBlanco_DoubleClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 47, 33);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 10.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(247, 247, 247);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(58, -102);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(76, 23);
            textBox5.TabIndex = 11;
            // 
            // VinoBlancoAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 224, 230);
            ClientSize = new Size(650, 230);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(dtgvVBlanco);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VinoBlancoAdm";
            Text = "VinoBlanco";
            Load += VinoBlancoAdm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVBlanco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvVBlanco;
        private Button button2;
        private TextBox textBox5;
    }
}