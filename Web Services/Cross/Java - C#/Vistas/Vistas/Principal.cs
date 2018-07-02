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
        private BindingList<aeropuerto> lista = new BindingList<aeropuerto>();
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
            aeropuerto a = new aeropuerto();
            a.codigo = txtCodigo.Text;
            a.nombre = txtNombre.Text;
            a.ubicacion = txtUbicacion.Text;
            a.mts_altura = Int32.Parse(txtAltura.Text);
            a.id = acceso.registrar(a);
            txtId.Text = a.id.ToString();
            lista.Add(a);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (aeropuerto aer in lista)
            {
                
                if (aer.id == Int32.Parse(txtId.Text))
                {
                    acceso.eliminar(aer.id);
                    lista.Remove(aer);
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach(aeropuerto aer in lista)
            {
                if(aer.id == Int32.Parse(txtId.Text))
                {
                    aer.codigo = txtCodigo.Text;
                    aer.nombre = txtNombre.Text;
                    aer.ubicacion = txtUbicacion.Text;
                    aer.mts_altura = Int32.Parse(txtAltura.Text);
                    acceso.modificar(aer);
                    break;
                }
            }
            
        }
    }
}
