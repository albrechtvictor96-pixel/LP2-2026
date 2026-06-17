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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 56);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Provisiones UC";
            // 
            // btnModuloPedidos
            // 
            btnModuloPedidos.Location = new Point(118, 167);
            btnModuloPedidos.Name = "btnModuloPedidos";
            btnModuloPedidos.Size = new Size(267, 106);
            btnModuloPedidos.TabIndex = 1;
            btnModuloPedidos.Text = "Registrar Pedidos de Compras";
            btnModuloPedidos.UseVisualStyleBackColor = true;
            btnModuloPedidos.Click += btnModuloPedidos_Click;
            // 
            // btnModuloAprobacion
            // 
            btnModuloAprobacion.Location = new Point(420, 167);
            btnModuloAprobacion.Name = "btnModuloAprobacion";
            btnModuloAprobacion.Size = new Size(277, 106);
            btnModuloAprobacion.TabIndex = 2;
            btnModuloAprobacion.Text = "Procesar y Aprobar Pedidos";
            btnModuloAprobacion.UseVisualStyleBackColor = true;
            btnModuloAprobacion.Click += btnModuloAprobacion_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(355, 343);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(119, 41);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnModuloAprobacion);
            Controls.Add(btnModuloPedidos);
            Controls.Add(label1);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            Load += FormMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnModuloPedidos;
        private Button btnModuloAprobacion;
        private Button btnVolver;
    }
}