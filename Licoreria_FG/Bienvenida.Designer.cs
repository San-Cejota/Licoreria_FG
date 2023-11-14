namespace Licoreria_FG
{
    partial class Bienvenida
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbMensaje = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(246, 17);
            label1.Name = "label1";
            label1.Size = new Size(168, 37);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido ";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 80;
            timer2.Tick += timer2_Tick;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.Anchor = AnchorStyles.None;
            circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.White;
            circularProgressBar1.InnerColor = Color.FromArgb(64, 64, 64);
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(257, 153);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.FromArgb(96, 109, 128);
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColor = Color.FromArgb(220, 224, 230);
            circularProgressBar1.ProgressWidth = 25;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(202, 202);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "%";
            circularProgressBar1.TabIndex = 2;
            circularProgressBar1.Text = "0";
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.Value = 68;
            circularProgressBar1.Click += circularProgressBar1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(86, 126, 187);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 378);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.fg;
            pictureBox2.Location = new Point(58, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(530, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(254, 87);
            label2.Name = "label2";
            label2.Size = new Size(160, 34);
            label2.TabIndex = 0;
            label2.Text = "FAKE GODS ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Demi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(270, 111);
            label3.Name = "label3";
            label3.Size = new Size(116, 30);
            label3.TabIndex = 0;
            label3.Text = "-Licoreria-";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Demi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(444, 339);
            label4.Name = "label4";
            label4.Size = new Size(265, 30);
            label4.TabIndex = 5;
            label4.Text = "¡Gracias por preferirnos!";
            // 
            // lbMensaje
            // 
            lbMensaje.AutoSize = true;
            lbMensaje.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbMensaje.ForeColor = Color.WhiteSmoke;
            lbMensaje.Location = new Point(420, 19);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(0, 34);
            lbMensaje.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Demi", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(311, 52);
            label5.Name = "label5";
            label5.Size = new Size(30, 34);
            label5.TabIndex = 0;
            label5.Text = "a";
            // 
            // Bienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 76, 126);
            ClientSize = new Size(706, 378);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(circularProgressBar1);
            Controls.Add(lbMensaje);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenida";
            Load += Bienvenida_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        public Label lbMensaje;
        public Label label1;
        public Label label5;
    }
}