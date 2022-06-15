using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampiyonlarLigiSimilasyonuFormApp
{
    public partial class Form1 : Form
    {
        List<Takimlar> takimlar = new List<Takimlar>();

        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            takimlar = new List<Takimlar>();

            //1.torba

            Takimlar yenitakim=null; 

            yenitakim = new Takimlar("Bayern Münih", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Sevilla", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Juventuus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Paris Saint-Germain", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Zenit", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Porto", "Portekiz");
            takimlar.Add(yenitakim);
            //2.torba
            yenitakim = new Takimlar("Barcelona", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Atletico Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Borussia Dortmund", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Shaktar Donetsk", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Chelsea", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Ajax", "Hollanda");
            takimlar.Add(yenitakim);
            //3.torba
            yenitakim = new Takimlar("Dynamo Kiev", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Red Bull Salzburg", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("RB Leipzig", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("İnternazionale", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Olympiacos", "Yunanistan");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Lazio", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar(" Krasnodar", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Atalanta", "İtalya");
            takimlar.Add(yenitakim);
            //4.torba
            yenitakim = new Takimlar(" Lokomotiv Moskova", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Marseille", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Club Brugge", "Belçika");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Bor. Mönchengladbach", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Galatasaray", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Midtjylland", "Danimarka");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Rennes", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takimlar("Ferencváros", "Macaristan");
            takimlar.Add(yenitakim);





        }
        //GRUP ATAMASI
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox_ALL.Visible = true;

            Random rastgeletakim = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int  j = 0;  j < 4;  j++)
            {
                secilentakimlar.Clear();

                for (int i = 0; i < 8; i++)
                {
                    int secilentakim = rastgeletakim.Next(0, takimlar.Count / 4);

                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool takimKontrolu = false;

                for (int k = 0; k < 8; k++)
                {
                    takimKontrolu = ayniUlkeTakimKontrolu(gruplar[k], torbalar[j].Items[secilentakimlar[k]] as Takimlar );
                    if (takimKontrolu)
                    
                        break;
                    
                }
                if (!takimKontrolu)
                {
                    listBox1.Items.Add(torbalar[j].Items[secilentakimlar[0]] as Takimlar);
                    listBox2.Items.Add(torbalar[j].Items[secilentakimlar[1]] as Takimlar);
                    listBox3.Items.Add(torbalar[j].Items[secilentakimlar[2]] as Takimlar);
                    listBox4.Items.Add(torbalar[j].Items[secilentakimlar[3]] as Takimlar);
                    listBox5.Items.Add(torbalar[j].Items[secilentakimlar[4]] as Takimlar);
                    listBox6.Items.Add(torbalar[j].Items[secilentakimlar[5]] as Takimlar);
                    listBox7.Items.Add(torbalar[j].Items[secilentakimlar[6]] as Takimlar);
                    listBox8.Items.Add(torbalar[j].Items[secilentakimlar[7]] as Takimlar);
                }
                else
                {
                    j--;
                }
            }
        }
        private bool ayniUlkeTakimKontrolu (ListBox gruplar,Takimlar takim)
        {
            bool durum = false;
            for (int i = 0; i < gruplar.Items.Count; i++)
            {
                Takimlar gruptakim = gruplar.Items[i] as Takimlar;
                if (gruptakim.TeamCountry==takim.TeamCountry)
                {
                    durum = true;
                    break;
                } 
            }
            return durum;
        }
        //TORBA ATAMASI BUTONU (TORBALAR)
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox_ALL.Visible = true;

            torbaList1.Items.Add(takimlar[0]);
            torbaList1.Items.Add(takimlar[1]);
            torbaList1.Items.Add(takimlar[2]);
            torbaList1.Items.Add(takimlar[3]);
            torbaList1.Items.Add(takimlar[4]);
            torbaList1.Items.Add(takimlar[5]);
            torbaList1.Items.Add(takimlar[6]);
            torbaList1.Items.Add(takimlar[7]);

            torbaList2.Items.Add(takimlar[8]);
            torbaList2.Items.Add(takimlar[9]);
            torbaList2.Items.Add(takimlar[10]);
            torbaList2.Items.Add(takimlar[11]);
            torbaList2.Items.Add(takimlar[12]);
            torbaList2.Items.Add(takimlar[13]);
            torbaList2.Items.Add(takimlar[14]);
            torbaList2.Items.Add(takimlar[15]);

            torbaList3.Items.Add(takimlar[16]);
            torbaList3.Items.Add(takimlar[17]);
            torbaList3.Items.Add(takimlar[18]);
            torbaList3.Items.Add(takimlar[19]);
            torbaList3.Items.Add(takimlar[20]);
            torbaList3.Items.Add(takimlar[21]);
            torbaList3.Items.Add(takimlar[22]);
            torbaList3.Items.Add(takimlar[23]);

            torbaList4.Items.Add(takimlar[24]);
            torbaList4.Items.Add(takimlar[25]);
            torbaList4.Items.Add(takimlar[26]);
            torbaList4.Items.Add(takimlar[27]);
            torbaList4.Items.Add(takimlar[28]);
            torbaList4.Items.Add(takimlar[29]);
            torbaList4.Items.Add(takimlar[30]);
            torbaList4.Items.Add(takimlar[31]);

            torbalar.Add(torbaList1);
            torbalar.Add(torbaList2);
            torbalar.Add(torbaList3);
            torbalar.Add(torbaList4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);

        }
        //KARŞILAŞMALAR
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox_ALL.Visible = false;
        }
    }
}
