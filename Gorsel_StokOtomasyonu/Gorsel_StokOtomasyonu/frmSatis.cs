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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmUrunEkle urun = new frmUrunEkle();
            urun.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MusteriListele musList = new MusteriListele();
            musList.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UrunListele urunList = new UrunListele();
            urunList.ShowDialog();
        }

        private void txtSatışFiyatı_TextChanged(object sender, EventArgs e)
        {
                
   
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            satisbs.AddNew();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            satisbs.EndEdit();
            dataGridView1.Refresh();
            appDataSet1.WriteXml("data.xml");
            txtToplamFiyati.Clear();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            satisbs.RemoveCurrent();
            dataGridView1.Refresh();
            appDataSet1.WriteXml("data.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satış ve benzeri işlemler yapmak için öncelikle 'ekle' butonuna basarak boş bir veritabanı satırı oluşturunuz ardından verilerinizi giriniz. ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            

            textBox1.Enabled = false;
            txtToplamFiyati.Enabled = false;
            
            if (File.Exists("data.xml"))
                appDataSet1.ReadXml("data.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txtMiktari.Text);
            double sayi2 = Convert.ToDouble(txtSatışFiyatı.Text);

            double sonuc = sayi1 * sayi2;
            txtToplamFiyati.Text = Convert.ToString(sonuc);

            textBox1.Text = DateTime.Now.ToString();
        }
    }
}
