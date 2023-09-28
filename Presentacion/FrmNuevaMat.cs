using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmNuevaMat : Form
    {
        public FrmNuevaMat()
        {
            InitializeComponent();
        }

        private void FrmNuevaMat_Load(object sender, EventArgs e)
        {

        }




        private void chkProcedencia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProcedencia.Checked){ grupOtraEscuela.Enabled = false; }
            else { grupOtraEscuela.Enabled = true;
            }

        }


    }
}
