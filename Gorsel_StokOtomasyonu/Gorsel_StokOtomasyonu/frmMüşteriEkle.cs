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
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
                appDataSet.ReadXml("data.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsMüşteriler.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bsMüşteriler.EndEdit();
            dataGridView1.Refresh();
            appDataSet.WriteXml("data.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bsMüşteriler.RemoveCurrent();
            dataGridView1.Refresh();
            appDataSet.WriteXml("data.xml");
        }
    }
}
