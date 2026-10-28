using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Controllers;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmEditarDepartamentos : Form
    {
        private readonly DepartamentosController _departamentosController;

        public frmEditarDepartamentos(string codigo, DepartamentosController departamentosController)
        {
            InitializeComponent();

            _departamentosController = departamentosController;

            foreach (Departamento departamento in _departamentosController.ObtenerTodos())
            {
                cbxCodigo.Items.Add(departamento.Codigo);
            }

            cbxCodigo.SelectedItem = codigo;
        }

        private void cbxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCodigo.SelectedItem == null)
            {
                return;
            }

            Departamento? departamento = _departamentosController.BuscarPorCodigo(
                cbxCodigo.SelectedItem.ToString() ?? ""
            );

            if (departamento != null)
            {
                txtDepartamento.Text = departamento.Nombre;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbxCodigo.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un código.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDepartamento.Text))
            {
                MessageBox.Show("Ingrese el nombre del departamento.");
                return;
            }

            Departamento? original = _departamentosController.BuscarPorCodigo(
                cbxCodigo.SelectedItem.ToString() ?? ""
            );

            if (original == null)
            {
                MessageBox.Show("Departamento no encontrado.");
                return;
            }

            try
            {
                Departamento copia = new Departamento(
                    original.Codigo,
                    txtDepartamento.Text.Trim(),
                    original.Ubicacion,
                    original.Encargado
                );

                _departamentosController.Actualizar(original, copia);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}