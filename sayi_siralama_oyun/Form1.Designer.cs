namespace oyun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblOyuncuSkor = new Label();
            lblBilgiSkor = new Label();
            lblDurum = new Label();
            btntemizle = new Button();
            t = new PictureBox();
            k = new PictureBox();
            m = new PictureBox();
            si = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)t).BeginInit();
            ((System.ComponentModel.ISupportInitialize)k).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m).BeginInit();
            ((System.ComponentModel.ISupportInitialize)si).BeginInit();
            SuspendLayout();
            // 
            // lblOyuncuSkor
            // 
            lblOyuncuSkor.AutoSize = true;
            lblOyuncuSkor.Location = new Point(144, 349);
            lblOyuncuSkor.Name = "lblOyuncuSkor";
            lblOyuncuSkor.Size = new Size(38, 15);
            lblOyuncuSkor.TabIndex = 0;
            lblOyuncuSkor.Text = "label1";
            // 
            // lblBilgiSkor
            // 
            lblBilgiSkor.AutoSize = true;
            lblBilgiSkor.Location = new Point(344, 349);
            lblBilgiSkor.Name = "lblBilgiSkor";
            lblBilgiSkor.Size = new Size(38, 15);
            lblBilgiSkor.TabIndex = 1;
            lblBilgiSkor.Text = "label2";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDurum.ForeColor = SystemColors.ButtonFace;
            lblDurum.Location = new Point(240, 283);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(57, 21);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "label3";
            // 
            // btntemizle
            // 
            btntemizle.BackColor = SystemColors.ButtonFace;
            btntemizle.Location = new Point(618, 283);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(75, 23);
            btntemizle.TabIndex = 3;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // t
            // 
            t.Image = Properties.Resources.tas;
            t.Location = new Point(12, 12);
            t.Name = "t";
            t.Size = new Size(161, 212);
            t.TabIndex = 4;
            t.TabStop = false;
            t.Click += t_Click;
            // 
            // k
            // 
            k.Image = (Image)resources.GetObject("k.Image");
            k.Location = new Point(179, 12);
            k.Name = "k";
            k.Size = new Size(158, 212);
            k.TabIndex = 5;
            k.TabStop = false;
            k.Click += k_Click;
            // 
            // m
            // 
            m.Image = (Image)resources.GetObject("m.Image");
            m.Location = new Point(344, 12);
            m.Name = "m";
            m.Size = new Size(160, 212);
            m.TabIndex = 6;
            m.TabStop = false;
            m.Click += m_Click;
            // 
            // si
            // 
            si.Image = (Image)resources.GetObject("si.Image");
            si.Location = new Point(542, 12);
            si.Name = "si";
            si.Size = new Size(214, 225);
            si.TabIndex = 7;
            si.TabStop = false;
            si.Click += si_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(si);
            Controls.Add(m);
            Controls.Add(k);
            Controls.Add(t);
            Controls.Add(btntemizle);
            Controls.Add(lblDurum);
            Controls.Add(lblBilgiSkor);
            Controls.Add(lblOyuncuSkor);
            Name = "Form1";
            Text = "Taş Kağıt Makas Oyunu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)t).EndInit();
            ((System.ComponentModel.ISupportInitialize)k).EndInit();
            ((System.ComponentModel.ISupportInitialize)m).EndInit();
            ((System.ComponentModel.ISupportInitialize)si).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOyuncuSkor;
        private Label lblBilgiSkor;
        private Label lblDurum;
        private Button btntemizle;
        private PictureBox t;
        private PictureBox k;
        private PictureBox m;
        private PictureBox si;
    }
}
