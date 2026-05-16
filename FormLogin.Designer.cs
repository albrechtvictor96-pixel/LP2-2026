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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 123);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 196);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(334, 116);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(210, 27);
            txtusuario.TabIndex = 5;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(334, 192);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(210, 27);
            txtpassword.TabIndex = 3;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(331, 315);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(94, 29);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 488);
            Controls.Add(btningresar);
            Controls.Add(txtpassword);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtpassword;
        private Button btningresar;
    }
}
