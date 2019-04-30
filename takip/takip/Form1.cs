using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace takip
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            label1.Font = new Font("dry brush", 32, FontStyle.Bold);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string user = bunifuMetroTextbox1.Text;
            string pass = bunifuMetroTextbox2.Text;
            con = new SqlConnection("server=HANIFI; Initial Catalog=takip;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM login where kadi='" + bunifuMetroTextbox1.Text + "' AND sifre='" + bunifuMetroTextbox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                anasayfa ana = new anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "";
        }

        private void bunifuMetroTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuMetroTextbox2.Text = "";
        }
        Point İlkkonum; // Bu değişkenler Global olarak tanımlanmalı.
        bool durum = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            this.Cursor = Cursors.SizeAll; // Fareyi taşıma şeklinde seçim yapılmış ikon halini almasını sağladık.
            İlkkonum = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
            this.Cursor = Cursors.Default; // Fare işaretçisi Default halini aldı.

        }

        private void bunifuMetroTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string user = bunifuMetroTextbox1.Text;
                string pass = bunifuMetroTextbox2.Text;
                con = new SqlConnection("server=HANIFI; Initial Catalog=takip;Integrated Security=SSPI");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM login where kadi='" + bunifuMetroTextbox1.Text + "' AND sifre='" + bunifuMetroTextbox2.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    anasayfa ana = new anasayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();
            }
        }
    }
}
