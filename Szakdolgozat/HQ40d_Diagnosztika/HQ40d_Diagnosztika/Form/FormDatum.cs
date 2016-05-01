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
    public partial class FormDatum : Form
    {
        public FormDatum()
        {
            AdatKezelo ak = new AdatKezelo();
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;           
            dataGridViewDatum.ColumnCount = 4;
            dataGridViewDatum.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewDatum.Columns[0].Width = 50;
            dataGridViewDatum.Columns[1].Width = 80;
            dataGridViewDatum.Columns[2].Width = 80;
            dataGridViewDatum.Columns[3].Width = 100;            

            dataGridViewDatum.Columns[0].Name = "Sorszám";
            dataGridViewDatum.Columns[1].Name = "Dátum";
            dataGridViewDatum.Columns[2].Name = "Idő";
            dataGridViewDatum.Columns[3].Name = "Személyek";
            try
            {
                foreach (var a in ak.dLista())
                {
                    DateTime datum = a.datum;
                    dataGridViewDatum.Rows.Add(a.datumID, a.datum.ToString("d"), a.ido, a.Szemelyek.nev);
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
