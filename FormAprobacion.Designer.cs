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
            lstHistorial.Location = new Point(379, 81);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(409, 244);
            lstHistorial.TabIndex = 3;
            // 
            // btnAprobar
            // 
            btnAprobar.Location = new Point(188, 365);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new Size(193, 50);
            btnAprobar.TabIndex = 4;
            btnAprobar.Text = "Aprobar Pedidos";
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Click += btnAprobar_Click;
            // 
            // btnRechazar
            // 
            btnRechazar.Location = new Point(387, 365);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(196, 50);
            btnRechazar.TabIndex = 5;
            btnRechazar.Text = "Rechazar Pedidos";
            btnRechazar.UseVisualStyleBackColor = true;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 41);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Historial ";
            // 
            // btnDeshacerAprovacion
            // 
            btnDeshacerAprovacion.Location = new Point(12, 365);
            btnDeshacerAprovacion.Name = "btnDeshacerAprovacion";
            btnDeshacerAprovacion.Size = new Size(170, 50);
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
            dgvPendientes.Location = new Point(2, 81);
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.RowHeadersWidth = 51;
            dgvPendientes.Size = new Size(371, 244);
            dgvPendientes.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 41);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 12;
            label1.Text = "Pedidos Pendientes";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(601, 365);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(160, 50);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAprobacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(dgvPendientes);
            Controls.Add(btnDeshacerAprovacion);
            Controls.Add(label4);
            Controls.Add(btnRechazar);
            Controls.Add(btnAprobar);
            Controls.Add(lstHistorial);
            Name = "FormAprobacion";
            Text = "FormAprobacion";
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