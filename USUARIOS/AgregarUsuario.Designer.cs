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
            txtRol = new ComboBox();
            label6 = new Label();
            botonok = new Button();
            botoncancel = new Button();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Agregar Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 80);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 145);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 283);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 352);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(198, 138);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(321, 27);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(321, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(198, 345);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(321, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtRol
            // 
            txtRol.FormattingEnabled = true;
            txtRol.Items.AddRange(new object[] { "Administrador", "Directivo", "Funcionario" });
            txtRol.Location = new Point(198, 219);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(168, 28);
            txtRol.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 222);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 10;
            label6.Text = "Rol:";
            // 
            // botonok
            // 
            botonok.Location = new Point(227, 407);
            botonok.Name = "botonok";
            botonok.Size = new Size(94, 29);
            botonok.TabIndex = 11;
            botonok.Text = "OK";
            botonok.UseVisualStyleBackColor = true;
            botonok.Click += botonok_Click;
            // 
            // botoncancel
            // 
            botoncancel.Location = new Point(397, 407);
            botoncancel.Name = "botoncancel";
            botoncancel.Size = new Size(94, 29);
            botoncancel.TabIndex = 12;
            botoncancel.Text = "CANCEL";
            botoncancel.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(198, 284);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(321, 27);
            txtUsuario.TabIndex = 13;
            // 
            // AgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsuario);
            Controls.Add(botoncancel);
            Controls.Add(botonok);
            Controls.Add(label6);
            Controls.Add(txtRol);
            Controls.Add(txtPassword);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private ComboBox txtRol;
        private Label label6;
        private Button botonok;
        private Button botoncancel;
        private TextBox txtEmail;
        private TextBox txtUsuario;
    }
}