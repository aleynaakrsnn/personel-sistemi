using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OzOkulEntities1 con = new OzOkulEntities1();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personel1 save = new Personel1();
            save.AdSoyad = textBox1.Text;
            save.Cinsiyet = textBox2.Text;
            save.BaslamaTarihi =Convert.ToDateTime(maskedTextBox1.Text);
            save.VardiyaDurumu = textBox3.Text;
            save.Maas = Convert.ToDecimal(textBox4.Text);
            save.Prim = Convert.ToInt32(textBox5.Text);
            save.GorevNo = Convert.ToInt32(textBox6.Text);
            save.UnvanNo = Convert.ToInt32(textBox7.Text);


            con.PeEkle(save.AdSoyad, save.Cinsiyet, save.BaslamaTarihi, save.VardiyaDurumu, save.Maas,save.Prim,save.GorevNo,save.UnvanNo);
            con.SaveChanges();
            dataGridView1.DataSource = con.PeListele().ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.PeListele().ToList();
                                        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personel1 update = new Personel1();


            update.PersonelNo = Convert.ToInt32(textBox1.Tag);
            update.AdSoyad = textBox1.Text;
            update.Cinsiyet = textBox2.Text;
            update.BaslamaTarihi = Convert.ToDateTime(maskedTextBox1.Text);
            update.VardiyaDurumu = textBox3.Text;
            update.Maas = Convert.ToDecimal(textBox4.Text);
            update.Prim = Convert.ToInt32(textBox5.Text);
            update.GorevNo = Convert.ToInt32(textBox6.Text);
            update.UnvanNo = Convert.ToInt32(textBox7.Text);

            con.PeYenile(update.PersonelNo, update.AdSoyad, update.Cinsiyet, update.BaslamaTarihi, update.VardiyaDurumu, update.Maas, update.Prim,update.GorevNo,update.UnvanNo);
            con.SaveChanges();
            dataGridView1.DataSource = con.PeListele().ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Personel1 search = new Personel1();
            search.AdSoyad = textBox1.Text;

            con.PeAra(search.AdSoyad);
            con.SaveChanges();
            dataGridView1.DataSource = con.PeAra(search.AdSoyad);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            con.PeSil(id);
            con.SaveChanges();
            dataGridView1.DataSource = con.PeListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["PersonelNo"].Value.ToString();
            textBox1.Text = satir.Cells["AdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["Cinsiyet"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["BaslamaTarihi"].Value.ToString();
            textBox3.Text = satir.Cells["VardiyaDurumu"].Value.ToString();
            textBox4.Text = satir.Cells["Maas"].Value.ToString();
            textBox5.Text = satir.Cells["Prim"].Value.ToString();
            textBox6.Text = satir.Cells["GorevNo"].Value.ToString();
            textBox7.Text = satir.Cells["UnvanNo"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form2 go = new Form2();
            go.Show();
            this.Hide();
        }
    }
}
