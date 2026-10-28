using InventarioEquiposFase3N.Models;
using InventarioEquiposFase3N.Controllers;
using System;
using System.Windows.Forms;

namespace InventarioEquiposFase3N
{
    public partial class frmDepartamentos : Form
    {
        private readonly DepartamentosController _departamentosController;

        public frmDepartamentos(DepartamentosController departamentosController)
        {
            InitializeComponent();

            _departamentosController = departamentosController;

            RefrescarGrid();
        }

        private void toolBtnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            using frmDepartamentoModal frm = new frmDepartamentoModal();

            if (frm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                Departamento departamento = new Departamento(
                    frm.Codigo,
                    frm.Nombre,
                    frm.Ubicacion,
                    frm.Encargado
                );

                _departamentosController.Agregar(departamento);

                RefrescarGrid();

                MessageBox.Show("Departamento agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo agregar");
            }
        }

        private void toolBtnEditarDepartamento_Click(object sender, EventArgs e)
        {
            if (dtgDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un departamento.");
                return;
            }

            string codigo = dtgDepartamentos.CurrentRow.Cells[0].Value?.ToString() ?? "";

            using frmEditarDepartamentos frm =
                new frmEditarDepartamentos(codigo, _departamentosController);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                RefrescarGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDepartamentos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un departamento.");
                return;
            }

            string codigo = dtgDepartamentos.CurrentRow.Cells[0].Value?.ToString() ?? "";

            Departamento? departamento =
                _departamentosController.BuscarPorCodigo(codigo);

            if (departamento == null)
            {
                MessageBox.Show("No se encontró el departamento.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar el departamento " + departamento.Nombre + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _departamentosController.Eliminar(departamento);

                RefrescarGrid();

                MessageBox.Show("Departamento eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo eliminar");
            }
        }

        private void RefrescarGrid()
        {
            dtgDepartamentos.Rows.Clear();

            foreach (Departamento departamento in _departamentosController.ObtenerTodos())
            {
                dtgDepartamentos.Rows.Add(
                    departamento.Codigo,
                    departamento.Ubicacion,
                    departamento.Encargado,
                    departamento.Nombre
                );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}