namespace TP_LP2
{
    partial class RegistroCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCompras));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpFecha = new DateTimePicker();
            btnEditar = new Button();
            btnEliminar = new Button();
            label7 = new Label();
            txtCantidad = new TextBox();
            cmbFacultad = new ComboBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 219);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Cantidad (Nro)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(219, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion de Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 25);
            label3.TabIndex = 4;
            label3.Text = "Nombre del Solicitante";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(226, 82);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(308, 32);
            txtNombre.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.White;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Location = new Point(85, 418);
            btnRegistrar.Margin = new Padding(4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(279, 98);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar Pedido";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(226, 145);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(308, 32);
            txtDescripcion.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(85, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(252, 32);
            label4.TabIndex = 8;
            label4.Text = "Registro de Compras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(739, 310);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 282);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 10;
            label6.Text = "Facultad";
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(645, 76);
            dtpFecha.Margin = new Padding(4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(312, 32);
            dtpFecha.TabIndex = 12;
            dtpFecha.Value = new DateTime(2026, 6, 23, 11, 32, 59, 0);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(509, 310);
            btnEditar.Margin = new Padding(4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(208, 70);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar Compra";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(760, 310);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(208, 70);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Compra";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(760, 27);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 28);
            label7.TabIndex = 15;
            label7.Text = "FECHA";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(156, 216);
            txtCantidad.Margin = new Padding(4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(313, 32);
            txtCantidad.TabIndex = 17;
            // 
            // cmbFacultad
            // 
            cmbFacultad.FormattingEnabled = true;
            cmbFacultad.Items.AddRange(new object[] { "Facultad de Ciencias Jurídicas", "Facultad de Ciencias Contables", "Facultad de Ciencias de la Salud ", "Facultad de Ciencias y Tecnología " });
            cmbFacultad.Location = new Point(114, 282);
            cmbFacultad.Margin = new Padding(4);
            cmbFacultad.Name = "cmbFacultad";
            cmbFacultad.Size = new Size(355, 33);
            cmbFacultad.TabIndex = 18;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(621, 433);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(234, 69);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // RegistroCompras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnVolver);
            Controls.Add(cmbFacultad);
            Controls.Add(txtCantidad);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(dtpFecha);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDescripcion);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "RegistroCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro y Gestión de Pedidos de Compra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDescripcion;
        private Button btnRegistrar;
        private TextBox txtdescripcion;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFecha;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label7;
        private TextBox txtCantidad;
        private ComboBox cmbFacultad;
        private Button btnVolver;
    }
}