using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sakk
{
    public partial class Form1 : Form
    {
        static PictureBox[,] kepek = new PictureBox[8, 8];
        static Babuk[,] babok = new Babuk[8,8];
        static int honnani;
        static int honnanj;
        static bool valaszt = true;
        static bool feher = true;
        static bool uthet = true;
        static bool sakk = false;
        static List<int> lephetlista = new List<int>();
        static List<int> uthetlista = new List<int>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void babokfeltoltese()
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                        babok[i, j] = new Babuk(-1, "", "",0,0);  
                }
            }
            babok[0, 0] = new Babuk(0, "bástya", "fehér", 0, 0);
            kepek[0, 0].Image = Image.FromFile("../../img/white_rook.png");
            babok[1, 0] = new Babuk(1,"huszár", "fehér", 1, 0);
            kepek[1, 0].Image = Image.FromFile("../../img/white_knight.png");
            babok[2, 0] = new Babuk(2,"futó", "fehér", 2, 0);
            kepek[2, 0].Image = Image.FromFile("../../img/white_bishop.png");
            babok[3, 0] = new Babuk(3,"vezér", "fehér", 3, 0);
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
            for (int j = 0; j <8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (j==1)
                    {
                        babok[i,j] = new Babuk(i+8, "gyalog", "fehér",i,j);
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
            tablageneralas();
            babokfeltoltese();
        }

        private void tablageneralas()
        {
            int db = 0;
            int db2 = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox kep = new PictureBox();
                    kep.Location = new System.Drawing.Point(20 + (i * 50), 20 + (j * 50));
                    kep.Name = j + "";
                    kep.Visible = true;
                    kep.Size = new System.Drawing.Size(50, 50);
                    if (j <= 2 && j >= 0)
                    {
                        db++;
                        if (db == 8)
                        {
                            db = 0;
                        }
                        if (db % 2 == 1)
                        {
                           // kep.Image = Image.FromFile("feher.png");
                            //dama[i, j] = 1;
                        }

                    }
                    if (j <= 7 && j >= 5)
                    {
                        db2++;
                        if (db2 == 8)
                        {
                            db2 = 0;
                        }
                        if (db2 % 2 == 0)
                        {
                            //kep.Image = Image.FromFile("fekete.png");
                            //dama[i, j] = 2;
                        }
                    }
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
                    Controls.Add(kep);
                    kepek[i, j] = kep;
                    kep.Click += new System.EventHandler(this.palyaklikk);
                }
            }

        }
        private void palyaklikk(object sender, EventArgs e)
        {
            PictureBox kapcsolt = sender as PictureBox;

            if(valaszt)
            {
                if(feher)
                { 
                    if(babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Id >= 0&& babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Szin=="fehér")
                    {
                    torolszinek();
                    honnani = Convert.ToInt32(kapcsolt.Tag);
                    honnanj = Convert.ToInt32(kapcsolt.Name);
                        MessageBox.Show("id:" +babok[honnani,honnanj].Id);
                    babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].lephete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), lephetlista);
                        babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].uthete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), uthetlista);
                        szinezes();
                    }
                    if (valaszt && kapcsolt.Image == null)
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
                        MessageBox.Show("id:" + babok[honnani, honnanj].Id);
                        babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].uthete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), uthetlista);
                        babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].lephete(babok, Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name), lephetlista);
                        szinezes();
                    }
                    if (valaszt && kapcsolt.Image == null)
                    {
                        valaszt = false;
                    }
                }
            }
           
            if(!valaszt&&kapcsolt.BackColor==Color.Orange)
            {
                lepes(Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name));
                //MessageBox.Show(babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Szin + "típus: " + babok[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Tipus);
               // MessageBox.Show("name: babok[honnani,honnanj].huszar()j:" +kepek[Convert.ToInt32(kapcsolt.Tag),Convert.ToInt32(kapcsolt.Name)].Name+"tag: i: "+ kepek[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Tag);

                if(feher)
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
            }
         
        }

        private void lepes(int i,int j)
        {
           
            kepek[i, j].Image = kepek[honnani, honnanj].Image;
            kepek[honnani, honnanj].Image = null;

            babok[i, j] = babok[honnani, honnanj];
            babok[honnani, honnanj]= babok[honnani, honnanj] = new Babuk(-1, "", "", 0, 0);
        }

        private void szinezes()
        {
            int segedi = 0;
            int segedj = 0;
            int db = 0;
          // MessageBox.Show(""+lephetlista.Count);
            for (int i = 0; i < lephetlista.Count; i++)
            {
                if(i%2==0)
                {
                    //MessageBox.Show("belépett osztva 0");
                    segedi = lephetlista[i];
                    db++;
                }
                if(i%2==1)
                {
                   // MessageBox.Show("belépett osztva 1");
                    segedj = lephetlista[i];
                    db++;
                }
                if(db==2)
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
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0;  j < 8;  j++)
                {
                    if(kepek[i,j].BackColor==Color.Orange||kepek[i,j].BackColor==Color.Red)
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
    }
}
