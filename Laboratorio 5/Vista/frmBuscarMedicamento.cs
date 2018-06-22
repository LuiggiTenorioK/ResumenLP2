using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratorio3_LP2;
using LogicaNegocio;

namespace Vista
{
    public partial class frmBuscarMedicamento : Form
    {
        private MedicamentoBL logicaNegocio;
        private Medicamento objetoSeleccionado;

        public Medicamento ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        public frmBuscarMedicamento()
        {
            InitializeComponent();
            logicaNegocio = new MedicamentoBL();
            dataGridView1.DataSource = logicaNegocio.listarMedicamentos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            objetoSeleccionado = (Medicamento)dataGridView1.CurrentRow.DataBoundItem;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
