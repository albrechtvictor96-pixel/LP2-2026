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
            lstHistorial = new ListBox();
            btnAprobar = new Button();
            btnRechazar = new Button();
            label4 = new Label();
            btnDeshacerAprovacion = new Button();
            dgvPendientes = new DataGridView();
            label1 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
            SuspendLayout();
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(484, 102);
            lstHistorial.Margin = new Padding(4);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(510, 304);
            lstHistorial.TabIndex = 3;
            // 
            // btnAprobar
            // 
            btnAprobar.Location = new Point(235, 456);
            btnAprobar.Margin = new Padding(4);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(241, 62);
            btnAprobar.TabIndex = 4;
            btnAprobar.Text = "Aprobar Pedidos";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(484, 456);
            btnRechazar.Margin = new Padding(4);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(245, 62);
            btnRechazar.TabIndex = 5;
            btnRechazar.Text = "Rechazar Pedidos";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(683, 56);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 9;
            label4.Text = "Historial ";
            // 
            // btnDeshacerAprovacion
            // 
            btnDeshacerAprovacion.Location = new Point(15, 456);
            btnDeshacerAprovacion.Margin = new Padding(4);
            btnDeshacerAprovacion.Name = "btnDeshacerAprovacion";
            btnDeshacerAprovacion.Size = new Size(212, 62);
            btnDeshacerAprovacion.TabIndex = 10;
            btnDeshacerAprovacion.Text = "Deshacer Ultima Aprobacion";
            btnDeshacerAprovacion.UseVisualStyleBackColor = true;
            btnDeshacerAprovacion.Click += btnDeshacerAprovacion_Click;
            // 
            // dgvPendientes
            // 
            dgvPendientes.BackgroundColor = SystemColors.Window;
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientes.GridColor = SystemColors.ControlText;
            dgvPendientes.Location = new Point(2, 101);
            dgvPendientes.Margin = new Padding(4);
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.RowHeadersWidth = 51;
            dgvPendientes.Size = new Size(474, 305);
            dgvPendientes.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 12;
            label1.Text = "Pedidos Pendientes";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(751, 456);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(200, 62);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAprobacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(dgvPendientes);
            Controls.Add(btnDeshacerAprovacion);
            Controls.Add(label4);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(lstHistorial);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FormAprobacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion y Aprobacion de Pedidos";
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstHistorial;
        private Button btnAprobar;
        private Button btnRechazar;
        private Label label4;
        private Button btnDeshacerAprovacion;
        private DataGridView dgvPendientes;
        private Label label1;
        private Button btnVolver;
    }
}