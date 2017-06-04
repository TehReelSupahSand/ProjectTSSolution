namespace Client
{
    partial class MenuCliente
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
            this.buttonPedirLista = new System.Windows.Forms.Button();
            this.buttonPedirFicheiro = new System.Windows.Forms.Button();
            this.listBoxlistaFicheiros = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPedirLista
            // 
            this.buttonPedirLista.Location = new System.Drawing.Point(12, 194);
            this.buttonPedirLista.Name = "buttonPedirLista";
            this.buttonPedirLista.Size = new System.Drawing.Size(139, 23);
            this.buttonPedirLista.TabIndex = 0;
            this.buttonPedirLista.Text = "Pedir Lista de Ficheiros";
            this.buttonPedirLista.UseVisualStyleBackColor = true;
            // 
            // buttonPedirFicheiro
            // 
            this.buttonPedirFicheiro.Location = new System.Drawing.Point(191, 194);
            this.buttonPedirFicheiro.Name = "buttonPedirFicheiro";
            this.buttonPedirFicheiro.Size = new System.Drawing.Size(139, 23);
            this.buttonPedirFicheiro.TabIndex = 1;
            this.buttonPedirFicheiro.Text = "Pedir Ficheiro";
            this.buttonPedirFicheiro.UseVisualStyleBackColor = true;
            // 
            // listBoxlistaFicheiros
            // 
            this.listBoxlistaFicheiros.FormattingEnabled = true;
            this.listBoxlistaFicheiros.Location = new System.Drawing.Point(12, 45);
            this.listBoxlistaFicheiros.Name = "listBoxlistaFicheiros";
            this.listBoxlistaFicheiros.Size = new System.Drawing.Size(139, 134);
            this.listBoxlistaFicheiros.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(173, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 133);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(309, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(67, 23);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 226);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxlistaFicheiros);
            this.Controls.Add(this.buttonPedirFicheiro);
            this.Controls.Add(this.buttonPedirLista);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPedirLista;
        private System.Windows.Forms.Button buttonPedirFicheiro;
        private System.Windows.Forms.ListBox listBoxlistaFicheiros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogout;
    }
}