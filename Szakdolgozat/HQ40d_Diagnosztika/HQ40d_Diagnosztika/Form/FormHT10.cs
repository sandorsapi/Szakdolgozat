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
    public partial class FormHT10 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT10(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT10Vezk.Visible = true;
            dataGridViewKivHT10KH.Visible = false;
            vezetokepessegGrid(); 
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT10KH.ColumnCount = 7;
            dataGridViewKivHT10KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT10KH.Columns[0].Width = 50;
            dataGridViewKivHT10KH.Columns[1].Width = 150;
            dataGridViewKivHT10KH.Columns[2].Width = 80;
            dataGridViewKivHT10KH.Columns[3].Width = 100;
            dataGridViewKivHT10KH.Columns[4].Width = 70;
            dataGridViewKivHT10KH.Columns[5].Width = 60;
            dataGridViewKivHT10KH.Columns[6].Width = 50;

            dataGridViewKivHT10KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT10KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT10KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT10KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT10KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT10KH.Columns[5].Name = "Idő";
            dataGridViewKivHT10KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT10Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT10KH.RowCount < ak.kemhHT10Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT10KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT10Vezk.ColumnCount = 7;
            dataGridViewKivHT10Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT10Vezk.Columns[0].Width = 50;
            dataGridViewKivHT10Vezk.Columns[1].Width = 150;
            dataGridViewKivHT10Vezk.Columns[2].Width = 80;
            dataGridViewKivHT10Vezk.Columns[3].Width = 100;
            dataGridViewKivHT10Vezk.Columns[4].Width = 70;
            dataGridViewKivHT10Vezk.Columns[5].Width = 60;
            dataGridViewKivHT10Vezk.Columns[6].Width = 50;

            dataGridViewKivHT10Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT10Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT10Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT10Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT10Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT10Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT10Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT10Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT10Vezk.RowCount < ak.vezkHT10Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT10Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT10Vezk.Visible = true;
                dataGridViewKivHT10KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT10KH.Visible = true;
                dataGridViewKivHT10Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
