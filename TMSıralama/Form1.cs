using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMSıralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Size = Convert.ToInt32(txtDiziBoyutu.Text) + 2;
            //Sıralanacak dizinin boyut konrolü yapılır
            if(Convert.ToInt32(txtDiziBoyutu.Text) > 1 && Convert.ToInt32(txtDiziBoyutu.Text) <= 10)
                frm2.ShowDialog();

            else if(Convert.ToInt32(txtDiziBoyutu.Text) <= 0)
                MessageBox.Show("Geçerli bir boyut giriniz!");

            else
                MessageBox.Show("Maksimum 10 boyutlu dizi giriniz!");
        }
        //Sadece sayı girilmesini sağlar
        private void txtDiziBoyutu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
