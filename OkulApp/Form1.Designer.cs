namespace OkulApp
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
            lblSiniflar = new Label();
            lbSiniflar = new ListBox();
            bttnEkle = new Button();
            bttnSil = new Button();
            txtSinif = new TextBox();
            bttnYeni = new Button();
            dataGridView1 = new DataGridView();
            CoNumara = new DataGridViewTextBoxColumn();
            ColAd = new DataGridViewTextBoxColumn();
            Cinsiyet = new DataGridViewComboBoxColumn();
            Sınıf = new DataGridViewComboBoxColumn();
            ColSoyad = new DataGridViewTextBoxColumn();
            bttnOgrencileriGuncelle = new Button();
            bttnOgrenciSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblSiniflar
            // 
            lblSiniflar.AutoSize = true;
            lblSiniflar.BackColor = Color.Black;
            lblSiniflar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSiniflar.ForeColor = Color.Lime;
            lblSiniflar.Location = new Point(98, 38);
            lblSiniflar.Name = "lblSiniflar";
            lblSiniflar.Size = new Size(75, 25);
            lblSiniflar.TabIndex = 0;
            lblSiniflar.Text = "Siniflar";
            // 
            // lbSiniflar
            // 
            lbSiniflar.FormattingEnabled = true;
            lbSiniflar.Location = new Point(7, 88);
            lbSiniflar.Name = "lbSiniflar";
            lbSiniflar.Size = new Size(257, 334);
            lbSiniflar.TabIndex = 1;
            // 
            // bttnEkle
            // 
            bttnEkle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            bttnEkle.Location = new Point(3, 469);
            bttnEkle.Name = "bttnEkle";
            bttnEkle.Size = new Size(116, 56);
            bttnEkle.TabIndex = 2;
            bttnEkle.Text = "Ekle/Güncelle";
            bttnEkle.UseVisualStyleBackColor = true;
            bttnEkle.Click += bttnEkle_Click;
            // 
            // bttnSil
            // 
            bttnSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            bttnSil.Location = new Point(144, 470);
            bttnSil.Name = "bttnSil";
            bttnSil.Size = new Size(128, 56);
            bttnSil.TabIndex = 3;
            bttnSil.Text = "Sil";
            bttnSil.UseVisualStyleBackColor = true;
            bttnSil.Click += bttnSil_Click;
            // 
            // txtSinif
            // 
            txtSinif.Location = new Point(50, 427);
            txtSinif.Name = "txtSinif";
            txtSinif.Size = new Size(158, 23);
            txtSinif.TabIndex = 4;
            // 
            // bttnYeni
            // 
            bttnYeni.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            bttnYeni.Location = new Point(75, 531);
            bttnYeni.Name = "bttnYeni";
            bttnYeni.Size = new Size(112, 46);
            bttnYeni.TabIndex = 5;
            bttnYeni.Text = "Yeni";
            bttnYeni.UseVisualStyleBackColor = true;
            bttnYeni.Click += bttnKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CoNumara, ColAd, Cinsiyet, Sınıf, ColSoyad });
            dataGridView1.Location = new Point(317, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(433, 334);
            dataGridView1.TabIndex = 6;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // CoNumara
            // 
            CoNumara.DataPropertyName = "Numara";
            CoNumara.HeaderText = "Numara";
            CoNumara.Name = "CoNumara";
            // 
            // ColAd
            // 
            ColAd.DataPropertyName = "Ad";
            ColAd.HeaderText = "Ad";
            ColAd.Name = "ColAd";
            // 
            // Cinsiyet
            // 
            Cinsiyet.DataPropertyName = "Cinsiyet";
            Cinsiyet.HeaderText = "Cinsiyet";
            Cinsiyet.Name = "Cinsiyet";
            // 
            // Sınıf
            // 
            Sınıf.DataPropertyName = "SinifId";
            Sınıf.HeaderText = "Sınıf";
            Sınıf.Name = "Sınıf";
            // 
            // ColSoyad
            // 
            ColSoyad.DataPropertyName = "Soyad";
            ColSoyad.HeaderText = "Soyad";
            ColSoyad.Name = "ColSoyad";
            // 
            // bttnOgrencileriGuncelle
            // 
            bttnOgrencileriGuncelle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            bttnOgrencileriGuncelle.Location = new Point(525, 428);
            bttnOgrencileriGuncelle.Name = "bttnOgrencileriGuncelle";
            bttnOgrencileriGuncelle.Size = new Size(148, 33);
            bttnOgrencileriGuncelle.TabIndex = 7;
            bttnOgrencileriGuncelle.Text = "Güncelle";
            bttnOgrencileriGuncelle.UseVisualStyleBackColor = true;
            bttnOgrencileriGuncelle.Click += bttnOgrencileriGuncelle_Click;
            // 
            // bttnOgrenciSil
            // 
            bttnOgrenciSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            bttnOgrenciSil.Location = new Point(372, 428);
            bttnOgrenciSil.Name = "bttnOgrenciSil";
            bttnOgrenciSil.Size = new Size(147, 33);
            bttnOgrenciSil.TabIndex = 8;
            bttnOgrenciSil.Text = "Sil";
            bttnOgrenciSil.UseVisualStyleBackColor = true;
            bttnOgrenciSil.Click += bttnOgrenciSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(799, 578);
            Controls.Add(bttnOgrenciSil);
            Controls.Add(bttnOgrencileriGuncelle);
            Controls.Add(dataGridView1);
            Controls.Add(bttnYeni);
            Controls.Add(txtSinif);
            Controls.Add(bttnSil);
            Controls.Add(bttnEkle);
            Controls.Add(lbSiniflar);
            Controls.Add(lblSiniflar);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSiniflar;
        private ListBox lbSiniflar;
        private Button bttnEkle;
        private Button bttnSil;
        private TextBox txtSinif;
        private Button bttnYeni;
        private DataGridView dataGridView1;
        private Button bttnOgrencileriGuncelle;
        private Button bttnOgrenciSil;
        private DataGridViewTextBoxColumn CoNumara;
        private DataGridViewTextBoxColumn ColAd;
        private DataGridViewComboBoxColumn Cinsiyet;
        private DataGridViewComboBoxColumn Sınıf;
        private DataGridViewTextBoxColumn ColSoyad;
    }
}
