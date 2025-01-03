using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace UcakRezervasyon
{
    public partial class BiletSecim : Form
    {
   
       
        
        
        private Dictionary<string, Dictionary<string, double>> sehirucretleri;
        private Dictionary<Tuple<string, string, DateTime>, bool> seferler = new Dictionary<Tuple<string, string, DateTime>, bool>()
            {
                { Tuple.Create( "Trabzon", "İstanbul", new DateTime(2025, 01, 09)), true },
                { Tuple.Create( "Bursa", "İstanbul", new DateTime(2025, 05, 28)), true },
                { Tuple.Create( "Mardin", "İstanbul", new DateTime(2025, 01, 20)), true },
                { Tuple.Create( "Samsun", "İstanbul", new DateTime(2025, 08, 30)), true },
            };
        
        public BiletSecim()
        {
            InitializeComponent();
            

            

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            
            
            sehirucretleri = new Dictionary<string, Dictionary<string, double>>()
            {
                {"Trabzon", new Dictionary<string, double> ()
                {
                    {"İstanbul", 1200 }
                }
                },

                {"Bursa", new Dictionary<string, double> ()
                {
                    {"İstanbul", 800 }
                }
                },

                {"Mardin", new Dictionary<string, double> ()
                {
                    {"İstanbul", 3000 }
                }
                },

                {"Samsun", new Dictionary<string, double> ()
                {
                    {"İstanbul", 2000 }
                }
                },
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nereden = comboBox1.SelectedItem?.ToString();
            string nereye = comboBox2.SelectedItem?.ToString();
            DateTime tarih = dateTimePicker1.Value.Date;
            string yolcu = comboBox4.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nereden) || string.IsNullOrEmpty(nereye))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (nereden == nereye)
            {
                MessageBox.Show("Lütfen farklı şehirler seçiniz.");
                return;
            }

            var seferKey = Tuple.Create(nereden, nereye, tarih);
            if(seferler.ContainsKey(seferKey))
            {
                if (seferler[seferKey])
                {
                    label3.Text = $"{nereden} -> {nereye} {tarih.ToString("dd/MM/yyyy")} tarihinde uçuş var.";
                    KullaniciBilgisi frmShow = new KullaniciBilgisi();
                    frmShow.ShowDialog();
                }
                else
                {
                    label3.Text = $"{nereden} -> {nereye} {tarih.ToString("dd/MM/yyyy")} tarihinde uçuş bulunmamaktadır.";
                }
            }
            else
            {
                label3.Text = "Sefer bilgisi bulunamadı.";
            }

            

            
                  
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gidis = comboBox1.SelectedItem?.ToString();
            string varis = comboBox2.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(gidis) || string.IsNullOrEmpty(varis))
            {
                MessageBox.Show("Lütfen her iki şehri de seçiniz.");
                return;
            }

            if(sehirucretleri.ContainsKey(gidis) && sehirucretleri[gidis].ContainsKey(varis))
            {
                double ucret = sehirucretleri[gidis][varis];
                label4.Text = $"{gidis} ile {varis} arasındaki ücret: {ucret} TL";
            }

            else
            {
                label4.Text = "Bu şehirler arasındaki ücret bulunamamaktadır.";
            }
        }
    }
}
