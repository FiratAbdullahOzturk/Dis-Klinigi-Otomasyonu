using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace DisKlingiOtomasyonu
{
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string query = "insert into TedaviTbl values ('" + TedaviAdiTb.Text + "','" + TutarTb.Text + "','" + AciklamaTb.Text + "')";
            Hastalar Hs = new Hastalar();
            try
            {
                Hs.HastaEkle(query);
                MessageBox.Show("Tedavi Başarıyla Eklendi.");
                uyeler();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int key = 0;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hastalar Hs = new Hastalar();
            if (key == 0)
            {
                MessageBox.Show("Silinecek Tedaviyi Seçiniz.");
            }
            else
            {
                try
                {
                    string query = "Delete from TedaviTbl where TId=" + key + "";
                    Hs.HastaSil(query);
                    MessageBox.Show("Tedavi  Başarıyla Silindi");
                    uyeler();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
        void uyeler()
        {
            Hastalar Hs = new Hastalar();
            string query = "select*from TedaviTbl";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void filter()
        {
            Hastalar Hs = new Hastalar();
            string query = "select*from TedaviTbl where TAd like '%" + ARATB.Text + "%'";
            DataSet ds = Hs.ShowHasta(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }
        void Reset()
        {
            TedaviAdiTb.Text = "";
            TutarTb.Text = "";
            AciklamaTb.Text = "";
        }
        private void Tedavi_Load(object sender, EventArgs e)
        {
            uyeler();
            Reset();
        }



        private void TedaviDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TedaviAdiTb.Text = TedaviDGV.SelectedRows[0].Cells[1].Value.ToString();
            TutarTb.Text = TedaviDGV.SelectedRows[0].Cells[2].Value.ToString();
            AciklamaTb.Text = TedaviDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (TedaviAdiTb.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(TedaviDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }

        private void ARATB_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Randevu rnd = new Randevu();
            rnd.Show();
            this.Hide();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Receteler rct = new Receteler();
            rct.Show();
            this.Hide();
        }
    }
}
