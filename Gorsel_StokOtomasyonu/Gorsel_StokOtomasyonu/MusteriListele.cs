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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }

        private void MusteriListele_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
                appDataSet.ReadXml("data.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musterilistbs.EndEdit();
            dataGridView1.Refresh();
            appDataSet.WriteXml("data.xml");
        }
    }
}
