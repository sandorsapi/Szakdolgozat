using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HQ40d_Diagnosztika
{    
    class AdatKezelo
    {
        DiagnosztikaDataContext db = new DiagnosztikaDataContext();
        private DateTime _datumTol;
        private DateTime _datumIg;
        

        public AdatKezelo() { }

        public DateTime datumTol
        {
            get{ return _datumTol; }    
            set{ _datumTol = value; }       
        }

        public DateTime datumIg
        {
            get { return _datumIg; }
            set { _datumIg = value; } 
        }

        //A mérés adatainak rögzítése
        public void alapadatRogzites(string tipus, string d, string idoAdat, string felhasznalo, string berendezes, int mero_kod, string meresAdat, string hofokAdat)
        {
                int tipus_id = 0;
                int szemely_id = 0;
                int datum_id = 0;
                DateTime dat = Convert.ToDateTime(d);
                tipus_id = tipusAdat(tipus);
                int berendezes_id = berendezesIndex(berendezes);
                //Ha a felhasználó még nincs rögzítve
                if (szemelyEllenor(felhasznalo) == false)
                {
                    Szemelyek szemely = new Szemelyek { nev = felhasznalo };
                    db.Szemelyeks.InsertOnSubmit(szemely);
                    db.SubmitChanges();
                }
                szemely_id = szemelyAdat(felhasznalo);
                Mikor mikor = new Mikor { datum = dat, ido = idoAdat, szemely = szemely_id };
                db.Mikors.InsertOnSubmit(mikor);
                db.SubmitChanges();
                datum_id = datumAdat(dat);
                switch (tipus)
                {
                    case "CD":
                        Vezetokepesseg vezK = new Vezetokepesseg { tipus = tipus_id, berendezes_azonosito = berendezes_id, hofok = Double.Parse(hofokAdat), vezetokepesseg1 = Double.Parse(meresAdat), mikor = datum_id, meres_kod = mero_kod };
                        db.Vezetokepessegs.InsertOnSubmit(vezK);
                        db.SubmitChanges();
                        break;
                    case "pH":
                        Kemhata kemH = new Kemhata { tipus = tipus_id, berendezes_azonosito = berendezes_id, hofok = Double.Parse(hofokAdat), kemhatas = Double.Parse(meresAdat), mikor = datum_id, meres_kod = mero_kod };
                        db.Kemhatas.InsertOnSubmit(kemH);
                        db.SubmitChanges();
                        break;
                }
            }

        //Fájl letárolása
        public void fajlTarolas(string fajl)
        {
            Fajltarolo fTarolo = new Fajltarolo { fajlnev = fajl };
            db.Fajltarolos.InsertOnSubmit(fTarolo);
            db.SubmitChanges();            
        }
        
        //A berendezés létezik a Berendezesek táblában
        public bool berendezesEllenor(string berendezesnev)
        {            
            bool letezik = false;
            var ber = db.Berendezeseks.Where(b => b.berendezes_nev == berendezesnev).Select(b => b.berendezes_nev);
            foreach (var bnev in ber)
            {
                if (berendezesnev == bnev.ToString())
                {
                    letezik = true;
                }
            }
            return letezik;
        }

        //Szemely létezésének ellenőrzése
        public bool szemelyEllenor(string felhasznalo)
        {
            bool szemelyLetezik = false;
            var sz = db.Szemelyeks.Select(s => s.nev);
            foreach (var szemely in sz)
            {
                if (felhasznalo == szemely)
                {
                    szemelyLetezik = true;
                }
            }
            return szemelyLetezik;
        }

        //Dátum létezésének ellenőrzése
        public bool datumEllenor(DateTime datum)
        {
            bool datumLetezik = false;
            var dt = db.Mikors.Select(d => d.datum);
            foreach (var dAdat in dt)
            {
                if (dAdat == datum)
                {
                    datumLetezik = true;
                }
            }
            return datumLetezik;
        }

        //A letárolt fájl meglétének ellenőrzése
        public bool fajlEllenor(string fajl)
        {
            bool fajlLetezik = false;
            var ft = db.Fajltarolos.Where(f => f.fajlnev == fajl).Select(f => f.fajlnev);
            foreach (var i in ft)
            {
                if (i == fajl)
                {
                    fajlLetezik = true;
                }
            }
            return fajlLetezik;
        }

        //Berendezés ID visszaadása berendezés neve alapján
        public int berendezesIndex(string berendezes)
        {
            int bIndex;
            var id = db.Berendezeseks.Single(b => b.berendezes_nev == berendezes);
            bIndex = id.berendezesID;                      
            return bIndex;
        }

        //Tipus ID visszaadása tipusnév alapján
        public int tipusAdat(string tipusNev)
        {
            int tip;
            var tTipus = db.Tipus.Single(t => t.tipus1 == tipusNev);
            tip = tTipus.typeID;
            return tip;
        }

        //Dátum ID visszaadása datum alapján
        public int datumAdat(DateTime datum)
        {
            int dat = 0;
            var d = db.Mikors.Where(m => m.datum == datum).Select(m => m.datumID);
            if (d != null)
            {
                foreach (var id in d)
                {
                    dat = id;
                }
            }
            return dat;
        }

        //Szemely ID visszaadása szemely név alapján
        public int szemelyAdat(string szemely)
        {
            int szID = 0;
            var s = db.Szemelyeks.Where(sz => sz.nev == szemely).Select(sz => sz.szemelyID);
            if (s !=null)
            {
                foreach (var id in s)
                {
                    szID = id;
                }
            }
            return szID;
        }

        //Új berendezés felvétele
        public void berendezesUj(string berendezes)
        {
            Berendezesek ber = new Berendezesek { berendezes_nev = berendezes };
            db.Berendezeseks.InsertOnSubmit(ber);
            db.SubmitChanges();
        }

        //Vezetőképesség adatok visszaadása
        public List<Vezetokepesseg> vLista()
        {
            List<Vezetokepesseg> vList = new List<Vezetokepesseg>();
            var vlist = db.Vezetokepessegs.Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var l in vlist)
            {
                vList.Add(l);
            }
            return vList;
        }

        //Kémhatás adatok visszaadása
        public List<Kemhata> kLista()
        {
            List<Kemhata> kList = new List<Kemhata>();
            var klist = db.Kemhatas.Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var l in klist)
            {
                kList.Add(l);
            }
            return kList;
        }

        //Dátum adatok visszaadása
        public List<Mikor> dLista()
        {
            List<Mikor> dList = new List<Mikor>();
            var dlist = db.Mikors.Select(k => k).OrderBy(k => k.datum);
            foreach (var l in dlist)
            {
                dList.Add(l);
            }
            return dList;
        }

        //Berendezés adatok visszaadása
        public List<Berendezesek> bLista()
        {
            List<Berendezesek> bList = new List<Berendezesek>();
            var blist = db.Berendezeseks.Select(b => b);
            foreach (var l in blist)
            {
                bList.Add(l);
            }
            return bList;
        }

        //Fájl adatok visszaadása
        public List<Fajltarolo> fLista()
        {
            List<Fajltarolo> fList = new List<Fajltarolo>();
            var flist = db.Fajltarolos.Select(f => f);
            foreach (var l in flist)
            {
                fList.Add(l);
            }
            return fList;
        }

        //Személyek adatainak visszaadása
        public List<Szemelyek> szLista()
        {
            List<Szemelyek> szList = new List<Szemelyek>();
            var szlist = db.Szemelyeks.Select(s => s);
            foreach (var l in szlist)
            {
                szList.Add(l);
            }
            return szList;
        }

        //Típus adatok visszaadása
        public List<Tipus> tLista()
        {
            List<Tipus> tList = new List<Tipus>();
            var tlist = db.Tipus.Select(t => t);
            foreach (var l in tlist)
            {
                tList.Add(l);
            }
            return tList;
        }

        //Keresett vezetőképesség adatok visszaadása dátumok alapján
        public List<DateTime> datumLista(DateTime datTol, DateTime datIg)
        {
            List<DateTime> vKLista = new List<DateTime>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg).Select(v => v.Mikor1.datum).Distinct().OrderBy(v => v);
            foreach (var vk in vK)
            {              
                vKLista.Add(vk);
            }
            return vKLista;
        }

        public List<Vezetokepesseg> vezkLista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //Keresett kémhatás adatok visszaadása dátumok alapján
        public List<Kemhata> kemHkLista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var k in kH)
            {
                kHLista.Add(k);
            }
            return kHLista;
        }

        //HT1 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT1Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT1" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT1 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT1Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT1").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT2 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT2Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT2" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT2 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT2Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT2").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT3 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT3Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT3" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT3 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT3Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT3").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT4 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT4Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT4" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT4 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT4Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT4").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT5 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT5Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT5" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT5 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT5Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT5").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT6 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT6Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT6" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT6 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT6Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT6").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT7 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT7Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT7" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT7 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT7Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT7").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT8 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT8Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT8" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT8 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT8Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT8").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT9 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT9Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT9" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT9 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT9Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT9").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT10 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHT10Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HT10" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //HT10 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHT10Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HT10").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //Pótvíz dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkPotvizLista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "TORNYOK POTV" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //Pótvíz dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhPotvizLista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "TORNYOK POTV").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //Hűtési dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkHutesiLista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "HUTESI" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //Hűtési dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhHutesiLista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "HUTESI").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //Nyersvíz dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkNyersvizLista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "NYERS VIZ" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //Nyersviz dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhNyersvizLista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "NYERS VIZ").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //Kondenz dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkKondenzLista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "KONDENZ" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //Kondenz dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhKondenzLista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "KONDENZ").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //Duo10 dátum alaján kiválasztott vezetőképesség adatai
        public List<Vezetokepesseg> vezkDuo10Lista(DateTime datTol, DateTime datIg)
        {
            List<Vezetokepesseg> vKLista = new List<Vezetokepesseg>();
            var vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum >= datTol && v.Mikor1.datum <= datIg && v.Berendezesek.berendezes_nev == "DUO10" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in vK)
            {
                vKLista.Add(vk);
            }
            return vKLista;
        }

        //Duo10 dátum alaján kiválasztott kémhatás adatai
        public List<Kemhata> kemhDuo10Lista(DateTime datTol, DateTime datIg)
        {
            List<Kemhata> kHLista = new List<Kemhata>();
            var kH = db.Kemhatas.Where(k => k.Mikor1.datum >= datTol && k.Mikor1.datum <= datIg && k.Berendezesek.berendezes_nev == "DUO10").Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var kh in kH)
            {
                kHLista.Add(kh);
            }
            return kHLista;
        }

        //HT 1 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht1VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h1Lista = new List<Vezetokepesseg>();
            var h1vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT1" && v.vezetokepesseg1 >1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h1vK)
            {
                h1Lista.Add(vk);
            }
            return h1Lista;
        }

        //HT 1 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht1KHLista(DateTime datum)
        {
            List<Kemhata> h1Lista = new List<Kemhata>();
            var h1kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT1" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h1kH)
            {
                h1Lista.Add(vk);
            }
            return h1Lista;
        }

        //HT 2 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht2VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h2Lista = new List<Vezetokepesseg>();
            var h2vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT2" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h2vK)
            {
                h2Lista.Add(vk);
            }
            return h2Lista;
        }

        //HT 2 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht2KHLista(DateTime datum)
        {
            List<Kemhata> h2Lista = new List<Kemhata>();
            var h2kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT2" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h2kH)
            {
                h2Lista.Add(vk);
            }
            return h2Lista;
        }

        //HT 3 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht3VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h3Lista = new List<Vezetokepesseg>();
            var h3vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT3" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h3vK)
            {
                h3Lista.Add(vk);
            }
            return h3Lista;
        }

        //HT 3 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht3KHLista(DateTime datum)
        {
            List<Kemhata> h3Lista = new List<Kemhata>();
            var h3kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT3" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h3kH)
            {
                h3Lista.Add(vk);
            }
            return h3Lista;
        }

        //HT 4 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht4VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h4Lista = new List<Vezetokepesseg>();
            var h4vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT4" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h4vK)
            {
                h4Lista.Add(vk);
            }
            return h4Lista;
        }

        //HT 4 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht4KHLista(DateTime datum)
        {
            List<Kemhata> h4Lista = new List<Kemhata>();
            var h4kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT4" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h4kH)
            {
                h4Lista.Add(vk);
            }
            return h4Lista;
        }

        //HT 5 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht5VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h5Lista = new List<Vezetokepesseg>();
            var h5vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT5" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h5vK)
            {
                h5Lista.Add(vk);
            }
            return h5Lista;
        }

        //HT 5 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht5KHLista(DateTime datum)
        {
            List<Kemhata> h5Lista = new List<Kemhata>();
            var h5kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT5" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h5kH)
            {
                h5Lista.Add(vk);
            }
            return h5Lista;
        }

        //HT 6 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht6VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h6Lista = new List<Vezetokepesseg>();
            var h6vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT6" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h6vK)
            {
                h6Lista.Add(vk);
            }
            return h6Lista;
        }

        //HT 6 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht6KHLista(DateTime datum)
        {
            List<Kemhata> h6Lista = new List<Kemhata>();
            var h6kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT6" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h6kH)
            {
                h6Lista.Add(vk);
            }
            return h6Lista;
        }

        //HT 7 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht7VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h7Lista = new List<Vezetokepesseg>();
            var h7vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT7" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h7vK)
            {
                h7Lista.Add(vk);
            }
            return h7Lista;
        }

        //HT 7 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht7KHLista(DateTime datum)
        {
            List<Kemhata> h7Lista = new List<Kemhata>();
            var h7kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT7" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h7kH)
            {
                h7Lista.Add(vk);
            }
            return h7Lista;
        }

        //HT 8 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht8VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h8Lista = new List<Vezetokepesseg>();
            var h8vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT8" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h8vK)
            {
                h8Lista.Add(vk);
            }
            return h8Lista;
        }

        //HT 8 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht8KHLista(DateTime datum)
        {
            List<Kemhata> h8Lista = new List<Kemhata>();
            var h8kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT8" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h8kH)
            {
                h8Lista.Add(vk);
            }
            return h8Lista;
        }

        //HT 9 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht9VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h9Lista = new List<Vezetokepesseg>();
            var h9vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT9" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h9vK)
            {
                h9Lista.Add(vk);
            }
            return h9Lista;
        }

        //HT 9 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht9KHLista(DateTime datum)
        {
            List<Kemhata> h9Lista = new List<Kemhata>();
            var h9kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT9" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h9kH)
            {
                h9Lista.Add(vk);
            }
            return h9Lista;
        }

        //HT 10 vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> ht10VKLista(DateTime datum)
        {
            List<Vezetokepesseg> h10Lista = new List<Vezetokepesseg>();
            var h10vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HT10" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in h10vK)
            {
                h10Lista.Add(vk);
            }
            return h10Lista;
        }

        //HT 10 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> ht10KHLista(DateTime datum)
        {
            List<Kemhata> h10Lista = new List<Kemhata>();
            var h10kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HT10" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in h10kH)
            {
                h10Lista.Add(vk);
            }
            return h10Lista;
        }

        //Pótvíz vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> potvizVKLista(DateTime datum)
        {
            List<Vezetokepesseg> potvizLista = new List<Vezetokepesseg>();
            var potvizvK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "TORNYOK POTV" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in potvizvK)
            {
                potvizLista.Add(vk);
            }
            return potvizLista;
        }

        //Pótvíz kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> potvizKHLista(DateTime datum)
        {
            List<Kemhata> potvizLista = new List<Kemhata>();
            var potvizkH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "TORNYOK POTV" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in potvizkH)
            {
                potvizLista.Add(vk);
            }
            return potvizLista;
        }

        //Kondenz vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> kondenzVKLista(DateTime datum)
        {
            List<Vezetokepesseg> kondenzLista = new List<Vezetokepesseg>();
            var kondenzvK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "KONDENZ" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in kondenzvK)
            {
                kondenzLista.Add(vk);
            }
            return kondenzLista;
        }

        //Kondenz kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> kondenzKHLista(DateTime datum)
        {
            List<Kemhata> kondenzLista = new List<Kemhata>();
            var kondenzkH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "KONDENZ" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in kondenzkH)
            {
                kondenzLista.Add(vk);
            }
            return kondenzLista;
        }

        //Hűtési vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> hutesiVKLista(DateTime datum)
        {
            List<Vezetokepesseg> hutesiLista = new List<Vezetokepesseg>();
            var hutesivK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "HUTESI" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in hutesivK)
            {
                hutesiLista.Add(vk);
            }
            return hutesiLista;
        }

        //Hűtési kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> hutesiKHLista(DateTime datum)
        {
            List<Kemhata> hutesiLista = new List<Kemhata>();
            var hutesikH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "HUTESI" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in hutesikH)
            {
                hutesiLista.Add(vk);
            }
            return hutesiLista;
        }

        //Nyers víz vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> nyersvizVKLista(DateTime datum)
        {
            List<Vezetokepesseg> nyersvizLista = new List<Vezetokepesseg>();
            var nyersvizvK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "NYERS VIZ" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in nyersvizvK)
            {
                nyersvizLista.Add(vk);
            }
            return nyersvizLista;
        }

        //Nyers víz kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> nyersvizKHLista(DateTime datum)
        {
            List<Kemhata> nyersvizLista = new List<Kemhata>();
            var nyersvizkH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "NYERS VIZ" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in nyersvizkH)
            {
                nyersvizLista.Add(vk);
            }
            return nyersvizLista;
        }

        //Duo10 víz vezetőképesség adatai egy dátum szerinti kiválasztással
        public List<Vezetokepesseg> duo10VKLista(DateTime datum)
        {
            List<Vezetokepesseg> duo10Lista = new List<Vezetokepesseg>();
            var duo10vK = db.Vezetokepessegs.Where(v => v.Mikor1.datum == datum && v.Berendezesek.berendezes_nev == "DUO10" && v.vezetokepesseg1 > 1).Select(v => v).OrderBy(v => v.Mikor1.datum);
            foreach (var vk in duo10vK)
            {
                duo10Lista.Add(vk);
            }
            return duo10Lista;
        }

        //Duo10 kémhatás adatai egy dátum szerinti kiválasztással
        public List<Kemhata> duo10KHLista(DateTime datum)
        {
            List<Kemhata> duo10Lista = new List<Kemhata>();
            var duo10kH = db.Kemhatas.Where(k => k.Mikor1.datum == datum && k.Berendezesek.berendezes_nev == "DUO10" && k.kemhatas > 0).Select(k => k).OrderBy(k => k.Mikor1.datum);
            foreach (var vk in duo10kH)
            {
                duo10Lista.Add(vk);
            }
            return duo10Lista;
        } 

    }
}
