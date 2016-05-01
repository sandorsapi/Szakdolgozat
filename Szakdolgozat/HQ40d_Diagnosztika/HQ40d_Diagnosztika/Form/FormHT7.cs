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
    public partial class FormHT7 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT7(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT7Vezk.Visible = true;
            dataGridViewKivHT7KH.Visible = false;
            vezetokepessegGrid(); 
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT7KH.ColumnCount = 7;
            dataGridViewKivHT7KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT7KH.Columns[0].Width = 50;
            dataGridViewKivHT7KH.Columns[1].Width = 150;
            dataGridViewKivHT7KH.Columns[2].Width = 80;
            dataGridViewKivHT7KH.Columns[3].Width = 100;
            dataGridViewKivHT7KH.Columns[4].Width = 70;
            dataGridViewKivHT7KH.Columns[5].Width = 60;
            dataGridViewKivHT7KH.Columns[6].Width = 50;

            dataGridViewKivHT7KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT7KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT7KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT7KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT7KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT7KH.Columns[5].Name = "Idő";
            dataGridViewKivHT7KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT7Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT7KH.RowCount < ak.kemhHT7Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT7KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT7Vezk.ColumnCount = 7;
            dataGridViewKivHT7Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT7Vezk.Columns[0].Width = 50;
            dataGridViewKivHT7Vezk.Columns[1].Width = 150;
            dataGridViewKivHT7Vezk.Columns[2].Width = 80;
            dataGridViewKivHT7Vezk.Columns[3].Width = 100;
            dataGridViewKivHT7Vezk.Columns[4].Width = 70;
            dataGridViewKivHT7Vezk.Columns[5].Width = 60;
            dataGridViewKivHT7Vezk.Columns[6].Width = 50;

            dataGridViewKivHT7Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT7Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT7Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT7Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT7Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT7Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT7Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT7Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT7Vezk.RowCount < ak.vezkHT7Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT7Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT7Vezk.Visible = true;
                dataGridViewKivHT7KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT7KH.Visible = true;
                dataGridViewKivHT7Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
