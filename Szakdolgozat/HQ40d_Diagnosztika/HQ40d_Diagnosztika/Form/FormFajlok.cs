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
    public partial class FormFajlok : Form
    {
        public FormFajlok()
        {
            AdatKezelo ak = new AdatKezelo();
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;           
            dataGridViewFajlok.ColumnCount = 2;
            dataGridViewFajlok.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewFajlok.Columns[0].Width = 50;
            dataGridViewFajlok.Columns[1].Width = 200;            
            dataGridViewFajlok.Columns[0].Name = "Sorszám";
            dataGridViewFajlok.Columns[1].Name = "Fájl neve";
            try
            {
                foreach (var a in ak.fLista())
                {
                    dataGridViewFajlok.Rows.Add(a.fajlID, a.fajlnev);
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
