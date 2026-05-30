namespace TP_LP2
{
    partial class FormAprobacion
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
            txtAprobNombre = new TextBox();
            txtAprobDescripcion = new TextBox();
            txtAprobCantidad = new TextBox();
            lstHistorial = new ListBox();
            btnAprobar = new Button();
            btnRechazar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtAprobNombre
            // 
            txtAprobNombre.Location = new Point(46, 97);
            txtAprobNombre.Name = "txtAprobNombre";
            txtAprobNombre.Size = new Size(175, 27);
            txtAprobNombre.TabIndex = 0;
            // 
            // txtAprobDescripcion
            // 
            txtAprobDescripcion.Location = new Point(33, 187);
            txtAprobDescripcion.Name = "txtAprobDescripcion";
            txtAprobDescripcion.Size = new Size(221, 27);
            txtAprobDescripcion.TabIndex = 1;
            // 
            // txtAprobCantidad
            // 
            txtAprobCantidad.Location = new Point(71, 303);
            txtAprobCantidad.Name = "txtAprobCantidad";
            txtAprobCantidad.Size = new Size(157, 27);
            txtAprobCantidad.TabIndex = 2;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(260, 97);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(509, 224);
            lstHistorial.TabIndex = 3;
            // 
            // btnAprobar
            // 
            btnAprobar.Location = new Point(333, 342);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(193, 66);
            btnAprobar.TabIndex = 4;
            btnAprobar.Text = "Aprobar Pedidos";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(545, 342);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(196, 66);
            btnRechazar.TabIndex = 5;
            btnRechazar.Text = "Rechazar Pedidos";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 36);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre del Solicitante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 138);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 7;
            label2.Text = "Descripcion de Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 241);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 8;
            label3.Text = "Cantidad Solicitada";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 62);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 9;
            label4.Text = "Historial";
            // 
            // FormAprobacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(lstHistorial);
            Controls.Add(txtAprobCantidad);
            Controls.Add(txtAprobDescripcion);
            Controls.Add(txtAprobNombre);
            Name = "FormAprobacion";
            Text = "FormAprobacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAprobNombre;
        private TextBox txtAprobDescripcion;
        private TextBox txtAprobCantidad;
        private ListBox lstHistorial;
        private Button btnAprobar;
        private Button btnRechazar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}