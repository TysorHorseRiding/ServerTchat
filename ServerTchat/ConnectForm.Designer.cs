namespace ServerTchat
{
    partial class ConnectForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonONOFF = new System.Windows.Forms.Button();
            this.IPAdress = new System.Windows.Forms.Label();
            this.IPAdressShow = new System.Windows.Forms.Label();
            this.PortAdress = new System.Windows.Forms.Label();
            this.PortAdressShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonONOFF
            // 
            this.buttonONOFF.Location = new System.Drawing.Point(92, 76);
            this.buttonONOFF.Name = "buttonONOFF";
            this.buttonONOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonONOFF.TabIndex = 0;
            this.buttonONOFF.Text = "ON/OFF";
            this.buttonONOFF.UseVisualStyleBackColor = true;
            this.buttonONOFF.Click += new System.EventHandler(this.buttonONOFF_Click);
            // 
            // IPAdress
            // 
            this.IPAdress.AutoSize = true;
            this.IPAdress.Location = new System.Drawing.Point(24, 23);
            this.IPAdress.Name = "IPAdress";
            this.IPAdress.Size = new System.Drawing.Size(20, 13);
            this.IPAdress.TabIndex = 2;
            this.IPAdress.Text = "IP:";
            // 
            // IPAdressShow
            // 
            this.IPAdressShow.AutoSize = true;
            this.IPAdressShow.Location = new System.Drawing.Point(50, 23);
            this.IPAdressShow.Name = "IPAdressShow";
            this.IPAdressShow.Size = new System.Drawing.Size(23, 13);
            this.IPAdressShow.TabIndex = 3;
            this.IPAdressShow.Text = "null";
            // 
            // PortAdress
            // 
            this.PortAdress.AutoSize = true;
            this.PortAdress.Location = new System.Drawing.Point(150, 23);
            this.PortAdress.Name = "PortAdress";
            this.PortAdress.Size = new System.Drawing.Size(40, 13);
            this.PortAdress.TabIndex = 4;
            this.PortAdress.Text = "PORT:";
            // 
            // PortAdressShow
            // 
            this.PortAdressShow.AutoSize = true;
            this.PortAdressShow.Location = new System.Drawing.Point(196, 23);
            this.PortAdressShow.Name = "PortAdressShow";
            this.PortAdressShow.Size = new System.Drawing.Size(23, 13);
            this.PortAdressShow.TabIndex = 5;
            this.PortAdressShow.Text = "null";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 131);
            this.Controls.Add(this.PortAdressShow);
            this.Controls.Add(this.PortAdress);
            this.Controls.Add(this.IPAdressShow);
            this.Controls.Add(this.IPAdress);
            this.Controls.Add(this.buttonONOFF);
            this.Name = "ConnectForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonONOFF;
        private System.Windows.Forms.Label IPAdress;
        private System.Windows.Forms.Label IPAdressShow;
        private System.Windows.Forms.Label PortAdress;
        private System.Windows.Forms.Label PortAdressShow;
    }
}

