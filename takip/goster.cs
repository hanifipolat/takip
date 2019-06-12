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
    public partial class goster : Form
    {
        public goster()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            //sqlDataSource1.Fill();
        }

        private void goster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'takipDataSet12.musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.takipDataSet12.musteri);
            gridView1.BestFitColumns();
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsBehavior.Editable = true;
        }
        public static object mail;
        static string conString = "Data Source=HANIFI;Initial Catalog=takip;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);
        private void btndelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int[] selectedrows = gridView1.GetSelectedRows();
            foreach (int item in selectedrows)
            {
                if (item >= 0)
                {
                    mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colmail);
                }
            }

            baglanti.Open();
            string secmeSorgusu = "SELECT * from musteri where mail=@mail";
            //musterino parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@mail", mail.ToString());
            //musterino parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            //DataReader ile müşteri verilerini veritabanından belleğe aktardık.
            if (dr.Read()) //Datareader herhangi bir okuma yapabiliyorsa aşağıdaki kodlar çalışır.
            {
                string isim = dr["adi"].ToString().Trim();
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum) // Eğer kullanıcı Evet seçeneğini seçmişse, veritabanından kaydı silecek kodlar çalışır.
                {
                    string silmeSorgusu = "DELETE from musteri where mail=@mail";
                    //musterino parametresine bağlı olarak müşteri kaydını silen sql sorgusu
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@mail", mail.ToString());
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
                    //Silme işlemini gerçekleştirdikten sonra kullanıcıya mesaj verdik.
                }
            }
            else
                MessageBox.Show("Müşteri Bulunamadı.");
            baglanti.Close();
            this.musteriTableAdapter.Fill(this.takipDataSet12.musteri);
            gridView1.BestFitColumns();
        }
        
        private void btnedit_Click(object sender, EventArgs e)
        {
            
            int[] selectedrows = gridView1.GetSelectedRows();
            foreach (int item in selectedrows)
            {
                if (item >= 0)
                {
                    mail = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colmail);
                    duzenleform dzn = new duzenleform();
                    dzn.Show();
                }
            }
        }
    }
}
