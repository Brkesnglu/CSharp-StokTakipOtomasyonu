using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel_StokOtomasyonu
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsUrunler.EndEdit();
            dataGridView1.Refresh();
            appDataSet.WriteXml("data.xml");
        }

        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
                appDataSet.ReadXml("data.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsUrunler.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsUrunler.AddNew();
        }
    }
}
