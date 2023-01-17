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
    public partial class OkulYonetimList : Form
    {
        public OkulYonetimList()
        {
            InitializeComponent();
        }

        ipProjeEntities db = new ipProjeEntities();
        public string deger;

        void listele()
        {
            dataGridView1.DataSource = db.okulYonetimT.ToList();
            dataGridView1.Columns[4].Visible = false;

            var yonetimlist = db.okulYonetimT.ToList();


        }
        private void OkulYonetimList_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
