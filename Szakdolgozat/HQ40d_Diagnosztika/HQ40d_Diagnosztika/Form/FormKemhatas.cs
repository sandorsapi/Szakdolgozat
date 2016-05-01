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
    public partial class FormKemhatas : Form
    {
        public FormKemhatas()
        {
            AdatKezelo ak = new AdatKezelo();
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;           
            dataGridViewKemhatas.ColumnCount = 7;
            dataGridViewKemhatas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewKemhatas.Columns[0].Width = 50;
            dataGridViewKemhatas.Columns[1].Width = 150;
            dataGridViewKemhatas.Columns[2].Width = 80;
            dataGridViewKemhatas.Columns[3].Width = 100;
            dataGridViewKemhatas.Columns[4].Width = 70;
            dataGridViewKemhatas.Columns[5].Width = 60;
            dataGridViewKemhatas.Columns[6].Width = 50;

            dataGridViewKemhatas.Columns[0].Name = "Sorszám";
            dataGridViewKemhatas.Columns[1].Name = "Kémhatás (pH)";
            dataGridViewKemhatas.Columns[2].Name = "Hőfok (ᵒC)";
            dataGridViewKemhatas.Columns[3].Name = "Berendezés";
            dataGridViewKemhatas.Columns[4].Name = "Dátum";
            dataGridViewKemhatas.Columns[5].Name = "Idő";
            dataGridViewKemhatas.Columns[6].Name = "Típus";
            try
            {
                foreach (var a in ak.kLista())
                {
                    DateTime datum = a.Mikor1.datum.Date;
                    dataGridViewKemhatas.Rows.Add(a.phID, a.kemhatas, a.hofok, a.Berendezesek.berendezes_nev, datum.ToString("d"), a.Mikor1.ido, a.Tipus1.tipus1);
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
