using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosEntrePantallas
{
    public partial class frmGestionarPersona : Form
    {


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmListarPersonas frm = new frmListarPersonas(listaPersonas);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtID.Text = frm.PersonaSeleccionada.Id.ToString();
                txtNombre.Text = frm.PersonaSeleccionada.Nombre;
                txtEdad.Text = frm.PersonaSeleccionada.Edad.ToString();
                posicion = frm.Posicion;
                btnModificar.Enabled = true;
            }
        }

    }
}

namespace DatosEntrePantallas
{
    public partial class frmListarPersonas : Form
    {
        private Persona personaSeleccionada;
        private int posicion;
        public frmListarPersonas()
        {
            InitializeComponent();
            
        }

        public frmListarPersonas(BindingList<Persona> personas)
        {
            InitializeComponent();
            dgvPersonas.DataSource = personas;
        }

        public Persona PersonaSeleccionada { get => personaSeleccionada; set => personaSeleccionada = value; }
        public int Posicion { get => posicion; set => posicion = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
                personaSeleccionada = (Persona)dgvPersonas.CurrentRow.DataBoundItem;
                posicion = dgvPersonas.CurrentRow.Index;
            this.DialogResult = DialogResult.OK;
        }
    }
}