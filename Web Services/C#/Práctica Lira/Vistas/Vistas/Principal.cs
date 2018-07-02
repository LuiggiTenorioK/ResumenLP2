using LogicaNegocio;
using LogicaNegocio.AeropuertoWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Principal : Form
    {
        private AeropuertoBL acceso;
        private BindingList<Aeropuerto> lista = new BindingList<Aeropuerto>();
        public Principal()
        {
            InitializeComponent();
            tabla.AutoGenerateColumns = false;
            acceso = new AeropuertoBL();
            lista = acceso.listar();
            tabla.DataSource = lista;
            txtId.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabla.Rows[e.RowIndex];
                txtId.Text = row.Cells["ID"].Value.ToString();
                txtCodigo.Text = row.Cells["CODIGO"].Value.ToString();
                txtNombre.Text = row.Cells["NOMBRE"].Value.ToString();
                txtUbicacion.Text = row.Cells["UBICACION"].Value.ToString();
                txtAltura.Text = row.Cells["ALTURA"].Value.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Aeropuerto a = new Aeropuerto();
            a.Codigo = txtCodigo.Text;
            a.Nombre = txtNombre.Text;
            a.Ubicacion = txtUbicacion.Text;
            a.Mts_altura = Int32.Parse(txtAltura.Text);
            a.Id = acceso.registrar(a);
            txtId.Text = a.Id.ToString();
            lista.Add(a);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Aeropuerto aer in lista)
            {
                
                if (aer.Id == Int32.Parse(txtId.Text))
                {
                    acceso.eliminar(aer.Id);
                    lista.Remove(aer);
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach(Aeropuerto aer in lista)
            {
                if(aer.Id == Int32.Parse(txtId.Text))
                {
                    aer.Codigo = txtCodigo.Text;
                    aer.Nombre = txtNombre.Text;
                    aer.Ubicacion = txtUbicacion.Text;
                    aer.Mts_altura = Int32.Parse(txtAltura.Text);
                    acceso.modificar(aer);
                    break;
                }
            }
            
        }
    }
}
