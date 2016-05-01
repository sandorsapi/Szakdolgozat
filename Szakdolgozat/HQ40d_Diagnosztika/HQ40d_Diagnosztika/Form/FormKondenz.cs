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
    public partial class FormKondenz : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormKondenz(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivKondenzVezk.Visible = true;
            dataGridViewKivKondenzKH.Visible = false;
            vezetokepessegGrid();            
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivKondenzKH.ColumnCount = 7;
            dataGridViewKivKondenzKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivKondenzKH.Columns[0].Width = 50;
            dataGridViewKivKondenzKH.Columns[1].Width = 150;
            dataGridViewKivKondenzKH.Columns[2].Width = 80;
            dataGridViewKivKondenzKH.Columns[3].Width = 100;
            dataGridViewKivKondenzKH.Columns[4].Width = 70;
            dataGridViewKivKondenzKH.Columns[5].Width = 60;
            dataGridViewKivKondenzKH.Columns[6].Width = 50;

            dataGridViewKivKondenzKH.Columns[0].Name = "Sorszám";
            dataGridViewKivKondenzKH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivKondenzKH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivKondenzKH.Columns[3].Name = "Berendezés";
            dataGridViewKivKondenzKH.Columns[4].Name = "Dátum";
            dataGridViewKivKondenzKH.Columns[5].Name = "Idő";
            dataGridViewKivKondenzKH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhKondenzLista(datumTol, datumIg))
                {
                    if (dataGridViewKivKondenzKH.RowCount < ak.kemhKondenzLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivKondenzKH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivKondenzVezk.ColumnCount = 7;
            dataGridViewKivKondenzVezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivKondenzVezk.Columns[0].Width = 50;
            dataGridViewKivKondenzVezk.Columns[1].Width = 150;
            dataGridViewKivKondenzVezk.Columns[2].Width = 80;
            dataGridViewKivKondenzVezk.Columns[3].Width = 100;
            dataGridViewKivKondenzVezk.Columns[4].Width = 70;
            dataGridViewKivKondenzVezk.Columns[5].Width = 60;
            dataGridViewKivKondenzVezk.Columns[6].Width = 50;

            dataGridViewKivKondenzVezk.Columns[0].Name = "Sorszám";
            dataGridViewKivKondenzVezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivKondenzVezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivKondenzVezk.Columns[3].Name = "Berendezés";
            dataGridViewKivKondenzVezk.Columns[4].Name = "Dátum";
            dataGridViewKivKondenzVezk.Columns[5].Name = "Idő";
            dataGridViewKivKondenzVezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkKondenzLista(datumTol, datumIg))
                {
                    if (dataGridViewKivKondenzVezk.RowCount < ak.vezkKondenzLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivKondenzVezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivKondenzVezk.Visible = true;
                dataGridViewKivKondenzKH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivKondenzKH.Visible = true;
                dataGridViewKivKondenzVezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
