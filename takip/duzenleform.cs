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
    public partial class duzenleform : Form
    {
        public duzenleform()
        {
            InitializeComponent();
        }

        private void duzenleform_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = HANIFI; Initial Catalog = takip; Integrated Security = True");
            {
                conn.Open();
                SqlCommand komut1 = new SqlCommand();
                komut1.CommandText = "SELECT * FROM musteri where mail=@mail";
                komut1.Parameters.AddWithValue("@mail", goster.mail.ToString().Trim());
                komut1.Connection = conn;
                komut1.CommandType = CommandType.Text;
                SqlDataReader dr;
                dr = komut1.ExecuteReader();
                while (dr.Read())
                {

                    bunifuCustomTextbox1.Text = dr["adi"].ToString().Trim();
                    maskedTextBox1.Text = dr["telefon"].ToString();
                    bunifuCustomTextbox2.Text = dr["mail"].ToString().Trim();
                    richTextBox1.Text = dr["adres"].ToString().Trim();
                    bunifuCustomTextbox3.Text = dr["tutar"].ToString().Trim();
                    bunifuCustomTextbox4.Text = dr["hosting"].ToString().Trim();
                    bunifuCustomTextbox5.Text = dr["alanadi"].ToString().Trim();
                    bunifuCustomTextbox6.Text = dr["yazilim"].ToString().Trim();
                    bunifuCustomTextbox7.Text = dr["sure"].ToString().Trim();

                }
                dr.Close();
                conn.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = HANIFI; Initial Catalog = takip; Integrated Security = True"))
            {
                conn.Open();
                string kayit = "UPDATE musteri SET adi=@adi,telefon=@telefon,mail=@mail,adres=@adres,hosting=@hosting,alanadi=@alanadi,yazilim=@yazilim,sure=@sure,tutar=@tutar where mail=@idno";
                SqlCommand komut = new SqlCommand(kayit, conn);
                komut.Parameters.AddWithValue("@adi", bunifuCustomTextbox1.Text);
                komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@mail", bunifuCustomTextbox2.Text);
                komut.Parameters.AddWithValue("@adres", richTextBox1.Text);
                komut.Parameters.AddWithValue("@hosting", bunifuCustomTextbox4.Text);
                komut.Parameters.AddWithValue("@alanadi", bunifuCustomTextbox5.Text);
                komut.Parameters.AddWithValue("@yazilim", bunifuCustomTextbox6.Text);
                komut.Parameters.AddWithValue("@sure", bunifuCustomTextbox7.Text);
                komut.Parameters.AddWithValue("@tutar", bunifuCustomTextbox3.Text);
                komut.Parameters.AddWithValue("@idno", goster.mail.ToString());
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Bilgileri Güncellendi.");
                this.Hide();
            }
        }

        Point İlkkonum; // Bu değişkenler Global olarak tanımlanmalı.
        bool durum = false;
        private void duzenleform_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            this.Cursor = Cursors.SizeAll; // Fareyi taşıma şeklinde seçim yapılmış ikon halini almasını sağladık.
            İlkkonum = e.Location;
        }

        private void duzenleform_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }

        private void duzenleform_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
            this.Cursor = Cursors.Default;
        }
    }
}
