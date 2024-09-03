namespace UI
{
    partial class FormLogueo
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
            button1 = new Button();
            textBoxUsuario = new TextBox();
            textBoxPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(264, 422);
            button1.Name = "button1";
            button1.Size = new Size(265, 61);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(271, 219);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.PlaceholderText = "Usuario";
            textBoxUsuario.Size = new Size(258, 31);
            textBoxUsuario.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(271, 313);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "Contraseña";
            textBoxPassword.Size = new Size(258, 31);
            textBoxPassword.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(336, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormLogueo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 575);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsuario);
            Controls.Add(button1);
            Name = "FormLogueo";
            Text = "FormLogueo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxUsuario;
        private TextBox textBoxPassword;
        private PictureBox pictureBox1;
    }
}