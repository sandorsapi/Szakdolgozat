using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace HQ40d_Diagnosztika
{
    public partial class FormAlap : Form
    {
        
        private BufferedGraphicsContext contextVK;
        private BufferedGraphics grafxVK;
        private BufferedGraphicsContext contextKH;
        private BufferedGraphics grafxKH;
        
        Grafika grafika = new Grafika();
        AdatKezelo ak = new AdatKezelo();
        FileKezelo fk = new FileKezelo();

        private Boolean ertekNull = false;
     
        public FormAlap()
        {           
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            InitializeComponent();
            mertekegysegVK();
            panelDiagram.Visible = true;
            grafika.panelVezk = true;               
            contextVK = BufferedGraphicsManager.Current;
            contextVK.MaximumBuffer = new Size(910, 527);
            grafxVK = contextVK.Allocate(panelDiagram.CreateGraphics(), new Rectangle(0, 0, 910, 527));            
            DrawToBufferVK(grafxVK);           
        }      

        //Pufferelt vezetőképesség grafika
        public void DrawToBufferVK(BufferedGraphics vg)
        {            
            grafika.tBPoz = trackBarPozicio.Value;            
            vg.Graphics.FillRectangle(Brushes.White, 0, 0, 908, 525);
            grafika.vkGraf(vg.Graphics);                                    
        }

        //Pufferelt kémhatás grafika
        public void DrawToBufferKH(BufferedGraphics kg)
        {
            grafika.tBPoz = trackBarPozicio.Value;
            kg.Graphics.FillRectangle(Brushes.White, 0, 0, 908, 525);
            grafika.khGraf(kg.Graphics);                        
        }

       
        private void btnBezar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //File feltöltés
        private void fileBetöltésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //progressBar.Maximum = fk.pHossz;
            //progressBar.Step = 1;
            //progressBar.Minimum = 0;
                     
            Thread szal = new Thread(fk.feldolgozo);
            string fileN = null;           
            OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Filter = "*.csv|";
            oDialog.InitialDirectory = "C:\\";
            if (oDialog.ShowDialog() == DialogResult.OK)
            {               
                string[] fileTomb = oDialog.FileName.Split('.');
                if (fileTomb[1] == "csv")
                {
                    try
                    {
                        fk.fileNev = oDialog.FileName;
                        string[] tomb = oDialog.FileName.Split('\\');
                        fileN = tomb[tomb.Length - 1];
                        if (!ak.fajlEllenor(fileN))
                        {                           
                            szal.Start();
                            backgroundWorker1.RunWorkerAsync();                      
                            ak.fajlTarolas(fileN);
                        }
                        else
                        {
                            MessageBox.Show("A fájl feldolgozva - válassz másikat!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba a fájl feldolgozásában \n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nem megfelelő a fájl kiterjesztése!", "File hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chbHt1_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT1 = chbHt1.Checked;
            ujrarajzol();
            if (chbHt1.Checked == true)
            {
                panelHT1.BackColor = Color.Magenta;
                ujrarajzol();
            }
            else
            {
                panelHT1.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt2_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT2 = chbHt2.Checked;
            ujrarajzol();
            if (chbHt2.Checked == true)
            {
                panelHT2.BackColor = Color.DarkGreen;
                ujrarajzol();
            }
            else
            {
                panelHT2.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt3_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT3 = chbHt3.Checked;
            ujrarajzol();
            if (chbHt3.Checked == true)
            {
                panelHT3.BackColor = Color.DarkBlue;
                ujrarajzol();
            }
            else
            {
                panelHT3.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt4_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT4 = chbHt4.Checked;
            ujrarajzol();
            if (chbHt4.Checked == true)
            {
                panelHT4.BackColor = Color.MediumBlue;
                ujrarajzol();
            }
            else
            {
                panelHT4.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt5_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT5 = chbHt5.Checked;
            ujrarajzol();
            if (chbHt5.Checked == true)
            {
                panelHT5.BackColor = Color.MediumTurquoise;
                ujrarajzol();
            }
            else
            {
                panelHT5.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt6_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT6 = chbHt6.Checked;
            ujrarajzol();
            if (chbHt6.Checked == true)
            {
                panelHT6.BackColor = Color.Orange;
                ujrarajzol();
            }
            else
            {
                panelHT6.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt7_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT7 = chbHt7.Checked;
            ujrarajzol();
            if (chbHt7.Checked == true)
            {
                panelHT7.BackColor = Color.PaleGoldenrod;
                ujrarajzol();
            }
            else
            {
                panelHT7.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt8_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT8 = chbHt8.Checked;
            ujrarajzol();
            if (chbHt8.Checked == true)
            {
                panelHT8.BackColor = Color.Pink;
                ujrarajzol();
            }
            else
            {
                panelHT8.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt9_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT9 = chbHt9.Checked;
            ujrarajzol();
            if (chbHt9.Checked == true)
            {
                panelHT9.BackColor = Color.DarkRed;
                ujrarajzol();
            }
            else
            {
                panelHT9.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHt10_CheckedChanged(object sender, EventArgs e)
        {
            grafika.HT10 = chbHt10.Checked;
            ujrarajzol();
            if (chbHt10.Checked == true)
            {
                panelHT10.BackColor = Color.Yellow;
                ujrarajzol();
            }
            else
            {
                panelHT10.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbPotviz_CheckedChanged(object sender, EventArgs e)
        {
            grafika.Potviz = chbPotviz.Checked;
            ujrarajzol();
            if (chbPotviz.Checked == true)
            {
                panelPotviz.BackColor = Color.Violet;
                ujrarajzol();
            }
            else
            {
                panelPotviz.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbHutesi_CheckedChanged(object sender, EventArgs e)
        {
            grafika.Hutesi = chbHutesi.Checked;
            ujrarajzol();
            if (chbHutesi.Checked == true)
            {
                panelHutesi.BackColor = Color.Brown;
                ujrarajzol();
            }
            else
            {
                panelHutesi.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbKondenz_CheckedChanged(object sender, EventArgs e)
        {
            grafika.Kondenz = chbKondenz.Checked;
            ujrarajzol();
            if (chbKondenz.Checked == true)
            {
                panelKondenz.BackColor = Color.BurlyWood;
                ujrarajzol();
            }
            else
            {
                panelKondenz.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbNyersviz_CheckedChanged(object sender, EventArgs e)
        {
            grafika.Nyersviz = chbNyersviz.Checked;
            ujrarajzol();
            if (chbNyersviz.Checked == true)
            {
                panelNyersviz.BackColor = Color.DeepSkyBlue;
                ujrarajzol();
            }
            else
            {
                panelNyersviz.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void chbDuo10_CheckedChanged(object sender, EventArgs e)
        {
            grafika.Duo10 = chbDuo10.Checked;
            ujrarajzol();
            if (chbDuo10.Checked == true)
            {
                panelDuo10.BackColor = Color.DarkCyan;
                ujrarajzol();
            }
            else
            {
                panelDuo10.BackColor = Color.Gray;
                ujrarajzol();
            }
        }

        private void btnSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSelectAll.Checked == true)
            {
                chbHt1.Checked = true;
                chbHt2.Checked = true;
                chbHt3.Checked = true;
                chbHt4.Checked = true;
                chbHt5.Checked = true;
                chbHt6.Checked = true;
                chbHt7.Checked = true;
                chbHt8.Checked = true;
                chbHt9.Checked = true;
                chbHt10.Checked = true;
                chbPotviz.Checked = true;
                chbHutesi.Checked = true;
                chbKondenz.Checked = true;
                chbNyersviz.Checked = true;
                chbDuo10.Checked = true;
            }
            else
            {
                chbHt1.Checked = false;
                chbHt2.Checked = false;
                chbHt3.Checked = false;
                chbHt4.Checked = false;
                chbHt5.Checked = false;
                chbHt6.Checked = false;
                chbHt7.Checked = false;
                chbHt8.Checked = false;
                chbHt9.Checked = false;
                chbHt10.Checked = false;
                chbPotviz.Checked = false;
                chbHutesi.Checked = false;
                chbKondenz.Checked = false;
                chbNyersviz.Checked = false;
                chbDuo10.Checked = false;
            }
        }

        private void btnKivalaszt_Click(object sender, EventArgs e)
        {
            koordinatakTorlese();
            listakFeltoltese();
            string kivDatumok = string.Format("Kiválasztott intervallum: {0} - tól, {1} - ig", dTPTol.Value.ToString("d"), dTPIg.Value.ToString("d"));
            MessageBox.Show(kivDatumok, "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (rbtnVezetokepesseg.Checked)
            {
                panelDiagram.Refresh();
                grafxVK.Render(Graphics.FromHwnd(panelDiagram.Handle));
                DrawToBufferVK(grafxVK);
            }
            if (rbtnKemhatas.Checked)
            {
                panelKemhatas.Refresh();
                grafxKH.Render(Graphics.FromHwnd(panelKemhatas.Handle));
                DrawToBufferKH(grafxKH);
            }     
            btnKivalaszt.Enabled = false;
            kiválasztottAdatokToolStripMenuItem.Enabled = true;
        }

        private void koordinatakTorlese()
        {
            grafika.HT1KOVKLista.Clear();
            grafika.HT1KOKHLista.Clear();
            grafika.HT2KOVKLista.Clear();
            grafika.HT2KOKHLista.Clear();
            grafika.HT3KOVKLista.Clear();
            grafika.HT3KOKHLista.Clear();
            grafika.HT4KOVKLista.Clear();
            grafika.HT4KOKHLista.Clear();
            grafika.HT5KOVKLista.Clear();
            grafika.HT5KOKHLista.Clear();
            grafika.HT6KOVKLista.Clear();
            grafika.HT6KOKHLista.Clear();
            grafika.HT7KOVKLista.Clear();
            grafika.HT7KOKHLista.Clear();
            grafika.HT8KOVKLista.Clear();
            grafika.HT8KOKHLista.Clear();
            grafika.HT9KOVKLista.Clear();
            grafika.HT9KOKHLista.Clear();
            grafika.HT10KOVKLista.Clear();
            grafika.HT10KOKHLista.Clear();
            grafika.PotvizKOVKLista.Clear();
            grafika.PotvizKOKHLista.Clear();
            grafika.HutesiKOVKLista.Clear();
            grafika.HutesiKOKHLista.Clear();
            grafika.KondenzKOVKLista.Clear();
            grafika.KondenzKOKHLista.Clear();
            grafika.NyersvizKOVKLista.Clear();
            grafika.NyersvizKOKHLista.Clear();
            grafika.Duo10KOVKLista.Clear();
            grafika.Duo10KOKHLista.Clear();
        }

        private void berendezésekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormBerendezesek Fb = new FormBerendezesek();
            Fb.Show();
        }

        private void vezetőképességToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVezetokepesseg vk = new FormVezetokepesseg();
            vk.Show();
        }

        private void dátumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDatum fd = new FormDatum();
            fd.Show();
        }

        private void mérésTípusokToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTipus Ft = new FormTipus();
            Ft.Show();
        }

        private void személyekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSzemelyek fsz = new FormSzemelyek();
            fsz.Show();
        }

        private void fájlokToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFajlok ff = new FormFajlok();
            ff.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Vezetőképesség grafikus panel esemény
        private void panelDiagram_Paint(object sender, PaintEventArgs e)
        {           
            grafxVK.Render(e.Graphics);            
            grafxVK.Render(Graphics.FromHwnd(panelDiagram.Handle));            
            DrawToBufferVK(grafxVK);            
        }
      
        //Kémhatás grafikus panel esemény
        private void panelKemhatas_Paint(object sender, PaintEventArgs e)
        {           
            grafxKH.Render(e.Graphics);
            grafxKH.Render(Graphics.FromHwnd(panelKemhatas.Handle));            
            DrawToBufferKH(grafxKH);
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {           
            trackBarPozicio.Value = 0;
            labelErtekNullazo();
            contextKH = BufferedGraphicsManager.Current;
            contextKH.MaximumBuffer = new Size(910, 527);
            grafxKH = contextKH.Allocate(panelKemhatas.CreateGraphics(), new Rectangle(0, 0, 910, 527));
            DrawToBufferKH(grafxKH);
            panelKemhatas.Visible = true;
            grafika.panelVezk = false;
            grafika.panelKemh = true;
            mertekegysegKH();
        }

        private void rbtnVezetokepesseg_CheckedChanged(object sender, EventArgs e)
        {           
            trackBarPozicio.Value = 0;
            labelErtekNullazo();
            contextVK = BufferedGraphicsManager.Current;
            contextVK.MaximumBuffer = new Size(910, 527);
            grafxVK = contextVK.Allocate(panelDiagram.CreateGraphics(), new Rectangle(0, 0, 910, 527));            
            DrawToBufferVK(grafxVK);            
            panelDiagram.Visible = true;
            panelKemhatas.Visible = false;
            grafika.panelKemh = false;
            grafika.panelVezk = true;
            mertekegysegVK();
        }

        private void mertekegysegVK()
        {
            label6.Text = "μS/cm";
            label22.Text = "μS/cm";
            label23.Text = "μS/cm";
            label24.Text = "μS/cm";
            label25.Text = "μS/cm";
            label26.Text = "μS/cm";
            label27.Text = "μS/cm";
            label28.Text = "μS/cm";
            label29.Text = "μS/cm";
            label30.Text = "μS/cm";
            label31.Text = "μS/cm";
            label32.Text = "μS/cm";
            label33.Text = "μS/cm";
            label34.Text = "μS/cm";
            label35.Text = "μS/cm";
        }

        private void mertekegysegKH()
        {
            label6.Text = "pH";
            label22.Text = "pH";
            label23.Text = "pH";
            label24.Text = "pH";
            label25.Text = "pH";
            label26.Text = "pH";
            label27.Text = "pH";
            label28.Text = "pH";
            label29.Text = "pH";
            label30.Text = "pH";
            label31.Text = "pH";
            label32.Text = "pH";
            label33.Text = "pH";
            label34.Text = "pH";
            label35.Text = "pH";
        }

        private void dTPTol_ValueChanged(object sender, EventArgs e)
        {            
            ak.datumTol = dTPTol.Value;
        }

        private void dTPIg_ValueChanged(object sender, EventArgs e)
        {
            ak.datumIg = dTPIg.Value;
            datumfeldolgozo();
        }

        //Pozíció frissítése
        private void trackBarPozicio_Scroll(object sender, EventArgs e)
        {
            labelErtekTorles();
            ujrarajzol();           
        }

        private void labelErtekTorles()
        {
            lblErtek1.Text = Grafika.ertek1;
            lblErtek2.Text = Grafika.ertek2;
            lblErtek3.Text = Grafika.ertek3;
            lblErtek4.Text = Grafika.ertek4;
            lblErtek5.Text = Grafika.ertek5;
            lblErtek6.Text = Grafika.ertek6;
            lblErtek7.Text = Grafika.ertek7;
            lblErtek8.Text = Grafika.ertek8;
            lblErtek9.Text = Grafika.ertek9;
            lblErtek10.Text = Grafika.ertek10;
            lblErtek11.Text = Grafika.ertek11;
            lblErtek12.Text = Grafika.ertek12;
            lblErtek13.Text = Grafika.ertek13;
            lblErtek14.Text = Grafika.ertek14;
            lblErtek15.Text = Grafika.ertek15;
        }

        //Görgetés jobbra
        private void btnJobb_Click(object sender, EventArgs e)
        {
            koordinatakTorlese();
            labelErtekNullazo();
            if (grafika.leptetoIndex < 1)
            {
                grafika.leptetoIndex = 0;
                if (rbtnVezetokepesseg.Checked)
                {
                    panelDiagram.Refresh();
                    grafxVK.Render(Graphics.FromHwnd(panelDiagram.Handle));
                    DrawToBufferVK(grafxVK);
                }
                if (rbtnKemhatas.Checked)
                {
                    panelKemhatas.Refresh();
                    grafxKH.Render(Graphics.FromHwnd(panelKemhatas.Handle));
                    DrawToBufferKH(grafxKH);
                }     
            }
            else
            {
                grafika.leptetoIndex--;
                if (rbtnVezetokepesseg.Checked)
                {
                    panelDiagram.Refresh();
                    grafxVK.Render(Graphics.FromHwnd(panelDiagram.Handle));
                    DrawToBufferVK(grafxVK);
                }
                if (rbtnKemhatas.Checked)
                {
                    panelKemhatas.Refresh();
                    grafxKH.Render(Graphics.FromHwnd(panelKemhatas.Handle));
                    DrawToBufferKH(grafxKH);                
                }     
            }
        }

        private void labelErtekNullazo()
        {
            lblErtek1.Text = null;
            Grafika.ertek1 = null;
            lblErtek2.Text = null;
            Grafika.ertek2 = null;
            lblErtek3.Text = null;
            Grafika.ertek3 = null;
            lblErtek4.Text = null;
            Grafika.ertek4 = null;
            lblErtek5.Text = null;
            Grafika.ertek5 = null;
            lblErtek6.Text = null;
            Grafika.ertek6 = null;
            lblErtek7.Text = null;
            Grafika.ertek7 = null;
            lblErtek8.Text = null;
            Grafika.ertek8 = null;
            lblErtek9.Text = null;
            Grafika.ertek9 = null;
            lblErtek10.Text = null;
            Grafika.ertek10 = null;
            lblErtek11.Text = null;
            Grafika.ertek11 = null;
            lblErtek12.Text = null;
            Grafika.ertek12 = null;
            lblErtek13.Text = null;
            Grafika.ertek13 = null;
            lblErtek14.Text = null;
            Grafika.ertek14 = null;
            lblErtek15.Text = null;
            Grafika.ertek15 = null;
        }
        
        //Görgetés balra
        private void btnBal_Click(object sender, EventArgs e)
        {
            koordinatakTorlese();
            labelErtekNullazo();
            if (grafika.leptetoIndex >= grafika.mCount)
            {
                grafika.leptetoIndex = grafika.mCount;
                if (rbtnVezetokepesseg.Checked)
                {
                    panelDiagram.Refresh();
                    grafxVK.Render(Graphics.FromHwnd(panelDiagram.Handle));
                    DrawToBufferVK(grafxVK);
                }
                if (rbtnKemhatas.Checked)
                {
                    panelKemhatas.Refresh();
                    grafxKH.Render(Graphics.FromHwnd(panelKemhatas.Handle));
                    DrawToBufferKH(grafxKH);
                }     
            }
            else
            {
                grafika.leptetoIndex++;
                if (rbtnVezetokepesseg.Checked)
                {
                    panelDiagram.Refresh();
                    grafxVK.Render(Graphics.FromHwnd(panelDiagram.Handle));
                    DrawToBufferVK(grafxVK);
                }
                if (rbtnKemhatas.Checked)
                {
                    panelKemhatas.Refresh();
                    grafxKH.Render(Graphics.FromHwnd(panelKemhatas.Handle));
                    DrawToBufferKH(grafxKH);
                }     
            }
        }

        public void ujrarajzol()
        {
            if (rbtnVezetokepesseg.Checked)
            {               
                grafxVK.Render(Graphics.FromHwnd(panelDiagram.Handle));
                DrawToBufferVK(grafxVK);
            }
            if (rbtnKemhatas.Checked)
            {               
                grafxKH.Render(Graphics.FromHwnd(panelKemhatas.Handle));
                DrawToBufferKH(grafxKH);
            }     
        }

        private void hűtőtorony1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT1 fh1 = new FormHT1(dTPTol.Value, dTPIg.Value);
            fh1.Show();
        }

        private void hűtőtorony2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT2 fh2 = new FormHT2(dTPTol.Value, dTPIg.Value);
            fh2.Show();
        }

        private void hűtőtorony3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT3 fh3 = new FormHT3(dTPTol.Value, dTPIg.Value);
            fh3.Show();
        }

        private void hűtőtorony4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT4 fh4 = new FormHT4(dTPTol.Value, dTPIg.Value);
            fh4.Show();
        }

        private void hűtőtorony5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT5 fh5 = new FormHT5(dTPTol.Value, dTPIg.Value);
            fh5.Show();
        }

        private void hűtőtorony6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT6 fh6 = new FormHT6(dTPTol.Value, dTPIg.Value);
            fh6.Show();
        }

        private void hűtőtorony7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT7 fh7 = new FormHT7(dTPTol.Value, dTPIg.Value);
            fh7.Show();
        }

        private void hűtőtorony8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT8 fh8 = new FormHT8(dTPTol.Value, dTPIg.Value);
            fh8.Show();
        }

        private void hűtőtorony9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT9 fh9 = new FormHT9(dTPTol.Value, dTPIg.Value);
            fh9.Show();
        }

        private void hűtőtorony10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHT10 fh10 = new FormHT10(dTPTol.Value, dTPIg.Value);
            fh10.Show();
        }

        private void pótvízToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPotviz fpv = new FormPotviz(dTPTol.Value, dTPIg.Value);
            fpv.Show();
        }

        private void hűtésiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHutesi fh = new FormHutesi(dTPTol.Value, dTPIg.Value);
            fh.Show();
        }

        private void kondenzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKondenz fk = new FormKondenz(dTPTol.Value, dTPIg.Value);
            fk.Show();
        }

        private void nyersvízToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNyersviz fnyv = new FormNyersviz(dTPTol.Value, dTPIg.Value);
            fnyv.Show();
        }
        private void duo10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDuo10 fd = new FormDuo10(dTPTol.Value, dTPIg.Value);
            fd.Show();
        }

        private void kémhatásToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKemhatas fk = new FormKemhatas();
            fk.Show();
        } 

        private  void datumfeldolgozo()
        {
            Cursor.Current = Cursors.WaitCursor;            
            if (ak.datumIg != null)
            {
                btnKivalaszt.Enabled = true;
            }
            //A dátum választás ellenőrzése
            if (dTPTol.Value > dTPIg.Value)
            {
                btnKivalaszt.Enabled = false;
                dTPIg.Value = DateTime.Now;
                MessageBox.Show("A dátum kiinduló értéke nem lehet nagyobb a dátum végértékénél!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    btnBal.Visible = false;
                    btnJobb.Visible = false;
                    listakTorlese();
                    if (ak.vezkLista(dTPTol.Value, dTPIg.Value).Count == 0 && ak.kemHkLista(dTPTol.Value, dTPIg.Value).Count == 0)
                    {
                        ertekNull = true;
                    }
                    else
                    {
                        ertekNull = false;
                    }
                    if (ertekNull)
                    {
                        btnKivalaszt.Enabled = false;
                        MessageBox.Show("A dátumokhoz nem tartozik érték!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        foreach (var v in ak.datumLista(dTPTol.Value, dTPIg.Value))
                        {
                            grafika.datLista.Add(v);
                        }                                        
                        if (grafika.datLista.Count > 25)
                        {
                            btnJobb.Visible = true;
                            btnBal.Visible = true;
                        }                        
                        btnKivalaszt.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SQL Hiba \n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Cursor.Current = Cursors.Default;
            ertekNull = false;
        }

        private void listakTorlese()
        {
            grafika.datLista.Clear();
            grafika.leptetoIndex = 0;
            grafika.mCount = 0;
            grafika.HT1VKLista.Clear();
            grafika.HT1KHLista.Clear();
            grafika.HT2VKLista.Clear();
            grafika.HT2KHLista.Clear();
            grafika.HT3VKLista.Clear();
            grafika.HT3KHLista.Clear();
            grafika.HT4VKLista.Clear();
            grafika.HT4KHLista.Clear();
            grafika.HT5VKLista.Clear();
            grafika.HT5KHLista.Clear();
            grafika.HT6VKLista.Clear();
            grafika.HT6KHLista.Clear();
            grafika.HT7VKLista.Clear();
            grafika.HT7KHLista.Clear();
            grafika.HT8VKLista.Clear();
            grafika.HT8KHLista.Clear();
            grafika.HT9VKLista.Clear();
            grafika.HT9KHLista.Clear();
            grafika.HT10VKLista.Clear();
            grafika.HT10KHLista.Clear();
            grafika.PotvizVKLista.Clear();
            grafika.PotvizKHLista.Clear();
            grafika.KondenzVKLista.Clear();
            grafika.KondenzKHLista.Clear();
            grafika.HutesiVKLista.Clear();
            grafika.HutesiKHLista.Clear();
            grafika.NyersvizVKLista.Clear();
            grafika.NyersvizKHLista.Clear();
            grafika.Duo10VKLista.Clear();
            grafika.Duo10KHLista.Clear();
        }

        private void listakFeltoltese()
        {
            Cursor.Current = Cursors.WaitCursor;           
            foreach (var d in grafika.datLista)
            {
                foreach (var ht1 in ak.ht1VKLista(d))
                {
                    grafika.HT1VKLista.Add(ht1);
                }
                foreach (var ht2 in ak.ht2VKLista(d))
                {
                    grafika.HT2VKLista.Add(ht2);
                }
                foreach (var ht3 in ak.ht3VKLista(d))
                {
                    grafika.HT3VKLista.Add(ht3);
                }
                foreach (var ht4 in ak.ht4VKLista(d))
                {
                    grafika.HT4VKLista.Add(ht4);
                }
                foreach (var ht5 in ak.ht5VKLista(d))
                {
                    grafika.HT5VKLista.Add(ht5);
                }
                foreach (var ht6 in ak.ht6VKLista(d))
                {
                    grafika.HT6VKLista.Add(ht6);
                }
                foreach (var ht7 in ak.ht7VKLista(d))
                {
                    grafika.HT7VKLista.Add(ht7);
                }
                foreach (var ht8 in ak.ht8VKLista(d))
                {
                    grafika.HT8VKLista.Add(ht8);
                }
                foreach (var ht9 in ak.ht9VKLista(d))
                {
                    grafika.HT9VKLista.Add(ht9);
                }
                foreach (var ht10 in ak.ht10VKLista(d))
                {
                    grafika.HT10VKLista.Add(ht10);
                }
                foreach (var potviz in ak.potvizVKLista(d))
                {
                    grafika.PotvizVKLista.Add(potviz);
                }
                foreach (var kondenz in ak.kondenzVKLista(d))
                {
                    grafika.KondenzVKLista.Add(kondenz);
                }
                foreach (var hutesi in ak.hutesiVKLista(d))
                {
                    grafika.HutesiVKLista.Add(hutesi);
                }
                foreach (var nyersviz in ak.nyersvizVKLista(d))
                {
                    grafika.NyersvizVKLista.Add(nyersviz);
                }
                foreach (var duo10 in ak.duo10VKLista(d))
                {
                    grafika.Duo10VKLista.Add(duo10);
                }
            }
            foreach (var d in grafika.datLista)
            {
                foreach (var ht1 in ak.ht1KHLista(d))
                {
                    grafika.HT1KHLista.Add(ht1);
                }
                foreach (var ht2 in ak.ht2KHLista(d))
                {
                    grafika.HT2KHLista.Add(ht2);
                }
                foreach (var ht3 in ak.ht3KHLista(d))
                {
                    grafika.HT3KHLista.Add(ht3);
                }
                foreach (var ht4 in ak.ht4KHLista(d))
                {
                    grafika.HT4KHLista.Add(ht4);
                }
                foreach (var ht5 in ak.ht5KHLista(d))
                {
                    grafika.HT5KHLista.Add(ht5);
                }
                foreach (var ht6 in ak.ht6KHLista(d))
                {
                    grafika.HT6KHLista.Add(ht6);
                }
                foreach (var ht7 in ak.ht7KHLista(d))
                {
                    grafika.HT7KHLista.Add(ht7);
                }
                foreach (var ht8 in ak.ht8KHLista(d))
                {
                    grafika.HT8KHLista.Add(ht8);
                }
                foreach (var ht9 in ak.ht9KHLista(d))
                {
                    grafika.HT9KHLista.Add(ht9);
                }
                foreach (var ht10 in ak.ht10KHLista(d))
                {
                    grafika.HT10KHLista.Add(ht10);
                }
                foreach (var potviz in ak.potvizKHLista(d))
                {
                    grafika.PotvizKHLista.Add(potviz);
                }
                foreach (var kondenz in ak.kondenzKHLista(d))
                {
                    grafika.KondenzKHLista.Add(kondenz);
                }
                foreach (var hutesi in ak.hutesiKHLista(d))
                {
                    grafika.HutesiKHLista.Add(hutesi);
                }
                foreach (var nyersviz in ak.nyersvizKHLista(d))
                {
                    grafika.NyersvizKHLista.Add(nyersviz);
                }
                foreach (var duo10 in ak.duo10KHLista(d))
                {
                    grafika.Duo10KHLista.Add(duo10);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void használatiÚtmutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtmutato fu = new FormUtmutato();
            fu.Show();
        }

        private void szerzoAdataiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSzerzo fsz = new FormSzerzo();
            fsz.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 1000000; j++)
            {               
                backgroundWorker.ReportProgress(j);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Value = 0;
        }
     }
}

