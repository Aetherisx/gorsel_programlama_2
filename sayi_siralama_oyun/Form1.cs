using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int oyuncu_skor;
        int bilg_skor;
        string hangisi;
        string d;
        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            t.ImageLocation = "C:\\Users\\ardat\\source\\repos\\oyun\\oyun\\Resources\\tas.png";
            k.ImageLocation = "C:\\Users\\ardat\\source\\repos\\oyun\\oyun\\Resources\\kagit.png";
            m.ImageLocation = "C:\\Users\\ardat\\source\\repos\\oyun\\oyun\\Resources\\makas.png";

            lblOyuncuSkor.Text = "Oyuncu=" + oyuncu_skor.ToString();
            lblBilgiSkor.Text = "PC=" + bilg_skor.ToString();
            lblDurum.BackColor = Color.Orange;
        }

        public void sec()
        {
            int s;
            s = r.Next(1, 4);
            if (s == 1)
            {
                si.ImageLocation = "C:\\Users\\ardat\\source\\repos\\oyun\\oyun\\Resources\\tas.png";
                d = "Ta�";
            }
            if (s == 2)
            {
                si.ImageLocation = "C:\\Users\\ardat\\source\\repos\\oyun\\oyun\\Resources\\kagit.png";
                d = "Ka��t";
            }
            if (s == 3)
            {
                si.ImageLocation = "C:\\Users\\ardat\\source\\repos\\oyun\\oyun\\Resources\\makas.png";
                d = "Makas";
            }

        }

        public void skorkontrol()
        {
            if (oyuncu_skor == 10)
            {
                MessageBox.Show("Oyunu Oyuncu Kazand�");
                k.Enabled = false;
                m.Enabled = false;
                t.Enabled = false;
            }
            if (bilg_skor == 10)
            {
                MessageBox.Show("Oyunu Bilgisayar Kazand�");
                k.Enabled = false;
                m.Enabled = false;
                t.Enabled = false;
            }
        }

        private void t_Click(object sender, EventArgs e)
        {
            sec();
            if (d == "Ta�")
            {
                lblDurum.Text = "Durumlar E�it";
                lblDurum.BackColor = Color.Green;
            }
            if (d == "Ka��t")
            {
                lblDurum.Text = "Ka��t Ta�� Sarar PC +1 Skor";
                bilg_skor += 1;
                lblBilgiSkor.Text = "PC=" + bilg_skor.ToString();
                lblDurum.BackColor = Color.Red;
            }
            if (d == "Makas")
            {
                lblDurum.Text = "Ta� Makas� K�rar Oyuncu +1 Skor";
                oyuncu_skor += 1;
                lblOyuncuSkor.Text = "Oyuncu" + oyuncu_skor.ToString();
                lblDurum.BackColor = Color.Blue;
            }
            skorkontrol();
        }

        private void k_Click(object sender, EventArgs e)
        {
            sec();
            if (d == "Ta�")
            {
                lblDurum.Text = "Ka��t Ta�� Sarar Oyuncu +1 Skor";
                oyuncu_skor += 1;
                lblOyuncuSkor.Text = "Oyuncu=" + oyuncu_skor.ToString();
                lblDurum.BackColor = Color.Blue;
            }
            if (d == "Ka��t")
            {
                lblDurum.Text = "Durumlar E�it";
                lblDurum.BackColor = Color.Green;
            }
            if (d == "Makas")
            {
                lblDurum.Text = "Makas Ka��d� Keser PC +1 Skor";
                bilg_skor += 1;
                lblBilgiSkor.Text = "PC=" + bilg_skor.ToString();
                lblDurum.BackColor = Color.Blue;
            }
            skorkontrol();
        }

        private void m_Click(object sender, EventArgs e)
        {
            sec();
            if (d == "Ta�")
            {
                lblDurum.Text = "Ta� Makas� K�rar PC +1 Skor";
                bilg_skor += 1;
                lblBilgiSkor.Text = "PC=" + bilg_skor.ToString();
                lblDurum.BackColor = Color.Red;
            }
            if (d == "Ka��t")
            {
                lblDurum.Text = "Makas Ka��d� Keser Oyuncu +1 Skor";
                oyuncu_skor += 1;
                lblOyuncuSkor.Text = "Oyuncu" + oyuncu_skor.ToString();
                lblDurum.BackColor = Color.Blue;
            }
            if (d == "Makas")
            {
                lblDurum.Text = "Durumlar E�it";
                lblDurum.BackColor = Color.Green;
            }
            skorkontrol();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            oyuncu_skor = 0;
            bilg_skor = 0;
            lblDurum.Text = "";
            k.Enabled = true;
            m.Enabled = true;
            t.Enabled = true;
            lblOyuncuSkor.Text = "Oyuncu=" + oyuncu_skor.ToString();
            lblBilgiSkor.Text = "PC=" + bilg_skor.ToString();
            lblDurum.BackColor = Color.Orange;
        }

        private void si_Click(object sender, EventArgs e)
        {

        }
    }
}
