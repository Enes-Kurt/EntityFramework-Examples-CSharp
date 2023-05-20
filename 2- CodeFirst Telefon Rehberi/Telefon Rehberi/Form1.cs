using Uygulama__27._04.Context;
using Uygulama__27._04.Models;
using Uygulama__27._04.Reprository;

namespace Uygulama__27._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rep = new KisiReprository();
        }

        KisiReprository rep;
        Kisi kisi;
        int id;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rep.KisileriGetir();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void btnRehbereEkle_Click(object sender, EventArgs e)
        {
            kisi = new Kisi();
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.Telefon = mtbTelefon.Text;
            int ekle = rep.KisiEkle(kisi);

            if (ekle > 0)
                MessageBox.Show("Kisi Eklendi");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rep.KisileriGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kisi = new Kisi();
            kisi.KisiID = id;
            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.Telefon = mtbTelefon.Text;
            int guncelle = rep.Guncelle(kisi, id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rep.KisileriGetir();

            if (guncelle > 0)
                MessageBox.Show("Guncellendi");
        }

        private void btnKiþiAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string kisiAdSoyad = txtArananKisi.Text;
            dataGridView1.DataSource = rep.KisiAra(kisiAdSoyad);
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = true;
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtbTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
        }
    }
}