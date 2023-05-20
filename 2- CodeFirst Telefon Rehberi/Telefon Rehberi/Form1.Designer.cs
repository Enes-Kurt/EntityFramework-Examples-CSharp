namespace Uygulama__27._04
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
            btnRehbereEkle = new Button();
            txtSoyad = new TextBox();
            txtArananKisi = new TextBox();
            mtbTelefon = new MaskedTextBox();
            txtAd = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnKişiAra = new Button();
            btnGuncelle = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRehbereEkle
            // 
            btnRehbereEkle.BackColor = Color.FromArgb(255, 128, 0);
            btnRehbereEkle.Location = new Point(129, 155);
            btnRehbereEkle.Name = "btnRehbereEkle";
            btnRehbereEkle.Size = new Size(159, 44);
            btnRehbereEkle.TabIndex = 0;
            btnRehbereEkle.Text = "Rehbere Ekle";
            btnRehbereEkle.UseVisualStyleBackColor = false;
            btnRehbereEkle.Click += btnRehbereEkle_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(115, 71);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(194, 34);
            txtSoyad.TabIndex = 1;
            // 
            // txtArananKisi
            // 
            txtArananKisi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtArananKisi.Location = new Point(476, 76);
            txtArananKisi.Name = "txtArananKisi";
            txtArananKisi.Size = new Size(241, 34);
            txtArananKisi.TabIndex = 1;
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(115, 115);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(194, 34);
            mtbTelefon.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(115, 28);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(194, 34);
            txtAd.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(763, 237);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
           
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(mtbTelefon);
            groupBox1.Controls.Add(btnRehbereEkle);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(36, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 205);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Ekleme Paneli";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 121);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 77);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 34);
            label1.Name = "label1";
            label1.Size = new Size(37, 28);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(505, 42);
            label4.Name = "label4";
            label4.Size = new Size(182, 28);
            label4.TabIndex = 0;
            label4.Text = "Aranacak Ad Soyad";
            // 
            // btnKişiAra
            // 
            btnKişiAra.BackColor = Color.FromArgb(255, 128, 0);
            btnKişiAra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKişiAra.Location = new Point(494, 123);
            btnKişiAra.Name = "btnKişiAra";
            btnKişiAra.Size = new Size(210, 45);
            btnKişiAra.TabIndex = 0;
            btnKişiAra.Text = "Kişi Ara";
            btnKişiAra.UseVisualStyleBackColor = false;
            btnKişiAra.Click += btnKişiAra_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnGuncelle.Enabled = false;
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(494, 186);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(210, 45);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "Guncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 250);
            label5.Name = "label5";
            label5.Size = new Size(101, 31);
            label5.TabIndex = 0;
            label5.Text = "REHBER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 545);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(txtArananKisi);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKişiAra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRehbereEkle;
        private TextBox txtSoyad;
        private TextBox txtArananKisi;
        private MaskedTextBox mtbTelefon;
        private TextBox txtAd;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnKişiAra;
        private Button btnGuncelle;
        private Label label5;
    }
}