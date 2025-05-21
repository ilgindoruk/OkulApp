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

            Cinsiyet.DataSource = new List<CinsiyetÝtem>
            {
                new CinsiyetÝtem() {Id=1, Cinsiyet = "Erkek" },
                new CinsiyetÝtem() {Id=2, Cinsiyet = "Kýz" }

            };

            Cinsiyet.DisplayMember = "Cinsiyet"; //Cinsiyetin adýný göster
            Cinsiyet.ValueMember = "Id"; //Cinsiyetin id'sini göster

        }

        void VerileriYukle()
        {
            var liste = db.Siniflar.ToList();
            lbSiniflar.DataSource = liste;
            lbSiniflar.DisplayMember = "SinifAdi";
            lbSiniflar.ValueMember = "Id";

            Sýnýf.DataSource = liste;
            Sýnýf.DisplayMember = "SinifAdi";
            Sýnýf.ValueMember = "Id";

            dataGridView1.AutoGenerateColumns = false;
            db.Ogrenciler.Load(); //Ogrencileri yükle
            var ogrenciListe = db.Ogrenciler.Local.ToBindingList();
            dataGridView1.DataSource = ogrenciListe;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void bttnEkle_Click(object sender, EventArgs e)
        {
            //1-Ekleme (Listede birþey seçili deðilse)
            //2-Güncelleme (Listede seçili sýnýf var ise)

            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Seçili sýnýfý al

            if (secili == null)
            {
                DbSinif yeniSinif = new();
                yeniSinif.SinifAdi = txtSinif.Text; //Sýnýf adýný al

                db.Siniflar.Add(yeniSinif); //Sýnýfý ekle
                db.SaveChanges(); //Deðiþiklikleri kaydet
                MessageBox.Show("Yeni sýnýf eklendi.");
            }
            else
            {
                secili.SinifAdi = txtSinif.Text; //Seçili sýnýfýn adýný güncelle
                db.SaveChanges(); //Deðiþiklikleri kaydet
                db.Siniflar.Local.ToBindingList().ResetBindings(); //Listeyi güncelle
                MessageBox.Show("Sýnýf güncellendi.");
            }
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            lbSiniflar.SelectedIndex = -1;
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            DbSinif secili = lbSiniflar.SelectedItem as DbSinif; //Seçili sýnýfý al

            if (secili != null)
            {

                var cevap = MessageBox.Show(secili.SinifAdi + "  adlý sýnýf silmek istediðinize" + " emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (cevap == DialogResult.Yes)
                {
                    db.Siniflar.Remove(secili); //Seçili sýnýfý sil
                    db.SaveChanges(); //Deðiþiklikleri kaydet
                    MessageBox.Show("Sýnýf silindi");
                }


            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; //Hata mesajýný gizle
        }

        private void bttnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            int seciliIndex = dataGridView1.CurrentRow.Index;

            if (seciliIndex < 0)
                return;

            DbÖðrenci ogr = dataGridView1.Rows[seciliIndex].DataBoundItem as DbÖðrenci;

            var cevap = MessageBox.Show($"{ogr.Numara} {ogr.Ad} {ogr.Soyad} adlý öðrenciyi silmek " +
                    $"istediðinze emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                db.Ogrenciler.Remove(ogr);
                db.SaveChanges();
                MessageBox.Show("Öðrenci silindi.");
            }
        }

        private void bttnOgrencileriGuncelle_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
 