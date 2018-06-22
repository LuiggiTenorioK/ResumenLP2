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
    public enum estado
    {
        Inicial, Nuevo, Guardar
    }
    public partial class frmRegistrarPedido : Form
    {
        private Medicamento m;
        private Pedido pedido;
        private PedidoBL logicaNegocioPed;
        private Paciente p;
        private Detalle_PedidoBL logicaNegocioDet;

        public frmRegistrarPedido()
        {
            InitializeComponent();
            estadoComponentes(estado.Inicial);
            pedido = new Pedido();
            dgvMedicamentos.AutoGenerateColumns = false;
            logicaNegocioPed = new PedidoBL();
            logicaNegocioDet = new Detalle_PedidoBL();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente formBuscarCliente = new frmBuscarPaciente();
            if (formBuscarCliente.ShowDialog() == DialogResult.OK)
            {
                p = formBuscarCliente.ObjetoSeleccionado;
                txtDNI.Text = p.DNI;
                txtIDPaciente.Text = p.Id.ToString();
                txtNombreCompleto.Text = p.Nombres + " " + p.Apellido_Paterno + " " + p.Apellido_Paterno;
            }
        }

        private void btnBuscarMedicamento_Click(object sender, EventArgs e)
        {
            frmBuscarMedicamento formBuscarMedicamento = new frmBuscarMedicamento();
            if (formBuscarMedicamento.ShowDialog() == DialogResult.OK)
            {
                m = formBuscarMedicamento.ObjetoSeleccionado;
                txtIDMedicamento.Text = m.Id_medicamento.ToString();
                txtNombreMedicamento.Text = m.Nombre;
                txtPresentacion.Text = m.Presentacion;
                txtCostoUnitario.Text = m.Costo_Unidad.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.Guardar);
            double total = 0;
            foreach (Detalle_Pedido x in pedido.Detalles_pedido) {
                total += x.Subtotal;
            }
            int idPedido = logicaNegocioPed.registrarPedido(p.Id, total);
            foreach (Detalle_Pedido x in pedido.Detalles_pedido) {
                logicaNegocioDet.registrarDetallePedido(idPedido, x.Medicamento.Id_medicamento, x.Cantidad, x.Subtotal);
            }
            MessageBox.Show("Se ha realizado correctamente el registro","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.Nuevo);
            pedido.Detalles_pedido.Clear();
            dgvMedicamentos.DataSource = pedido.Detalles_pedido;
        }

        public void estadoComponentes(estado e)
        {
            switch (e)
            {
                case estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    txtIDPaciente.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombreCompleto.Enabled = false;
                    txtIDMedicamento.Enabled = false;
                    txtNombreMedicamento.Enabled = false;
                    txtPresentacion.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtTotal.Enabled = false;
                    dgvMedicamentos.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnBuscarMedicamento.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnCancelar.Enabled = false;
                    //btnBuscarPedido.Enabled = true;
                    limpiarCampos();
                    break;
                case estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    txtIDPaciente.Enabled = true;
                    txtDNI.Enabled = true;
                    txtNombreCompleto.Enabled = true;
                    txtIDMedicamento.Enabled = true;
                    txtNombreMedicamento.Enabled = true;
                    txtPresentacion.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtCostoUnitario.Enabled = true;
                    txtTotal.Enabled = true;
                    dgvMedicamentos.Enabled = true;
                    btnBuscarCliente.Enabled = true;
                    btnBuscarMedicamento.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnEliminar.Enabled = true;
                    //btnBuscarPedido.Enabled = false;
                    btnCancelar.Enabled = true;
                    limpiarCampos();
                    break;
                case estado.Guardar:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    txtIDPaciente.Enabled = false;
                    txtDNI.Enabled = false;
                    txtNombreCompleto.Enabled = false;
                    txtIDMedicamento.Enabled = false;
                    txtNombreMedicamento.Enabled = false;
                    txtPresentacion.Enabled = false;
                    txtCantidad.Enabled = false;
                    txtCostoUnitario.Enabled = false;
                    txtTotal.Enabled = false;
                    dgvMedicamentos.Enabled = false;
                    btnBuscarCliente.Enabled = false;
                    btnBuscarMedicamento.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
                    //btnBuscarPedido.Enabled = true;
                    btnCancelar.Enabled = false;
                    break;
            }
        }

        public void limpiarCampos()
        {
            txtIDPaciente.Text = "";
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtIDMedicamento.Text = "";
            txtNombreMedicamento.Text = "";
            txtPresentacion.Text = "";
            txtCantidad.Text = "";
            txtCostoUnitario.Text = "";
            txtCantidad.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            estadoComponentes(estado.Inicial);
            pedido.Detalles_pedido.Clear();
            dgvMedicamentos.DataSource = pedido.Detalles_pedido;
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            String cant = txtCantidad.Text;
            foreach (Char c in cant) {
                if (!(c >= '0' && c <= '9')) {
                    MessageBox.Show("Ingrese una cantidad numerica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (cant.Length == 0) {
                MessageBox.Show("Ingrese la cantidad a solicitar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int cantidad = Int32.Parse(txtCantidad.Text);
            int encontrado = 0;
            foreach (Detalle_Pedido x in pedido.Detalles_pedido) {
                if (x.Medicamento.Id_medicamento == m.Id_medicamento) {
                    Detalle_Pedido y = x;
                    pedido.Detalles_pedido.Remove(y);
                    y.Cantidad += cantidad;
                    y.Subtotal = ((double)y.Cantidad) * y.CostoUnit;
                    pedido.Detalles_pedido.Add(y);
                    encontrado++;
                    break;
                }
            }
            if (encontrado == 0) {
                Detalle_Pedido det = new Detalle_Pedido(m, cantidad, ((double)cantidad) * m.Costo_Unidad);
                pedido.Detalles_pedido.Add(det);
            }
            dgvMedicamentos.DataSource = pedido.Detalles_pedido;
            double total = 0;
            foreach (Detalle_Pedido x in pedido.Detalles_pedido) {
                total += x.Subtotal;
            }
            txtTotal.Text = total.ToString("0.00");
        }

        private void dgvMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            int pos = dgvMedicamentos.CurrentRow.Index;
            pedido.Detalles_pedido.RemoveAt(pos);
            dgvMedicamentos.DataSource = pedido.Detalles_pedido;
            double total = 0;
            foreach (Detalle_Pedido x in pedido.Detalles_pedido) {
                total += x.Subtotal;
            }
            txtTotal.Text = total.ToString("0.00");
        }

        private void frmRegistrarPedido_Load(object sender, EventArgs e) {

        }
    }
}
