using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Drawing2D;


namespace HQ40d_Diagnosztika
{
    class Grafika
    {       
        private int trackBarpozicio = 0;
        private int lepteto = 0;
        private int maxCount = 0;
        private int xLeptek = 0;

        private bool _panelVezk;
        private bool _panelKemh;

        private Boolean ht1 = false;
        private Boolean ht2 = false;
        private Boolean ht3 = false;
        private Boolean ht4 = false;
        private Boolean ht5 = false;
        private Boolean ht6 = false;
        private Boolean ht7 = false;
        private Boolean ht8 = false;
        private Boolean ht9 = false;
        private Boolean ht10 = false;
        private Boolean potviz = false;
        private Boolean hutesi = false;
        private Boolean kondenz = false;
        private Boolean nyersviz = false;
        private Boolean duo10 = false;

        public static string ertek1;
        public static string ertek2;
        public static string ertek3;
        public static string ertek4;
        public static string ertek5;
        public static string ertek6;
        public static string ertek7;
        public static string ertek8;
        public static string ertek9;
        public static string ertek10;
        public static string ertek11;
        public static string ertek12;
        public static string ertek13;
        public static string ertek14;
        public static string ertek15;


        private List<DateTime> dLista = new List<DateTime>();
        private List<Vezetokepesseg> ht1VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht1KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht2VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht2KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht3VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht3KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht4VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht4KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht5VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht5KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht6VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht6KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht7VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht7KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht8VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht8KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht9VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht9KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> ht10VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> ht10KHLista = new List<Kemhata>();
        private List<Vezetokepesseg> kondenzVKLista = new List<Vezetokepesseg>();
        private List<Kemhata> kondenzKHLista = new List<Kemhata>();
        private List<Vezetokepesseg> potvizVKLista = new List<Vezetokepesseg>();
        private List<Kemhata> potvizKHLista = new List<Kemhata>();
        private List<Vezetokepesseg> hutesiVKLista = new List<Vezetokepesseg>();
        private List<Kemhata> hutesiKHLista = new List<Kemhata>();
        private List<Vezetokepesseg> nyersvizVKLista = new List<Vezetokepesseg>();
        private List<Kemhata> nyersvizKHLista = new List<Kemhata>();
        private List<Vezetokepesseg> duo10VKLista = new List<Vezetokepesseg>();
        private List<Kemhata> duo10KHLista = new List<Kemhata>();

        //Kiválasztott berendezés koordináták letárolása
        private List<Koordinata> ht1KoVezk = new List<Koordinata>();
        private List<Koordinata> ht1KoKemh = new List<Koordinata>();
        private List<Koordinata> ht2KoVezk = new List<Koordinata>();
        private List<Koordinata> ht2KoKemh = new List<Koordinata>();
        private List<Koordinata> ht3KoVezk = new List<Koordinata>();
        private List<Koordinata> ht3KoKemh = new List<Koordinata>();
        private List<Koordinata> ht4KoVezk = new List<Koordinata>();
        private List<Koordinata> ht4KoKemh = new List<Koordinata>();
        private List<Koordinata> ht5KoVezk = new List<Koordinata>();
        private List<Koordinata> ht5KoKemh = new List<Koordinata>();
        private List<Koordinata> ht6KoVezk = new List<Koordinata>();
        private List<Koordinata> ht6KoKemh = new List<Koordinata>();
        private List<Koordinata> ht7KoVezk = new List<Koordinata>();
        private List<Koordinata> ht7KoKemh = new List<Koordinata>();
        private List<Koordinata> ht8KoVezk = new List<Koordinata>();
        private List<Koordinata> ht8KoKemh = new List<Koordinata>();
        private List<Koordinata> ht9KoVezk = new List<Koordinata>();
        private List<Koordinata> ht9KoKemh = new List<Koordinata>();
        private List<Koordinata> ht10KoVezk = new List<Koordinata>();
        private List<Koordinata> ht10KoKemh = new List<Koordinata>();
        private List<Koordinata> potvizKoVezk = new List<Koordinata>();
        private List<Koordinata> potvizKoKemh = new List<Koordinata>();
        private List<Koordinata> hutesiKoVezk = new List<Koordinata>();
        private List<Koordinata> hutesiKoKemh = new List<Koordinata>();
        private List<Koordinata> kondenzKoVezk = new List<Koordinata>();
        private List<Koordinata> kondenzKoKemh = new List<Koordinata>();
        private List<Koordinata> nyersvizKoVezk = new List<Koordinata>();
        private List<Koordinata> nyersvizKoKemh = new List<Koordinata>();
        private List<Koordinata> duo10KoVezk = new List<Koordinata>();
        private List<Koordinata> duo10KoKemh = new List<Koordinata>();

        Koordinata ko = new Koordinata();

        public Grafika(){}

        public int tBPoz
        {
            get { return trackBarpozicio; }
            set { trackBarpozicio = value; }
        }

        public int leptetoIndex
        {
            get { return lepteto; }
            set { lepteto = value; }
        }

        public int mCount
        {
            get { return maxCount; }
            set { maxCount = value; }
        }

        public List<DateTime> datLista
        {
            get { return dLista; }
            set { dLista = value; }
        }

        public Boolean panelVezk
        {
            set { _panelVezk = value; }
        }

        public Boolean panelKemh
        {
            set { _panelKemh = value; }
        }

        public Boolean HT1
        {
            set { ht1 = value; }
        }

        public Boolean HT2
        {
            set { ht2 = value; }
        }

        public Boolean HT3
        {
            set { ht3 = value; }
        }

        public Boolean HT4
        {
            set { ht4 = value; }
        }

        public Boolean HT5
        {
            set { ht5 = value; }
        }

        public Boolean HT6
        {
            set { ht6 = value; }
        }

        public Boolean HT7
        {
            set { ht7 = value; }
        }

        public Boolean HT8
        {
            set { ht8 = value; }
        }

        public Boolean HT9
        {
            set { ht9 = value; }
        }

        public Boolean HT10
        {
            set { ht10 = value; }
        }

        public Boolean Potviz
        {
            set { potviz = value; }
        }

        public Boolean Hutesi
        {
            set { hutesi = value; }
        }

        public Boolean Kondenz
        {
            set { kondenz = value; }
        }

        public Boolean Nyersviz
        {
            set { nyersviz = value; }
        }

        public Boolean Duo10
        {
            set { duo10 = value; }
        }

        public List<Vezetokepesseg> HT1VKLista
        {
            get { return ht1VKLista; }
            set { ht1VKLista = value; }
        }

        public List<Kemhata> HT1KHLista
        {
            get { return ht1KHLista; }
            set { ht1KHLista = value; }
        }

        public List<Vezetokepesseg> HT2VKLista
        {
            get { return ht2VKLista; }
            set { ht2VKLista = value; }
        }

        public List<Kemhata> HT2KHLista
        {
            get { return ht2KHLista; }
            set { ht2KHLista = value; }
        }

        public List<Vezetokepesseg> HT3VKLista
        {
            get { return ht3VKLista; }
            set { ht3VKLista = value; }
        }

        public List<Kemhata> HT3KHLista
        {
            get { return ht3KHLista; }
            set { ht3KHLista = value; }
        }

        public List<Vezetokepesseg> HT4VKLista
        {
            get { return ht4VKLista; }
            set { ht4VKLista = value; }
        }

        public List<Kemhata> HT4KHLista
        {
            get { return ht4KHLista; }
            set { ht4KHLista = value; }
        }

        public List<Vezetokepesseg> HT5VKLista
        {
            get { return ht5VKLista; }
            set { ht5VKLista = value; }
        }

        public List<Kemhata> HT5KHLista
        {
            get { return ht5KHLista; }
            set { ht5KHLista = value; }
        }

        public List<Vezetokepesseg> HT6VKLista
        {
            get { return ht6VKLista; }
            set { ht6VKLista = value; }
        }

        public List<Kemhata> HT6KHLista
        {
            get { return ht6KHLista; }
            set { ht6KHLista = value; }
        }

        public List<Vezetokepesseg> HT7VKLista
        {
            get { return ht7VKLista; }
            set { ht7VKLista = value; }
        }

        public List<Kemhata> HT7KHLista
        {
            get { return ht7KHLista; }
            set { ht7KHLista = value; }
        }

        public List<Vezetokepesseg> HT8VKLista
        {
            get { return ht8VKLista; }
            set { ht8VKLista = value; }
        }

        public List<Kemhata> HT8KHLista
        {
            get { return ht8KHLista; }
            set { ht8KHLista = value; }
        }

        public List<Vezetokepesseg> HT9VKLista
        {
            get { return ht9VKLista; }
            set { ht9VKLista = value; }
        }

        public List<Kemhata> HT9KHLista
        {
            get { return ht9KHLista; }
            set { ht9KHLista = value; }
        }

        public List<Vezetokepesseg> HT10VKLista
        {
            get { return ht10VKLista; }
            set { ht10VKLista = value; }
        }

        public List<Kemhata> HT10KHLista
        {
            get { return ht10KHLista; }
            set { ht10KHLista = value; }
        }      

        public List<Vezetokepesseg> KondenzVKLista
        {
            get { return kondenzVKLista; }
            set { kondenzVKLista = value; }
        }

        public List<Kemhata> KondenzKHLista
        {
            get { return kondenzKHLista; }
            set { kondenzKHLista = value; }
        }

        public List<Vezetokepesseg> PotvizVKLista
        {
            get { return potvizVKLista; }
            set { potvizVKLista = value; }
        }

        public List<Kemhata> PotvizKHLista
        {
            get { return potvizKHLista; }
            set { potvizKHLista = value; }
        }

        public List<Vezetokepesseg> HutesiVKLista
        {
            get { return hutesiVKLista; }
            set { hutesiVKLista = value; }
        }

        public List<Kemhata> HutesiKHLista
        {
            get { return hutesiKHLista; }
            set { hutesiKHLista = value; }
        }

        public List<Vezetokepesseg> NyersvizVKLista
        {
            get { return nyersvizVKLista; }
            set { nyersvizVKLista = value; }
        }

        public List<Kemhata> NyersvizKHLista
        {
            get { return nyersvizKHLista; }
            set { nyersvizKHLista = value; }
        }

        public List<Vezetokepesseg> Duo10VKLista
        {
            get { return duo10VKLista; }
            set { duo10VKLista = value; }
        }

        public List<Kemhata> Duo10KHLista
        {
            get { return duo10KHLista; }
            set { duo10KHLista = value; }
        }

        public List<Koordinata> HT1KOVKLista
        {
            get { return ht1KoVezk; }
            set { ht1KoVezk = value; }
        }

        public List<Koordinata> HT1KOKHLista
        {
            get { return ht1KoKemh; }
            set { ht1KoKemh = value; }
        }

        public List<Koordinata> HT2KOVKLista
        {
            get { return ht2KoVezk; }
            set { ht2KoVezk = value; }
        }

        public List<Koordinata> HT2KOKHLista
        {
            get { return ht2KoKemh; }
            set { ht2KoKemh = value; }
        }

        public List<Koordinata> HT3KOVKLista
        {
            get { return ht3KoVezk; }
            set { ht3KoVezk = value; }
        }

        public List<Koordinata> HT3KOKHLista
        {
            get { return ht3KoKemh; }
            set { ht3KoKemh = value; }
        }

        public List<Koordinata> HT4KOVKLista
        {
            get { return ht4KoVezk; }
            set { ht4KoVezk = value; }
        }

        public List<Koordinata> HT4KOKHLista
        {
            get { return ht4KoKemh; }
            set { ht4KoKemh = value; }
        }

        public List<Koordinata> HT5KOVKLista
        {
            get { return ht5KoVezk; }
            set { ht5KoVezk = value; }
        }

        public List<Koordinata> HT5KOKHLista
        {
            get { return ht5KoKemh; }
            set { ht5KoKemh = value; }
        }

        public List<Koordinata> HT6KOVKLista
        {
            get { return ht6KoVezk; }
            set { ht6KoVezk = value; }
        }

        public List<Koordinata> HT6KOKHLista
        {
            get { return ht6KoKemh; }
            set { ht6KoKemh = value; }
        }

        public List<Koordinata> HT7KOVKLista
        {
            get { return ht7KoVezk; }
            set { ht7KoVezk = value; }
        }

        public List<Koordinata> HT7KOKHLista
        {
            get { return ht7KoKemh; }
            set { ht7KoKemh = value; }
        }

        public List<Koordinata> HT8KOVKLista
        {
            get { return ht8KoVezk; }
            set { ht8KoVezk = value; }
        }

        public List<Koordinata> HT8KOKHLista
        {
            get { return ht8KoKemh; }
            set { ht8KoKemh = value; }
        }

        public List<Koordinata> HT9KOVKLista
        {
            get { return ht9KoVezk; }
            set { ht9KoVezk = value; }
        }

        public List<Koordinata> HT9KOKHLista
        {
            get { return ht9KoKemh; }
            set { ht9KoKemh = value; }
        }

        public List<Koordinata> HT10KOVKLista
        {
            get { return ht10KoVezk; }
            set { ht10KoVezk = value; }
        }

        public List<Koordinata> HT10KOKHLista
        {
            get { return ht10KoKemh; }
            set { ht10KoKemh = value; }
        }

        public List<Koordinata> PotvizKOVKLista
        {
            get { return potvizKoVezk; }
            set { potvizKoVezk = value; }
        }

        public List<Koordinata> PotvizKOKHLista
        {
            get { return potvizKoKemh; }
            set { potvizKoKemh = value; }
        }

        public List<Koordinata> KondenzKOVKLista
        {
            get { return kondenzKoVezk; }
            set { kondenzKoVezk = value; }
        }

        public List<Koordinata> KondenzKOKHLista
        {
            get { return kondenzKoKemh; }
            set { kondenzKoKemh = value; }
        }

        public List<Koordinata> HutesiKOVKLista
        {
            get { return hutesiKoVezk; }
            set { hutesiKoVezk = value; }
        }

        public List<Koordinata> HutesiKOKHLista
        {
            get { return hutesiKoKemh; }
            set { hutesiKoKemh = value; }
        }

        public List<Koordinata> NyersvizKOVKLista
        {
            get { return nyersvizKoVezk; }
            set { nyersvizKoVezk = value; }
        }

        public List<Koordinata> NyersvizKOKHLista
        {
            get { return nyersvizKoKemh; }
            set { nyersvizKoKemh = value; }
        }

        public List<Koordinata> Duo10KOVKLista
        {
            get { return duo10KoVezk; }
            set { duo10KoVezk = value; }
        }

        public List<Koordinata> Duo10KOKHLista
        {
            get { return duo10KoKemh; }
            set { duo10KoKemh = value; }
        }

        //Vezetőképesség grafikon kirajzolása
        public void vkGraf(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush vezkBrush = new SolidBrush(Color.Blue);      
            Brush racs = new SolidBrush(Color.LightGray);
            Pen racsPen = new Pen(racs, 1);
            Brush pozicionaloBrush = new SolidBrush(Color.Black);
            Pen pozicionaloPen = new Pen(pozicionaloBrush, 1);
            Pen vezkPen = new Pen(vezkBrush, 1);
            StringFormat sFormat = new StringFormat();
            sFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawLine(vezkPen, 90, 30, 90, 450);
            g.DrawLine(vezkPen, 90, 450, 870, 450);

            int KoordErtekVezetokepesseg = 200;
            int vezkLeptekY = 40;
            int vezkLeptekX = 40;
            int vezkKisLeptekY = -10;
            //Lépték az értékekhez
            while (vezkLeptekY != 460)
            {
                g.DrawLine(vezkPen, 82, 460 - vezkLeptekY, 98, 460 - vezkLeptekY);
                g.DrawLine(racsPen, 98, 460 - vezkLeptekY, 870, 460 - vezkLeptekY);
                g.DrawString((KoordErtekVezetokepesseg).ToString(), new Font("Segoe UI", 12), Brushes.Blue, 80, 450 - vezkLeptekY, sFormat);

                vezkLeptekY = vezkLeptekY + 30;
                KoordErtekVezetokepesseg = KoordErtekVezetokepesseg + 200;
                while (vezkKisLeptekY != 410)
                {
                    g.DrawLine(vezkPen, 87, 435 - vezkKisLeptekY, 92, 435 - vezkKisLeptekY);
                    vezkKisLeptekY = vezkKisLeptekY + 5;
                    g.DrawLine(vezkPen, 90, 100, 90, 442);
                }
            }
            while (vezkLeptekX != 820)
            {
                g.DrawLine(vezkPen, 80 + vezkLeptekX, 458, 80 + vezkLeptekX, 442);
                g.DrawLine(racsPen, 80 + vezkLeptekX, 442, 80 + vezkLeptekX, 30);
                vezkLeptekX = vezkLeptekX + 30;
            }
            vezkLeptekX = 30;            
            Brush brush = new SolidBrush(Color.Blue);
            koordinataTorloVK();
            datumHelyekVK(g, vezkLeptekX, brush);            
            scrollPoz(g);
        }

        private void koordinataTorloVK()
        {
            ht1KoVezk.Clear();
            ht2KoVezk.Clear();
            ht3KoVezk.Clear();
            ht4KoVezk.Clear();
            ht5KoVezk.Clear();
            ht6KoVezk.Clear();
            ht7KoVezk.Clear();
            ht8KoVezk.Clear();
            ht9KoVezk.Clear();
            ht10KoVezk.Clear();
            potvizKoVezk.Clear();
            hutesiKoVezk.Clear();
            kondenzKoVezk.Clear();
            nyersvizKoVezk.Clear();
            duo10KoVezk.Clear();
            ertekNullazo();
        }

        //Kémhatás grafikon kirajzolása
        public void khGraf(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush kemhBrush = new SolidBrush(Color.Green);
            Pen kemhPen = new Pen(kemhBrush, 1);
            Brush racs = new SolidBrush(Color.LightGray);
            Pen racsPen = new Pen(racs, 1);            
            StringFormat sFormat = new StringFormat();
            sFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            
            g.DrawLine(kemhPen, 90, 30, 90, 450);
            g.DrawLine(kemhPen, 90, 450, 870, 450);

            int KoordErtek = 1;
            int kemhLeptekY = 40;
            int kemhLeptekX = 40;
            int kemhKisLeptekY = -10;
            //Lépték az értékekhez
            while (kemhLeptekY != 460)
            {
                g.DrawLine(kemhPen, 82, 460 - kemhLeptekY, 98, 460 - kemhLeptekY);
                g.DrawLine(racsPen, 98, 460 - kemhLeptekY, 870, 460 - kemhLeptekY);                
                g.DrawString((KoordErtek).ToString(), new Font("Segoe UI", 12), Brushes.Green, 80, 450 - kemhLeptekY, sFormat);

                kemhLeptekY = kemhLeptekY + 30;
                KoordErtek = KoordErtek + 1;
                while (kemhKisLeptekY != 410)
                {
                    g.DrawLine(kemhPen, 87, 435 - kemhKisLeptekY, 92, 435 - kemhKisLeptekY);                  
                    kemhKisLeptekY = kemhKisLeptekY + 5;
                }
            }
            while (kemhLeptekX != 820)
            {
                g.DrawLine(kemhPen, 80 + kemhLeptekX, 458, 80 + kemhLeptekX, 442);                
                g.DrawLine(racsPen, 80 + kemhLeptekX, 442, 80 + kemhLeptekX, 30);                
                kemhLeptekX = kemhLeptekX + 30;
            }
            kemhLeptekX = 30;
            Brush brush = new SolidBrush(Color.Green);
            koordinataTorloKH();
            datumHelyekKH(g, kemhLeptekX, brush); 
            scrollPoz(g);
        }

        private void koordinataTorloKH()
        {
            ht1KoKemh.Clear();
            ht2KoKemh.Clear();
            ht3KoKemh.Clear();
            ht4KoKemh.Clear();
            ht5KoKemh.Clear();
            ht6KoKemh.Clear();
            ht7KoKemh.Clear();
            ht8KoKemh.Clear();
            ht9KoKemh.Clear();
            ht10KoKemh.Clear();
            potvizKoKemh.Clear();
            hutesiKoKemh.Clear();
            kondenzKoKemh.Clear();
            nyersvizKoKemh.Clear();
            duo10KoKemh.Clear();
            ertekNullazo();
        }

        private static void ertekNullazo()
        {
            ertek1 = null;
            ertek2 = null;
            ertek3 = null;
            ertek4 = null;
            ertek5 = null;
            ertek6 = null;
            ertek7 = null;
            ertek8 = null;
            ertek9 = null;
            ertek10 = null;
            ertek11 = null;
            ertek12 = null;
            ertek13 = null;
            ertek14 = null;
            ertek15 = null;
        }

        
        public void scrollPoz(Graphics g)
        {                
            Brush pozicionaloBrush = new SolidBrush(Color.Black);
            Pen pozicionaloPen = new Pen(pozicionaloBrush, 1);
            if (trackBarpozicio >= 0)
            {
                g.DrawLine(pozicionaloPen, 90 + trackBarpozicio, 30, 90 + trackBarpozicio, 450);
                if (ht1)
                {                    
                    if (_panelVezk)
                    {
                        ertek1 = null;
                        for (int i = 0; i < ht1KoVezk.Count; i++)
                        {
                            if (ht1KoVezk[i].ht1VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_1(g, ht1KoVezk[i].ht1VX, ht1KoVezk[i].ht1VY);
                                ertek1 = ht1VKLista[i+ lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek1 = null;
                        for (int i = 0; i < ht1KoKemh.Count; i++)
                        {
                            if (ht1KoKemh[i].ht1KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_1(g, ht1KoKemh[i].ht1KX, ht1KoKemh[i].ht1KY);
                                ertek1 = ht1KHLista[i+ lepteto].kemhatas.ToString();
                            }
                        }
                    }                   
                }
                if (ht2)
                {
                    if (_panelVezk)
                    {
                        ertek2 = null;
                        for (int i = 0; i < ht2KoVezk.Count; i++)
                        {
                            if (ht2KoVezk[i].ht2VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_2(g, ht2KoVezk[i].ht2VX, ht2KoVezk[i].ht2VY);
                                ertek2 = ht2VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek2 = null;
                        for (int i = 0; i < ht2KoKemh.Count; i++)
                        {
                            if (ht2KoKemh[i].ht2KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_2(g, ht2KoKemh[i].ht2KX, ht2KoKemh[i].ht2KY);
                                ertek2 = ht2KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht3)
                {
                    if (_panelVezk)
                    {
                        ertek3 = null;
                        for (int i = 0; i < ht3KoVezk.Count; i++)
                        {
                            if (ht3KoVezk[i].ht3VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_3(g, ht3KoVezk[i].ht3VX, ht3KoVezk[i].ht3VY);
                                ertek3 = ht3VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek3 = null;
                        for (int i = 0; i < ht3KoKemh.Count; i++)
                        {
                            if (ht3KoKemh[i].ht3KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_3(g, ht3KoKemh[i].ht3KX, ht3KoKemh[i].ht3KY);
                                ertek3 = ht3KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht4)
                {
                    if (_panelVezk)
                    {
                        ertek4 = null;
                        for (int i = 0; i < ht4KoVezk.Count; i++)
                        {
                            if (ht4KoVezk[i].ht4VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_4(g, ht4KoVezk[i].ht4VX, ht4KoVezk[i].ht4VY);
                                ertek4 = ht4VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek4 = null;
                        for (int i = 0; i < ht4KoKemh.Count; i++)
                        {
                            if (ht4KoKemh[i].ht4KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_4(g, ht4KoKemh[i].ht4KX, ht4KoKemh[i].ht4KY);
                                ertek4 = ht4KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht5)
                {
                    if (_panelVezk)
                    {
                        ertek5 = null;
                        for (int i = 0; i < ht5KoVezk.Count; i++)
                        {
                            if (ht5KoVezk[i].ht5VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_5(g, ht5KoVezk[i].ht5VX, ht5KoVezk[i].ht5VY);
                                ertek5 = ht5VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek5 = null;
                        for (int i = 0; i < ht5KoKemh.Count; i++)
                        {
                            if (ht5KoKemh[i].ht5KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_5(g, ht5KoKemh[i].ht5KX, ht5KoKemh[i].ht5KY);
                                ertek5 = ht5KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht6)
                {
                    if (_panelVezk)
                    {
                        ertek6 = null;
                        for (int i = 0; i < ht6KoVezk.Count; i++)
                        {
                            if (ht6KoVezk[i].ht6VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_6(g, ht6KoVezk[i].ht6VX, ht6KoVezk[i].ht6VY);
                                ertek6 = ht6VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek6 = null;
                        for (int i = 0; i < ht6KoKemh.Count; i++)
                        {
                            if (ht6KoKemh[i].ht6KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_6(g, ht6KoKemh[i].ht6KX, ht6KoKemh[i].ht6KY);
                                ertek6 = ht6KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht7)
                {
                    if (_panelVezk)
                    {
                        ertek7 = null;
                        for (int i = 0; i < ht7KoVezk.Count; i++)
                        {
                            if (ht7KoVezk[i].ht7VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_7(g, ht7KoVezk[i].ht7VX, ht7KoVezk[i].ht7VY);
                                ertek7 = ht7VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek7 = null;
                        for (int i = 0; i < ht7KoKemh.Count; i++)
                        {
                            if (ht7KoKemh[i].ht7KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_7(g, ht7KoKemh[i].ht7KX, ht7KoKemh[i].ht7KY);
                                ertek7 = ht7KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht8)
                {
                    if (_panelVezk)
                    {
                        ertek8 = null;
                        for (int i = 0; i < ht8KoVezk.Count; i++)
                        {
                            if (ht8KoVezk[i].ht8VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_8(g, ht8KoVezk[i].ht8VX, ht8KoVezk[i].ht8VY);
                                ertek8 = ht8VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek8 = null;
                        for (int i = 0; i < ht8KoKemh.Count; i++)
                        {
                            if (ht8KoKemh[i].ht8KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_8(g, ht8KoKemh[i].ht8KX, ht8KoKemh[i].ht8KY);
                                ertek8 =  ht8KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht9)
                {
                    if (_panelVezk)
                    {
                        ertek9 = null;
                        for (int i = 0; i < ht9KoVezk.Count; i++)
                        {
                            if (ht9KoVezk[i].ht9VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_9(g, ht9KoVezk[i].ht9VX, ht9KoVezk[i].ht9VY);
                                ertek9 = ht9VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek9 = null;
                        for (int i = 0; i < ht9KoKemh.Count; i++)
                        {
                            if (ht9KoKemh[i].ht9KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_9(g, ht9KoKemh[i].ht9KX, ht9KoKemh[i].ht9KY);
                                ertek9 = ht9KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (ht10)
                {
                    if (_panelVezk)
                    {
                        ertek10 = null;
                        for (int i = 0; i < ht10KoVezk.Count; i++)
                        {
                            if (ht10KoVezk[i].ht10VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_10(g, ht10KoVezk[i].ht10VX, ht10KoVezk[i].ht10VY);
                                ertek10 = ht10VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek10 = null;
                        for (int i = 0; i < ht10KoKemh.Count; i++)
                        {
                            if (ht10KoKemh[i].ht10KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_10(g, ht10KoKemh[i].ht10KX, ht10KoKemh[i].ht10KY);
                                ertek10 = ht10KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (potviz)
                {
                    if (_panelVezk)
                    {
                        ertek11 = null;
                        for (int i = 0; i < potvizKoVezk.Count; i++)
                        {
                            if (potvizKoVezk[i].potvizVX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_11(g, potvizKoVezk[i].potvizVX, potvizKoVezk[i].potvizVY);
                                ertek11 = potvizVKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek11 = null;
                        for (int i = 0; i < potvizKoKemh.Count; i++)
                        {
                            if (potvizKoKemh[i].potvizKX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_11(g, potvizKoKemh[i].potvizKX, potvizKoKemh[i].potvizKY);
                                ertek11 = potvizKHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (hutesi)
                {
                    if (_panelVezk)
                    {
                        ertek12 = null;
                        for (int i = 0; i < hutesiKoVezk.Count; i++)
                        {
                            if (hutesiKoVezk[i].hutesiVX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_12(g, hutesiKoVezk[i].hutesiVX, hutesiKoVezk[i].hutesiVY);
                                ertek12 = hutesiVKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek12 = null;
                        for (int i = 0; i < hutesiKoKemh.Count; i++)
                        {
                            if (hutesiKoKemh[i].hutesiKX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_12(g, hutesiKoKemh[i].hutesiKX, hutesiKoKemh[i].hutesiKY);
                                ertek12 = hutesiKHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (kondenz)
                {
                    if (_panelVezk)
                    {
                        ertek13 = null;
                        for (int i = 0; i < kondenzKoVezk.Count; i++)
                        {
                            if (kondenzKoVezk[i].kondenzVX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_13(g, kondenzKoVezk[i].kondenzVX, kondenzKoVezk[i].kondenzVY);
                                ertek13 = kondenzVKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek13 = null;
                        for (int i = 0; i < kondenzKoKemh.Count; i++)
                        {
                            if (kondenzKoKemh[i].kondenzKX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_13(g, kondenzKoKemh[i].kondenzKX, kondenzKoKemh[i].kondenzKY);
                                ertek13 = kondenzKHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (nyersviz)
                {
                    if (_panelVezk)
                    {
                        ertek14 = null;
                        for (int i = 0; i < nyersvizKoVezk.Count; i++)
                        {
                            if (nyersvizKoVezk[i].nyersvizVX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_14(g, nyersvizKoVezk[i].nyersvizVX, nyersvizKoVezk[i].nyersvizVY);
                                ertek14 = nyersvizVKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek14 = null;
                        for (int i = 0; i < nyersvizKoKemh.Count; i++)
                        {
                            if (nyersvizKoKemh[i].nyersvizKX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_14(g, nyersvizKoKemh[i].nyersvizKX, nyersvizKoKemh[i].nyersvizKY);
                                ertek14 = nyersvizKHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
                if (duo10)
                {
                    if (_panelVezk)
                    {
                        ertek15 = null;
                        for (int i = 0; i < duo10KoVezk.Count; i++)
                        {
                            if (duo10KoVezk[i].duo10VX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_15(g, duo10KoVezk[i].duo10VX, duo10KoVezk[i].duo10VY);
                                ertek15 = duo10VKLista[i + lepteto].vezetokepesseg1.ToString();
                            }
                        }
                    }
                    if (_panelKemh)
                    {
                        ertek15 = null;
                        for (int i = 0; i < duo10KoKemh.Count; i++)
                        {
                            if (duo10KoKemh[i].duo10KX == (90 + trackBarpozicio) - 4)
                            {
                                negyzet_15(g, duo10KoKemh[i].duo10KX, duo10KoKemh[i].duo10KY);
                                ertek15 = duo10KHLista[i + lepteto].kemhatas.ToString();
                            }
                        }
                    }
                }
            }           
        }

        //Pozícionáló négyzet objektuma
        private void negyzet_1(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX-2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX-2, pozY - 3, 10, 10);
            g.DrawString("1", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_2(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("2", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_3(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("3", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_4(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("4", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_5(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("5", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_6(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("6", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_7(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("7", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_8(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("8", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_9(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("9", new Font("Arial", 6), szamBrush, pozX, pozY - 3);
        }

        private void negyzet_10(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("10", new Font("Arial", 6), szamBrush, pozX-2, pozY - 3);
        }

        private void negyzet_11(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("11", new Font("Arial", 6), szamBrush, pozX-2, pozY - 3);
        }

        private void negyzet_12(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("12", new Font("Arial", 6), szamBrush, pozX-2, pozY - 3);
        }

        private void negyzet_13(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("13", new Font("Arial", 6), szamBrush, pozX-2, pozY - 3);
        }

        private void negyzet_14(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("14", new Font("Arial", 6), szamBrush, pozX-2, pozY - 3);
        }

        private void negyzet_15(Graphics g, int pozX, int pozY)
        {
            Brush szamBrush = new SolidBrush(Color.Black);
            Pen szamPen = new Pen(szamBrush, 1);
            Brush negyzetBrush = new SolidBrush(Color.White);
            Pen negyzetPen = new Pen(negyzetBrush, 1);
            g.DrawRectangle(szamPen, pozX - 2, pozY - 3, 10, 10);
            g.FillRectangle(negyzetBrush, pozX - 2, pozY - 3, 10, 10);
            g.DrawString("15", new Font("Arial", 6), szamBrush, pozX - 2, pozY - 3);
        }

        private void datumHelyekVK(Graphics g, int leptek, Brush brush)
        {            
            if (datLista.Count > 26)
            {
                maxCount = datLista.Count - 26;
                if (lepteto <= maxCount)
                {
                    for (int i = lepteto; i < 26 + lepteto; i++)
                    {
                        if (ht1 == true)
                        {                           
                            for (int j = lepteto; j < ht1VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht1VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT1VK(g, leptek, j);
                                    grafVonalHT1VK(g);
                                }
                            }
                        }
                        if (ht2 == true)
                        {
                            for (int j = lepteto; j < ht2VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht2VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT2VK(g, leptek, j);
                                    grafVonalHT2VK(g);
                                }
                            }
                        }
                        if (ht3 == true)
                        {
                            for (int j = lepteto; j < ht3VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht3VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT3VK(g, leptek, j);
                                    grafVonalHT3VK(g);
                                }
                            }
                        }
                        if (ht4 == true)
                        {
                            for (int j = lepteto; j < ht4VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht4VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT4VK(g, leptek, j);
                                    grafVonalHT4VK(g);
                                }
                            }
                        }
                        if (ht5 == true)
                        {
                            for (int j = lepteto; j < ht5VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht5VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT5VK(g, leptek, j);
                                    grafVonalHT5VK(g);
                                }
                            }
                        }
                        if (ht6 == true)
                        {
                            for (int j = lepteto; j < ht6VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht6VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT6VK(g, leptek, j);
                                    grafVonalHT6VK(g);
                                }
                            }
                        }
                        if (ht7 == true)
                        {
                            for (int j = lepteto; j < ht7VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht7VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT7VK(g, leptek, j);
                                    grafVonalHT7VK(g);
                                }
                            }
                        }
                        if (ht8 == true)
                        {
                            for (int j = lepteto; j < ht8VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht8VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT8VK(g, leptek, j);
                                    grafVonalHT8VK(g);
                                }
                            }
                        }
                        if (ht9 == true)
                        {
                            for (int j = lepteto; j < ht9VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht9VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT9VK(g, leptek, j);
                                    grafVonalHT9VK(g);
                                }
                            }
                        }
                        if (ht10 == true)
                        {
                            for (int j = lepteto; j < ht10VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht10VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT10VK(g, leptek, j);
                                    grafVonalHT10VK(g);
                                }
                            }
                        }
                        if (potviz == true)
                        {
                            for (int j = lepteto; j < potvizVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == potvizVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafPotvizVK(g, leptek, j);
                                    grafVonalPotvizVK(g);
                                }
                            }
                        }
                        if (hutesi == true)
                        {
                            for (int j = lepteto; j < hutesiVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == hutesiVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHutesiVK(g, leptek, j);
                                    grafVonalHutesiVK(g);
                                }
                            }
                        }
                        if (kondenz == true)
                        {
                            for (int j = lepteto; j < kondenzVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == kondenzVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafKondenzVK(g, leptek, j);
                                    grafVonalKondenzVK(g);
                                }
                            }
                        }
                        if (nyersviz == true)
                        {
                            for (int j = lepteto; j < nyersvizVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == nyersvizVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafNyersvizVK(g, leptek, j);
                                    grafVonalNyersvizVK(g);
                                }
                            }
                        }
                        if (duo10 == true)
                        {
                            for (int j = lepteto; j < duo10VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == duo10VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafDuo10VK(g, leptek, j);
                                    grafVonalDuo10VK(g);
                                }
                            }
                        }
                        g.TranslateTransform(40.0F + leptek, 515.0F);
                        g.RotateTransform(300.0F);
                        g.DrawString(datLista[i].ToString("d"), new Font("Segoe UI", 10), brush, 0.0F, 0.0F);
                        leptek = leptek + 30;
                        g.ResetTransform();
                    }
                }
            }
            else
            {
                if (datLista.Count != 0 && datLista.Count < 26)
                {
                    xLeptek = 26 / datLista.Count;
                    for (int i = lepteto; i < datLista.Count; i++)
                    {
                        if (ht1 == true)
                        {                          
                            for (int j = lepteto; j < ht1VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht1VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT1VK(g, leptek, j);
                                    grafVonalHT1VK(g);
                                }
                            }                           
                        }
                        if (ht2 == true)
                        {
                            for (int j = lepteto; j < ht2VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht2VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT2VK(g, leptek, j);
                                    grafVonalHT2VK(g);
                                }
                            }
                        }
                        if (ht3 == true)
                        {
                            for (int j = lepteto; j < ht3VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht3VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT3VK(g, leptek, j);
                                    grafVonalHT3VK(g);
                                }
                            }
                        }
                        if (ht4 == true)
                        {
                            for (int j = lepteto; j < ht4VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht4VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT4VK(g, leptek, j);
                                    grafVonalHT4VK(g);
                                }
                            }
                        }
                        if (ht5 == true)
                        {
                            for (int j = lepteto; j < ht5VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht5VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT5VK(g, leptek, j);
                                    grafVonalHT5VK(g);
                                }
                            }
                        }
                        if (ht6 == true)
                        {
                            for (int j = lepteto; j < ht6VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht6VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT6VK(g, leptek, j);
                                    grafVonalHT6VK(g);
                                }
                            }
                        }
                        if (ht7 == true)
                        {
                            for (int j = lepteto; j < ht7VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht7VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT7VK(g, leptek, j);
                                    grafVonalHT7VK(g);
                                }
                            }
                        }
                        if (ht8 == true)
                        {
                            for (int j = lepteto; j < ht8VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht8VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT8VK(g, leptek, j);
                                    grafVonalHT8VK(g);
                                }
                            }
                        }
                        if (ht9 == true)
                        {
                            for (int j = lepteto; j < ht9VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht9VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT9VK(g, leptek, j);
                                    grafVonalHT9VK(g);
                                }
                            }
                        }
                        if (ht10 == true)
                        {
                            for (int j = lepteto; j < ht10VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht10VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT10VK(g, leptek, j);
                                    grafVonalHT10VK(g);
                                }
                            }
                        }
                        if (potviz == true)
                        {
                            for (int j = lepteto; j < potvizVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == potvizVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafPotvizVK(g, leptek, j);
                                    grafVonalPotvizVK(g);
                                }
                            }
                        }
                        if (hutesi == true)
                        {
                            for (int j = lepteto; j < hutesiVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == hutesiVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHutesiVK(g, leptek, j);
                                    grafVonalHutesiVK(g);
                                }
                            }
                        }
                        if (kondenz == true)
                        {
                            for (int j = lepteto; j < kondenzVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == kondenzVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafKondenzVK(g, leptek, j);
                                    grafVonalKondenzVK(g);
                                }
                            }
                        }
                        if (nyersviz == true)
                        {
                            for (int j = lepteto; j < nyersvizVKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == nyersvizVKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafNyersvizVK(g, leptek, j);
                                    grafVonalNyersvizVK(g);
                                }
                            }
                        }
                        if (duo10 == true)
                        {
                            for (int j = lepteto; j < duo10VKLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == duo10VKLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafDuo10VK(g, leptek, j);
                                    grafVonalDuo10VK(g);
                                }
                            }
                        }
                        g.TranslateTransform(40.0F + leptek, 515.0F);
                        g.RotateTransform(300.0F);
                        g.DrawString(datLista[i].ToString("d"), new Font("Segoe UI", 10), brush, 0.0F, 0.0F);
                        leptek = leptek + (30 * xLeptek);
                        g.ResetTransform();
                    }
                    xLeptek = 0;                  
                }
            }
        }

        private void datumHelyekKH(Graphics g, int leptek, Brush brush)
        {
            if (datLista.Count > 26)
            {
                maxCount = datLista.Count - 26;
                if (lepteto <= maxCount)
                {
                    for (int i = lepteto; i < 26 + lepteto; i++)
                    {
                        if (ht1 == true)
                        {
                            for (int j = lepteto; j < ht1KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht1KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT1KH(g, leptek, j);
                                    grafVonalHT1KH(g);
                                }
                            }                            
                        }
                        if (ht2 == true)
                        {
                            for (int j = lepteto; j < ht2KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht2KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT2KH(g, leptek, j);
                                    grafVonalHT2KH(g);
                                }
                            }
                        }
                        if (ht3 == true)
                        {
                            for (int j = lepteto; j < ht3KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht3KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT3KH(g, leptek, j);
                                    grafVonalHT3KH(g);
                                }
                            }
                        }
                        if (ht4 == true)
                        {
                            for (int j = lepteto; j < ht4KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht4KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT4KH(g, leptek, j);
                                    grafVonalHT4KH(g);
                                }
                            }
                        }
                        if (ht5 == true)
                        {
                            for (int j = lepteto; j < ht5KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht5KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT5KH(g, leptek, j);
                                    grafVonalHT5KH(g);
                                }
                            }
                        }
                        if (ht6 == true)
                        {
                            for (int j = lepteto; j < ht6KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht6KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT6KH(g, leptek, j);
                                    grafVonalHT6KH(g);
                                }
                            }
                        }
                        if (ht7 == true)
                        {
                            for (int j = lepteto; j < ht7KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht7KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT7KH(g, leptek, j);
                                    grafVonalHT7KH(g);
                                }
                            }
                        }
                        if (ht8 == true)
                        {
                            for (int j = lepteto; j < ht8KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht8KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT8KH(g, leptek, j);
                                    grafVonalHT8KH(g);
                                }
                            }
                        }
                        if (ht9 == true)
                        {
                            for (int j = lepteto; j < ht9KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht9KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT9KH(g, leptek, j);
                                    grafVonalHT9KH(g);
                                }
                            }
                        }
                        if (ht10 == true)
                        {
                            for (int j = lepteto; j < ht10KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht10KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT10KH(g, leptek, j);
                                    grafVonalHT10KH(g);
                                }
                            }
                        }
                        if (potviz == true)
                        {
                            for (int j = lepteto; j < potvizKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == potvizKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafPotvizKH(g, leptek, j);
                                    grafVonalPotvizKH(g);
                                }
                            }
                        }
                        if (hutesi == true)
                        {
                            for (int j = lepteto; j < hutesiKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == hutesiKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHutesiKH(g, leptek, j);
                                    grafVonalHutesiKH(g);
                                }
                            }
                        }
                        if (kondenz == true)
                        {
                            for (int j = lepteto; j < kondenzKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == kondenzKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafKondenzKH(g, leptek, j);
                                    grafVonalKondenzKH(g);
                                }
                            }
                        }
                        if (nyersviz == true)
                        {
                            for (int j = lepteto; j < nyersvizKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == nyersvizKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafNyersvizKH(g, leptek, j);
                                    grafVonalNyersvizKH(g);
                                }
                            }
                        }
                        if (duo10 == true)
                        {
                            for (int j = lepteto; j < duo10KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == duo10KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafDuo10KH(g, leptek, j);
                                    grafVonalDuo10KH(g);
                                }
                            }
                        }
                        g.TranslateTransform(40.0F + leptek, 515.0F);
                        g.RotateTransform(300.0F);
                        g.DrawString(datLista[i].ToString("d"), new Font("SegoeUI", 10), brush, 0.0F, 0.0F);
                        leptek = leptek + 30;
                        g.ResetTransform();
                    }
                }
            }
            else
            {
                if (datLista.Count != 0 && datLista.Count < 26)
                {
                    xLeptek = 26 / datLista.Count;
                    for (int i = lepteto; i < datLista.Count; i++)
                    {
                        if (ht1 == true)
                        {
                            for (int j = lepteto; j < ht1KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht1KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT1KH(g, leptek, j);
                                    grafVonalHT1KH(g);
                                }
                            }
                        }
                        if (ht2 == true)
                        {
                            for (int j = lepteto; j < ht2KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht2KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT2KH(g, leptek, j);
                                    grafVonalHT2KH(g);
                                }
                            }
                        }
                        if (ht3 == true)
                        {
                            for (int j = lepteto; j < ht3KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht3KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT3KH(g, leptek, j);
                                    grafVonalHT3KH(g);
                                }
                            }
                        }
                        if (ht4 == true)
                        {
                            for (int j = lepteto; j < ht4KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht4KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT4KH(g, leptek, j);
                                    grafVonalHT4KH(g);
                                }
                            }
                        }
                        if (ht5 == true)
                        {
                            for (int j = lepteto; j < ht5KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht5KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT5KH(g, leptek, j);
                                    grafVonalHT5KH(g);
                                }
                            }
                        }
                        if (ht6 == true)
                        {
                            for (int j = lepteto; j < ht6KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht6KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT6KH(g, leptek, j);
                                    grafVonalHT6KH(g);
                                }
                            }
                        }
                        if (ht7 == true)
                        {
                            for (int j = lepteto; j < ht7KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht7KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT7KH(g, leptek, j);
                                    grafVonalHT7KH(g);
                                }
                            }
                        }
                        if (ht8 == true)
                        {
                            for (int j = lepteto; j < ht8KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht8KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT8KH(g, leptek, j);
                                    grafVonalHT8KH(g);
                                }
                            }
                        }
                        if (ht9 == true)
                        {
                            for (int j = lepteto; j < ht9KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht9KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT9KH(g, leptek, j);
                                    grafVonalHT9KH(g);
                                }
                            }
                        }
                        if (ht10 == true)
                        {
                            for (int j = lepteto; j < ht10KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == ht10KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHT10KH(g, leptek, j);
                                    grafVonalHT10KH(g);
                                }
                            }
                        }
                        if (potviz == true)
                        {
                            for (int j = lepteto; j < potvizKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == potvizKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafPotvizKH(g, leptek, j);
                                    grafVonalPotvizKH(g);
                                }
                            }
                        }
                        if (hutesi == true)
                        {
                            for (int j = lepteto; j < hutesiKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == hutesiKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafHutesiKH(g, leptek, j);
                                    grafVonalHutesiKH(g);
                                }
                            }
                        }
                        if (kondenz == true)
                        {
                            for (int j = lepteto; j < kondenzKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == kondenzKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafKondenzKH(g, leptek, j);
                                    grafVonalKondenzKH(g);
                                }
                            }
                        }
                        if (nyersviz == true)
                        {
                            for (int j = lepteto; j < nyersvizKHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == nyersvizKHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafNyersvizKH(g, leptek, j);
                                    grafVonalNyersvizKH(g);
                                }
                            }
                        }
                        if (duo10 == true)
                        {
                            for (int j = lepteto; j < duo10KHLista.Count; j++)
                            {
                                if (datLista[i].ToString("d") == duo10KHLista[j].Mikor1.datum.ToString("d"))
                                {
                                    grafDuo10KH(g, leptek, j);
                                    grafVonalDuo10KH(g);
                                }
                            }
                        }
                        g.TranslateTransform(40.0F + leptek, 515.0F);
                        g.RotateTransform(300.0F);
                        g.DrawString(datLista[i].ToString("d"), new Font("Segoe UI", 10), brush, 0.0F, 0.0F);
                        leptek = leptek + (30 * xLeptek);
                        g.ResetTransform();
                    }
                }
            }
        }

        //HT1 vezetőképesség adatpontok kirajzolása
        private void grafHT1VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht1Brush = new SolidBrush(Color.Magenta);
            if (ht1VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht1VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht1Brush, 86 + leptek, ertek - 2, 7, 7);
                ht1KoVezk.Add(new Koordinata() { ht1VX = 86 + leptek, ht1VY = ertek });
            }                              
        }

        //HT1 vezetőképesség vonal kirajzolása
        private void grafVonalHT1VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht1Brush = new SolidBrush(Color.Magenta);
            Pen ht1Pen = new Pen(ht1Brush, 2);
            if (ht1KoVezk.Count != 0)
            {
                for (int i = 0; i < ht1KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht1Pen, (ht1KoVezk[i].ht1VX) + 3, (ht1KoVezk[i].ht1VY) + 1, (ht1KoVezk[i + 1].ht1VX) + 3, (ht1KoVezk[i + 1].ht1VY) + 1);
                }
            }
        }

        //HT1 kémhatás adatpontok kirajzolása
        private void grafHT1KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht1Brush = new SolidBrush(Color.Magenta);
            if (ht1KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht1KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht1Brush, 86 + leptek, ertek - 2, 7, 7);
                ht1KoKemh.Add(new Koordinata() { ht1KX = 86 + leptek, ht1KY = ertek });
            }
        }

        //HT1 kémhatás vonal kirajzolása
        private void grafVonalHT1KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht1Brush = new SolidBrush(Color.Magenta);
            Pen ht1Pen = new Pen(ht1Brush, 2);
            if (ht1KoKemh.Count != 0)
            {
                for (int i = 0; i < ht1KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht1Pen, (ht1KoKemh[i].ht1KX) + 3, (ht1KoKemh[i].ht1KY) + 1, (ht1KoKemh[i + 1].ht1KX) + 3, (ht1KoKemh[i + 1].ht1KY) + 1);
                }
            }
        }

        //HT2 vezetőképesség adatpontok kirajzolása
        private void grafHT2VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht2Brush = new SolidBrush(Color.DarkGreen);
            if (ht2VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht2VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht2Brush, 86 + leptek, ertek - 2, 7, 7);
                ht2KoVezk.Add(new Koordinata() { ht2VX = 86 + leptek, ht2VY = ertek });
            }
        }

        //HT2 vezetőképesség vonal kirajzolása
        private void grafVonalHT2VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht2Brush = new SolidBrush(Color.DarkGreen);
            Pen ht2Pen = new Pen(ht2Brush, 2);
            if (ht2KoVezk.Count != 0)
            {
                for (int i = 0; i < ht2KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht2Pen, (ht2KoVezk[i].ht2VX) + 3, (ht2KoVezk[i].ht2VY) + 1, (ht2KoVezk[i + 1].ht2VX) + 3, (ht2KoVezk[i + 1].ht2VY) + 1);
                }
            }
        }

        //HT2 kémhatás adatpontok kirajzolása
        private void grafHT2KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht2Brush = new SolidBrush(Color.DarkGreen);
            if (ht2KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht2KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht2Brush, 86 + leptek, ertek - 2, 7, 7);
                ht2KoKemh.Add(new Koordinata() { ht2KX = 86 + leptek, ht2KY = ertek });
            }
        }

        //HT2 kémhatás vonal kirajzolása
        private void grafVonalHT2KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht2Brush = new SolidBrush(Color.DarkGreen);
            Pen ht2Pen = new Pen(ht2Brush, 2);
            if (ht2KoKemh.Count != 0)
            {
                for (int i = 0; i < ht2KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht2Pen, (ht2KoKemh[i].ht2KX) + 3, (ht2KoKemh[i].ht2KY) + 1, (ht2KoKemh[i + 1].ht2KX) + 3, (ht2KoKemh[i + 1].ht2KY) + 1);
                }
            }
        }

        //HT3 vezetőképesség adatpontok kirajzolása
        private void grafHT3VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht3Brush = new SolidBrush(Color.DarkBlue);
            if (ht3VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht3VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht3Brush, 86 + leptek, ertek - 2, 7, 7);
                ht3KoVezk.Add(new Koordinata() { ht3VX = 86 + leptek, ht3VY = ertek });
            }
        }

        //HT3 vezetőképesség vonal kirajzolása
        private void grafVonalHT3VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht3Brush = new SolidBrush(Color.DarkBlue);
            Pen ht3Pen = new Pen(ht3Brush, 2);
            if (ht3KoVezk.Count != 0)
            {
                for (int i = 0; i < ht3KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht3Pen, (ht3KoVezk[i].ht3VX) + 3, (ht3KoVezk[i].ht3VY) + 1, (ht3KoVezk[i + 1].ht3VX) + 3, (ht3KoVezk[i + 1].ht3VY) + 1);
                }
            }
        }

        //HT3 kémhatás adatpontok kirajzolása
        private void grafHT3KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht3Brush = new SolidBrush(Color.DarkBlue);
            if (ht3KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht3KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht3Brush, 86 + leptek, ertek - 2, 7, 7);
                ht3KoKemh.Add(new Koordinata() { ht3KX = 86 + leptek, ht3KY = ertek });
            }
        }

        //HT3 kémhatás vonal kirajzolása
        private void grafVonalHT3KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht3Brush = new SolidBrush(Color.DarkBlue);
            Pen ht3Pen = new Pen(ht3Brush, 2);
            if (ht3KoKemh.Count != 0)
            {
                for (int i = 0; i < ht3KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht3Pen, (ht3KoKemh[i].ht3KX) + 3, (ht3KoKemh[i].ht3KY) + 1, (ht3KoKemh[i + 1].ht3KX) + 3, (ht3KoKemh[i + 1].ht3KY) + 1);
                }
            }
        }

        //HT4 vezetőképesség adatpontok kirajzolása
        private void grafHT4VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht4Brush = new SolidBrush(Color.MediumBlue);
            if (ht4VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht4VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht4Brush, 86 + leptek, ertek - 2, 7, 7);
                ht4KoVezk.Add(new Koordinata() { ht4VX = 86 + leptek, ht4VY = ertek });
            }
        }

        //HT4 vezetőképesség vonal kirajzolása
        private void grafVonalHT4VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht4Brush = new SolidBrush(Color.MediumBlue);
            Pen ht4Pen = new Pen(ht4Brush, 2);
            if (ht4KoVezk.Count != 0)
            {
                for (int i = 0; i < ht4KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht4Pen, (ht4KoVezk[i].ht4VX) + 3, (ht4KoVezk[i].ht4VY) + 1, (ht4KoVezk[i + 1].ht4VX) + 3, (ht4KoVezk[i + 1].ht4VY) + 1);
                }
            }
        }

        //HT4 kémhatás adatpontok kirajzolása
        private void grafHT4KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht4Brush = new SolidBrush(Color.MediumBlue);
            if (ht4KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht4KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht4Brush, 86 + leptek, ertek - 2, 7, 7);
                ht4KoKemh.Add(new Koordinata() { ht4KX = 86 + leptek, ht4KY = ertek });
            }
        }

        //HT4 kémhatás vonal kirajzolása
        private void grafVonalHT4KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht4Brush = new SolidBrush(Color.MediumBlue);
            Pen ht4Pen = new Pen(ht4Brush, 2);
            if (ht4KoKemh.Count != 0)
            {
                for (int i = 0; i < ht4KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht4Pen, (ht4KoKemh[i].ht4KX) + 3, (ht4KoKemh[i].ht4KY) + 1, (ht4KoKemh[i + 1].ht4KX) + 3, (ht4KoKemh[i + 1].ht4KY) + 1);
                }
            }
        }

        //HT5 vezetőképesség adatpontok kirajzolása
        private void grafHT5VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht5Brush = new SolidBrush(Color.MediumTurquoise);
            if (ht5VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht5VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht5Brush, 86 + leptek, ertek - 2, 7, 7);
                ht5KoVezk.Add(new Koordinata() { ht5VX = 86 + leptek, ht5VY = ertek });
            }
        }

        //HT5 vezetőképesség vonal kirajzolása
        private void grafVonalHT5VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht5Brush = new SolidBrush(Color.MediumTurquoise);
            Pen ht5Pen = new Pen(ht5Brush, 2);
            if (ht5KoVezk.Count != 0)
            {
                for (int i = 0; i < ht5KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht5Pen, (ht5KoVezk[i].ht5VX) + 3, (ht5KoVezk[i].ht5VY) + 1, (ht5KoVezk[i + 1].ht5VX) + 3, (ht5KoVezk[i + 1].ht5VY) + 1);
                }
            }
        }

        //HT5 kémhatás adatpontok kirajzolása
        private void grafHT5KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht5Brush = new SolidBrush(Color.MediumTurquoise);
            if (ht5KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht5KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht5Brush, 86 + leptek, ertek - 2, 7, 7);
                ht5KoKemh.Add(new Koordinata() { ht5KX = 86 + leptek, ht5KY = ertek });
            }
        }

        //HT5 kémhatás vonal kirajzolása
        private void grafVonalHT5KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht5Brush = new SolidBrush(Color.MediumTurquoise);
            Pen ht5Pen = new Pen(ht5Brush, 2);
            if (ht5KoKemh.Count != 0)
            {
                for (int i = 0; i < ht5KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht5Pen, (ht5KoKemh[i].ht5KX) + 3, (ht5KoKemh[i].ht5KY) + 1, (ht5KoKemh[i + 1].ht5KX) + 3, (ht5KoKemh[i + 1].ht5KY) + 1);
                }
            }
        }

        //HT6 vezetőképesség adatpontok kirajzolása
        private void grafHT6VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht6Brush = new SolidBrush(Color.Orange);
            if (ht6VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht6VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht6Brush, 86 + leptek, ertek - 2, 7, 7);
                ht6KoVezk.Add(new Koordinata() { ht6VX = 86 + leptek, ht6VY = ertek });
            }
        }

        //HT6 vezetőképesség vonal kirajzolása
        private void grafVonalHT6VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht6Brush = new SolidBrush(Color.Orange);
            Pen ht6Pen = new Pen(ht6Brush, 2);
            if (ht6KoVezk.Count != 0)
            {
                for (int i = 0; i < ht6KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht6Pen, (ht6KoVezk[i].ht6VX) + 3, (ht6KoVezk[i].ht6VY) + 1, (ht6KoVezk[i + 1].ht6VX) + 3, (ht6KoVezk[i + 1].ht6VY) + 1);
                }
            }
        }

        //HT6 kémhatás adatpontok kirajzolása
        private void grafHT6KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht6Brush = new SolidBrush(Color.Orange);
            if (ht6KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht6KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht6Brush, 86 + leptek, ertek - 2, 7, 7);
                ht6KoKemh.Add(new Koordinata() { ht6KX = 86 + leptek, ht6KY = ertek });
            }
        }

        //HT6 kémhatás vonal kirajzolása
        private void grafVonalHT6KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht6Brush = new SolidBrush(Color.Orange);
            Pen ht6Pen = new Pen(ht6Brush, 2);
            if (ht6KoKemh.Count != 0)
            {
                for (int i = 0; i < ht6KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht6Pen, (ht6KoKemh[i].ht6KX) + 3, (ht6KoKemh[i].ht6KY) + 1, (ht6KoKemh[i + 1].ht6KX) + 3, (ht6KoKemh[i + 1].ht6KY) + 1);
                }
            }
        }

        //HT7 vezetőképesség adatpontok kirajzolása
        private void grafHT7VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht7Brush = new SolidBrush(Color.PaleGoldenrod);
            if (ht7VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht7VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht7Brush, 86 + leptek, ertek - 2, 7, 7);
                ht7KoVezk.Add(new Koordinata() { ht7VX = 86 + leptek, ht7VY = ertek });
            }
        }

        //HT7 vezetőképesség vonal kirajzolása
        private void grafVonalHT7VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht7Brush = new SolidBrush(Color.PaleGoldenrod);
            Pen ht7Pen = new Pen(ht7Brush, 2);
            if (ht7KoVezk.Count != 0)
            {
                for (int i = 0; i < ht7KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht7Pen, (ht7KoVezk[i].ht7VX) + 3, (ht7KoVezk[i].ht7VY) + 1, (ht7KoVezk[i + 1].ht7VX) + 3, (ht7KoVezk[i + 1].ht7VY) + 1);
                }
            }
        }

        //HT7 kémhatás adatpontok kirajzolása
        private void grafHT7KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht7Brush = new SolidBrush(Color.PaleGoldenrod);
            if (ht7KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht7KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht7Brush, 86 + leptek, ertek - 2, 7, 7);
                ht7KoKemh.Add(new Koordinata() { ht7KX = 86 + leptek, ht7KY = ertek });
            }
        }

        //HT7 kémhatás vonal kirajzolása
        private void grafVonalHT7KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht7Brush = new SolidBrush(Color.PaleGoldenrod);
            Pen ht7Pen = new Pen(ht7Brush, 2);
            if (ht7KoKemh.Count != 0)
            {
                for (int i = 0; i < ht7KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht7Pen, (ht7KoKemh[i].ht7KX) + 3, (ht7KoKemh[i].ht7KY) + 1, (ht7KoKemh[i + 1].ht7KX) + 3, (ht7KoKemh[i + 1].ht7KY) + 1);
                }
            }
        }

        //HT8 vezetőképesség adatpontok kirajzolása
        private void grafHT8VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht8Brush = new SolidBrush(Color.Pink);
            if (ht8VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht8VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht8Brush, 86 + leptek, ertek - 2, 7, 7);
                ht8KoVezk.Add(new Koordinata() { ht8VX = 86 + leptek, ht8VY = ertek });
            }
        }

        //HT8 vezetőképesség vonal kirajzolása
        private void grafVonalHT8VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht8Brush = new SolidBrush(Color.Pink);
            Pen ht8Pen = new Pen(ht8Brush, 2);
            if (ht8KoVezk.Count != 0)
            {
                for (int i = 0; i < ht8KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht8Pen, (ht8KoVezk[i].ht8VX) + 3, (ht8KoVezk[i].ht8VY) + 1, (ht8KoVezk[i + 1].ht8VX) + 3, (ht8KoVezk[i + 1].ht8VY) + 1);
                }
            }
        }

        //HT8 kémhatás adatpontok kirajzolása
        private void grafHT8KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht8Brush = new SolidBrush(Color.Pink);
            if (ht8KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht8KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht8Brush, 86 + leptek, ertek - 2, 7, 7);
                ht8KoKemh.Add(new Koordinata() { ht8KX = 86 + leptek, ht8KY = ertek });
            }
        }

        //HT8 kémhatás vonal kirajzolása
        private void grafVonalHT8KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht8Brush = new SolidBrush(Color.Pink);
            Pen ht8Pen = new Pen(ht8Brush, 2);
            if (ht8KoKemh.Count != 0)
            {
                for (int i = 0; i < ht8KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht8Pen, (ht8KoKemh[i].ht8KX) + 3, (ht8KoKemh[i].ht8KY) + 1, (ht8KoKemh[i + 1].ht8KX) + 3, (ht8KoKemh[i + 1].ht8KY) + 1);
                }
            }
        }

        //HT9 vezetőképesség adatpontok kirajzolása
        private void grafHT9VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht9Brush = new SolidBrush(Color.DarkRed);
            if (ht9VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht9VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht9Brush, 86 + leptek, ertek - 2, 7, 7);
                ht9KoVezk.Add(new Koordinata() { ht9VX = 86 + leptek, ht9VY = ertek });
            }
        }

        //HT9 vezetőképesség vonal kirajzolása
        private void grafVonalHT9VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht9Brush = new SolidBrush(Color.DarkRed);
            Pen ht9Pen = new Pen(ht9Brush, 2);
            if (ht9KoVezk.Count != 0)
            {
                for (int i = 0; i < ht9KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht9Pen, (ht9KoVezk[i].ht9VX) + 3, (ht9KoVezk[i].ht9VY) + 1, (ht9KoVezk[i + 1].ht9VX) + 3, (ht9KoVezk[i + 1].ht9VY) + 1);
                }
            }
        }

        //HT9 kémhatás adatpontok kirajzolása
        private void grafHT9KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht9Brush = new SolidBrush(Color.DarkRed);
            if (ht9KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht9KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht9Brush, 86 + leptek, ertek - 2, 7, 7);
                ht9KoKemh.Add(new Koordinata() { ht9KX = 86 + leptek, ht9KY = ertek });
            }
        }

        //HT9 kémhatás vonal kirajzolása
        private void grafVonalHT9KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht9Brush = new SolidBrush(Color.DarkRed);
            Pen ht9Pen = new Pen(ht9Brush, 2);
            if (ht9KoKemh.Count != 0)
            {
                for (int i = 0; i < ht9KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht9Pen, (ht9KoKemh[i].ht9KX) + 3, (ht9KoKemh[i].ht9KY) + 1, (ht9KoKemh[i + 1].ht9KX) + 3, (ht9KoKemh[i + 1].ht9KY) + 1);
                }
            }
        }

        //HT10 vezetőképesség adatpontok kirajzolása
        private void grafHT10VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht10Brush = new SolidBrush(Color.Yellow);
            if (ht10VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht10VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht10Brush, 86 + leptek, ertek - 2, 7, 7);
                ht10KoVezk.Add(new Koordinata() { ht10VX = 86 + leptek, ht10VY = ertek });
            }
        }

        //HT10 vezetőképesség vonal kirajzolása
        private void grafVonalHT10VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht10Brush = new SolidBrush(Color.Yellow);
            Pen ht10Pen = new Pen(ht10Brush, 2);
            if (ht10KoVezk.Count != 0)
            {
                for (int i = 0; i < ht10KoVezk.Count - 1; i++)
                {
                    g.DrawLine(ht10Pen, (ht10KoVezk[i].ht10VX) + 3, (ht10KoVezk[i].ht10VY) + 1, (ht10KoVezk[i + 1].ht10VX) + 3, (ht10KoVezk[i + 1].ht10VY) + 1);
                }
            }
        }

        //HT10 kémhatás adatpontok kirajzolása
        private void grafHT10KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht10Brush = new SolidBrush(Color.Yellow);
            if (ht10KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((ht10KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(ht10Brush, 86 + leptek, ertek - 2, 7, 7);
                ht10KoKemh.Add(new Koordinata() { ht10KX = 86 + leptek, ht10KY = ertek });
            }
        }

        //HT10 kémhatás vonal kirajzolása
        private void grafVonalHT10KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush ht10Brush = new SolidBrush(Color.Yellow);
            Pen ht10Pen = new Pen(ht10Brush, 2);
            if (ht10KoKemh.Count != 0)
            {
                for (int i = 0; i < ht10KoKemh.Count - 1; i++)
                {
                    g.DrawLine(ht10Pen, (ht10KoKemh[i].ht10KX) + 3, (ht10KoKemh[i].ht10KY) + 1, (ht10KoKemh[i + 1].ht10KX) + 3, (ht10KoKemh[i + 1].ht10KY) + 1);
                }
            }
        }

        //Pótvíz vezetőképesség adatpontok kirajzolása
        private void grafPotvizVK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush potvizBrush = new SolidBrush(Color.Violet);
            if (potvizVKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((potvizVKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(potvizBrush, 86 + leptek, ertek - 2, 7, 7);
                potvizKoVezk.Add(new Koordinata() { potvizVX = 86 + leptek, potvizVY = ertek });
            }
        }

        //Pótvíz vezetőképesség vonal kirajzolása
        private void grafVonalPotvizVK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush potvizBrush = new SolidBrush(Color.Violet);
            Pen potvizPen = new Pen(potvizBrush, 2);
            if (potvizKoVezk.Count != 0)
            {
                for (int i = 0; i < potvizKoVezk.Count - 1; i++)
                {
                    g.DrawLine(potvizPen, (potvizKoVezk[i].potvizVX) + 3, (potvizKoVezk[i].potvizVY) + 1, (potvizKoVezk[i + 1].potvizVX) + 3, (potvizKoVezk[i + 1].potvizVY) + 1);
                }
            }
        }

        //Pótvíz kémhatás adatpontok kirajzolása
        private void grafPotvizKH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush potvizBrush = new SolidBrush(Color.Violet);
            if (potvizKHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((potvizKHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(potvizBrush, 86 + leptek, ertek - 2, 7, 7);
                potvizKoKemh.Add(new Koordinata() { potvizKX = 86 + leptek, potvizKY = ertek });
            }
        }

        //Pótvíz kémhatás vonal kirajzolása
        private void grafVonalPotvizKH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush potvizBrush = new SolidBrush(Color.Violet);
            Pen potvizPen = new Pen(potvizBrush, 2);
            if (potvizKoKemh.Count != 0)
            {
                for (int i = 0; i < potvizKoKemh.Count - 1; i++)
                {
                    g.DrawLine(potvizPen, (potvizKoKemh[i].potvizKX) + 3, (potvizKoKemh[i].potvizKY) + 1, (potvizKoKemh[i + 1].potvizKX) + 3, (potvizKoKemh[i + 1].potvizKY) + 1);
                }
            }
        }

        //Hűtési vezetőképesség adatpontok kirajzolása
        private void grafHutesiVK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush hutesiBrush = new SolidBrush(Color.Brown);
            if (hutesiVKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((hutesiVKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(hutesiBrush, 86 + leptek, ertek - 2, 7, 7);
                hutesiKoVezk.Add(new Koordinata() { hutesiVX = 86 + leptek, hutesiVY = ertek });
            }
        }

        //Hűtési vezetőképesség vonal kirajzolása
        private void grafVonalHutesiVK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush hutesiBrush = new SolidBrush(Color.Brown);
            Pen hutesiPen = new Pen(hutesiBrush, 2);
            if (hutesiKoVezk.Count != 0)
            {
                for (int i = 0; i < hutesiKoVezk.Count - 1; i++)
                {
                    g.DrawLine(hutesiPen, (hutesiKoVezk[i].hutesiVX) + 3, (hutesiKoVezk[i].hutesiVY) + 1, (hutesiKoVezk[i + 1].hutesiVX) + 3, (hutesiKoVezk[i + 1].hutesiVY) + 1);
                }
            }
        }

        //Hűtési kémhatás adatpontok kirajzolása
        private void grafHutesiKH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush hutesiBrush = new SolidBrush(Color.Brown);
            if (hutesiKHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((hutesiKHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(hutesiBrush, 86 + leptek, ertek - 2, 7, 7);
                hutesiKoKemh.Add(new Koordinata() { hutesiKX = 86 + leptek, hutesiKY = ertek });
            }
        }

        //Hűtési kémhatás vonal kirajzolása
        private void grafVonalHutesiKH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush hutesiBrush = new SolidBrush(Color.Brown);
            Pen hutesiPen = new Pen(hutesiBrush, 2);
            if (hutesiKoKemh.Count != 0)
            {
                for (int i = 0; i < hutesiKoKemh.Count - 1; i++)
                {
                    g.DrawLine(hutesiPen, (hutesiKoKemh[i].hutesiKX) + 3, (hutesiKoKemh[i].hutesiKY) + 1, (hutesiKoKemh[i + 1].hutesiKX) + 3, (hutesiKoKemh[i + 1].hutesiKY) + 1);
                }
            }
        }

        //Kondenz vezetőképesség adatpontok kirajzolása
        private void grafKondenzVK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush kondenzBrush = new SolidBrush(Color.BurlyWood);
            if (kondenzVKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((kondenzVKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(kondenzBrush, 86 + leptek, ertek - 2, 7, 7);
                kondenzKoVezk.Add(new Koordinata() { kondenzVX = 86 + leptek, kondenzVY = ertek });
            }
        }

        //Kondenz vezetőképesség vonal kirajzolása
        private void grafVonalKondenzVK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush kondenzBrush = new SolidBrush(Color.BurlyWood);
            Pen kondenzPen = new Pen(kondenzBrush, 2);
            if (kondenzKoVezk.Count != 0)
            {
                for (int i = 0; i < kondenzKoVezk.Count - 1; i++)
                {
                    g.DrawLine(kondenzPen, (kondenzKoVezk[i].kondenzVX) + 3, (kondenzKoVezk[i].kondenzVY) + 1, (kondenzKoVezk[i + 1].kondenzVX) + 3, (kondenzKoVezk[i + 1].kondenzVY) + 1);
                }
            }
        }

        //Kondenz kémhatás adatpontok kirajzolása
        private void grafKondenzKH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush kondenzBrush = new SolidBrush(Color.BurlyWood);
            if (kondenzKHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((kondenzKHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(kondenzBrush, 86 + leptek, ertek - 2, 7, 7);
                kondenzKoKemh.Add(new Koordinata() { kondenzKX = 86 + leptek, kondenzKY = ertek });
            }
        }

        //Kondenz kémhatás vonal kirajzolása
        private void grafVonalKondenzKH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush kondenzBrush = new SolidBrush(Color.BurlyWood);
            Pen kondenzPen = new Pen(kondenzBrush, 2);
            if (kondenzKoKemh.Count != 0)
            {
                for (int i = 0; i < kondenzKoKemh.Count - 1; i++)
                {
                    g.DrawLine(kondenzPen, (kondenzKoKemh[i].kondenzKX) + 3, (kondenzKoKemh[i].kondenzKY) + 1, (kondenzKoKemh[i + 1].kondenzKX) + 3, (kondenzKoKemh[i + 1].kondenzKY) + 1);
                }
            }
        }

        //Nyers víz vezetőképesség adatpontok kirajzolása
        private void grafNyersvizVK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush nyersvizBrush = new SolidBrush(Color.DeepSkyBlue);
            if (nyersvizVKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((nyersvizVKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(nyersvizBrush, 86 + leptek, ertek - 2, 7, 7);
                nyersvizKoVezk.Add(new Koordinata() { nyersvizVX = 86 + leptek, nyersvizVY = ertek });
            }
        }

        //Nyers víz vezetőképesség vonal kirajzolása
        private void grafVonalNyersvizVK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush nyersvizBrush = new SolidBrush(Color.DeepSkyBlue);
            Pen nyersvizPen = new Pen(nyersvizBrush, 2);
            if (nyersvizKoVezk.Count != 0)
            {
                for (int i = 0; i < nyersvizKoVezk.Count - 1; i++)
                {
                    g.DrawLine(nyersvizPen, (nyersvizKoVezk[i].nyersvizVX) + 3, (nyersvizKoVezk[i].nyersvizVY) + 1, (nyersvizKoVezk[i + 1].nyersvizVX) + 3, (nyersvizKoVezk[i + 1].nyersvizVY) + 1);
                }
            }
        }

        //Nyers víz kémhatás adatpontok kirajzolása
        private void grafNyersvizKH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush nyersvizBrush = new SolidBrush(Color.DeepSkyBlue);
            if (nyersvizKHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((nyersvizKHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(nyersvizBrush, 86 + leptek, ertek - 2, 7, 7);
                nyersvizKoKemh.Add(new Koordinata() { nyersvizKX = 86 + leptek, nyersvizKY = ertek });
            }
        }

        //Nyers víz kémhatás vonal kirajzolása
        private void grafVonalNyersvizKH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush nyersvizBrush = new SolidBrush(Color.DeepSkyBlue);
            Pen nyersvizPen = new Pen(nyersvizBrush, 2);
            if (nyersvizKoKemh.Count != 0)
            {
                for (int i = 0; i < nyersvizKoKemh.Count - 1; i++)
                {
                    g.DrawLine(nyersvizPen, (nyersvizKoKemh[i].nyersvizKX) + 3, (nyersvizKoKemh[i].nyersvizKY) + 1, (nyersvizKoKemh[i + 1].nyersvizKX) + 3, (nyersvizKoKemh[i + 1].nyersvizKY) + 1);
                }
            }
        }

        //Duo10 vezetőképesség adatpontok kirajzolása
        private void grafDuo10VK(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush duo10Brush = new SolidBrush(Color.DarkCyan);
            if (duo10VKLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((duo10VKLista[index].vezetokepesseg1 * 0.150), 0, MidpointRounding.ToEven));
                g.FillEllipse(duo10Brush, 86 + leptek, ertek - 2, 7, 7);
                duo10KoVezk.Add(new Koordinata() { duo10VX = 86 + leptek, duo10VY = ertek });
            }
        }

        //Duo10 vezetőképesség vonal kirajzolása
        private void grafVonalDuo10VK(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush duo10Brush = new SolidBrush(Color.DarkCyan);
            Pen duo10Pen = new Pen(duo10Brush, 2);
            if (duo10KoVezk.Count != 0)
            {
                for (int i = 0; i < duo10KoVezk.Count - 1; i++)
                {
                    g.DrawLine(duo10Pen, (duo10KoVezk[i].duo10VX) + 3, (duo10KoVezk[i].duo10VY) + 1, (duo10KoVezk[i + 1].duo10VX) + 3, (duo10KoVezk[i + 1].duo10VY) + 1);
                }
            }
        }

        //Duo10 kémhatás adatpontok kirajzolása
        private void grafDuo10KH(Graphics g, int leptek, int index)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush duo10Brush = new SolidBrush(Color.DarkCyan);
            if (duo10KHLista.Count != 0)
            {
                int ertek = 450 - Convert.ToInt32(Math.Round((duo10KHLista[index].kemhatas * 30), 0, MidpointRounding.ToEven));
                g.FillEllipse(duo10Brush, 86 + leptek, ertek - 2, 7, 7);
                duo10KoKemh.Add(new Koordinata() { duo10KX = 86 + leptek, duo10KY = ertek });
            }
        }

        //Duo10 víz kémhatás vonal kirajzolása
        private void grafVonalDuo10KH(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush duo10Brush = new SolidBrush(Color.DarkCyan);
            Pen duo10Pen = new Pen(duo10Brush, 2);
            if (duo10KoKemh.Count != 0)
            {
                for (int i = 0; i < duo10KoKemh.Count - 1; i++)
                {
                    g.DrawLine(duo10Pen, (duo10KoKemh[i].duo10KX) + 3, (duo10KoKemh[i].duo10KY) + 1, (duo10KoKemh[i + 1].duo10KX) + 3, (duo10KoKemh[i + 1].duo10KY) + 1);
                }
            }
        }
    }
}
