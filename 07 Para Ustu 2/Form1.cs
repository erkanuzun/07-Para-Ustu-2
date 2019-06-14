using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Para_Ustu_2
{
    public partial class Form1 : Form
    {
        Image[] resimler =
        {
            Properties.Resources.Kagit_200TL,
            Properties.Resources.Kagit_100TL,
            Properties.Resources.Kagit_50TL,
            Properties.Resources.Kagit_20TL,
            Properties.Resources.Kagit_10TL,
            Properties.Resources.Kagit_5TL,
            Properties.Resources.Madeni_1TL,
            Properties.Resources.Madeni_50Kr,
            Properties.Resources.Madeni_25Kr,
            Properties.Resources.Madeni_10Kr,
            Properties.Resources.Madeni_5Kr,
            Properties.Resources.Madeni_1Kr
        };

        int[] paradegerleri = { 20000, 10000, 5000, 2000, 1000, 500, 100, 50, 25, 10, 5, 1 };
        int tutar, odenen, paraustu;

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox para = (PictureBox)sender;
            int deger = Convert.ToInt32(para.Tag);
            odenen += deger;
            label_Odenen.Text = (odenen / 100.0).ToString("0.00");

            PictureBox yeniPara = new PictureBox();
            yeniPara.Image = para.Image;
            yeniPara.Tag = para.Tag;
            yeniPara.SizeMode = PictureBoxSizeMode.AutoSize;
            yeniPara.Click += YeniPara_Click;

            flowLayoutPanel_Tezgah.Controls.Add(yeniPara);
        }

        private void YeniPara_Click(object sender, EventArgs e)
        {
            PictureBox para = (PictureBox)sender;
            int deger = Convert.ToInt32(para.Tag);
            odenen -= deger;
            label_Odenen.Text = (odenen / 100.0).ToString("0.00");
            flowLayoutPanel_Tezgah.Controls.Remove(para);
        }

        private void Button_Odeme_Click(object sender, EventArgs e)
        {
            paraustu = odenen - tutar;
            label_ParaUstu.Text = (paraustu / 100.0).ToString("0.00");
            Refresh();
            System.Threading.Thread.Sleep(500);

            flowLayoutPanel_Tezgah.Controls.Clear();

            int i = 0;
            while (paraustu > 0)
            {
                if(paraustu >= paradegerleri[i])
                {
                    paraustu -= paradegerleri[i];

                    PictureBox yeniPara = new PictureBox();
                    yeniPara.Image = resimler[i];
                    yeniPara.SizeMode = PictureBoxSizeMode.AutoSize;

                    flowLayoutPanel_Tezgah.Controls.Add(yeniPara);
                    System.Threading.Thread.Sleep(500);
                    Refresh();
                }
                else
                {
                    i++;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Yeni_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tutar = 10 + rnd.Next(50000);
            label_Tutar.Text = (tutar / 100.0).ToString("0.00");
            odenen = 0;
            label_Odenen.Text = "0,00";
            paraustu = 0;
            label_ParaUstu.Text = "0,00";
            flowLayoutPanel_Tezgah.Controls.Clear();
        }
    }
}
