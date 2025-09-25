namespace gorsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool calisti = false;

        int salise = 0;
        int saniye = DateTime.Now.Second - 3;
        int dakika = DateTime.Now.Minute;
        int saat = DateTime.Now.Hour;
        int sistemsaat = DateTime.Now.Hour;
        int sistemdakika = DateTime.Now.Minute;
        int sistemsaniye = DateTime.Now.Second;

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = saniye.ToString();
            label2.Text = dakika.ToString();
            label1.Text = saat.ToString();
            label4.Text = salise.ToString();
            timer1.Interval = 10;
            timer1.Start();
            button1.Enabled = false;

            if (button1.BackColor == Color.Green)
            {
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (calisti == false)
            {
                salise++;
                if (salise == 100)
                {
                    saniye++;
                    salise = 0;
                }
                if (saniye == 60)
                {
                    dakika++;
                    saniye = 0;
                }
                if (dakika == 60)
                {
                    saat++;
                    dakika = 0;
                }
                if (saat == 24)
                {
                    saat = 0;
                }
                label3.Text = saniye.ToString();
                label2.Text = dakika.ToString();
                label1.Text = saat.ToString();
                label4.Text = salise.ToString();
            }

            if (calisti == true)
            {
                button1.Enabled = true;
                button1.BackColor = Color.Green;
                label5.Text = salise.ToString();
                label6.Text = saniye.ToString();
                label7.Text = dakika.ToString();
                label8.Text = saat.ToString();
                if (salise == 0)
                {
                    salise = 100;
                    saniye--;
                }
                salise--;
                if (saniye == 0)
                {
                    dakika--;
                    saniye = 60;
                }
                if (dakika == 00)
                {
                    saat--;
                    dakika = 60;
                }
                if (saat == 00)
                {
                    saat = 24;
                }
            }
            if (saat == sistemsaat && dakika == sistemdakika && saniye == sistemsaniye && calisti == false)
            {
                timer1.Stop();
                calisti = true;
                button1.Enabled = true;
            }
        }
    }
}
