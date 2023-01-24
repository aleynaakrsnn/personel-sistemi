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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        OzOkulEntities1 con = new OzOkulEntities1();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.CListele().ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cocuk save = new Cocuk();
            
            save.AdSoyad = textBox1.Text;
            save.Cinsiyet = textBox2.Text;
            save.DogumTarihi = Convert.ToDateTime(maskedTextBox1.Text);
            save.PersonelNo =Convert.ToInt32(textBox3.Text);
            

            con.CEkle(save.AdSoyad, save.Cinsiyet, save.DogumTarihi, save.PersonelNo);
            con.SaveChanges();
            dataGridView1.DataSource = con.CListele().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            con.CSil(id);
            con.SaveChanges();
            dataGridView1.DataSource = con.CListele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cocuk update = new Cocuk();

            update.CocukNo=Convert.ToInt32(textBox1.Tag);  
            update.AdSoyad = textBox1.Text;
            update.Cinsiyet = textBox2.Text;
            update.DogumTarihi = Convert.ToDateTime(maskedTextBox1.Text);
            update.PersonelNo = Convert.ToInt32(textBox3.Text);

            con.CYenile(update.CocukNo,update.AdSoyad, update.Cinsiyet, update.DogumTarihi, update.PersonelNo);
            con.SaveChanges();
            dataGridView1.DataSource = con.CListele().ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cocuk search = new Cocuk();
            search.AdSoyad = textBox1.Text;

            con.CAra(search.AdSoyad);
            con.SaveChanges();
            dataGridView1.DataSource = con.CAra(search.AdSoyad);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form3 go = new Form3();
            go.Show();
            this.Hide();
        }
    }
}
