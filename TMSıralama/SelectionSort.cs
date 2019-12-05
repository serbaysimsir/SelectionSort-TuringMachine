using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace TMSıralama
{
    class SelectionSort
    {

        public void Sort(int[] items , List<TextBox> textbox, List<Label> label)
        {
            int n = items.Length;
            int minIndis = 0;
            int bosIndis = 0;
            bool bittimi = false;

            for (int i = 0; i < n; i++)
            {

                SelectionSort.labelAyar(label, i);
                //minimumum i olarak ayarla
                minIndis = i;
                //i'den sonraki tüm elemanları tara
                for (int j = i + 1; j < n+1; j++)
                {
                    SelectionSort.labelAyar(label, j);
                    //daha küçük eleman bulursan indisini sakla
                    if (n != j && items[j] < items[minIndis] )
                    {
                        minIndis = j;
                    }
                    System.Threading.Thread.Sleep(1000);
                    Application.DoEvents();
                }

                //en küçük indis değiştiyse, yani i'den sonraki elemanlardan birisi i'den küçükse
                //takas işlemi gerçekleştir
                if (minIndis != i)
                {
                   
                    int temp = items[i];
                    items[i] = items[minIndis];
                    SelectionSort.labelAyar(label, i);
                    textbox[i].Text = items[minIndis].ToString();
                    textbox[i + 1].Text = "*";
                    SelectionSort.labelAyar(label, i);
                    bosIndis = i + 1;
                    items[minIndis] = temp;
                    textbox[minIndis+1].Text = temp.ToString();
                    System.Threading.Thread.Sleep(1000);
                    Application.DoEvents();
          
                }
                //minindis=i ise boşlukları sağa kaydırır
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    Application.DoEvents();
                    SelectionSort.labelAyar(label, i+1);
                    System.Threading.Thread.Sleep(1000);
                    Application.DoEvents();
                    SelectionSort.labelAyar(label, i);
                    textbox[i].Text = textbox[i+1].Text;
                    
                    textbox[i+1].Text="*";
                    bosIndis = i + 1;
                    bittimi = true;
                }
                      
            }
            //sıralama işlemibittikten sonra boşluklar yan yana gelene kadar boşlukları kaydırır
            if(bittimi == true)
            {
                for (int j = bosIndis; j <= items.Length; j++)
                {
                    System.Threading.Thread.Sleep(1000);
                    Application.DoEvents();
                    SelectionSort.labelAyar(label, j);
                    textbox[j].Text = textbox[j + 1].Text;
                    textbox[j + 1].Text="*";
                }
                //işlemin bittiğini gösterir
                textbox[n].Text = "!";
            }
           
        }
        //çalışma sırasında o anki textbox ı göstermek için imlecin hareketi yapılır
        public static void labelAyar(List<Label> labels, int indis)
        {
            int sayac = 0;
            foreach (Label item in labels)
            {
                if (sayac == indis)
                {
                    item.Visible = true;
                    System.Threading.Thread.Sleep(1000);
                    Application.DoEvents();
                }
                else
                    item.Visible = false;
                sayac++;
            }
        }
    }
}
