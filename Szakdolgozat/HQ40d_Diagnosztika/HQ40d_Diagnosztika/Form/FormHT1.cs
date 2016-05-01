using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HQ40d_Diagnosztika
{
    public partial class FormHT1 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT1(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();           
            dataGridViewKivHT1Vezk.Visible = true;
            dataGridViewKivHT1KH.Visible = false;
            vezetokepessegGrid();            
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT1KH.ColumnCount = 7;
            dataGridViewKivHT1KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT1KH.Columns[0].Width = 50;
            dataGridViewKivHT1KH.Columns[1].Width = 150;
            dataGridViewKivHT1KH.Columns[2].Width = 80;
            dataGridViewKivHT1KH.Columns[3].Width = 100;
            dataGridViewKivHT1KH.Columns[4].Width = 70;
            dataGridViewKivHT1KH.Columns[5].Width = 60;
            dataGridViewKivHT1KH.Columns[6].Width = 50;

            dataGridViewKivHT1KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT1KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT1KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT1KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT1KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT1KH.Columns[5].Name = "Idő";
            dataGridViewKivHT1KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT1Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT1KH.RowCount < ak.kemhHT1Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT1KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
                    }            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adathiba! \n" + ex.Message, "SQL hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void vezetokepessegGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT1Vezk.ColumnCount = 7;
            dataGridViewKivHT1Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT1Vezk.Columns[0].Width = 50;
            dataGridViewKivHT1Vezk.Columns[1].Width = 150;
            dataGridViewKivHT1Vezk.Columns[2].Width = 80;
            dataGridViewKivHT1Vezk.Columns[3].Width = 100;
            dataGridViewKivHT1Vezk.Columns[4].Width = 70;
            dataGridViewKivHT1Vezk.Columns[5].Width = 60;
            dataGridViewKivHT1Vezk.Columns[6].Width = 50;

            dataGridViewKivHT1Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT1Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT1Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT1Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT1Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT1Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT1Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT1Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT1Vezk.RowCount < ak.vezkHT1Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT1Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adathiba! \n" + ex.Message, "SQL hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnVezetokepesseg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnVezetokepesseg.Checked == true)
            {
                dataGridViewKivHT1Vezk.Visible = true;
                dataGridViewKivHT1KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT1KH.Visible = true;
                dataGridViewKivHT1Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
