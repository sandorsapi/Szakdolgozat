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
    public partial class FormPotviz : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormPotviz(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivPotvizVezk.Visible = true;
            dataGridViewKivPotvizKH.Visible = false;
            vezetokepessegGrid(); 
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivPotvizKH.ColumnCount = 7;
            dataGridViewKivPotvizKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivPotvizKH.Columns[0].Width = 50;
            dataGridViewKivPotvizKH.Columns[1].Width = 150;
            dataGridViewKivPotvizKH.Columns[2].Width = 80;
            dataGridViewKivPotvizKH.Columns[3].Width = 100;
            dataGridViewKivPotvizKH.Columns[4].Width = 70;
            dataGridViewKivPotvizKH.Columns[5].Width = 60;
            dataGridViewKivPotvizKH.Columns[6].Width = 50;

            dataGridViewKivPotvizKH.Columns[0].Name = "Sorszám";
            dataGridViewKivPotvizKH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivPotvizKH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivPotvizKH.Columns[3].Name = "Berendezés";
            dataGridViewKivPotvizKH.Columns[4].Name = "Dátum";
            dataGridViewKivPotvizKH.Columns[5].Name = "Idő";
            dataGridViewKivPotvizKH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhPotvizLista(datumTol, datumIg))
                {
                    if (dataGridViewKivPotvizKH.RowCount < ak.kemhPotvizLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivPotvizKH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivPotvizVezk.ColumnCount = 7;
            dataGridViewKivPotvizVezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivPotvizVezk.Columns[0].Width = 50;
            dataGridViewKivPotvizVezk.Columns[1].Width = 150;
            dataGridViewKivPotvizVezk.Columns[2].Width = 80;
            dataGridViewKivPotvizVezk.Columns[3].Width = 100;
            dataGridViewKivPotvizVezk.Columns[4].Width = 70;
            dataGridViewKivPotvizVezk.Columns[5].Width = 60;
            dataGridViewKivPotvizVezk.Columns[6].Width = 50;

            dataGridViewKivPotvizVezk.Columns[0].Name = "Sorszám";
            dataGridViewKivPotvizVezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivPotvizVezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivPotvizVezk.Columns[3].Name = "Berendezés";
            dataGridViewKivPotvizVezk.Columns[4].Name = "Dátum";
            dataGridViewKivPotvizVezk.Columns[5].Name = "Idő";
            dataGridViewKivPotvizVezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkPotvizLista(datumTol, datumIg))
                {
                    if (dataGridViewKivPotvizVezk.RowCount < ak.vezkPotvizLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivPotvizVezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivPotvizVezk.Visible = true;
                dataGridViewKivPotvizKH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivPotvizKH.Visible = true;
                dataGridViewKivPotvizVezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
