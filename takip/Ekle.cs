﻿using System;
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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=HANIFI;Initial Catalog=takip;Integrated Security=True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti =new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.
        string hosting="";
        string alanadi="";
        string yazilim;
        DateTime bugun = DateTime.Today;
        int tutar =0;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           try
            {
                
                if (checkEdit1.Checked)
                {
                    hosting += "1 GB ";
                    tutar += 40;
                }
                if (checkEdit2.Checked)
                {
                    hosting += "2 GB ";
                    tutar += 55;
                }
                if (checkEdit3.Checked)
                {
                    hosting += "4 GB ";
                    tutar += 80;
                }
                if (checkEdit4.Checked)
                {
                    hosting += "8 GB ";
                    tutar += 100;
                }
                if (checkEdit5.Checked)
                {
                    hosting += "Limitsiz ";
                    tutar += 120;
                }
                if (hosting == "")
                {
                    hosting += "yok";
                }
                if (checkEdit12.Checked)
                {
                    alanadi += ".com ";
                    tutar += 70;
                }
                if (checkEdit11.Checked)
                {
                    alanadi += ".net ";
                    tutar += 60;
                }
                if (checkEdit10.Checked)
                {
                    alanadi += ".org ";
                    tutar += 40;
                }
                if (checkEdit9.Checked)
                {
                    alanadi += ".xyz ";
                    tutar += 25;
                }
                if (checkEdit8.Checked)
                {
                    alanadi += ".com.tr ";
                }
                if(alanadi=="")
                {
                    alanadi += "yok";
                }
                if (checkEdit13.Checked)
                {
                    yazilim += "Yok ";
                }
                if (checkEdit14.Checked)
                {
                    yazilim += "Var ";
                }
                if (checkEdit7.Checked)
                {
                    DateTime biraysonra = bugun.AddMonths(1);
                }
                if (checkEdit6.Checked)
                {
                    
                }
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into musteri(adi,telefon,mail,adres,fiyat,tutar,hosting,alanadi,yazilim,sure) values (@adi,@telefon,@mail,@adres,@fiyat,@tutar,@hosting,@alanadi,@yazilim,@sure)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@adi", bunifuCustomTextbox1.Text);
                komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@mail", bunifuCustomTextbox2.Text);
                komut.Parameters.AddWithValue("@adres", richTextBox1.Text);
                komut.Parameters.AddWithValue("@fiyat", bunifuCustomTextbox3.Text);
                komut.Parameters.AddWithValue("@tutar", tutar);
                komut.Parameters.AddWithValue("@hosting", hosting);
                komut.Parameters.AddWithValue("@alanadi", alanadi);
                komut.Parameters.AddWithValue("@yazilim", yazilim);
                if (checkEdit6.Checked && checkEdit7.Checked==false)
                {
                    komut.Parameters.AddWithValue("@sure",bugun.AddYears(1) );
                }
                if (checkEdit7.Checked && checkEdit6.Checked == false)
                {
                    komut.Parameters.AddWithValue("@sure", bugun.AddMonths(1));
                }
                if (checkEdit7.Checked && checkEdit5.Checked)
                {
                    MessageBox.Show("hem ay hemde yılı işaretlediğiniz için tarih verisi kayıt olmamıştır.");
                }
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. Her bir alanda tek seçim yapınız lütfen." + hata.Message);
            }
        }
    }
}
