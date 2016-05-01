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
    public partial class FormHutesi : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormHutesi(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivHutesiVezk.Visible = true;
            dataGridViewKivHutesiKH.Visible = false;
            vezetokepessegGrid();     
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivHutesiKH.ColumnCount = 7;
            dataGridViewKivHutesiKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHutesiKH.Columns[0].Width = 50;
            dataGridViewKivHutesiKH.Columns[1].Width = 150;
            dataGridViewKivHutesiKH.Columns[2].Width = 80;
            dataGridViewKivHutesiKH.Columns[3].Width = 100;
            dataGridViewKivHutesiKH.Columns[4].Width = 70;
            dataGridViewKivHutesiKH.Columns[5].Width = 60;
            dataGridViewKivHutesiKH.Columns[6].Width = 50;

            dataGridViewKivHutesiKH.Columns[0].Name = "Sorszám";
            dataGridViewKivHutesiKH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivHutesiKH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHutesiKH.Columns[3].Name = "Berendezés";
            dataGridViewKivHutesiKH.Columns[4].Name = "Dátum";
            dataGridViewKivHutesiKH.Columns[5].Name = "Idő";
            dataGridViewKivHutesiKH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhHutesiLista(datumTol, datumIg))
                {
                    if (dataGridViewKivHutesiKH.RowCount < ak.kemhHutesiLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHutesiKH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivHutesiVezk.ColumnCount = 7;
            dataGridViewKivHutesiVezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivHutesiVezk.Columns[0].Width = 50;
            dataGridViewKivHutesiVezk.Columns[1].Width = 150;
            dataGridViewKivHutesiVezk.Columns[2].Width = 80;
            dataGridViewKivHutesiVezk.Columns[3].Width = 100;
            dataGridViewKivHutesiVezk.Columns[4].Width = 70;
            dataGridViewKivHutesiVezk.Columns[5].Width = 60;
            dataGridViewKivHutesiVezk.Columns[6].Width = 50;

            dataGridViewKivHutesiVezk.Columns[0].Name = "Sorszám";
            dataGridViewKivHutesiVezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivHutesiVezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivHutesiVezk.Columns[3].Name = "Berendezés";
            dataGridViewKivHutesiVezk.Columns[4].Name = "Dátum";
            dataGridViewKivHutesiVezk.Columns[5].Name = "Idő";
            dataGridViewKivHutesiVezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkHutesiLista(datumTol, datumIg))
                {
                    if (dataGridViewKivHutesiVezk.RowCount < ak.vezkHutesiLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivHutesiVezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivHutesiVezk.Visible = true;
                dataGridViewKivHutesiKH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivHutesiKH.Visible = true;
                dataGridViewKivHutesiVezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
