using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHospital.model;

namespace WFAHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hastaCount;
        List<Randevu> doktorlar = new List<Randevu>() {
            new Randevu() { DoktorAdSoyad = "Alp Kurtboğan", DoktorBransi = Branslar.Kardiyoloji },
            new Randevu() { DoktorAdSoyad = "Gözde Erdoğan", DoktorBransi = Branslar.Göz },
            new Randevu() { DoktorAdSoyad = "Gizem Erdoğan", DoktorBransi = Branslar.Ortopedi },
            new Randevu() { DoktorAdSoyad = "Feride Erdoğan", DoktorBransi = Branslar.Rehabilitasyon }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            tbTc.MaxLength = 11;
            cbBrans.DataSource = Enum.GetValues(typeof(Branslar));
            cbRandevuSaat.Items.Add("09");
            cbRandevuDakika.Items.Add("00");
            for (int i = 10; i <= 18; i++)
            {
                cbRandevuSaat.Items.Add(i);
            }
            for (int i = 15; i < 60; i++)
            {
                cbRandevuDakika.Items.Add(i);
                i += 14;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text =="Ekle")
            {
                Randevu randevum = new Randevu();

                if (cbErkek.Checked == true)
                {
                    randevum.HastaCinsiyet = "Erkek";
                }
                else
                {
                    randevum.HastaCinsiyet = "Kadın";
                }

                randevum.HastaAdSoyad = tbAdSoyad.Text;
                randevum.HastaTC = Convert.ToInt64(tbTc.Text);
                randevum.HastaDogumTarihi = dateDogumTarihi.Value;
                randevum.DoktorBransi = (Branslar)cbBrans.SelectedItem;
                randevum.DoktorAdSoyad = cbDoktor.SelectedItem.ToString();
                randevum.RandevuTarihi = dateRandevuDate.Value;
                randevum.RandevuSaati = cbRandevuSaat.SelectedText;
                randevum.RandevuDakika = cbRandevuDakika.SelectedText;

                ///////////////////// //Kontroller///////////////////////////////////////////////
                Regex regex = new Regex("^[0-9]+$");
                if (!regex.IsMatch(tbTc.Text))
                {
                    MessageBox.Show("Lütfen sadece TC alanına sayı giriniz");
                    tbTc.Text = "";
                }
                else if (tbTc.Text == null || tbTc.Text.Length != 11)
                {
                    MessageBox.Show("Lütfen TC alanını boş bırakmayınız");
                }
                else
                {
                    lbHastalar.Items.Add(randevum);
                    lblToplamHasta.Text = "Toplam {" + (++hastaCount) + " }Hasta";
                }



                foreach (Randevu item in lbHastalar.Items)
                {    //Randevusu bugün olanları list e atmak
                    if (randevum.RandevuTarihi.Day == DateTime.Now.Day)
                    {
                        string[] row = { item.HastaTC.ToString(), item.HastaAdSoyad, item.RandevuTarihi.ToString() };
                        var listViewItem = new ListViewItem(row);
                        lstHastalar.Items.Add(listViewItem);
                    }

                }
            }
                

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (Control item in gbHastaKayıt.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }
                else
                {
                    dateDogumTarihi.Value = DateTime.Now;
                    dateRandevuDate.Value = DateTime.Now;
                    cbBrans.SelectedIndex = 0;
                    cbDoktor.SelectedIndex = 0;
                    cbErkek.Checked = false;
                    cbRandevuSaat.SelectedIndex = 0;
                    cbRandevuDakika.SelectedIndex = 0;
                }

            }
            btnEkle.Text = "Ekle";
        }

        private void cbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoktor.Items.Clear();
            foreach (Randevu item in doktorlar)
            {
                if (item.DoktorBransi.ToString() == cbBrans.SelectedItem.ToString())
                {
                    cbDoktor.Items.Add(item);
                }
            }
        }

        private void lbHastalar_Click(object sender, EventArgs e)
        {
           Randevu r =  (Randevu) lbHastalar.SelectedItem;


            tbTc.Text = r.HastaTC.ToString();
            tbAdSoyad.Text = r.HastaAdSoyad;
            cbBrans.Text = r.DoktorBransi.ToString();
            cbDoktor.Text = r.DoktorAdSoyad;
            dateDogumTarihi.Value = r.HastaDogumTarihi.Date;
            cbRandevuSaat.Text = r.RandevuSaati.ToString();
            cbRandevuDakika.Text = r.RandevuDakika.ToString();
            dateRandevuDate.Value = r.RandevuTarihi.Date;

            btnEkle.Text = "Güncelle";
             lbHastalar.Items.Remove(lbHastalar.SelectedItem); 

        }
    }
    }
