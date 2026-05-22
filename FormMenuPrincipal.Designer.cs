namespace TP_LP2
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
            this.btnModuloPedidos = new Button();
            btnModuloAprovacion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(167, 35);
            label1.Name = "label1";
            label1.Size = new Size(418, 32);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestion de Provisiones UC";
            // 
            // btnModuloPedidos
            // 
            this.btnModuloPedidos.Location = new Point(120, 322);
            this.btnModuloPedidos.Name = "btnModuloPedidos";
            this.btnModuloPedidos.Size = new Size(221, 66);
            this.btnModuloPedidos.TabIndex = 1;
            this.btnModuloPedidos.Text = "Registrar Pedidos de Compras";
            this.btnModuloPedidos.UseVisualStyleBackColor = true;
            // 
            // btnModuloAprovacion
            // 
            btnModuloAprovacion.Location = new Point(452, 334);
            btnModuloAprovacion.Name = "btnModuloAprovacion";
            btnModuloAprovacion.Size = new Size(196, 54);
            btnModuloAprovacion.TabIndex = 2;
            btnModuloAprovacion.Text = "Procesar y Aprovacion de Pedidos";
            btnModuloAprovacion.UseVisualStyleBackColor = true;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnModuloAprovacion);
            Controls.Add(this.btnModuloPedidos);
            Controls.Add(label1);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnModuloAprovacion;
    }
}