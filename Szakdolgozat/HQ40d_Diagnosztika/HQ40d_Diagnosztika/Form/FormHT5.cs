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
    public partial class FormHT5 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT5(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT5Vezk.Visible = true;
            dataGridViewKivHT5KH.Visible = false;
            vezetokepessegGrid(); 
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT5KH.ColumnCount = 7;
            dataGridViewKivHT5KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT5KH.Columns[0].Width = 50;
            dataGridViewKivHT5KH.Columns[1].Width = 150;
            dataGridViewKivHT5KH.Columns[2].Width = 80;
            dataGridViewKivHT5KH.Columns[3].Width = 100;
            dataGridViewKivHT5KH.Columns[4].Width = 70;
            dataGridViewKivHT5KH.Columns[5].Width = 60;
            dataGridViewKivHT5KH.Columns[6].Width = 50;

            dataGridViewKivHT5KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT5KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT5KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT5KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT5KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT5KH.Columns[5].Name = "Idő";
            dataGridViewKivHT5KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT5Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT5KH.RowCount < ak.kemhHT5Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT5KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT5Vezk.ColumnCount = 7;
            dataGridViewKivHT5Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT5Vezk.Columns[0].Width = 50;
            dataGridViewKivHT5Vezk.Columns[1].Width = 150;
            dataGridViewKivHT5Vezk.Columns[2].Width = 80;
            dataGridViewKivHT5Vezk.Columns[3].Width = 100;
            dataGridViewKivHT5Vezk.Columns[4].Width = 70;
            dataGridViewKivHT5Vezk.Columns[5].Width = 60;
            dataGridViewKivHT5Vezk.Columns[6].Width = 50;

            dataGridViewKivHT5Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT5Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT5Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT5Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT5Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT5Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT5Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT5Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT5Vezk.RowCount < ak.vezkHT5Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT5Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT5Vezk.Visible = true;
                dataGridViewKivHT5KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT5KH.Visible = true;
                dataGridViewKivHT5Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
