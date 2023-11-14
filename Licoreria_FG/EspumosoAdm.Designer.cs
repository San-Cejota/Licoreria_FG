namespace Licoreria_FG
{
    partial class EspumosoAdm
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
            dtgvEspumoso = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvEspumoso).BeginInit();
            SuspendLayout();
            // 
            // dtgvEspumoso
            // 
            dtgvEspumoso.AllowUserToDeleteRows = false;
            dtgvEspumoso.Anchor = AnchorStyles.None;
            dtgvEspumoso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvEspumoso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEspumoso.Location = new Point(50, 30);
            dtgvEspumoso.Name = "dtgvEspumoso";
            dtgvEspumoso.RowHeadersVisible = false;
            dtgvEspumoso.RowTemplate.Height = 25;
            dtgvEspumoso.Size = new Size(555, 180);
            dtgvEspumoso.TabIndex = 1;
            dtgvEspumoso.DoubleClick += dtgvEspumoso_DoubleClick;
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
            button1.TabIndex = 9;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EspumosoAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 224, 230);
            ClientSize = new Size(650, 230);
            Controls.Add(button1);
            Controls.Add(dtgvEspumoso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EspumosoAdm";
            Text = "EspumosoAdm";
            Load += EspumosoAdm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvEspumoso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvEspumoso;
        private Button button1;
    }
}