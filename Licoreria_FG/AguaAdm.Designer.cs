namespace Licoreria_FG
{
    partial class AguaAdm
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
            dtgvAgua = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvAgua).BeginInit();
            SuspendLayout();
            // 
            // dtgvAgua
            // 
            dtgvAgua.AllowUserToAddRows = false;
            dtgvAgua.AllowUserToDeleteRows = false;
            dtgvAgua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAgua.Location = new Point(50, 30);
            dtgvAgua.Name = "dtgvAgua";
            dtgvAgua.ReadOnly = true;
            dtgvAgua.RowTemplate.Height = 25;
            dtgvAgua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvAgua.Size = new Size(555, 180);
            dtgvAgua.TabIndex = 0;
            dtgvAgua.DoubleClick += dtgvAgua_DoubleClick;
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
            button1.TabIndex = 10;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // AguaAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 230);
            Controls.Add(button1);
            Controls.Add(dtgvAgua);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AguaAdm";
            Text = "AguaAdm";
            Load += AguaAdm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvAgua).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvAgua;
        private Button button1;
    }
}