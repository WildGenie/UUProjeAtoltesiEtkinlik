namespace UUNotsis
{
    partial class Mesajlar
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
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxAlici = new System.Windows.Forms.MaskedTextBox();
            this.textBoxBaslik = new System.Windows.Forms.TextBox();
            this.richTextBoxMesaj = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonGonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 40);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 19);
            this.label.TabIndex = 2;
            this.label.Text = "Başlık";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mesaj";
            // 
            // maskedTextBoxAlici
            // 
            this.maskedTextBoxAlici.Location = new System.Drawing.Point(96, 5);
            this.maskedTextBoxAlici.Mask = "00000";
            this.maskedTextBoxAlici.Name = "maskedTextBoxAlici";
            this.maskedTextBoxAlici.Size = new System.Drawing.Size(628, 26);
            this.maskedTextBoxAlici.TabIndex = 1;
            this.maskedTextBoxAlici.ValidatingType = typeof(int);
            // 
            // textBoxBaslik
            // 
            this.textBoxBaslik.Location = new System.Drawing.Point(96, 37);
            this.textBoxBaslik.Name = "textBoxBaslik";
            this.textBoxBaslik.Size = new System.Drawing.Size(628, 26);
            this.textBoxBaslik.TabIndex = 3;
            // 
            // richTextBoxMesaj
            // 
            this.richTextBoxMesaj.Location = new System.Drawing.Point(96, 68);
            this.richTextBoxMesaj.Name = "richTextBoxMesaj";
            this.richTextBoxMesaj.Size = new System.Drawing.Size(628, 204);
            this.richTextBoxMesaj.TabIndex = 5;
            this.richTextBoxMesaj.Text = "";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 329);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(729, 176);
            this.dataGridView.TabIndex = 7;
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(96, 278);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(628, 31);
            this.buttonGonder.TabIndex = 6;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            // 
            // Mesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(729, 505);
            this.Controls.Add(this.buttonGonder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.richTextBoxMesaj);
            this.Controls.Add(this.textBoxBaslik);
            this.Controls.Add(this.maskedTextBoxAlici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Mesajlar";
            this.Text = "Mesajlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAlici;
        private System.Windows.Forms.TextBox textBoxBaslik;
        private System.Windows.Forms.RichTextBox richTextBoxMesaj;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonGonder;
    }
}