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
            dgvUsuarios.Location = new Point(192, 72);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(391, 190);
            dgvUsuarios.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(103, 301);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 35);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar Usuario";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(295, 301);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(164, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(502, 301);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 35);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnRegistrarNuevo
            // 
            btnRegistrarNuevo.Location = new Point(313, 371);
            btnRegistrarNuevo.Name = "btnRegistrarNuevo";
            btnRegistrarNuevo.Size = new Size(134, 35);
            btnRegistrarNuevo.TabIndex = 4;
            btnRegistrarNuevo.Text = "Registrar Nuevo";
            btnRegistrarNuevo.UseVisualStyleBackColor = true;
            btnRegistrarNuevo.Click += btnRegistrarNuevo_Click;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarNuevo);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dgvUsuarios);
            Name = "FormGestionUsuarios";
            Text = "FormGestionUsuarios";
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