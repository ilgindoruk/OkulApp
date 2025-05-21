using Microsoft.EntityFrameworkCore;
using OkulApp.Modeller;

namespace OkulApp
{
    public partial class Form1 : Form
    {
        OkulDataContext db = new();
        public Form1()
        {
            InitializeComponent();

            Cinsiyet.DataSource = new List<Cinsiyet�tem>
            {
                new Cinsiyet�tem() {Id=1, Cinsiyet = "Erkek" },
                new Cinsiyet�tem() {Id=2, Cinsiyet = "K�z" }

            };

            Cinsiyet.DisplayMember = "Cinsiyet"; //Cinsiyetin ad�n� g�ster
            Cinsiyet.ValueMember = "Id"; //Cinsiyetin id'sini g�ster

        }

        void VerileriYukle()
        {
            var liste = db.Siniflar.ToList();
            lbSiniflar.DataSource = liste;
            lbSiniflar.DisplayMember = "SinifAdi";
            lbSiniflar.ValueMember = "Id";

            S�n�f.DataSource = liste;
            S�n�f.DisplayMember = "SinifAdi";
            S�n�f.ValueMember = "Id";

            dataGridView1.AutoGenerateColumns = false;
            db.Ogrenciler.Load(); //Ogrencileri y�kle
            var ogrenciListe = db.Ogrenciler.Local.ToBindingList();
            dataGridView1.DataSource = ogrenciListe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void bttnEkle_Click(object sender, EventArgs e)
        {
            //1-Ekleme (Listede bir�ey se�ili de�ilse)
            //2-G�ncelleme (Listede se�ili s�n�f var ise)

            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Se�ili s�n�f� al

            if (secili == null)
            {
                DbSinif yeniSinif = new();
                yeniSinif.SinifAdi = txtSinif.Text; //S�n�f ad�n� al

                db.Siniflar.Add(yeniSinif); //S�n�f� ekle
                db.SaveChanges(); //De�i�iklikleri kaydet
                MessageBox.Show("Yeni s�n�f eklendi.");
            }
            else
            {
                secili.SinifAdi = txtSinif.Text; //Se�ili s�n�f�n ad�n� g�ncelle
                db.SaveChanges(); //De�i�iklikleri kaydet
                db.Siniflar.Local.ToBindingList().ResetBindings(); //Listeyi g�ncelle
                MessageBox.Show("S�n�f g�ncellendi.");
            }
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            lbSiniflar.SelectedIndex = -1;
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Se�ili s�n�f� al

            if (secili != null)
            {

                var cevap = MessageBox.Show(secili.SinifAdi + "  adl� s�n�f silmek istedi�inize" + " emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    db.Siniflar.Remove(secili); //Se�ili s�n�f� sil
                    db.SaveChanges(); //De�i�iklikleri kaydet
                    MessageBox.Show("S�n�f silindi");
                }


            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; //Hata mesaj�n� gizle
        }

        private void bttnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int seciliIndex = dataGridView1.CurrentRow.Index;

            if (seciliIndex < 0)
                return;

            Db��renci ogr = dataGridView1.Rows[seciliIndex].DataBoundItem as Db��renci;

            var cevap = MessageBox.Show($"{ogr.Numara} {ogr.Ad} {ogr.Soyad} adl� ��renciyi silmek " +
                    $"istedi�inze emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                db.Ogrenciler.Remove(ogr);
                db.SaveChanges();
                MessageBox.Show("��renci silindi.");
            }
        }

        private void bttnOgrencileriGuncelle_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
 