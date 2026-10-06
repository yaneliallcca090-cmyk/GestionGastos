namespace GestionGastos.Views
{
    partial class formGastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtDescripcion = new TextBox();
            cbxCategoria = new ComboBox();
            nudMonto = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            cbxMetodoPago = new ComboBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            lblTotal = new Label();
            txtBuscar = new TextBox();
            panel6 = new Panel();
            dgvTablaGastos = new DataGridView();
            btnEditar = new Button();
            btnEliminar = new Button();
            label10 = new Label();
            panel4 = new Panel();
            estadoSistema = new StatusStrip();
            lblEstatus = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTablaGastos).BeginInit();
            panel4.SuspendLayout();
            estadoSistema.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 21);
            label1.Name = "label1";
            label1.Size = new Size(199, 17);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE GASTOS-REGISTRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(115, 90);
            label2.Name = "label2";
            label2.Size = new Size(123, 17);
            label2.TabIndex = 1;
            label2.Text = "REGISTRAR GASTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(46, 132);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(46, 194);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoría";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(47, 256);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Monto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(47, 318);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Fecha";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(46, 380);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 6;
            label7.Text = "Método de Pago";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(82, 446);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 34);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Location = new Point(197, 446);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 34);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(46, 150);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(280, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(46, 213);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(281, 23);
            cbxCategoria.TabIndex = 10;
            // 
            // nudMonto
            // 
            nudMonto.Location = new Point(47, 276);
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(280, 23);
            nudMonto.TabIndex = 11;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(47, 339);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(280, 23);
            dtpFecha.TabIndex = 12;
            // 
            // cbxMetodoPago
            // 
            cbxMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMetodoPago.FormattingEnabled = true;
            cbxMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cbxMetodoPago.Location = new Point(47, 402);
            cbxMetodoPago.Name = "cbxMetodoPago";
            cbxMetodoPago.Size = new Size(280, 23);
            cbxMetodoPago.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(cbxMetodoPago);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dtpFecha);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(nudMonto);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cbxCategoria);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 504);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Location = new Point(371, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 488);
            panel3.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Indigo;
            panel5.Controls.Add(label8);
            panel5.Location = new Point(373, -4);
            panel5.Name = "panel5";
            panel5.Size = new Size(477, 59);
            panel5.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(176, 21);
            label8.Name = "label8";
            label8.Size = new Size(145, 17);
            label8.TabIndex = 0;
            label8.Text = "GASTOS REGISTRADOS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 102);
            label9.Name = "label9";
            label9.Size = new Size(53, 17);
            label9.TabIndex = 0;
            label9.Text = "Buscar :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(58, 419);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(16, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "...";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(67, 96);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(329, 23);
            txtBuscar.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(dgvTablaGastos);
            panel6.Controls.Add(btnEditar);
            panel6.Controls.Add(btnEliminar);
            panel6.Location = new Point(3, 140);
            panel6.Name = "panel6";
            panel6.Size = new Size(472, 250);
            panel6.TabIndex = 5;
            // 
            // dgvTablaGastos
            // 
            dgvTablaGastos.AllowUserToAddRows = false;
            dgvTablaGastos.AllowUserToDeleteRows = false;
            dgvTablaGastos.AllowUserToResizeRows = false;
            dgvTablaGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaGastos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTablaGastos.Location = new Point(8, 3);
            dgvTablaGastos.Name = "dgvTablaGastos";
            dgvTablaGastos.ReadOnly = true;
            dgvTablaGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTablaGastos.Size = new Size(457, 166);
            dgvTablaGastos.TabIndex = 0;
            dgvTablaGastos.DoubleClick += dgvTablaGastos_DoubleClick;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Moccasin;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Location = new Point(81, 198);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(128, 34);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.RosyBrown;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Location = new Point(269, 198);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 34);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 419);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 6;
            label10.Text = "Total : ";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(txtBuscar);
            panel4.Controls.Add(lblTotal);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(373, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(477, 499);
            panel4.TabIndex = 15;
            // 
            // estadoSistema
            // 
            estadoSistema.Items.AddRange(new ToolStripItem[] { lblEstatus });
            estadoSistema.Location = new Point(0, 503);
            estadoSistema.Name = "estadoSistema";
            estadoSistema.Size = new Size(853, 22);
            estadoSistema.TabIndex = 16;
            estadoSistema.Text = "statusStrip1";
            // 
            // lblEstatus
            // 
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(16, 17);
            lblEstatus.Text = "...";
            // 
            // formGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 525);
            Controls.Add(estadoSistema);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "formGastos";
            Text = "formGastos";
            Load += formGastos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTablaGastos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            estadoSistema.ResumeLayout(false);
            estadoSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtDescripcion;
        private ComboBox cbxCategoria;
        private NumericUpDown nudMonto;
        private DateTimePicker dtpFecha;
        private ComboBox cbxMetodoPago;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Label label8;
        private Label label9;
        private Label lblTotal;
        private TextBox txtBuscar;
        private Panel panel6;
        private DataGridView dgvTablaGastos;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label10;
        private Panel panel4;
        private StatusStrip estadoSistema;
        private ToolStripStatusLabel lblEstatus;
    }
}