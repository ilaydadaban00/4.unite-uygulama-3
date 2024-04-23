using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.UNİTE_UYGULAMA_3
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                notlar[index] = int.Parse(txtdersNotu.Text);
                // int.Parse fonksiyonu girilen değeri “int” veri türüne dönüştürür
                index++;
                txtAdSoyad.Text = "";
                txtdersNotu.Text = "";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    lbListele.Items.Add(isimler[i] +" > "+notlar[i]);
                }
            }
        }
    }
}
