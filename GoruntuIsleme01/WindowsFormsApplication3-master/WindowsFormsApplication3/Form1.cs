using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//KNN ALGORİTMASI classifty
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        
        List<Coordinate> Coordinateliste = new List<Coordinate>();
       
        public Form1()
        {
            InitializeComponent();
            baslangic();
        }
        public void baslangic()
        {
            //listeye hazır elemanlar koyma
            Coordinate kor1 = new Coordinate();
            Coordinate kor2 = new Coordinate();
            Coordinate kor3 = new Coordinate();
            Coordinate kor4 = new Coordinate();

            kor1.x = 4; kor1.y = 3; kor1.sinif = "sinif1";
            Coordinateliste.Add(kor1);

            kor2.x = 1; kor2.y = 2; kor2.sinif = "sinif1";
            Coordinateliste.Add(kor2);

            kor3.x = 9; kor3.y = 5; kor3.sinif = "sinif2";
            Coordinateliste.Add(kor3);

            kor4.x = 5; kor4.y = 5; kor4.sinif = "sinif2";
            Coordinateliste.Add(kor4);

            //listeyi görüntüleme
            foreach (Coordinate i in Coordinateliste)
            {
                listBox1.Items.Add(i.x + " " + i.y + " " + i.sinif);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coordinate kor = new Coordinate();
            List<Distance> uzaklikliste = new List<Distance>();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            try
            {
                 kor.x = int.Parse(textBox1.Text);
                 kor.y = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                throw;
            }
            for (int i = 0; i < Coordinateliste.Count(); i++)
            {
                Distance uza = new Distance();
                uza.value = Math.Round(Math.Sqrt(Math.Pow(Coordinateliste[i].x - kor.x, 2) + Math.Pow(Coordinateliste[i].y - kor.y, 2)),3);
                uza.obj = Coordinateliste[i].sinif;             
                uzaklikliste.Add(uza);
            }
            for (int i = 0; i < uzaklikliste.Count(); i++)
            {
                listBox2.Items.Add(uzaklikliste[i].value + " " + uzaklikliste[i].obj);
            }        
            for (int i = 0; i < uzaklikliste.Count()-1; i++)
            {
                for (int j = 1; j < uzaklikliste.Count()-i; j++)
                {
                    if(uzaklikliste[j].value < uzaklikliste[j - 1].value)
                    {
                        Distance u = uzaklikliste[j - 1];
                        uzaklikliste[j - 1] = uzaklikliste[j];
                        uzaklikliste[j] = u;
                    }
                }
            }
            for (int i = 0; i < uzaklikliste.Count(); i++)
            {
                listBox3.Items.Add(uzaklikliste[i].value + " " + uzaklikliste[i].obj);
            }
            int a = 0; int b = 0;
            int KK = int.Parse(txt_Kdegeri.Text);
            if (KK <= Coordinateliste.Count())
            {
                for (int i = 0; i < KK; i++)
                {
                    if (uzaklikliste[i].obj == "sinif1") a++;
                    if (uzaklikliste[i].obj == "sinif2") b++;
                }
                if (a > b)
                {
                    kor.sinif = "sinif1";
                }
                else if (a < b)
                {
                    kor.sinif = "sinif2";
                }
                else
                {
                    kor.sinif = uzaklikliste[0].obj;
                }
                Coordinateliste.Add(kor);
                listBox1.Items.Clear();

                foreach (Coordinate kullanici in Coordinateliste)
                {
                    listBox1.Items.Add(kullanici.x + " " + kullanici.y + " " + kullanici.sinif);
                }
            }
            else
            {
                MessageBox.Show("Hata. Lütfen " + Coordinateliste.Count() + "'e esit veya kücük deger giriniz.");
            }
        }

      
    }

   
}
