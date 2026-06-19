namespace TP_LP2.COMPRAS
{
    partial class FormMenuPrincipal
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
            btnModuloPedidos = new Button();
            btnModuloAprobacion = new Button();
            btnVolver = new Button();
            btnGestionarUsuarios = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 0;
            label1.Text = "Provisiones UC";
            // 
            // btnModuloPedidos
            // 
            btnModuloPedidos.Location = new Point(89, 155);
            btnModuloPedidos.Margin = new Padding(4, 4, 4, 4);
            btnModuloPedidos.Name = "btnModuloPedidos";
            btnModuloPedidos.Size = new Size(334, 132);
            btnModuloPedidos.TabIndex = 1;
            btnModuloPedidos.Text = "Registrar Pedidos de Compras";
            btnModuloPedidos.UseVisualStyleBackColor = true;
            btnModuloPedidos.Click += btnModuloPedidos_Click;
            // 
            // btnModuloAprobacion
            // 
            btnModuloAprobacion.Location = new Point(548, 155);
            btnModuloAprobacion.Margin = new Padding(4, 4, 4, 4);
            btnModuloAprobacion.Name = "btnModuloAprobacion";
            btnModuloAprobacion.Size = new Size(346, 132);
            btnModuloAprobacion.TabIndex = 2;
            btnModuloAprobacion.Text = "Procesar y Aprobar Pedidos";
            btnModuloAprobacion.UseVisualStyleBackColor = true;
            btnModuloAprobacion.Click += btnModuloAprobacion_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(401, 496);
            btnVolver.Margin = new Padding(4, 4, 4, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(149, 51);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGestionarUsuarios
            // 
            btnGestionarUsuarios.Location = new Point(320, 370);
            btnGestionarUsuarios.Margin = new Padding(4, 4, 4, 4);
            btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            btnGestionarUsuarios.Size = new Size(318, 81);
            btnGestionarUsuarios.TabIndex = 4;
            btnGestionarUsuarios.Text = "Gestionar Usuarios";
            btnGestionarUsuarios.UseVisualStyleBackColor = true;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnGestionarUsuarios);
            Controls.Add(btnVolver);
            Controls.Add(btnModuloAprobacion);
            Controls.Add(btnModuloPedidos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Pedidos y Adquisiciones";
            Load += FormMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnModuloPedidos;
        private Button btnModuloAprobacion;
        private Button btnVolver;
        private Button btnGestionarUsuarios;
    }
}