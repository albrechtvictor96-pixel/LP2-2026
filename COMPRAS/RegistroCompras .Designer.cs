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
            label1.Location = new Point(12, 175);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion de Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre del Solicitante";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 27);
            txtNombre.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(27, 334);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(223, 84);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar Pedido";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(181, 115);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(247, 27);
            txtDescripcion.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 9);
            label4.Name = "label4";
            label4.Size = new Size(227, 31);
            label4.TabIndex = 8;
            label4.Text = "Registro de Compras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(591, 248);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 226);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 10;
            label6.Text = "Facultad";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(514, 48);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 12;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(337, 248);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(166, 56);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar Compra";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(535, 248);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(204, 56);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Compra";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 9);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 15;
            label7.Text = "Fecha";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(91, 172);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(251, 27);
            txtCantidad.TabIndex = 17;
            // 
            // cmbFacultad
            // 
            cmbFacultad.FormattingEnabled = true;
            cmbFacultad.Items.AddRange(new object[] { "CYT", "CSQ", "FCE" });
            cmbFacultad.Location = new Point(91, 226);
            cmbFacultad.Name = "cmbFacultad";
            cmbFacultad.Size = new Size(159, 28);
            cmbFacultad.TabIndex = 18;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(425, 363);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(187, 55);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // RegistroCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "RegistroCompras";
            Text = "Registro de Compras";
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