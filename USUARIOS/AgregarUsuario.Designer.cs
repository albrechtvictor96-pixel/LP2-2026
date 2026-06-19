namespace TP_LP2
{
    partial class AgregarUsuario
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtPassword = new TextBox();
            cmbRol = new ComboBox();
            label6 = new Label();
            botonok = new Button();
            botoncancel = new Button();
            txtUsuario = new TextBox();
            txtCedula = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(68, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "Agregar Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 354);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 440);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(248, 135);
            txtApellido.Margin = new Padding(4, 4, 4, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(400, 32);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(248, 69);
            txtNombre.Margin = new Padding(4, 4, 4, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(400, 32);
            txtNombre.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(248, 431);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 32);
            txtPassword.TabIndex = 8;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Directivo", "Funcionario" });
            cmbRol.Location = new Point(248, 274);
            cmbRol.Margin = new Padding(4, 4, 4, 4);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(209, 33);
            cmbRol.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 278);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 10;
            label6.Text = "Rol:";
            // 
            // botonok
            // 
            botonok.Location = new Point(277, 509);
            botonok.Margin = new Padding(4, 4, 4, 4);
            botonok.Name = "botonok";
            botonok.Size = new Size(118, 36);
            botonok.TabIndex = 11;
            botonok.Text = "Aceptar";
            botonok.UseVisualStyleBackColor = true;
            botonok.Click += btnAgregar_Click;
            // 
            // botoncancel
            // 
            botoncancel.Location = new Point(492, 509);
            botoncancel.Margin = new Padding(4, 4, 4, 4);
            botoncancel.Name = "botoncancel";
            botoncancel.Size = new Size(118, 36);
            botoncancel.TabIndex = 12;
            botoncancel.Text = "Cancelar";
            botoncancel.UseVisualStyleBackColor = true;
            botoncancel.Click += botoncancel_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(248, 355);
            txtUsuario.Margin = new Padding(4, 4, 4, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(400, 32);
            txtUsuario.TabIndex = 13;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(252, 205);
            txtCedula.Margin = new Padding(4, 4, 4, 4);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(395, 32);
            txtCedula.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 205);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 25);
            label7.TabIndex = 15;
            label7.Text = "C.I";
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(label7);
            Controls.Add(txtCedula);
            Controls.Add(txtUsuario);
            Controls.Add(botoncancel);
            Controls.Add(botonok);
            Controls.Add(label6);
            Controls.Add(cmbRol);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AgregarUsuario";
            Text = "AgregarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtPassword;
        private ComboBox cmbRol;
        private Label label6;
        private Button botonok;
        private Button botoncancel;
        private TextBox txtEmail;
        private TextBox txtUsuario;
        private TextBox txtCedula;
        private Label label7;
    }
}