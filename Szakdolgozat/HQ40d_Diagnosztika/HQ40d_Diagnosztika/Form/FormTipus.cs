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
    public partial class FormTipus : Form
    {
        public FormTipus()
        {
            AdatKezelo ak = new AdatKezelo();
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;           
            dataGridViewTipus.ColumnCount = 3;
            dataGridViewTipus.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewTipus.Columns[0].Width = 50;
            dataGridViewTipus.Columns[1].Width = 100;
            dataGridViewTipus.Columns[2].Width = 100;
            dataGridViewTipus.Columns[0].Name = "Sorszám";
            dataGridViewTipus.Columns[1].Name = "Mérés típusa";
            dataGridViewTipus.Columns[2].Name = "Azonosító";
            try
            {
                foreach (var a in ak.tLista())
                {
                    dataGridViewTipus.Rows.Add(a.typeID, a.tipus1, a.azonosito);
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
