namespace Client
{
    partial class MenuLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPedirLista = new System.Windows.Forms.Button();
            this.groupBoxFicheiros = new System.Windows.Forms.GroupBox();
            this.listBoxFicheiros = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGenerateKey = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxFicheiros.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generate Key\'s";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(155, 201);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(80, 34);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.buttonRegistar);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(248, 248);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registo/Login";
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(4, 201);
            this.buttonRegistar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(80, 34);
            this.buttonRegistar.TabIndex = 4;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(4, 160);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(231, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(7, 73);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(229, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(631, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(67, 23);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(187, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 133);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPedirLista
            // 
            this.buttonPedirLista.Location = new System.Drawing.Point(21, 19);
            this.buttonPedirLista.Name = "buttonPedirLista";
            this.buttonPedirLista.Size = new System.Drawing.Size(139, 23);
            this.buttonPedirLista.TabIndex = 7;
            this.buttonPedirLista.Text = "Pedir Lista de Ficheiros";
            this.buttonPedirLista.UseVisualStyleBackColor = true;
            // 
            // groupBoxFicheiros
            // 
            this.groupBoxFicheiros.Controls.Add(this.listBoxFicheiros);
            this.groupBoxFicheiros.Controls.Add(this.button3);
            this.groupBoxFicheiros.Controls.Add(this.button2);
            this.groupBoxFicheiros.Controls.Add(this.button1);
            this.groupBoxFicheiros.Controls.Add(this.buttonPedirLista);
            this.groupBoxFicheiros.Controls.Add(this.pictureBox1);
            this.groupBoxFicheiros.Location = new System.Drawing.Point(304, 70);
            this.groupBoxFicheiros.Name = "groupBoxFicheiros";
            this.groupBoxFicheiros.Size = new System.Drawing.Size(394, 205);
            this.groupBoxFicheiros.TabIndex = 5;
            this.groupBoxFicheiros.TabStop = false;
            this.groupBoxFicheiros.Text = "Ficheiros";
            // 
            // listBoxFicheiros
            // 
            this.listBoxFicheiros.FormattingEnabled = true;
            this.listBoxFicheiros.Location = new System.Drawing.Point(21, 48);
            this.listBoxFicheiros.Name = "listBoxFicheiros";
            this.listBoxFicheiros.Size = new System.Drawing.Size(139, 108);
            this.listBoxFicheiros.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ficheiro3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 22);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ficheiro2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ficheiro1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.Location = new System.Drawing.Point(95, 13);
            this.buttonGenerateKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(110, 21);
            this.buttonGenerateKey.TabIndex = 12;
            this.buttonGenerateKey.Text = "Public/Private Key\'s";
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxKey.Location = new System.Drawing.Point(283, 13);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(329, 37);
            this.textBoxKey.TabIndex = 13;
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 305);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonGenerateKey);
            this.Controls.Add(this.groupBoxFicheiros);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuLogin";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxFicheiros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPedirLista;
        private System.Windows.Forms.GroupBox groupBoxFicheiros;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxFicheiros;
    }
}

