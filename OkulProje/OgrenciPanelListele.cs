using GorselProje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class OgrenciPanelListele : Form
    {
        public OgrenciPanelListele()
        {
            InitializeComponent();
        }

        ipProjeEntities db = new ipProjeEntities();

        void listele()
        {

            dataGridView1.DataSource = db.ogrenci.ToList();

            dataGridView1.Columns[6].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OgrenciPanelListele_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ad Soyad")
            {
                var sonuc = from rec in db.ogrenci where rec.ogrenciAdSoyad.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Öğrenci No")
            {
                var sonuc = from rec in db.ogrenci where rec.ogrenciNo.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Bolum")
            {
                var sonuc = from rec in db.ogrenci where rec.ogrenciBolum.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
