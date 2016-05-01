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
    public partial class FormSzerzo : Form
    {
        public FormSzerzo()
        {
            InitializeComponent();
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
