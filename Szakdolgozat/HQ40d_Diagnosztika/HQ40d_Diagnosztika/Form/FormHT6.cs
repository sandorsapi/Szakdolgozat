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
    public partial class FormHT6 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT6(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT6Vezk.Visible = true;
            dataGridViewKivHT6KH.Visible = false;
            vezetokepessegGrid();
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT6KH.ColumnCount = 7;
            dataGridViewKivHT6KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT6KH.Columns[0].Width = 50;
            dataGridViewKivHT6KH.Columns[1].Width = 150;
            dataGridViewKivHT6KH.Columns[2].Width = 80;
            dataGridViewKivHT6KH.Columns[3].Width = 100;
            dataGridViewKivHT6KH.Columns[4].Width = 70;
            dataGridViewKivHT6KH.Columns[5].Width = 60;
            dataGridViewKivHT6KH.Columns[6].Width = 50;

            dataGridViewKivHT6KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT6KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT6KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT6KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT6KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT6KH.Columns[5].Name = "Idő";
            dataGridViewKivHT6KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT6Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT6KH.RowCount < ak.kemhHT6Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT6KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT6Vezk.ColumnCount = 7;
            dataGridViewKivHT6Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT6Vezk.Columns[0].Width = 50;
            dataGridViewKivHT6Vezk.Columns[1].Width = 150;
            dataGridViewKivHT6Vezk.Columns[2].Width = 80;
            dataGridViewKivHT6Vezk.Columns[3].Width = 100;
            dataGridViewKivHT6Vezk.Columns[4].Width = 70;
            dataGridViewKivHT6Vezk.Columns[5].Width = 60;
            dataGridViewKivHT6Vezk.Columns[6].Width = 50;

            dataGridViewKivHT6Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT6Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT6Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT6Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT6Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT6Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT6Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT6Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT6Vezk.RowCount < ak.vezkHT6Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT6Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT6Vezk.Visible = true;
                dataGridViewKivHT6KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT6KH.Visible = true;
                dataGridViewKivHT6Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
