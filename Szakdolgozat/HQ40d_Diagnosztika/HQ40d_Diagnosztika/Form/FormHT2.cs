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
    public partial class FormHT2 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT2(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT2Vezk.Visible = true;
            dataGridViewKivHT2KH.Visible = false;
            vezetokepessegGrid();
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT2KH.ColumnCount = 7;
            dataGridViewKivHT2KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT2KH.Columns[0].Width = 50;
            dataGridViewKivHT2KH.Columns[1].Width = 150;
            dataGridViewKivHT2KH.Columns[2].Width = 80;
            dataGridViewKivHT2KH.Columns[3].Width = 100;
            dataGridViewKivHT2KH.Columns[4].Width = 70;
            dataGridViewKivHT2KH.Columns[5].Width = 60;
            dataGridViewKivHT2KH.Columns[6].Width = 50;

            dataGridViewKivHT2KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT2KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT2KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT2KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT2KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT2KH.Columns[5].Name = "Idő";
            dataGridViewKivHT2KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT2Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT2KH.RowCount < ak.kemhHT2Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT2KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT2Vezk.ColumnCount = 7;
            dataGridViewKivHT2Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT2Vezk.Columns[0].Width = 50;
            dataGridViewKivHT2Vezk.Columns[1].Width = 150;
            dataGridViewKivHT2Vezk.Columns[2].Width = 80;
            dataGridViewKivHT2Vezk.Columns[3].Width = 100;
            dataGridViewKivHT2Vezk.Columns[4].Width = 70;
            dataGridViewKivHT2Vezk.Columns[5].Width = 60;
            dataGridViewKivHT2Vezk.Columns[6].Width = 50;

            dataGridViewKivHT2Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT2Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT2Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT2Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT2Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT2Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT2Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT2Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT2Vezk.RowCount < ak.vezkHT2Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT2Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT2Vezk.Visible = true;
                dataGridViewKivHT2KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT2KH.Visible = true;
                dataGridViewKivHT2Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
