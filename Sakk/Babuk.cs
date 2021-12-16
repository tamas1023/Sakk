using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Babuk
    {
        private int id;
        private string tipus;
        private string szin;
        private int kezdeshelyi;
        private int kezdeshelyj;

        public Babuk(int id, string tipus, string szin, int kezdeshelyi, int kezdeshelyj)
        {
            Id = id;
            Tipus = tipus;
            Szin = szin;
            this.Kezdeshelyi = kezdeshelyi;
            this.Kezdeshelyj = kezdeshelyj;
        }
        public void lephete(Babuk[,] babok,int i,int j,List<int>lepesek)
        {
            if (tipus == "huszár")
            {
                if (i - 2 >= 0 && j - 1 >= 0)
                { 
                    if(babok[i - 2, j - 1].id == -1)
                    { 
                        lepesek.Add(i-2);
                        lepesek.Add(j - 1);
                    }
                }
                if (i - 2 >= 0 && j + 1 <= 7 )
                {
                    if(babok[i - 2, j + 1].id == -1)
                    { 
                        lepesek.Add(i - 2);
                        lepesek.Add(j + 1);
                    }
                }
                if (i + 2 <= 7 && j + 1 <= 7)
                {
                    if (babok[i + 2, j + 1].id == -1)
                    {
                        lepesek.Add(i + 2);
                        lepesek.Add(j + 1);
                    }
                }
                if (i + 2 <= 7 && j - 1 >= 0)
                {
                    if (babok[i + 2, j - 1].id == -1)
                    {
                        lepesek.Add(i + 2);
                        lepesek.Add(j - 1);
                    }
                }
                if (i + 1 <= 7 && j - 2 >= 0)
                {
                    if (babok[i + 1, j - 2].id == -1)
                    {
                        lepesek.Add(i + 1);
                        lepesek.Add(j - 2);
                    }
                }
                if (i - 1 >= 0 && j - 2 >= 0)
                {
                    if (babok[i - 1, j - 2].id == -1)
                    {
                        lepesek.Add(i - 1);
                        lepesek.Add(j - 2);
                    }
                }
                if (i - 1 >= 0 && j + 2 <= 7)
                {
                    if (babok[i - 1, j + 2].id == -1)
                    {
                        lepesek.Add(i - 1);
                        lepesek.Add(j + 2);
                    }
                }
                if (i + 1 <= 7 && j + 2 <= 7)
                {
                    if (babok[i + 1, j + 2].id == -1)
                    {
                        lepesek.Add(i + 1);
                        lepesek.Add(j + 2);
                    }
                }
            }
            if(tipus=="gyalog"&&szin=="fehér")
            {
                if(j==1)
                {
                    lepesek.Add(i);
                    lepesek.Add(j + 1);
                    lepesek.Add(i);
                    lepesek.Add(j + 2);
                }
                if(j!=1)
                {
                    lepesek.Add(i);
                    lepesek.Add(j + 1);
                }
            }

        }
        public bool huszar()
        {
            if (tipus == "huszár")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Id { get => id; set => id = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Szin { get => szin; set => szin = value; }
        public int Kezdeshelyi { get => kezdeshelyi; set => kezdeshelyi = value; }
        public int Kezdeshelyj { get => kezdeshelyj; set => kezdeshelyj = value; }
    }
}
