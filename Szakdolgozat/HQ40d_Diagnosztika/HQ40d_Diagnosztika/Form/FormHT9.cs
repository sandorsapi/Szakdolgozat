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
    public partial class FormHT9 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT9(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT9Vezk.Visible = true;
            dataGridViewKivHT9KH.Visible = false;
            vezetokepessegGrid();    
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT9KH.ColumnCount = 7;
            dataGridViewKivHT9KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT9KH.Columns[0].Width = 50;
            dataGridViewKivHT9KH.Columns[1].Width = 150;
            dataGridViewKivHT9KH.Columns[2].Width = 80;
            dataGridViewKivHT9KH.Columns[3].Width = 100;
            dataGridViewKivHT9KH.Columns[4].Width = 70;
            dataGridViewKivHT9KH.Columns[5].Width = 60;
            dataGridViewKivHT9KH.Columns[6].Width = 50;

            dataGridViewKivHT9KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT9KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT9KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT9KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT9KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT9KH.Columns[5].Name = "Idő";
            dataGridViewKivHT9KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT9Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT9KH.RowCount < ak.kemhHT9Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT9KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT9Vezk.ColumnCount = 7;
            dataGridViewKivHT9Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT9Vezk.Columns[0].Width = 50;
            dataGridViewKivHT9Vezk.Columns[1].Width = 150;
            dataGridViewKivHT9Vezk.Columns[2].Width = 80;
            dataGridViewKivHT9Vezk.Columns[3].Width = 100;
            dataGridViewKivHT9Vezk.Columns[4].Width = 70;
            dataGridViewKivHT9Vezk.Columns[5].Width = 60;
            dataGridViewKivHT9Vezk.Columns[6].Width = 50;

            dataGridViewKivHT9Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT9Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT9Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT9Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT9Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT9Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT9Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT9Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT9Vezk.RowCount < ak.vezkHT9Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT9Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT9Vezk.Visible = true;
                dataGridViewKivHT9KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT9KH.Visible = true;
                dataGridViewKivHT9Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
