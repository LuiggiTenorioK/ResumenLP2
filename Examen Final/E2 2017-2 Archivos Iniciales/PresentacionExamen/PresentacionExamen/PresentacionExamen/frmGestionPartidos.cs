using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionExamen
{
    public partial class frmGestionPartidos : Form
    {
        public frmGestionPartidos()
        {
            InitializeComponent();
            dgvPosiciones.Columns["PAIS"].HeaderCell.Style.Alignment
  = DataGridViewContentAlignment.MiddleLeft;
            
        }

        private void btnModificarP1_Click(object sender, EventArgs e)
        {
            txtGolesE2P1.Enabled = true;
            txtGolesE1P1.Enabled = true;
            btnGuardarP1.Enabled = true;
            btnModificarP1.Enabled = false;
        }

        private void btnGuardarP1_Click(object sender, EventArgs e)
        {
            txtGolesE2P1.Enabled = false;
            txtGolesE1P1.Enabled = false;
            btnModificarP1.Enabled = true;
            btnGuardarP1.Enabled = false;
        }
    }
}
