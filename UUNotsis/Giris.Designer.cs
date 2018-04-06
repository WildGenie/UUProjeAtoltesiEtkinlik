namespace UUNotsis
{
    partial class Giris
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
            this.panel = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxNumara = new System.Windows.Forms.MaskedTextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.label2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(802, 184);
            this.panel.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label.Location = new System.Drawing.Point(13, 213);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(196, 19);
            this.label.TabIndex = 1;
            this.label.Text = "Öğrenci Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(13, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parola";
            // 
            // maskedTextBoxNumara
            // 
            this.maskedTextBoxNumara.Location = new System.Drawing.Point(218, 210);
            this.maskedTextBoxNumara.Mask = "00000";
            this.maskedTextBoxNumara.Name = "maskedTextBoxNumara";
            this.maskedTextBoxNumara.Size = new System.Drawing.Size(395, 26);
            this.maskedTextBoxNumara.TabIndex = 2;
            this.maskedTextBoxNumara.ValidatingType = typeof(int);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(218, 251);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(395, 26);
            this.textBoxParola.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(619, 210);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(171, 67);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uludağ Üniversitesi Not Sistemi";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::UUNotsis.Properties.Resources.exam;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(180, 186);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(802, 326);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.maskedTextBoxNumara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "UUNotsis Giriş";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumara;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button buttonLogin;
    }
}

