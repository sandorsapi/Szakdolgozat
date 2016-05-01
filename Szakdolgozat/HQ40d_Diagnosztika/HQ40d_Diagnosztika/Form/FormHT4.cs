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
    public partial class FormHT4 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT4(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT4Vezk.Visible = true;
            dataGridViewKivHT4KH.Visible = false;
            vezetokepessegGrid(); 
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT4KH.ColumnCount = 7;
            dataGridViewKivHT4KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT4KH.Columns[0].Width = 50;
            dataGridViewKivHT4KH.Columns[1].Width = 150;
            dataGridViewKivHT4KH.Columns[2].Width = 80;
            dataGridViewKivHT4KH.Columns[3].Width = 100;
            dataGridViewKivHT4KH.Columns[4].Width = 70;
            dataGridViewKivHT4KH.Columns[5].Width = 60;
            dataGridViewKivHT4KH.Columns[6].Width = 50;

            dataGridViewKivHT4KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT4KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT4KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT4KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT4KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT4KH.Columns[5].Name = "Idő";
            dataGridViewKivHT4KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT4Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT4KH.RowCount < ak.kemhHT4Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT4KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT4Vezk.ColumnCount = 7;
            dataGridViewKivHT4Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT4Vezk.Columns[0].Width = 50;
            dataGridViewKivHT4Vezk.Columns[1].Width = 150;
            dataGridViewKivHT4Vezk.Columns[2].Width = 80;
            dataGridViewKivHT4Vezk.Columns[3].Width = 100;
            dataGridViewKivHT4Vezk.Columns[4].Width = 70;
            dataGridViewKivHT4Vezk.Columns[5].Width = 60;
            dataGridViewKivHT4Vezk.Columns[6].Width = 50;

            dataGridViewKivHT4Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT4Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT4Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT4Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT4Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT4Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT4Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT4Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT4Vezk.RowCount < ak.vezkHT4Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT4Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT4Vezk.Visible = true;
                dataGridViewKivHT4KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT4KH.Visible = true;
                dataGridViewKivHT4Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
