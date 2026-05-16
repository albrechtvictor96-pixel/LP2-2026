namespace TP_LP2.USUARIOS
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
            dvgUsuarios = new DataGridView();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dvgUsuarios
            // 
            dvgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsuarios.Location = new Point(170, 58);
            dvgUsuarios.Name = "dvgUsuarios";
            dvgUsuarios.RowHeadersWidth = 51;
            dvgUsuarios.Size = new Size(391, 170);
            dvgUsuarios.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(84, 301);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(151, 35);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar Usuario";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(258, 301);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(164, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(450, 301);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 35);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(dvgUsuarios);
            Name = "FormGestionUsuarios";
            Text = "FormGestionUsuarios";
            Load += FormGestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dvgUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgUsuarios;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}