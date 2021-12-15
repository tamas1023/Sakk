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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablageneralas();
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
                            kep.BackColor = Color.Black;
                        }

                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            kep.BackColor = Color.Black;
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
            MessageBox.Show("i:" + kapcsolt.Tag + "j: " + kapcsolt.Name);
            MessageBox.Show("name: j:" +kepek[Convert.ToInt32(kapcsolt.Tag),Convert.ToInt32(kapcsolt.Name)].Name+"tag: i: "+ kepek[Convert.ToInt32(kapcsolt.Tag), Convert.ToInt32(kapcsolt.Name)].Tag);
            
        }

    }
}
