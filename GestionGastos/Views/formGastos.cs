using GestionGastos.Config;
using GestionGastos.Controllers;
using GestionGastos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionGastos.Views
{
    public partial class formGastos : Form
    {
        ConexionSqlite conectaSqlita = new ConexionSqlite();

        private readonly GastoController gasController;

        public formGastos()
        {
            InitializeComponent();

            gasController = new GastoController();

        }


        private void formGastos_Load(object sender, EventArgs e)
        {
            Categoria(cbxCategoria);
            MetodoPago(cbxMetodoPago);
            CargarTablaGasto(dgvTablaGastos);

            if (conectaSqlita.ProbarConexion())
            {
                //MessageBox.Show("Conexion exitosa", "ÉXITO!");
                lblEstatus.Text = "Conectado a a la BD";
                lblEstatus.ForeColor = Color.Green;
            }
            else
            {
                //MessageBox.Show("No se pudo conectar a la base de datos", "ALERTA");
                lblEstatus.Text = "No se tiene conexión a la BD";
                lblEstatus.ForeColor = Color.Red;
            }
        }




        //Esto es para mostar datos en la tabla

        private void CargarTablaGasto(DataGridView data)
        {
            data.DataSource = null;
            data.DataSource = gasController.ListarGasto();
        }



        private void Categoria(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Alimentación");
            combo.Items.Add("Transporte");
            combo.Items.Add("Salud");
            combo.Items.Add("Educación");
            combo.Items.Add("Entretenimiento");
            combo.Items.Add("Vivienda");
            combo.Items.Add("Servicios");
            combo.Items.Add("Compras");
            combo.Items.Add("Otros");
        }

        private void MetodoPago(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add("Efectivo");
            combo.Items.Add("Tarjeta");
            combo.Items.Add("Transferencia");
            combo.Items.Add("Yape");
            combo.Items.Add("Plin");
            combo.Items.Add("Otro");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length == 0)
            {
                MessageBox.Show("La descripcion no puede ser vacio", "Atencion");
                return;
            }

            if (cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar algun valor", "Atencion");
                return;
            }

            if (nudMonto.Value == 0)
            {
                MessageBox.Show("Debes ingresar algún monto", "Atencion");
                return;
            }

            if (cbxMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar método pago", "Atencion");
                return;
            }


            //Haces una instancia

            Gastos gasto = new Gastos
            {
                Descripcion = txtDescripcion.Text,
                Categoria = cbxCategoria.Text,
                Monto = decimal.Parse(nudMonto.Value.ToString()),
                Fecha = dtpFecha.Value,
                MetodoPago = cbxMetodoPago.Text
            };

            

            gasController.Registrar(gasto);

            CargarTablaGasto(dgvTablaGastos);

            MessageBox.Show("Datos registrados correctamente", "Correcto!");


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTablaGastos.CurrentRow == null)
            {
                return;
            }

            int idGasto = Convert.ToInt32(dgvTablaGastos.CurrentRow.Cells["IdGasto"].Value);

            gasController.Eliminar(idGasto);

            CargarTablaGasto(dgvTablaGastos);

            MessageBox.Show("Dato eliminado correctamente", "Eliminado");

        }

        private void dgvTablaGastos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTablaGastos.CurrentRow == null)
            {
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Desea editar datos de esta fila?",
                "¿Desea editar?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                DataGridViewRow fila = dgvTablaGastos.CurrentRow;

                txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString();
                cbxCategoria.Text = fila.Cells["Categoria"].Value?.ToString();
                nudMonto.Value = Convert.ToDecimal(fila.Cells["Monto"].Value?.ToString());

                if (fila.Cells["Fecha"].Value != null)
                {
                    dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                }

                cbxMetodoPago.Text = fila.Cells["MetodoPago"].Value?.ToString();
            }

            
        }
    }
}