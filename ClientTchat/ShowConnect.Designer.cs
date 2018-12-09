namespace ClientTchat
{
    partial class ShowConnect
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
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.buttonconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(80, 43);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(100, 20);
            this.usernamebox.TabIndex = 0;
            // 
            // buttonconnect
            // 
            this.buttonconnect.Location = new System.Drawing.Point(92, 80);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonconnect.TabIndex = 1;
            this.buttonconnect.Text = "Connection";
            this.buttonconnect.UseVisualStyleBackColor = true;
            this.buttonconnect.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // ShowConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 176);
            this.Controls.Add(this.buttonconnect);
            this.Controls.Add(this.usernamebox);
            this.Name = "ShowConnect";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Button buttonconnect;
    }
}

