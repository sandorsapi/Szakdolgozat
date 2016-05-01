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
    public partial class FormHT3 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT3(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT3Vezk.Visible = true;
            dataGridViewKivHT3KH.Visible = false;
            vezetokepessegGrid();
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT3KH.ColumnCount = 7;
            dataGridViewKivHT3KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT3KH.Columns[0].Width = 50;
            dataGridViewKivHT3KH.Columns[1].Width = 150;
            dataGridViewKivHT3KH.Columns[2].Width = 80;
            dataGridViewKivHT3KH.Columns[3].Width = 100;
            dataGridViewKivHT3KH.Columns[4].Width = 70;
            dataGridViewKivHT3KH.Columns[5].Width = 60;
            dataGridViewKivHT3KH.Columns[6].Width = 50;

            dataGridViewKivHT3KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT3KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT3KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT3KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT3KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT3KH.Columns[5].Name = "Idő";
            dataGridViewKivHT3KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT3Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT3KH.RowCount < ak.kemhHT3Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT3KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT3Vezk.ColumnCount = 7;
            dataGridViewKivHT3Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT3Vezk.Columns[0].Width = 50;
            dataGridViewKivHT3Vezk.Columns[1].Width = 150;
            dataGridViewKivHT3Vezk.Columns[2].Width = 80;
            dataGridViewKivHT3Vezk.Columns[3].Width = 100;
            dataGridViewKivHT3Vezk.Columns[4].Width = 70;
            dataGridViewKivHT3Vezk.Columns[5].Width = 60;
            dataGridViewKivHT3Vezk.Columns[6].Width = 50;

            dataGridViewKivHT3Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT3Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT3Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT3Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT3Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT3Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT3Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT3Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT3Vezk.RowCount < ak.vezkHT3Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT3Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT3Vezk.Visible = true;
                dataGridViewKivHT3KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT3KH.Visible = true;
                dataGridViewKivHT3Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
