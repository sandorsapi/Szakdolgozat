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
    public partial class FormSzemelyek : Form
    {
        public FormSzemelyek()
        {
            AdatKezelo ak = new AdatKezelo();
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            var db = new DiagnosztikaDataContext();
            var szAdat = db.Szemelyeks.Select(sz => sz);
            dataGridViewSzemelyek.ColumnCount = 3;
            dataGridViewSzemelyek.Columns[0].Width = 50;
            dataGridViewSzemelyek.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSzemelyek.Columns[0].Name = "Sorszám";
            dataGridViewSzemelyek.Columns[1].Name = "Személy neve";
            dataGridViewSzemelyek.Columns[2].Name = "Beosztása";
            try
            {
                foreach (var a in ak.szLista())
                {
                    dataGridViewSzemelyek.Rows.Add(a.szemelyID, a.nev, a.beosztas);
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
