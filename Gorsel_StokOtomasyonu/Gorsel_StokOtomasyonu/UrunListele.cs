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
    public partial class UrunListele : Form
    {
        public UrunListele()
        {
            InitializeComponent();
        }

        private void UrunListele_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
                appDataSet.ReadXml("data.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunGuncellebs.EndEdit();
            dataGridView1.Refresh();
            appDataSet.WriteXml("data.xml");
        }
    }
}
