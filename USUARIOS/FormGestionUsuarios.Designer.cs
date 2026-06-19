namespace TP_LP2
{
    partial class FormGestionUsuarios
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
            dgvUsuarios = new DataGridView();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            btnRegistrarNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(148, 36);
            dgvUsuarios.Margin = new Padding(4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(690, 288);
            dgvUsuarios.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(129, 376);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(189, 44);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar Usuario";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(369, 376);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(205, 44);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(628, 376);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(175, 44);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrarNuevo
            // 
            btnRegistrarNuevo.Location = new Point(391, 464);
            btnRegistrarNuevo.Margin = new Padding(4);
            btnRegistrarNuevo.Name = "btnRegistrarNuevo";
            btnRegistrarNuevo.Size = new Size(168, 44);
            btnRegistrarNuevo.TabIndex = 4;
            btnRegistrarNuevo.Text = "Registrar Nuevo";
            btnRegistrarNuevo.UseVisualStyleBackColor = true;
            btnRegistrarNuevo.Click += btnRegistrarNuevo_Click;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnRegistrarNuevo);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvUsuarios);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FormGestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración y Control de Usuarios";
            Load += FormGestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVolver;
        private Button btnRegistrarNuevo;
    }
}