using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Laboratorio3_LP2;

namespace Vista
{
    public partial class frmBuscarPaciente : Form
    {
        private PacienteBL logicaNegocio;
        private Paciente objetoSeleccionado;

        public Paciente ObjetoSeleccionado { get => objetoSeleccionado; set => objetoSeleccionado = value; }

        public frmBuscarPaciente()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            logicaNegocio = new PacienteBL();
            dataGridView1.DataSource = logicaNegocio.listarPacientes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            objetoSeleccionado = (Paciente)dataGridView1.CurrentRow.DataBoundItem;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
