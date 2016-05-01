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
    public partial class FormHT8 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHT8(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHT8Vezk.Visible = true;
            dataGridViewKivHT8KH.Visible = false;
            vezetokepessegGrid();    
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHT8KH.ColumnCount = 7;
            dataGridViewKivHT8KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT8KH.Columns[0].Width = 50;
            dataGridViewKivHT8KH.Columns[1].Width = 150;
            dataGridViewKivHT8KH.Columns[2].Width = 80;
            dataGridViewKivHT8KH.Columns[3].Width = 100;
            dataGridViewKivHT8KH.Columns[4].Width = 70;
            dataGridViewKivHT8KH.Columns[5].Width = 60;
            dataGridViewKivHT8KH.Columns[6].Width = 50;

            dataGridViewKivHT8KH.Columns[0].Name = "Sorszám";
            dataGridViewKivHT8KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHT8KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT8KH.Columns[3].Name = "Berendezés";
            dataGridViewKivHT8KH.Columns[4].Name = "Dátum";
            dataGridViewKivHT8KH.Columns[5].Name = "Idő";
            dataGridViewKivHT8KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHT8Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT8KH.RowCount < ak.kemhHT8Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT8KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHT8Vezk.ColumnCount = 7;
            dataGridViewKivHT8Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHT8Vezk.Columns[0].Width = 50;
            dataGridViewKivHT8Vezk.Columns[1].Width = 150;
            dataGridViewKivHT8Vezk.Columns[2].Width = 80;
            dataGridViewKivHT8Vezk.Columns[3].Width = 100;
            dataGridViewKivHT8Vezk.Columns[4].Width = 70;
            dataGridViewKivHT8Vezk.Columns[5].Width = 60;
            dataGridViewKivHT8Vezk.Columns[6].Width = 50;

            dataGridViewKivHT8Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHT8Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHT8Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHT8Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHT8Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivHT8Vezk.Columns[5].Name = "Idő";
            dataGridViewKivHT8Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHT8Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivHT8Vezk.RowCount < ak.vezkHT8Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHT8Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHT8Vezk.Visible = true;
                dataGridViewKivHT8KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHT8KH.Visible = true;
                dataGridViewKivHT8Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
