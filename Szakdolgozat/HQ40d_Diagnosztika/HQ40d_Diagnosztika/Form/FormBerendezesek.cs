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
    public partial class FormBerendezesek : Form
    {        
        public FormBerendezesek()
        {           
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
            adatracsFeltoltes();
            Cursor.Current = Cursors.Default;         
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            try
            {
                AdatKezelo ak = new AdatKezelo();
                if (tbUjBerendezes.Text.Length > 0)
                {
                    if (!ak.berendezesEllenor(tbUjBerendezes.Text.ToUpper()))
                    {
                        ak.berendezesUj(tbUjBerendezes.Text.ToUpper());
                        adatracsFeltoltes();
                    }
                    else
                    {
                        MessageBox.Show("A berendezés már létezik az adatbázisban", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("A mező üres!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A felvitel nem sikerült! \n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //dataGridView feltöltése
        public void adatracsFeltoltes()
        {
            AdatKezelo ak = new AdatKezelo();
            Cursor.Current = Cursors.WaitCursor;
            dataGridViewBerendezesek.ColumnCount = 2;
            dataGridViewBerendezesek.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewBerendezesek.Columns[0].Width = 50;
            dataGridViewBerendezesek.Columns[1].Width = 200;
            dataGridViewBerendezesek.Columns[0].Name = "Sorszám";
            dataGridViewBerendezesek.Columns[1].Name = "Berendezés neve";
            try
            {
                foreach (var a in ak.bLista())
                {
                    dataGridViewBerendezesek.Rows.Add(a.berendezesID, a.berendezes_nev);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adathiba! \n" + ex.Message, "SQL hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default; 
        }
    }
}
