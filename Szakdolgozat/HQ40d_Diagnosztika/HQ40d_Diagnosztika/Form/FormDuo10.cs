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
    public partial class FormDuo10 : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormDuo10(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivDuo10Vezk.Visible = true;
            dataGridViewKivDuo10KH.Visible = false;
            vezetokepessegGrid();     
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivDuo10KH.ColumnCount = 7;
            dataGridViewKivDuo10KH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivDuo10KH.Columns[0].Width = 50;
            dataGridViewKivDuo10KH.Columns[1].Width = 150;
            dataGridViewKivDuo10KH.Columns[2].Width = 80;
            dataGridViewKivDuo10KH.Columns[3].Width = 100;
            dataGridViewKivDuo10KH.Columns[4].Width = 70;
            dataGridViewKivDuo10KH.Columns[5].Width = 60;
            dataGridViewKivDuo10KH.Columns[6].Width = 50;

            dataGridViewKivDuo10KH.Columns[0].Name = "Sorszám";
            dataGridViewKivDuo10KH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivDuo10KH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivDuo10KH.Columns[3].Name = "Berendezés";
            dataGridViewKivDuo10KH.Columns[4].Name = "Dátum";
            dataGridViewKivDuo10KH.Columns[5].Name = "Idő";
            dataGridViewKivDuo10KH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhDuo10Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivDuo10KH.RowCount < ak.kemhDuo10Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivDuo10KH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivDuo10Vezk.ColumnCount = 7;
            dataGridViewKivDuo10Vezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivDuo10Vezk.Columns[0].Width = 50;
            dataGridViewKivDuo10Vezk.Columns[1].Width = 150;
            dataGridViewKivDuo10Vezk.Columns[2].Width = 80;
            dataGridViewKivDuo10Vezk.Columns[3].Width = 100;
            dataGridViewKivDuo10Vezk.Columns[4].Width = 70;
            dataGridViewKivDuo10Vezk.Columns[5].Width = 60;
            dataGridViewKivDuo10Vezk.Columns[6].Width = 50;

            dataGridViewKivDuo10Vezk.Columns[0].Name = "Sorszám";
            dataGridViewKivDuo10Vezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivDuo10Vezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivDuo10Vezk.Columns[3].Name = "Berendezés";
            dataGridViewKivDuo10Vezk.Columns[4].Name = "Dátum";
            dataGridViewKivDuo10Vezk.Columns[5].Name = "Idő";
            dataGridViewKivDuo10Vezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkDuo10Lista(datumTol, datumIg))
                {
                    if (dataGridViewKivDuo10Vezk.RowCount < ak.vezkDuo10Lista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivDuo10Vezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivDuo10Vezk.Visible = true;
                dataGridViewKivDuo10KH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivDuo10KH.Visible = true;
                dataGridViewKivDuo10Vezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
