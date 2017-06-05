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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.textBoxPasswordRegisto = new System.Windows.Forms.TextBox();
            this.textBoxUsernameRegisto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conecção ao Servidor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLogin);
            this.groupBox2.Controls.Add(this.textBoxPasswordLogin);
            this.groupBox2.Controls.Add(this.textBoxUsernameLogin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(336, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(325, 366);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(109, 295);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 42);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(5, 197);
            this.textBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.PasswordChar = '*';
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(313, 22);
            this.textBoxPasswordLogin.TabIndex = 3;
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(5, 90);
            this.textBoxUsernameLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(313, 22);
            this.textBoxUsernameLogin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRegistar);
            this.groupBox1.Controls.Add(this.textBoxPasswordRegisto);
            this.groupBox1.Controls.Add(this.textBoxUsernameRegisto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(11, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(319, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registo";
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(92, 295);
            this.buttonRegistar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(107, 42);
            this.buttonRegistar.TabIndex = 4;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // textBoxPasswordRegisto
            // 
            this.textBoxPasswordRegisto.Location = new System.Drawing.Point(5, 197);
            this.textBoxPasswordRegisto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPasswordRegisto.Name = "textBoxPasswordRegisto";
            this.textBoxPasswordRegisto.PasswordChar = '*';
            this.textBoxPasswordRegisto.Size = new System.Drawing.Size(307, 22);
            this.textBoxPasswordRegisto.TabIndex = 3;
            // 
            // textBoxUsernameRegisto
            // 
            this.textBoxUsernameRegisto.Location = new System.Drawing.Point(9, 90);
            this.textBoxUsernameRegisto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsernameRegisto.Name = "textBoxUsernameRegisto";
            this.textBoxUsernameRegisto.Size = new System.Drawing.Size(304, 22);
            this.textBoxUsernameRegisto.TabIndex = 2;
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
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuLogin";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.TextBox textBoxPasswordRegisto;
        private System.Windows.Forms.TextBox textBoxUsernameRegisto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

