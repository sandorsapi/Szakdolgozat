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
    public partial class FormVezetokepesseg : Form
    {
        public FormVezetokepesseg()
        {
            AdatKezelo ak = new AdatKezelo();
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;           
            dataGridViewVezKepesseg.ColumnCount = 7;
            dataGridViewVezKepesseg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVezKepesseg.Columns[0].Width = 50;
            dataGridViewVezKepesseg.Columns[1].Width = 150;
            dataGridViewVezKepesseg.Columns[2].Width = 80;
            dataGridViewVezKepesseg.Columns[3].Width = 100;
            dataGridViewVezKepesseg.Columns[4].Width = 70;
            dataGridViewVezKepesseg.Columns[5].Width = 60;
            dataGridViewVezKepesseg.Columns[6].Width = 50;
            
            dataGridViewVezKepesseg.Columns[0].Name = "Sorszám";
            dataGridViewVezKepesseg.Columns[1].Name = "Vezetőképesség (μS/cm)";
            dataGridViewVezKepesseg.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewVezKepesseg.Columns[3].Name = "Berendezés";
            dataGridViewVezKepesseg.Columns[4].Name = "Dátum";
            dataGridViewVezKepesseg.Columns[5].Name = "Idő";
            dataGridViewVezKepesseg.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.vLista())
                {
                    DateTime datum = a.Mikor1.datum.Date;
                    dataGridViewVezKepesseg.Rows.Add(a.vezID, a.vezetokepesseg1, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
    }
}
