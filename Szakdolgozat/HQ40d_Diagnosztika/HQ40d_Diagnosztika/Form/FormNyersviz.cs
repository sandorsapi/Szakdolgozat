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
    public partial class FormNyersviz : Form
    {
        AdatKezelo ak = new AdatKezelo();
        private DateTime datumTol;
        private DateTime datumIg;

        public FormNyersviz(DateTime datTol, DateTime datIg)
        {            
            datumTol = datTol;
            datumIg = datIg;
            InitializeComponent();
            dataGridViewKivNyersvizVezk.Visible = true;
            dataGridViewKivNyersvizKH.Visible = false;
            vezetokepessegGrid();     
        }

        private void kemhatasGrid()
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewKivNyersvizKH.ColumnCount = 7;
            dataGridViewKivNyersvizKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivNyersvizKH.Columns[0].Width = 50;
            dataGridViewKivNyersvizKH.Columns[1].Width = 150;
            dataGridViewKivNyersvizKH.Columns[2].Width = 80;
            dataGridViewKivNyersvizKH.Columns[3].Width = 100;
            dataGridViewKivNyersvizKH.Columns[4].Width = 70;
            dataGridViewKivNyersvizKH.Columns[5].Width = 60;
            dataGridViewKivNyersvizKH.Columns[6].Width = 50;

            dataGridViewKivNyersvizKH.Columns[0].Name = "Sorszám";
            dataGridViewKivNyersvizKH.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKivNyersvizKH.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivNyersvizKH.Columns[3].Name = "Berendezés";
            dataGridViewKivNyersvizKH.Columns[4].Name = "Dátum";
            dataGridViewKivNyersvizKH.Columns[5].Name = "Idő";
            dataGridViewKivNyersvizKH.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kemhNyersvizLista(datumTol, datumIg))
                {
                    if (dataGridViewKivNyersvizKH.RowCount < ak.kemhNyersvizLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivNyersvizKH.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
            dataGridViewKivNyersvizVezk.ColumnCount = 7;
            dataGridViewKivNyersvizVezk.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKivNyersvizVezk.Columns[0].Width = 50;
            dataGridViewKivNyersvizVezk.Columns[1].Width = 150;
            dataGridViewKivNyersvizVezk.Columns[2].Width = 80;
            dataGridViewKivNyersvizVezk.Columns[3].Width = 100;
            dataGridViewKivNyersvizVezk.Columns[4].Width = 70;
            dataGridViewKivNyersvizVezk.Columns[5].Width = 60;
            dataGridViewKivNyersvizVezk.Columns[6].Width = 50;

            dataGridViewKivNyersvizVezk.Columns[0].Name = "Sorszám";
            dataGridViewKivNyersvizVezk.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewKivNyersvizVezk.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKivNyersvizVezk.Columns[3].Name = "Berendezés";
            dataGridViewKivNyersvizVezk.Columns[4].Name = "Dátum";
            dataGridViewKivNyersvizVezk.Columns[5].Name = "Idő";
            dataGridViewKivNyersvizVezk.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vezkNyersvizLista(datumTol, datumIg))
                {
                    if (dataGridViewKivNyersvizVezk.RowCount < ak.vezkNyersvizLista(datumTol, datumIg).Count)
                    {
                        DateTime datum = a.Mikor1.datum.Date;
                        dataGridViewKivNyersvizVezk.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
                dataGridViewKivNyersvizVezk.Visible = true;
                dataGridViewKivNyersvizKH.Visible = false;
                vezetokepessegGrid();
            }
        }

        private void rbtnKemhatas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnKemhatas.Checked == true)
            {
                dataGridViewKivNyersvizKH.Visible = true;
                dataGridViewKivNyersvizVezk.Visible = false;
                kemhatasGrid();
            }
        }
    }
}
