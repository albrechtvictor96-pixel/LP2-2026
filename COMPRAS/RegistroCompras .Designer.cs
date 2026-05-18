namespace TP_LP2.COMPRAS
{
    partial class RegistroCompras
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
            textBox4 = new TextBox();
            label3 = new Label();
            txt = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 238);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Cantidad N y Letra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(604, 139);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(545, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 27);
            textBox4.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 117);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre ";
            // 
            // txt
            // 
            txt.Location = new Point(123, 114);
            txt.Name = "txt";
            txt.Size = new Size(247, 27);
            txt.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(27, 362);
            button1.Name = "button1";
            button1.Size = new Size(197, 56);
            button1.TabIndex = 6;
            button1.Text = "Registrar Pedido";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(604, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 53);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 8;
            label4.Text = "Registro de Compras";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(591, 248);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(604, 261);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 10;
            label6.Text = "Facultad";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(514, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(293, 362);
            button2.Name = "button2";
            button2.Size = new Size(166, 56);
            button2.TabIndex = 13;
            button2.Text = "Editar Compra";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(535, 362);
            button3.Name = "button3";
            button3.Size = new Size(204, 56);
            button3.TabIndex = 14;
            button3.Text = "Eliminar Compra";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(604, 9);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 15;
            label7.Text = "Fecha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 289);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 17;
            // 
            // RegistroCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(txt);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroCompras";
            Text = "Registro de Compras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
        private TextBox txtdescripcion;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox textBox2;
    }
}