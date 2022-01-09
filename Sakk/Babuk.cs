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
            int seged = 1;
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
                if (j == 1 && babok[i, j + 2].id == -1&&babok[i,j+1].id==-1)
                {
                    lepesek.Add(i);
                    lepesek.Add(j + 2);
                }
                if(j == 1 && babok[i, j + 1].id == -1)
                { 
                    lepesek.Add(i);
                    lepesek.Add(j + 1);
                }
                if (j!=1 && babok[i, j + 1].id == -1)
                {
                    lepesek.Add(i);
                    lepesek.Add(j + 1);
                }
            }
            if (tipus == "gyalog" && szin == "fekete")
            {
                if (j == 6 &&babok[i,j-2].id==-1 && babok[i, j - 1].id == -1)
                {
                    lepesek.Add(i);
                    lepesek.Add(j - 2);
                }

                if(j==6&&babok[i,j-1].id==-1)
                {
                    lepesek.Add(i);
                    lepesek.Add(j - 1);
                }
                if (j != 6 && babok[i, j-1].id == -1)
                {
                    lepesek.Add(i);
                    lepesek.Add(j - 1);
                }
            }
            if(tipus=="futó")
            {
                if(j+1<8&&i+1<8)
                {
                    while (i+seged<8&&j+seged<8&&babok[i+seged,j+seged].id==-1)
                    {
           
                        lepesek.Add(i+seged);
                        lepesek.Add(j+seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8 && i - 1 >=0)
                {
                    while (i -seged >=0 && j + seged < 8 && babok[i - seged, j + seged].id == -1)
                    {

                        lepesek.Add(i-seged);
                        lepesek.Add(j+seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >=0 && i - 1 >= 0)
                {
                    while (i - seged >= 0 && j - seged >=0 && babok[i - seged, j - seged].id == -1)
                    {

                        lepesek.Add(i-seged);
                        lepesek.Add(j-seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i + 1 < 8)
                {
                    while (i + seged < 8 && j + seged >= 0 && babok[i + seged, j - seged].id == -1)
                    {

                        lepesek.Add(i+seged);
                        lepesek.Add(j-seged);
                        seged++;
                    }
                }
                seged = 1;
            }
            if(tipus=="bástya")
            {
                if(i+1<8)
                {
                    while(i+seged<8&&babok[i+seged,j].id==-1)
                    {
                        lepesek.Add(i + seged);
                        lepesek.Add(j);
                        seged++;
                    }
                }
                seged = 1;
                if (i - 1 >=0)
                {
                    while (i - seged >=0 && babok[i - seged, j].id == -1)
                    {
                        lepesek.Add(i - seged);
                        lepesek.Add(j);
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8)
                {
                    while (j + seged < 8 && babok[i, j+seged].id == -1)
                    {
                        lepesek.Add(i);
                        lepesek.Add(j+seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0)
                {
                    while (j - seged >=0 && babok[i, j - seged].id == -1)
                    {
                        lepesek.Add(i);
                        lepesek.Add(j - seged);
                        seged++;
                    }
                }
            }
            if(tipus== "király")
            {
                 if (i - 1 >= 0 && j - 1 >= 0)
                { 
                    if(babok[i - 1,j - 1].id == -1)
                    { 
                        lepesek.Add(i-1);
                        lepesek.Add(j - 1);
                    }
                }
                if (i - 1 >= 0 && j + 1 <8)
                {
                    if (babok[i - 1, j + 1].id == -1)
                    {
                        lepesek.Add(i - 1);
                        lepesek.Add(j + 1);
                    }
                }
                if (i - 1 >= 0)
                {
                    if (babok[i - 1, j].id == -1)
                    {
                        lepesek.Add(i - 1);
                        lepesek.Add(j);
                    }
                }
                if (i + 1 <8)
                {
                    if (babok[i + 1, j].id == -1)
                    {
                        lepesek.Add(i + 1);
                        lepesek.Add(j);
                    }
                }



                if (i + 1 <8 && j + 1 <8)
                {
                    if (babok[i +1, j + 1].id == -1)
                    {
                        lepesek.Add(i + 1);
                        lepesek.Add(j + 1);
                    }
                }
                if (i + 1 <8 && j - 1 >=0)
                {
                    if (babok[i + 1, j - 1].id == -1)
                    {
                        lepesek.Add(i + 1);
                        lepesek.Add(j - 1);
                    }
                }
                if (j - 1 >= 0)
                {
                    if (babok[i, j - 1].id == -1)
                    {
                        lepesek.Add(i);
                        lepesek.Add(j - 1);
                    }
                }
                if (j + 1 <8)
                {
                    if (babok[i, j + 1].id == -1)
                    {
                        lepesek.Add(i);
                        lepesek.Add(j + 1);
                    }
                }
            }
            if(tipus=="vezér")
            {
                if (i + 1 < 8)
                {
                    while (i + seged < 8 && babok[i + seged, j].id == -1)
                    {
                        lepesek.Add(i + seged);
                        lepesek.Add(j);
                        seged++;
                    }
                }
                seged = 1;
                if (i - 1 >= 0)
                {
                    while (i - seged >= 0 && babok[i - seged, j].id == -1)
                    {
                        lepesek.Add(i - seged);
                        lepesek.Add(j);
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8)
                {
                    while (j + seged < 8 && babok[i, j + seged].id == -1)
                    {
                        lepesek.Add(i);
                        lepesek.Add(j + seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0)
                {
                    while (j - seged >= 0 && babok[i, j - seged].id == -1)
                    {
                        lepesek.Add(i);
                        lepesek.Add(j - seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8 && i + 1 < 8)
                {
                    while (i + seged < 8 && j + seged < 8 && babok[i + seged, j + seged].id == -1)
                    {

                        lepesek.Add(i + seged);
                        lepesek.Add(j + seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8 && i - 1 >= 0)
                {
                    while (i - seged >= 0 && j + seged < 8 && babok[i - seged, j + seged].id == -1)
                    {

                        lepesek.Add(i - seged);
                        lepesek.Add(j + seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i - 1 >= 0)
                {
                    while (i - seged >= 0 && j - seged >= 0 && babok[i - seged, j - seged].id == -1)
                    {

                        lepesek.Add(i - seged);
                        lepesek.Add(j - seged);
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i + 1 < 8)
                {
                    while (i + seged < 8 && j + seged >= 0 && babok[i + seged, j - seged].id == -1)
                    {

                        lepesek.Add(i + seged);
                        lepesek.Add(j - seged);
                        seged++;
                    }
                }
                seged = 1;
            }
        }
        public void uthete(Babuk[,] babok, int i, int j, List<int> utesek)
        {
            int seged = 1;
            if (tipus == "huszár")
            {
                if (i - 2 >= 0 && j - 1 >= 0)
                {
                    if (babok[i - 2, j - 1].id != -1 && szin != babok[i - 2, j - 1].szin)
                    {
                        utesek.Add(i - 2);
                        utesek.Add(j - 1);
                    }
                }
                if (i - 2 >= 0 && j + 1 <= 7)
                {
                    if (babok[i - 2, j + 1].id != -1 && szin != babok[i - 2, j + 1].szin)
                    {
                        utesek.Add(i - 2);
                        utesek.Add(j + 1);
                        
                    }
                }
                if (i + 2 <= 7 && j + 1 <= 7)
                {
                    if (babok[i + 2, j + 1].id != -1 && szin != babok[i + 2, j + 1].szin)
                    {
                        utesek.Add(i + 2);
                        utesek.Add(j + 1);
                       
                    }
                }
                if (i + 2 <= 7 && j - 1 >= 0)
                {
                    if (babok[i + 2, j - 1].id != -1 && szin != babok[i + 2, j - 1].szin)
                    {
                        utesek.Add(i + 2);
                        utesek.Add(j - 1);
                       
                    }
                }
                if (i + 1 <= 7 && j - 2 >= 0)
                {
                    if (babok[i + 1, j - 2].id != -1 && szin != babok[i + 1, j - 2].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j - 2);
                       
                    }
                }
                if (i - 1 >= 0 && j - 2 >= 0)
                {
                    if (babok[i - 1, j - 2].id != -1 && szin != babok[i - 1, j - 2].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j - 2);
                        
                    }
                }
                if (i - 1 >= 0 && j + 2 <= 7)
                {
                    if (babok[i - 1, j + 2].id != -1 && szin != babok[i - 1, j + 2].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j + 2);
                       
                    }
                }
                if (i + 1 <= 7 && j + 2 <= 7)
                {
                    if (babok[i + 1, j + 2].id != -1 && szin != babok[i + 1, j + 2].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j + 2);
                       
                    }
                }
            }
            if (tipus == "gyalog" && szin == "fehér")
            {
                if (i - 1 >= 0)
                {
                    if (j == 1 && babok[i - 1, j + 1].id != -1 && szin != babok[i - 1, j + 1].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j + 1);
                    }
                }
                if (i + 1 <= 7)
                {
                    if (j == 1 && babok[i + 1, j + 1].id != -1 && szin != babok[i + 1, j + 1].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j + 1);
                    }
                }
                if (i - 1 >= 0)
                {
                    if (j != 1 && babok[i - 1, j + 1].id != -1 && szin != babok[i - 1, j + 1].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j + 1);
                    }
                }
                if (i + 1 <= 7)
                {
                    if (j != 1 && babok[i + 1, j + 1].id != -1 && szin != babok[i + 1, j + 1].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j + 1);
                    }
                }
            }
            if (tipus == "gyalog" && szin == "fekete")
            {
                if (i - 1 >= 0)
                {
                    if (j == 6 && babok[i - 1, j - 1].id != -1 && szin != babok[i - 1, j - 1].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j - 1);
                    }
                }
                if (i + 1 <= 7)
                {
                    if (j == 6 && babok[i + 1, j - 1].id != -1 && szin != babok[i + 1, j - 1].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j - 1);
                    }
                }
                if (i - 1 >= 0)
                {
                    if (j != 6 && babok[i - 1, j - 1].id != -1 && szin != babok[i - 1, j - 1].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j - 1);
                    }
                }
                if (i + 1 <= 7)
                {
                    if (j != 6 && babok[i + 1, j - 1].id != -1 && szin != babok[i + 1, j - 1].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j - 1);
                    }
                }
            }
            if (tipus == "futó")
            {
                if (j + 1 < 8 && i + 1 < 8)
                {
                    if (babok[i + seged, j + seged].id != -1 && szin != babok[i + seged, j + seged].szin)
                    {
                        utesek.Add(i + seged);
                        utesek.Add(j + seged);
                    }
                    while (i + seged < 8 && j + seged < 8 && babok[i + seged, j + seged].id == -1)
                    {
                        if (i + seged + 1 < 8 && j + seged + 1 < 8)
                        {
                            if (babok[i + seged + 1, j + seged + 1].id != -1 && szin != babok[i + seged + 1, j + seged + 1].szin)
                            {
                                utesek.Add(i + seged + 1);
                                utesek.Add(j + seged + 1);
                            }
                        }

                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8 && i - 1 >= 0)
                {
                    if (babok[i - seged, j + seged].id != -1 && szin != babok[i - seged, j + seged].szin)
                    {
                        utesek.Add(i - seged);
                        utesek.Add(j + seged);
                    }
                    while (i - seged >= 0 && j + seged < 8 && babok[i - seged, j + seged].id == -1)
                    {
                        if (i - seged - 1 >=0 && j + seged + 1 < 8)
                        {
                            if (babok[i - seged - 1, j + seged + 1].id != -1 && szin != babok[i - seged - 1, j + seged + 1].szin)
                            {
                                utesek.Add(i - seged - 1);
                                utesek.Add(j + seged + 1);
                            }
                        }

                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i - 1 >= 0)
                {
                    if (babok[i - seged, j - seged].id != -1 && szin != babok[i - seged, j - seged].szin)
                    {
                        utesek.Add(i - seged);
                        utesek.Add(j - seged);
                    }
                    while (i - seged >= 0 && j - seged >= 0 && babok[i - seged, j - seged].id == -1)
                    {
                        if (i - seged - 1 >= 0 && j - seged - 1 >=0)
                        {
                            if (babok[i - seged - 1, j - seged - 1].id != -1 && szin != babok[i - seged - 1, j - seged - 1].szin)
                            {
                                utesek.Add(i - seged - 1);
                                utesek.Add(j - seged - 1);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i + 1 < 8)
                {
                    if (babok[i + seged, j - seged].id != -1 && szin != babok[i + seged, j - seged].szin)
                    {
                        utesek.Add(i + seged);
                        utesek.Add(j - seged);
                    }
                    while (i + seged < 8 && j + seged >= 0 && babok[i + seged, j - seged].id == -1)
                    {
                        if (i + seged + 1 < 8 && j - seged - 1 >= 0)
                        {
                            if (babok[i + seged + 1, j - seged - 1].id != -1 && szin != babok[i + seged +1, j - seged - 1].szin)
                            {
                                utesek.Add(i + seged + 1);
                                utesek.Add(j - seged - 1);
                            }
                        }
                        seged++;
                    }

                }
                seged = 1;
            }
            if (tipus == "bástya")
            {
                if (i + 1 < 8)
                {
                    if (babok[i + seged, j].id != -1 && szin != babok[i + seged, j].szin)
                    {
                        utesek.Add(i + seged);
                        utesek.Add(j);
                    }
                    while (i + seged < 8 && babok[i + seged, j].id == -1)
                    {
                        if (i+seged+1<8)
                        { 
                            if(babok[i+seged+1,j].id!=-1&&szin!=babok[i+seged+1,j].szin)
                            {
                                utesek.Add(i + seged+1);
                                utesek.Add(j);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (i - 1 >= 0)
                {
                    if (babok[i - seged, j].id != -1 && szin != babok[i - seged, j].szin)
                    {
                        utesek.Add(i - seged);
                        utesek.Add(j);
                    }
                    while (i - seged >= 0 && babok[i - seged, j].id == -1)
                    {
                        if(i-seged-1>=0)
                        { 
                            if (babok[i - seged - 1, j].id != -1 && szin != babok[i - seged - 1, j].szin)
                            {
                                utesek.Add(i - seged - 1);
                                utesek.Add(j);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8)
                {
                    if (babok[i, j + seged].id != -1 && szin != babok[i, j + seged].szin)
                    {
                        utesek.Add(i);
                        utesek.Add(j + seged);
                    }
                    while (j + seged < 8 && babok[i, j + seged].id == -1)
                    {
                        if(j+seged+1<8)
                        { 
                            if (babok[i, j+seged+1].id != -1 && szin != babok[i , j+seged+1].szin)
                            {
                                utesek.Add(i );
                                utesek.Add(j+seged+1);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0)
                {
                    if (babok[i, j - seged].id != -1 && szin != babok[i, j - seged].szin)
                    {
                        utesek.Add(i);
                        utesek.Add(j - seged);
                    }
                    while (j - seged >= 0 && babok[i, j - seged].id == -1)
                    {
                        if(j-seged-1>=0)
                        { 
                            if (babok[i, j - seged - 1].id != -1 && szin != babok[i, j - seged - 1].szin)
                            {
                                utesek.Add(i);
                                utesek.Add(j - seged -1);
                            }
                        }
                        seged++;
                    }
                }
            }
            if (tipus == "király")
            {
                if (i - 1 >= 0 && j - 1 >= 0)
                {
                    if (babok[i - 1, j - 1].id != -1&&szin!=babok[i-1,j-1].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j - 1);
                    }
                }
                if (i - 1 >= 0 && j + 1 < 8)
                {
                    if (babok[i - 1, j + 1].id != -1 && szin != babok[i - 1, j + 1].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j + 1);
                    }
                }
                if (i - 1 >= 0)
                {
                    if (babok[i - 1, j].id != -1 && szin != babok[i - 1, j].szin)
                    {
                        utesek.Add(i - 1);
                        utesek.Add(j);
                    }
                }
                if (i + 1 < 8)
                {
                    if (babok[i + 1, j].id != -1 && szin != babok[i + 1, j].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j);
                    }
                }



                if (i + 1 < 8 && j + 1 < 8)
                {
                    if (babok[i + 1, j + 1].id != -1 && szin != babok[i + 1, j+1].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j + 1);
                    }
                }
                if (i + 1 < 8 && j - 1 >= 0)
                {
                    if (babok[i + 1, j - 1].id != -1 && szin != babok[i + 1, j-1].szin)
                    {
                        utesek.Add(i + 1);
                        utesek.Add(j - 1);
                    }
                }
                if (j - 1 >= 0)
                {
                    if (babok[i, j - 1].id != -1 && szin != babok[i, j-1].szin)
                    {
                        utesek.Add(i);
                        utesek.Add(j - 1);
                    }
                }
                if (j + 1 < 8)
                {
                    if (babok[i, j + 1].id != -1 && szin != babok[i, j+1].szin)
                    {
                        utesek.Add(i);
                        utesek.Add(j + 1);
                    }
                }
            }
            if(tipus=="vezér")
            {
                if (j + 1 < 8 && i + 1 < 8)
                {
                    if (babok[i + seged, j + seged].id != -1 && szin != babok[i + seged, j + seged].szin)
                    {
                        utesek.Add(i + seged);
                        utesek.Add(j + seged);
                    }
                    while (i + seged < 8 && j + seged < 8 && babok[i + seged, j + seged].id == -1)
                    {
                        if (i + seged + 1 < 8 && j + seged + 1 < 8)
                        {
                            if (babok[i + seged + 1, j + seged + 1].id != -1 && szin != babok[i + seged + 1, j + seged + 1].szin)
                            {
                                utesek.Add(i + seged + 1);
                                utesek.Add(j + seged + 1);
                            }
                        }

                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8 && i - 1 >= 0)
                {
                    if (babok[i - seged, j + seged].id != -1 && szin != babok[i - seged, j + seged].szin)
                    {
                        utesek.Add(i - seged);
                        utesek.Add(j + seged);
                    }
                    while (i - seged >= 0 && j + seged < 8 && babok[i - seged, j + seged].id == -1)
                    {
                        if (i - seged - 1 >= 0 && j + seged + 1 < 8)
                        {
                            if (babok[i - seged - 1, j + seged + 1].id != -1 && szin != babok[i - seged - 1, j + seged + 1].szin)
                            {
                                utesek.Add(i - seged - 1);
                                utesek.Add(j + seged + 1);
                            }
                        }

                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i - 1 >= 0)
                {
                    if (babok[i - seged, j - seged].id != -1 && szin != babok[i - seged, j - seged].szin)
                    {
                        utesek.Add(i - seged);
                        utesek.Add(j - seged);
                    }
                    while (i - seged >= 0 && j - seged >= 0 && babok[i - seged, j - seged].id == -1)
                    {
                        if (i - seged - 1 >= 0 && j - seged - 1 >= 0)
                        {
                            if (babok[i - seged - 1, j - seged - 1].id != -1 && szin != babok[i - seged - 1, j - seged - 1].szin)
                            {
                                utesek.Add(i - seged - 1);
                                utesek.Add(j - seged - 1);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i + 1 < 8)
                {
                    if (babok[i + seged, j - seged].id != -1 && szin != babok[i + seged, j - seged].szin)
                    {
                        utesek.Add(i + seged);
                        utesek.Add(j - seged);
                    }
                    while (i + seged < 8 && j + seged >= 0 && babok[i + seged, j - seged].id == -1)
                    {
                        if (i + seged + 1 < 8 && j - seged - 1 >= 0)
                        {
                            if (babok[i + seged + 1, j - seged - 1].id != -1 && szin != babok[i + seged + 1, j - seged - 1].szin)
                            {
                                utesek.Add(i + seged + 1);
                                utesek.Add(j - seged - 1);
                            }
                        }
                        seged++;
                    }

                }
                seged = 1;
                if (i + 1 < 8)
                {
                    if (babok[i + seged, j].id != -1 && szin != babok[i + seged, j].szin)
                    {
                        utesek.Add(i + seged);
                        utesek.Add(j);
                    }
                    while (i + seged < 8 && babok[i + seged, j].id == -1)
                    {
                        if (i + seged + 1 < 8)
                        {
                            if (babok[i + seged + 1, j].id != -1 && szin != babok[i + seged + 1, j].szin)
                            {
                                utesek.Add(i + seged + 1);
                                utesek.Add(j);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (i - 1 >= 0)
                {
                    if (babok[i - seged, j].id != -1 && szin != babok[i - seged, j].szin)
                    {
                        utesek.Add(i - seged);
                        utesek.Add(j);
                    }
                    while (i - seged >= 0 && babok[i - seged, j].id == -1)
                    {
                        if (i - seged - 1 >= 0)
                        {
                            if (babok[i - seged - 1, j].id != -1 && szin != babok[i - seged - 1, j].szin)
                            {
                                utesek.Add(i - seged - 1);
                                utesek.Add(j);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8)
                {
                    if (babok[i, j + seged].id != -1 && szin != babok[i, j + seged].szin)
                    {
                        utesek.Add(i);
                        utesek.Add(j + seged);
                    }
                    while (j + seged < 8 && babok[i, j + seged].id == -1)
                    {
                        if (j + seged + 1 < 8)
                        {
                            if (babok[i, j + seged + 1].id != -1 && szin != babok[i, j + seged + 1].szin)
                            {
                                utesek.Add(i);
                                utesek.Add(j + seged + 1);
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0)
                {
                    if (babok[i, j - seged].id != -1 && szin != babok[i, j - seged].szin)
                    {
                        utesek.Add(i);
                        utesek.Add(j - seged);
                    }
                    while (j - seged >= 0 && babok[i, j - seged].id == -1)
                    {
                        if (j - seged - 1 >= 0)
                        {
                            if (babok[i, j - seged - 1].id != -1 && szin != babok[i, j - seged - 1].szin)
                            {
                                utesek.Add(i);
                                utesek.Add(j - seged - 1);
                            }
                        }
                        seged++;
                    }
                }
            }

        }
        public void sakkvane(Babuk[,] babok, int i, int j, List<bool> sakkotadott, List<string> sakkbanszin)
        {
            int seged = 1;
            if (tipus == "huszár")
            {
                if (i - 2 >= 0 && j - 1 >= 0)
                {
                    if (babok[i - 2, j - 1].id != -1 && szin != babok[i - 2, j - 1].szin && babok[i - 2, j - 1].tipus == "király")
                    {
                            if (szin == "fekete")
                            {
                            sakkotadott.Add(true);
                            sakkbanszin.Add("fehér");
                            }
                            if(szin == "fehér")
                            {
                            sakkotadott.Add(true);
                            sakkbanszin.Add("fekete");
                            }
                    }
                }
                if (i - 2 >= 0 && j + 1 <= 7)
                {
                    if (babok[i - 2, j + 1].id != -1 && szin != babok[i - 2, j + 1].szin && babok[i - 2, j + 1].tipus == "király")
                    {
                        
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        
                    }
                }
                if (i + 2 <= 7 && j + 1 <= 7)
                {
                    if (babok[i + 2, j + 1].id != -1 && szin != babok[i + 2, j + 1].szin && babok[i + 2, j + 1].tipus == "király")
                    {
                        
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        
                    }
                }
                if (i + 2 <= 7 && j - 1 >= 0)
                {
                    if (babok[i + 2, j - 1].id != -1 && szin != babok[i + 2, j - 1].szin && babok[i + 2, j - 1].tipus == "király")
                    {
                        
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        
                    }
                }
                if (i + 1 <= 7 && j - 2 >= 0)
                {
                    if (babok[i + 1, j - 2].id != -1 && szin != babok[i + 1, j - 2].szin && babok[i + 1, j - 2].tipus == "király")
                    {
                       
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        
                    }
                }
                if (i - 1 >= 0 && j - 2 >= 0)
                {
                    if (babok[i - 1, j - 2].id != -1 && szin != babok[i - 1, j - 2].szin && babok[i - 1, j - 2].tipus == "király")
                    {
                        
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        
                    }
                }
                if (i - 1 >= 0 && j + 2 <= 7)
                {
                    if (babok[i - 1, j + 2].id != -1 && szin != babok[i - 1, j + 2].szin && babok[i - 1, j + 2].tipus == "király")
                    {
                       
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        
                    }
                }
                if (i + 1 <= 7 && j + 2 <= 7)
                {
                    if (babok[i + 1, j + 2].id != -1 && szin != babok[i + 1, j + 2].szin && babok[i + 1, j + 2].tipus == "király")
                    {
                        
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        
                    }
                }
            }
            if (tipus == "vezér")
            {
                if (i + 1 < 8)
                {
                    while (i + seged < 8 && babok[i + seged, j].id == -1)
                    {
                        if(babok[i+seged,j].tipus=="király"&&babok[i+seged,j].szin!=szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (i - 1 >= 0)
                {
                    while (i - seged >= 0 && babok[i - seged, j].id == -1)
                    {
                        if (babok[i - seged, j].tipus == "király" && babok[i - seged, j].szin != szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8)
                {
                    while (j + seged < 8 && babok[i, j + seged].id == -1)
                    {
                        if (babok[i, j+seged].tipus == "király" && babok[i , j + seged].szin != szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0)
                {
                    while (j - seged >= 0 && babok[i, j - seged].id == -1)
                    {
                        if (babok[i, j - seged].tipus == "király" && babok[i, j - seged].szin != szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8 && i + 1 < 8)
                {
                    while (i + seged < 8 && j + seged < 8 && babok[i + seged, j + seged].id == -1)
                    {

                        if (babok[i+seged, j + seged].tipus == "király" && babok[i+seged, j + seged].szin != szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j + 1 < 8 && i - 1 >= 0)
                {
                    while (i - seged >= 0 && j + seged < 8 && babok[i - seged, j + seged].id == -1)
                    {

                        if (babok[i - seged, j + seged].tipus == "király" && babok[i - seged, j + seged].szin != szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i - 1 >= 0)
                {
                    while (i - seged >= 0 && j - seged >= 0 && babok[i - seged, j - seged].id == -1)
                    {
                        if (babok[i - seged, j - seged].tipus == "király" && babok[i - seged, j - seged].szin != szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
                if (j - 1 >= 0 && i + 1 < 8)
                {
                    while (i + seged < 8 && j + seged >= 0 && babok[i + seged, j - seged].id == -1)
                    {

                        if (babok[i + seged, j - seged].tipus == "király" && babok[i + seged, j - seged].szin != szin)
                        {
                            if (szin == "fekete")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fehér");
                            }
                            if (szin == "fehér")
                            {
                                sakkotadott.Add(true);
                                sakkbanszin.Add("fekete");
                            }
                        }
                        seged++;
                    }
                }
                seged = 1;
            }
        }


        public int Id { get => id; set => id = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Szin { get => szin; set => szin = value; }
        public int Kezdeshelyi { get => kezdeshelyi; set => kezdeshelyi = value; }
        public int Kezdeshelyj { get => kezdeshelyj; set => kezdeshelyj = value; }
    }
}
