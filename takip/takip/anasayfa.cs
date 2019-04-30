using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takip
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                //Evet tıklandığında Yapılacak İşlemler
                Environment.Exit(0); // Evet tıklandığında uygulama kapanacak

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.SteelBlue;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            goster form = new goster();
            form.TopLevel = false;
            panel4.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            pictureBox2.Hide();
            panel4.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.SteelBlue;
            panel3.BackColor = Color.Transparent;
            Ekle form = new Ekle();
            form.TopLevel = false;
            panel4.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            pictureBox2.Hide();
            panel4.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            pictureBox2.Visible=true;
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.SteelBlue;
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.SteelBlue;
        }
        Point İlkkonum; // Bu değişkenler Global olarak tanımlanmalı.
        bool durum = false;
        private void anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
            durum = true;
            this.Cursor = Cursors.SizeAll; // Fareyi taşıma şeklinde seçim yapılmış ikon halini almasını sağladık.
            İlkkonum = e.Location;

        }

        private void anasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (durum)
            {
                this.Left = e.X + this.Left - (İlkkonum.X);
                this.Top = e.Y + this.Top - (İlkkonum.Y);
            }
        }

        private void anasayfa_MouseUp(object sender, MouseEventArgs e)
        {
            durum = false;
            this.Cursor = Cursors.Default; // Fare işaretçisi Default halini aldı.


        }
    }
}
