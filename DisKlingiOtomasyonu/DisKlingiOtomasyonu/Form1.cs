using System.Reflection.Metadata;

namespace DisKlingiOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
        }
        int hak = 3;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                MessageBox.Show("Kullan�c� Ad� ve /veya �ifre bo� b�rak�lamaz", "Uyar�");
            }
            else
            {
                if (TextBox1.Text == "admin" && TextBox2.Text == "123")
                {
                    Anasayfa anys = new Anasayfa();
                    anys.ShowDialog();
                    this.Hide();
                }
                else
                {
                    hak--;
                    MessageBox.Show("Kullan�c� Ad� ve/veya �ifre hatal� .Kalan hakk�n�z=" + hak, "Uyar�");
                    if (hak == 0)
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
