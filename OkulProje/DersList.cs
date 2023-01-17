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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulProje
{
    public partial class DersList : Form
    {
        public DersList()
        {
            InitializeComponent();
        }
        ipProjeEntities db = new ipProjeEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.ders
                                        select new
                                        {
                                            x.dersId,
                                            x.dersAd,
                                            x.dersKredi,
                                            x.okulYonetimT.yonetimAdSoyad

                                        }).ToList();



            //dataGridView1.Columns[4].Visible = false;

            var derslist = db.ders.ToList();


        }
        private void DersList_Load(object sender, EventArgs e)
        {
            listele();
            var ogretmenler = (from x in db.okulYonetimT
                               where x.yonetimTip == "12"
                               select new
                               {
                                   x.yonetimId,
                                   x.yonetimAdSoyad
                               }).ToList();
        }
    }
}
