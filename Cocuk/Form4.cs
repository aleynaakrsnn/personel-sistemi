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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        OzOkulEntities1 con = new OzOkulEntities1();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.UListele().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Unvanlar update = new Unvanlar();

            update.UnvanNo = Convert.ToInt32(textBox1.Tag);
            update.UnvanAdi = textBox1.Text;
            
            con.UYenile(update.UnvanNo, update.UnvanAdi);
            con.SaveChanges();
            dataGridView1.DataSource = con.UListele().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            con.USil(id);
            con.SaveChanges();
            dataGridView1.DataSource = con.UListele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Unvanlar search = new Unvanlar();
            search.UnvanAdi = textBox1.Text;

            con.UAra(search.UnvanAdi);
            con.SaveChanges();
            dataGridView1.DataSource = con.UAra(search.UnvanAdi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Unvanlar save = new Unvanlar();

            save.UnvanAdi = textBox1.Text;

            con.UEkle(save.UnvanAdi);
            con.SaveChanges();
            dataGridView1.DataSource = con.UListele().ToList();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form3 go = new Form3();
            go.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form5 go = new Form5();
            go.Show();
            this.Hide();
        }
    }
}
