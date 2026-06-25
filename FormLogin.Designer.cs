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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtpassword = new TextBox();
            btningresar = new Button();
            btnMostrarOcultar = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 196);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 276);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(348, 193);
            txtusuario.Margin = new Padding(4);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(262, 32);
            txtusuario.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(348, 273);
            txtpassword.Margin = new Padding(4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(262, 32);
            txtpassword.TabIndex = 3;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(348, 359);
            btningresar.Margin = new Padding(4);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(264, 71);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btnIngresar_Click_1;
            // 
            // btnMostrarOcultar
            // 
            btnMostrarOcultar.FlatStyle = FlatStyle.System;
            btnMostrarOcultar.Location = new Point(617, 273);
            btnMostrarOcultar.Name = "btnMostrarOcultar";
            btnMostrarOcultar.Size = new Size(42, 32);
            btnMostrarOcultar.TabIndex = 7;
            btnMostrarOcultar.Text = "👁";
            btnMostrarOcultar.UseVisualStyleBackColor = true;
            btnMostrarOcultar.Click += btnMostrarOcultar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(414, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 126);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(392, 483);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(175, 67);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 602);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnMostrarOcultar);
            Controls.Add(btningresar);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - Sistema de Gestión de Compras";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button btnSalir;
    }
}
