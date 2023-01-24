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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        OzOkulEntities1 con = new OzOkulEntities1();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.BListele().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Birimler update = new Birimler();

            update.BirimNo = Convert.ToInt32(textBox1.Tag);
            update.BirimAdi = textBox1.Text;

            con.UYenile(update.BirimNo, update.BirimAdi);
            con.SaveChanges();
            dataGridView1.DataSource = con.BListele().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            con.BSil(id);
            con.SaveChanges();
            dataGridView1.DataSource = con.BListele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Birimler search = new Birimler();
            search.BirimAdi = textBox1.Text;

            con.UAra(search.BirimAdi);
            con.SaveChanges();
            dataGridView1.DataSource = con.UAra(search.BirimAdi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Birimler save = new Birimler();

            save.BirimAdi = textBox1.Text;

            con.UEkle(save.BirimAdi);
            con.SaveChanges();
            dataGridView1.DataSource = con.BListele().ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 go = new Form4();
            go.Show();
            this.Hide();
        }
    }
}
