using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HQ40d_Diagnosztika
{
    class FileKezelo
    {
        private string fileName;     
        private string tipus;
        private string datum;
        private string ido;
        private string felhasznalo;
        private string berendezes;
        private int mero_kod;
        public string meres = null;
        private string vezetokepesseg = " ";
        private string kemhatas = " ";
        private string hofok;

        public FileKezelo() { }

        public string fileNev
        {
            get { return fileName; }
            set { fileName = value; }
        }

        //A .csv fájl feldolgozása soronként
        public void feldolgozo()
        {          
            AdatKezelo ak = new AdatKezelo();
            string[] adatok;
            int i = 0;
            string[] separator = { ",", "(", ")", "EndOfRecord" };
            string[] adatsorok = System.IO.File.ReadAllLines(fileName);
            while (i != adatsorok.Length)            
            {                
                for (; i < adatsorok.Length; i++)
                {
                    if (adatsorok[i] != "")
                    {
                        adatok = adatsorok[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                        //Adatok vizsgálata, hogy létezik e az RD sor
                        if (adatok[0] == "RD")
                        {
                            for (int j = 0; j < 13; j++)
                            {
                                meres = adatok[10].ToString();
                                meres = meres.Replace(".", ",");
                                berendezes = adatok[8].ToString();
                                berendezes = berendezes.Remove(berendezes.Length-1);
                                //Ha a berendezés létezik és a mérés adatai számok
                                if (ak.berendezesEllenor(berendezes) && stringFigyelo(meres))
                                {
                                    tipus = adatok[1].ToString();
                                    datum = adatok[2].ToString();
                                    ido = adatok[3].ToString();
                                    felhasznalo = adatok[4].ToString();
                                    mero_kod = Convert.ToInt32(adatok[9].ToString());
                                    hofok = adatok[12].ToString();
                                    hofok = hofok.Replace(".", ",");
                                    hofok = hofok.Substring(0, 4);
                                    if (tipus == "CD")
                                    {
                                        vezetokepesseg = meres;                                                                             
                                        ak.alapadatRogzites(tipus, datum, ido, felhasznalo, berendezes, mero_kod, vezetokepesseg, hofok);                                       
                                    }
                                    else
                                    {
                                        kemhatas = meres;                                                                            
                                        ak.alapadatRogzites(tipus, datum, ido, felhasznalo, berendezes, mero_kod, kemhatas, hofok);                                       
                                    }
                                }                               
                                break;
                            }
                        }                        
                    }                    
                }
            }            
        }

        //A mérés értékének vizsgálata
        public bool stringFigyelo(string szam)
        {
            bool kiertekeles = false;
            string[] tomb = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "," };
            int trueIndex = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < szam.Length; j++)
                {
                    if (szam[j].ToString() == tomb[i])
                    {                        
                        trueIndex++;
                    }                    
                }                         
            }
            if (trueIndex == szam.Length)
            {
                kiertekeles = true;
            }      
            return kiertekeles;
        }
    }
}