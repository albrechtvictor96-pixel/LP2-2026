namespace TP_LP2
{
    partial class FormLogin : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtpassword = new TextBox();
            btningresar = new Button();
            btnMostrarOcultar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 154);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 245);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(385, 154);
            txtusuario.Margin = new Padding(4);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(262, 32);
            txtusuario.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(385, 242);
            txtpassword.Margin = new Padding(4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(262, 32);
            txtpassword.TabIndex = 3;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(385, 370);
            btningresar.Margin = new Padding(4);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(201, 56);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btnIngresar_Click_1;
            // 
            // btnMostrarOcultar
            // 
            btnMostrarOcultar.FlatStyle = FlatStyle.Flat;
            btnMostrarOcultar.Location = new Point(654, 242);
            btnMostrarOcultar.Name = "btnMostrarOcultar";
            btnMostrarOcultar.Size = new Size(45, 32);
            btnMostrarOcultar.TabIndex = 7;
            btnMostrarOcultar.Text = "👁";
            btnMostrarOcultar.UseVisualStyleBackColor = true;
            btnMostrarOcultar.Click += btnMostrarOcultar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 610);
            Controls.Add(btnMostrarOcultar);
            Controls.Add(btningresar);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - Sistema de Gestión de Compras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtpassword;
        private Button btningresar;
        private Button btnMostrarOcultar;
    }
}
