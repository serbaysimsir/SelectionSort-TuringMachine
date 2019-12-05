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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public  int Size { get; set; }
        List<TextBox> textboxlar = new List<TextBox>();
        List<Label> labeller = new List<Label>();
        private void Form2_Load(object sender, EventArgs e)
        {
            //Girilen dizi boyutuna göre textboxlar ve oklar oluşturulur.
            for (int i = 0; i < Size; i++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(70 + (50 * i),  170);
                label.Size = new System.Drawing.Size(50, 50);
                label.Text = "       ↑";
                this.Controls.Add(label);
                labeller.Add(label);
                TextBox yenitext = new TextBox();
                yenitext.TextAlign = HorizontalAlignment.Center;
                yenitext.Location = new System.Drawing.Point(70 + (50 * i), 150);
                yenitext.Size = new System.Drawing.Size(50, 50);
                this.Controls.Add(yenitext);
                textboxlar.Add(yenitext);
                if(i == 0 || i == Size - 1)
                {
                    yenitext.Enabled = false;
                    yenitext.Text = "*";
                }
            }
            SelectionSort.labelAyar(labeller, 56);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Girilen girdilerin sayı değeri olması sağlanır
            int sayac = 0;
            int[] Dizi = new int[Size - 2];
            try
            {
                foreach (TextBox textBox in textboxlar)
                {
                    if (sayac != 0)
                        Dizi[sayac - 1] = Convert.ToInt32(textBox.Text);

                    if (sayac == Size - 2)
                    {
                        break;
                    }
                    sayac++;
                }
                button2.Visible = false;
                //textboxların değerlerinin değiştirilmemesi için kapatılması
                foreach (TextBox item in textboxlar)
                {
                    item.Enabled = false;
                }
                SelectionSort sıralama = new SelectionSort();
                sıralama.Sort(Dizi, textboxlar, labeller);
                
            }
            catch (Exception)
            {
                //Geçersiz değer girdisi yapıldığı zaman textbox ların sıfırlanması
                MessageBox.Show("Geçerli değerler giriniz!");
                int sayac2 = 0;
                foreach (TextBox item in textboxlar)
                {
                    item.Text = "";
                    if (sayac2 == 0 || sayac2 == Size - 1)
                    {
                        item.Text = "*";
                    }
                    sayac2++;
                }
            }
            
        }
    }

}
