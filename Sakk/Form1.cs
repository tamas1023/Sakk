using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakk
{
    public partial class Form1 : Form
    {
        static PictureBox[,] kepek = new PictureBox[8, 8];
        static Babuk[,] babok = new Babuk[8, 8];
        static int honnani;
        static int honnanj;
        static string nev1;
        static string nev2;
        static int honvaigyalog;
        static int honvajgyalog;
        static bool valaszt = true;
        static bool feher = true;
        static string sakkszin ="fehér";
        static bool sakkvane = false;
        static List<int> lephetlista = new List<int>();
        static List<int> uthetlista = new List<int>();
        static List<bool> sakkotadott = new List<bool>();
        static List<string> sakkbanszin = new List<string>();
        static int hanyadik = 0;
        public Form1()
        {
            InitializeComponent();
            gombokkinezetvaltozas();
            pictureBox5.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void gombokkinezetvaltozas()
        {
            leirasBTN.FlatStyle = FlatStyle.Flat;
            leirasBTN.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            tovabbutton.FlatStyle = FlatStyle.Flat;
            tovabbutton.FlatAppearance.BorderSize = 0;
            visszabutton.FlatStyle = FlatStyle.Flat;
            visszabutton.FlatAppearance.BorderSize = 0;

            feladasfeherbtn.FlatStyle = FlatStyle.Flat;
            feladasfeherbtn.FlatAppearance.BorderSize = 0;
            feladasfeketebn.FlatStyle = FlatStyle.Flat;
            feladasfeketebn.FlatAppearance.BorderSize = 0;

        }

        private void babokfeltoltese()
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    babok[i, j] = new Babuk(-1, "", "", 0, 0);
                }
            }
            babok[0, 0] = new Babuk(0, "bástya", "fehér", 0, 0);
            kepek[0, 0].Image = Image.FromFile("../../img/white_rook.png");
            babok[1, 0] = new Babuk(1, "huszár", "fehér", 1, 0);
            kepek[1, 0].Image = Image.FromFile("../../img/white_knight.png");
            babok[2, 0] = new Babuk(2, "futó", "fehér", 2, 0);
            kepek[2, 0].Image = Image.FromFile("../../img/white_bishop.png");
            babok[3, 0] = new Babuk(3, "vezér", "fehér", 3, 0);
            kepek[3, 0].Image = Image.FromFile("../../img/white_queen.png");
            babok[4, 0] = new Babuk(4, "király", "fehér", 4, 0);
            kepek[4, 0].Image = Image.FromFile("../../img/white_king.png");
            babok[5, 0] = new Babuk(5, "futó", "fehér", 5, 0);
            kepek[5, 0].Image = Image.FromFile("../../img/white_bishop.png");
            babok[6, 0] = new Babuk(6, "huszár", "fehér", 6, 0);
            kepek[6, 0].Image = Image.FromFile("../../img/white_knight.png");
            babok[7, 0] = new Babuk(7, "bástya", "fehér", 7, 0);
            kepek[7, 0].Image = Image.FromFile("../../img/white_rook.png");


            babok[0, 7] = new Babuk(24, "bástya", "fekete", 0, 7);
            kepek[0, 7].Image = Image.FromFile("../../img/black_rook.png");
            babok[1, 7] = new Babuk(25, "huszár", "fekete", 1, 7);
            kepek[1, 7].Image = Image.FromFile("../../img/black_knight.png");
            babok[2, 7] = new Babuk(26, "futó", "fekete", 2, 7);
            kepek[2, 7].Image = Image.FromFile("../../img/black_bishop.png");
            babok[3, 7] = new Babuk(27, "vezér", "fekete", 3, 7);
            kepek[3, 7].Image = Image.FromFile("../../img/black_queen.png");
            babok[4, 7] = new Babuk(28, "király", "fekete", 4, 7);
            kepek[4, 7].Image = Image.FromFile("../../img/black_king.png");
            babok[5, 7] = new Babuk(29, "futó", "fekete", 5, 7);
            kepek[5, 7].Image = Image.FromFile("../../img/black_bishop.png");
            babok[6, 7] = new Babuk(30, "huszár", "fekete", 6, 7);
            kepek[6, 7].Image = Image.FromFile("../../img/black_knight.png");
            babok[7, 7] = new Babuk(31, "bástya", "fekete", 7, 7);
            kepek[7, 7].Image = Image.FromFile("../../img/black_rook.png");
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (j == 1)
                    {
                        babok[i, j] = new Babuk(i + 8, "gyalog", "fehér", i, j);
                        kepek[i, j].Image = Image.FromFile("../../img/white_pawn.png");
                    }
                    if (j == 6)
                    {
                        babok[i, j] = new Babuk(i + 16, "gyalog", "fekete", i, j);
                        kepek[i, j].Image = Image.FromFile("../../img/black_pawn.png");
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           

            nev1 = textBox1.Text;
            nev2 = textBox2.Text;
            if (nev1 == "" || nev2 == "")
            {
                hibaLBL.Text = "Nincs megadva minden név!";
            }
            else
            {
                if (nev2 == nev1)
                {
                    hibaLBL.Text = "Ne adjatok meg ugyanolyan nevet!";
                }
                else
                {
                    panel1.Size = new Size(400, 400);
                    pictureBox6.Visible = false;
                    hibaLBL.Text = "";
                    panel1.Visible = true;
                    tablageneralas();
                    babokfeltoltese();
                    leirasBTN.Visible = false;
                    button1.Visible = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    feladasfeherbtn.Visible = true;
                    feladasfeketebn.Visible = true;
                    
                }
            }

        }

        private void tablageneralas()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox kep = new PictureBox();
                    kep.Location = new System.Drawing.Point(0 + (i * 50), 0 + (j * 50));
                    kep.Name = j + "";
                    kep.Visible = true;
                    kep.Size = new System.Drawing.Size(50, 50);
                
                  
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            kep.BackColor = Color.White;
                        }
                        else
                        {
                            kep.BackColor = Color.Gray;
                        }

                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            kep.BackColor = Color.Gray;
                        }
                        else
                        {
                            kep.BackColor = Color.White;
                        }
                    }
                    kep.Tag = i;
                    kep.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Controls.Add(kep);
                    panel1.Controls.Add(kep);
                    kepek[i, j] = kep;
                    kep.Click += new System.EventHandler(this.palyaklikk);
                }
            }

        }
        private void palyaklikk(object sender, EventArgs e)
        {
            PictureBox kapcsolt = sender as PictureBox;
            if (valaszt)
            {
                
                if (feher)
                {
                    if (babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Id >= 0 && babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Szin == "fehér")
                    {
                        torolszinek();
                        honnani = Convert.ToInt32(kapcsolt.Tag);
                        honnanj = Convert.ToInt32(kapcsolt.Name);
                        babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].lephete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), lephetlista);
                        babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].uthete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), uthetlista);
                        szinezes();
                    }
                    if (valaszt && kapcsolt.Image == null)
                    {
                        valaszt = false;
                    }
                    if (valaszt && kepek[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].BackColor == Color.Red)
                    {
                        valaszt = false;
                    }
                }
                else
                {
                    if (babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Id >= 0 && babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Szin == "fekete")
                    {
                        torolszinek();
                        honnani = Convert.ToInt32(kapcsolt.Tag);
                        honnanj = Convert.ToInt32(kapcsolt.Name);
                        babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].uthete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), uthetlista);
                        babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].lephete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), lephetlista);
                        szinezes();
                    }
                    if (valaszt && kapcsolt.Image == null)
                    {
                        valaszt = false;
                    }
                    if (valaszt && kepek[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].BackColor == Color.Red)
                    {
                        valaszt = false;
                    }
                }
            }
            if (!valaszt && kapcsolt.BackColor == Color.Orange)
            {
                lepes(Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name));
                babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].sakkvane(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), sakkotadott, sakkbanszin);
                 //MessageBox.Show(sakkszin);
                sakkbanvane();
                if (sakkvane)
                {
                   // MessageBox.Show(sakkszin);
                    for (int j = 0; j < 7; j++)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            if (babok[i, j].Tipus == "király" && babok[i, j].Szin == sakkszin)
                            {
                                kepek[i, j].BackColor = Color.Brown;
                                MessageBox.Show("Sakkban van a " + sakkszin + " Király");
                            }
                        }
                    }
                }
                //MessageBox.Show(babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Szin + "típus: " + babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Tipus);
                // MessageBox.Show("name: babok[honnani,honnanj].huszar()j:" +kepek[Convert.ToInt32(kapcsolt.Tag),Convert.ToInt32(kapcsolt.Name)].Name+"tag: i: "+ kepek[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Tag);

                if (feher)
                {
                    feher = false;
                }
                else
                {
                    feher = true;
                }
                // MessageBox.Show("teszt:" + lephetlista[0]);
                valaszt = true;
                torolszinek();
                sakkvane = false;
            }
            if (!valaszt && kapcsolt.BackColor == Color.Red)
            {
                //MessageBox.Show("üt");
                
                utes(Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name));
                lepes(Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name));
                babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].sakkvane(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), sakkotadott, sakkbanszin);
               // MessageBox.Show(sakkszin);
                sakkbanvane();
                if (sakkvane)
                {
                    //MessageBox.Show(sakkszin);
                    for (int j = 0; j < 7; j++)
                    {
                        for (int i = 0; i < 7; i++)
                        {
                            if (babok[i, j].Tipus == "király" && babok[i, j].Szin == sakkszin)
                            {
                                kepek[i, j].BackColor = Color.Brown;
                                MessageBox.Show("Sakkban van a " + sakkszin + " Király");
                            }
                        }
                    }
                }
                if (feher)
                {
                    feher = false;
                }
                else
                {
                    feher = true;
                }
                valaszt = true;
                torolszinek();
                sakkvane = false;
      
            }
        }

        private void sakkbanvane()
        {
            if(sakkotadott.Count!=0)
            {
                sakkvane = true;
                sakkszin = sakkbanszin[0];
            }
        }

        private void utes(int i, int j)
        {
            kepek[i, j].Image = null;
            babok[i, j] = new Babuk(-1, "", "", 0, 0);
        }

        private void lepes(int i, int j)
        {

            kepek[i, j].Image = kepek[honnani, honnanj].Image;
            kepek[honnani, honnanj].Image = null;

            babok[i, j] = babok[honnani, honnanj];
            babok[honnani, honnanj] = babok[honnani, honnanj] = new Babuk(-1, "", "", 0, 0);
            if (babok[i, j].Tipus == "gyalog")
            {
                gyalogvaltas(i, j);
            }
        }

        private void gyalogvaltas(int i, int j)
        {
            if (j == 7)
            {
                honvaigyalog = i;
                honvajgyalog = j;
                pictureBox5.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Image = Image.FromFile("../../img/white_rook.png");
                pictureBox2.Image = Image.FromFile("../../img/white_knight.png");
                pictureBox3.Image = Image.FromFile("../../img/white_bishop.png");
                pictureBox4.Image = Image.FromFile("../../img/white_queen.png");
                panel1.Enabled = false;

            }
            if (j == 0)
            {
                honvaigyalog = i;
                honvajgyalog = j;
                pictureBox5.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Image = Image.FromFile("../../img/black_rook.png");
                pictureBox2.Image = Image.FromFile("../../img/black_knight.png");
                pictureBox3.Image = Image.FromFile("../../img/black_bishop.png");
                pictureBox4.Image = Image.FromFile("../../img/black_queen.png");
                panel1.Enabled = false;

            }
        }

        private void szinezes()
        {
            int segedi = 0;
            int segedj = 0;
            int db = 0;
            // MessageBox.Show(""+lephetlista.Count);
            for (int i = 0; i < lephetlista.Count; i++)
            {
                if (i % 2 == 0)
                {
                    //MessageBox.Show("belépett osztva 0");
                    segedi = lephetlista[i];
                    db++;
                }
                if (i % 2 == 1)
                {
                    // MessageBox.Show("belépett osztva 1");
                    segedj = lephetlista[i];
                    db++;
                }
                if (db == 2)
                {
                    //MessageBox.Show("szinezés:" + segedi + " " + segedj);
                    kepek[segedi, segedj].BackColor = Color.Orange;
                    db = 0;
                }
            }
            segedi = 0;
            segedj = 0;
            for (int i = 0; i < uthetlista.Count; i++)
            {
                if (i % 2 == 0)
                {
                    //MessageBox.Show("belépett osztva 0");
                    segedi = uthetlista[i];
                    db++;
                }
                if (i % 2 == 1)
                {
                    // MessageBox.Show("belépett osztva 1");
                    segedj = uthetlista[i];
                    db++;
                }
                if (db == 2)
                {
                    //MessageBox.Show("szinezés:" + segedi + " " + segedj);
                    kepek[segedi, segedj].BackColor = Color.Red;
                    db = 0;
                }
            }
            
        }

        private void torolszinek()
        {
            lephetlista.Clear();
            uthetlista.Clear();
            sakkbanszin.Clear();
            sakkotadott.Clear();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (kepek[i, j].BackColor == Color.Orange || kepek[i, j].BackColor == Color.Red||kepek[i,j].BackColor==Color.Brown)
                    {
                        if (i % 2 == 0)
                        {
                            if (j % 2 == 0)
                            {
                                kepek[i, j].BackColor = Color.White;
                            }
                            else
                            {
                                kepek[i, j].BackColor = Color.Gray;
                            }

                        }
                        else
                        {
                            if (j % 2 == 0)
                            {
                                kepek[i, j].BackColor = Color.Gray;
                            }
                            else
                            {
                                kepek[i, j].BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                                       Color.Chocolate,
                                                                       Color.WhiteSmoke,
                                                                       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }


            private void pictureBox5_Click(object sender, EventArgs e)
            {
                panel1.Enabled = true;
                kepek[honvaigyalog, honvajgyalog].Image = pictureBox5.Image;
                babok[honvaigyalog, honvajgyalog].Tipus = "bástya";
                pictureboxeltuntetes();

            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
               
            }

            private void pictureBox3_Click(object sender, EventArgs e)
            {
                
            }

            private void pictureBox4_Click(object sender, EventArgs e)
            {
                
            }

            private void pictureboxeltuntetes()
            {
                pictureBox5.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

            }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            kepek[honvaigyalog, honvajgyalog].Image = pictureBox2.Image;
            babok[honvaigyalog, honvajgyalog].Tipus = "huszár";
            pictureboxeltuntetes();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            kepek[honvaigyalog, honvajgyalog].Image = pictureBox3.Image;
            babok[honvaigyalog, honvajgyalog].Tipus = "futó";
            pictureboxeltuntetes();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            kepek[honvaigyalog, honvajgyalog].Image = pictureBox4.Image;
            babok[honvaigyalog, honvajgyalog].Tipus = "vezér";
            pictureboxeltuntetes();
        }

        private void leirasBTN_Click(object sender, EventArgs e)
        {
            if (leirasBTN.Text=="Szabályok")
            {
                pictureBox6.Visible = false;
                button1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                tovabbutton.Visible = true;
                visszabutton.Visible = true;
                leirasBTN.Text = "Főmenü";
                LeirasLBL.Text = "Szöveg!";
                hanyadik = 0;
                kiiras();
            }
            else
            {
                pictureBox6.Visible = true;
                button1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                tovabbutton.Visible = false;
                visszabutton.Visible = false;
                LeirasLBL.Text = "";
                leirasBTN.Text = "Szabályok";
                pictureBox7.Image = null;
            }
            
        }

        private void tovabbutton_Click(object sender, EventArgs e)
        {
            if (hanyadik >= 0 && hanyadik <= 7)
            {
                if (tovabbutton.Text == "Tovább")
                {
                    hanyadik++;
                }
            }
            

            kiiras();
        }

        private void kiiras()
        {
            if (hanyadik == 0)
            {
                pictureBox7.Image = Image.FromFile("../../img/sakktabla.png");
                LeirasLBL.Text = "A sakkjátékot két játékos játssza egymás ellen a négyzet alakú, nyolc sorra és nyolc oszlopra felosztott sakktáblán, 16–16, azaz összesen 32 bábuval. A két játékos bábui határozottan eltérő színűek. A színek elnevezése világos, illetve sötét. A játékosok felváltva lépnek, és mindkettejük célja, hogy a másik fél király nevű figuráját a játékszabályok szerint bemattolják (azaz megtámadják, mégpedig úgy, hogy a támadást ne tudja elhárítani).";
                //kep1.Image = Image.FromFile("kep1.jpg");
            }
            if (hanyadik == 1)
            {
                pictureBox7.Image = Image.FromFile("../../img/sakkbabuk.png");
                LeirasLBL.Text = "A játék kezdetén a világosnak és a sötétnek ugyanannyi figurája van: 1–1 király, 1–1 vezér (alternatív neve: „királynő”), 2–2 bástya (alternatív neve: „torony”), 2–2 huszár (alternatív neve: „ló”), 2–2 futó és 8–8 gyalog (alternatív neve: „paraszt”). A figurák kiindulási helyzetét, illetve mozgatásuk lehetőségeit a játék szabálya határozza meg.";
                
            }
            if (hanyadik == 2)
            {
                //király
                pictureBox7.Image = Image.FromFile("../../img/kiraly.png");
                LeirasLBL.Text = "A király a játék legfontosabb bábja, hiszen az egész játék a bemattolására irányul. Bármely irányban (vízszintesen, függőlegesen, átlósan) léphet, de csak egy mezőt, kivéve ha sáncol.Két király nem állhat közvetlen egymás mellett.A király mozgását korlátozza, hogy sakkba nem léphet, azaz nem állhat olyan mezőre, amelyen ki lehetne ütni. Ha mégis megtámadják, akkor a Sakkadás című szakaszban ismertetett háromféle mód valamelyikével meg kell szüntetni a támadást. Amennyiben az ott leírtak közül egyiket sem lehet végrehajtani, de a király ütésben van, akkor a király mattot kapott.";
                
            }
            if (hanyadik == 3)
            {
                //vezér
                pictureBox7.Image = Image.FromFile("../../img/vezer.png");
                LeirasLBL.Text = "A vezér mozgása olyan, mintha egyesítettünk volna egy futót egy bástyával, azaz egyenesen vagy átlósan bármely irányban, bármennyi mezőt léphet, mindaddig, amíg a tábla széléhez nem ér, vagy egy másik figura nem kerül az útjába (ha ez ellenséges figura, kiütheti, ha saját báb, meg kell állnia egy mezővel előtte). E szabály egyébként a huszár (és a sáncolás nevű lépés) kivételével minden figurára igaz. Tág mozgáslehetőségéből adódóan a vezér a sakkjáték legerősebb figurája.";
                
            }
            if (hanyadik == 4)
            {
                //Bástya
                pictureBox7.Image = Image.FromFile("../../img/bastya.png");
                LeirasLBL.Text = "A bástya bármennyi mezőt léphet, de csak függőleges és vízszintes irányban, átlósan nem, így egy helyről, bárhol is áll a sakktáblán, 14 mezőre léphet, ha másik figura nincs az útjában. Legjobban a nyílt vonalakat „kedvelik”, azaz az olyan vonalakat, amelyeken nem áll más bábu, mert itt tudják legjobban kifejteni erejüket. Kivételes lépése a sáncolás. A megnyitásban a világossal játszó játékos bástyái az a1-es és a h1-es, a sötéttel játszó félé pedig az a8-as és a h8-as mezőkön helyezkednek el.";
                
            }
            if (hanyadik == 5)
            {
                //futó
                pictureBox7.Image = Image.FromFile("../../img/futo.png");
                LeirasLBL.Text = "A futók átlós irányban léphetnek, bármennyi mezőt, amíg egy másik báb nem kerül útjába. A játékosok a játék elején két-két futóval rendelkeznek, melyek közül az egyik csak a sötét, a másik csak a világos mezőkön közlekedik. A futók a megnyitásban a világossal játszó félnek a c1-es és az f1-es, a sötét bábukkal játszó játékosnak pedig a c8-as és az f8-as mezején helyezkednek el.";
                
            }
            if (hanyadik == 6)
            {
                //huszár
                pictureBox7.Image = Image.FromFile("../../img/huszar.png");
                LeirasLBL.Text = "A huszár a róla elnevezett „lóugrásban” lép: vízszintesen jobbra vagy balra két mezőt, majd függőlegesen fel vagy le egyet (vagy fordítva: függőlegesen fel vagy le kettőt és vízszintesen jobbra vagy balra egyet). Mivel a huszárnak nincs konkrét menetiránya, csak kiindulási és érkezési mezője (azaz nem „halad”, hanem ugrik), nincs értelme „útjában álló bábról” beszélni. A huszár lépéslehetőségeit egyedül az korlátozza, ha a tábla szélén vagy a sarokban áll, illetve ha saját figurák állnak az érkezési mezején.";

            }
            if (hanyadik == 7)
            {
                //gyalog
                pictureBox7.Image = Image.FromFile("../../img/gyalog.png");
                LeirasLBL.Text = "A gyalog kizárólag előre léphet. A kiindulási helyéről mind a nyolc gyalog tetszés szerint egy vagy két mezőt léphet előre, de a továbbiakban lépésenként mindig csak egy mezőt haladhat előre. Ütni azonban csak jobbra vagy balra átlósan tud, szintén csak egy mezőnyi távolságra.Ha a gyalog áthaladt az egész táblán és eljutott az ellenfél alapsorába, átváltozik tisztté.Ez úgy történik, hogy a gyalogot levesszük a tábláról, és a helyére állítunk egy(a táblán levő állományon kívüli) vezért, bástyát, futót vagy huszárt, tetszés szerint, függetlenül attól, hogy a felvett figurából hány van már a táblán eszerint egy játszmában.";

            }
            if (hanyadik == 8)
            {
                pictureBox7.Image = null;
                LeirasLBL.Text = "Lépés és ütés. Egy mezőn egy időben csak egy figura állhat. A játékot mindig világos kezdi, és tetszése szerint – de a szabályoknak adta kereteken belül – valamelyik figuráját áthelyezi egy másik mezőre. Ezt lépésnek hívjuk.Ezt követően sötét lép egyet.A játékosok felváltva lépnek, passzolásra nincs lehetőség(„lépéskényszer”). Ha egy mezőn az ellenfél bábuja áll, azt egy szabályos lépéssel ki lehet ütni: az ellenfél figuráját levesszük a tábláról, és saját, odalépő bábunkat tesszük a helyére.Saját figura kiütésére nincs lehetőség.";

            }
        }

        private void visszabutton_Click(object sender, EventArgs e)
        {
            
            if (hanyadik <= 8 && hanyadik > 0)
            {
                if (visszabutton.Text == "Vissza")
                {
                    hanyadik--;
                }
            }

            kiiras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A fehér játékos feladta a játékot.\n A nyertes a fekete játékos");
            Application.Restart();
        }

        private void feladasfeketebn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A fekete játékos feladta a játékot.\n A nyertes a fehér játékos");
            Application.Restart();
        }
    }
}