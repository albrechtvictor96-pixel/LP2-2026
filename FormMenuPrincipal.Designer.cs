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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            label1 = new Label();
            btnModuloPedidos = new Button();
            btnModuloAprobacion = new Button();
            btnVolver = new Button();
            btnGestionarUsuarios = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 31);
            label1.TabIndex = 0;
            label1.Text = "Provisiones UC";
            // 
            // btnModuloPedidos
            // 
            btnModuloPedidos.Location = new Point(58, 187);
            btnModuloPedidos.Margin = new Padding(4);
            btnModuloPedidos.Name = "btnModuloPedidos";
            btnModuloPedidos.Size = new Size(334, 132);
            btnModuloPedidos.TabIndex = 1;
            btnModuloPedidos.Text = "Registrar Pedidos de Compras";
            btnModuloPedidos.UseVisualStyleBackColor = true;
            btnModuloPedidos.Click += btnModuloPedidos_Click;
            // 
            // btnModuloAprobacion
            // 
            btnModuloAprobacion.Location = new Point(552, 187);
            btnModuloAprobacion.Margin = new Padding(4);
            btnModuloAprobacion.Name = "btnModuloAprobacion";
            btnModuloAprobacion.Size = new Size(346, 132);
            btnModuloAprobacion.TabIndex = 2;
            btnModuloAprobacion.Text = "Procesar y Aprobar Pedidos";
            btnModuloAprobacion.UseVisualStyleBackColor = true;
            btnModuloAprobacion.Click += btnModuloAprobacion_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(393, 485);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(149, 51);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGestionarUsuarios
            // 
            btnGestionarUsuarios.Location = new Point(305, 358);
            btnGestionarUsuarios.Margin = new Padding(4);
            btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            btnGestionarUsuarios.Size = new Size(318, 81);
            btnGestionarUsuarios.TabIndex = 4;
            btnGestionarUsuarios.Text = "Gestionar Usuarios";
            btnGestionarUsuarios.UseVisualStyleBackColor = true;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(422, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 130);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(pictureBox1);
            Controls.Add(btnGestionarUsuarios);
            Controls.Add(btnVolver);
            Controls.Add(btnModuloAprobacion);
            Controls.Add(btnModuloPedidos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Pedidos y Adquisiciones";
            Load += FormMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnModuloPedidos;
        private Button btnModuloAprobacion;
        private Button btnVolver;
        private Button btnGestionarUsuarios;
        private PictureBox pictureBox1;
    }
}