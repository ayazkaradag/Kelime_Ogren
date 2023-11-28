using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kelime_Ogren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglanti=new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Karadag\Desktop\dbSozluk.accdb");
        Random rast=new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtİng.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text=lblCevap.Text.ToLower();

            }
            baglanti.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            txtTurk.Focus();
            timer1.Start();
            
        }

        private void txtTurk_TextChanged(object sender, EventArgs e)
        {
            if(txtTurk.Text ==lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                txtTurk.Clear();

            }
        }

        private void lblKelime_Click(object sender, EventArgs e)
        {

        }

        private void lblSure_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if(sure == 0)
            {
                txtTurk.Enabled = false;
                txtİng.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
