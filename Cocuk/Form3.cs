using System;
using System.Linq;
using System.Windows.Forms;

namespace Cocuk
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        OzOkulEntities1 con = new OzOkulEntities1();


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.PrListele().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proje save = new Proje();
           
            save.ProjeAd = textBox1.Text;
            save.BaslamaTarihi = Convert.ToDateTime(maskedTextBox1.Text);
            save.BitisTarihi = Convert.ToDateTime(maskedTextBox2.Text);
            save.GorevNo = Convert.ToInt32(textBox2.Text);


            con.PrEkle(save.ProjeAd,save.BaslamaTarihi,save.BitisTarihi, save.GorevNo);
            con.SaveChanges();
            dataGridView1.DataSource = con.PrListele().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Tag);
            con.PrSil(id);
            con.SaveChanges();
            dataGridView1.DataSource = con.PrListele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Proje update = new Proje();

            update.ProjeNo = Convert.ToInt32(textBox1.Tag);
            update.ProjeAd = textBox1.Text;
            update.BaslamaTarihi = Convert.ToDateTime(maskedTextBox1.Text);
            update.BitisTarihi = Convert.ToDateTime(maskedTextBox2.Text);
            update.GorevNo = Convert.ToInt32(textBox2.Text);

            con.PrYenile(update.ProjeNo, update.ProjeAd, update.BaslamaTarihi, update.BitisTarihi, update.GorevNo);
            con.SaveChanges();
            dataGridView1.DataSource = con.CListele().ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Proje search = new Proje();
            search.ProjeAd = textBox1.Text;

            con.CAra(search.ProjeAd);
            con.SaveChanges();
            dataGridView1.DataSource = con.PrAra(search.ProjeAd);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
