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
            this.listBoxlistaFicheiros = new System.Windows.Forms.ListBox();
            this.buttonPedirFicheiro = new System.Windows.Forms.Button();
            this.buttonPedirLista = new System.Windows.Forms.Button();
            this.groupBoxFicheiros = new System.Windows.Forms.GroupBox();
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
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generate Key\'s";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(207, 247);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 42);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(331, 305);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registo/Login";
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(5, 247);
            this.buttonRegistar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(107, 42);
            this.buttonRegistar.TabIndex = 4;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(5, 197);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(307, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(9, 90);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(304, 22);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(841, 15);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(89, 28);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(245, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 164);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxlistaFicheiros
            // 
            this.listBoxlistaFicheiros.FormattingEnabled = true;
            this.listBoxlistaFicheiros.ItemHeight = 16;
            this.listBoxlistaFicheiros.Location = new System.Drawing.Point(31, 50);
            this.listBoxlistaFicheiros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxlistaFicheiros.Name = "listBoxlistaFicheiros";
            this.listBoxlistaFicheiros.Size = new System.Drawing.Size(184, 164);
            this.listBoxlistaFicheiros.TabIndex = 9;
            // 
            // buttonPedirFicheiro
            // 
            this.buttonPedirFicheiro.Location = new System.Drawing.Point(269, 234);
            this.buttonPedirFicheiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPedirFicheiro.Name = "buttonPedirFicheiro";
            this.buttonPedirFicheiro.Size = new System.Drawing.Size(185, 28);
            this.buttonPedirFicheiro.TabIndex = 8;
            this.buttonPedirFicheiro.Text = "Pedir Ficheiro";
            this.buttonPedirFicheiro.UseVisualStyleBackColor = true;
            this.buttonPedirFicheiro.Click += new System.EventHandler(this.buttonPedirFicheiro_Click);
            // 
            // buttonPedirLista
            // 
            this.buttonPedirLista.Location = new System.Drawing.Point(31, 234);
            this.buttonPedirLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPedirLista.Name = "buttonPedirLista";
            this.buttonPedirLista.Size = new System.Drawing.Size(185, 28);
            this.buttonPedirLista.TabIndex = 7;
            this.buttonPedirLista.Text = "Pedir Lista de Ficheiros";
            this.buttonPedirLista.UseVisualStyleBackColor = true;
            // 
            // groupBoxFicheiros
            // 
            this.groupBoxFicheiros.Controls.Add(this.listBoxlistaFicheiros);
            this.groupBoxFicheiros.Controls.Add(this.buttonPedirLista);
            this.groupBoxFicheiros.Controls.Add(this.pictureBox1);
            this.groupBoxFicheiros.Controls.Add(this.buttonPedirFicheiro);
            this.groupBoxFicheiros.Location = new System.Drawing.Point(405, 55);
            this.groupBoxFicheiros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFicheiros.Name = "groupBoxFicheiros";
            this.groupBoxFicheiros.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFicheiros.Size = new System.Drawing.Size(525, 299);
            this.groupBoxFicheiros.TabIndex = 5;
            this.groupBoxFicheiros.TabStop = false;
            this.groupBoxFicheiros.Text = "Ficheiros";
            // 
            // buttonGenerateKey
            // 
            this.buttonGenerateKey.Location = new System.Drawing.Point(128, 16);
            this.buttonGenerateKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerateKey.Name = "buttonGenerateKey";
            this.buttonGenerateKey.Size = new System.Drawing.Size(147, 26);
            this.buttonGenerateKey.TabIndex = 12;
            this.buttonGenerateKey.Text = "Public/Private Key\'s";
            this.buttonGenerateKey.UseVisualStyleBackColor = true;
            this.buttonGenerateKey.Click += new System.EventHandler(this.buttonGenerateKey_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(324, 2);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(476, 45);
            this.textBoxKey.TabIndex = 13;
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 375);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonGenerateKey);
            this.Controls.Add(this.groupBoxFicheiros);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListBox listBoxlistaFicheiros;
        private System.Windows.Forms.Button buttonPedirFicheiro;
        private System.Windows.Forms.Button buttonPedirLista;
        private System.Windows.Forms.GroupBox groupBoxFicheiros;
        private System.Windows.Forms.Button buttonGenerateKey;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}

