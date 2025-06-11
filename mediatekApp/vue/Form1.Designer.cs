namespace mediatekApp
{
    partial class frmAuthentification
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLogin.Location = new System.Drawing.Point(12, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "login :";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPwd.Location = new System.Drawing.Point(12, 63);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(101, 17);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "mot de passe :";
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSeConnecter.Location = new System.Drawing.Point(204, 97);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(108, 27);
            this.btnSeConnecter.TabIndex = 3;
            this.btnSeConnecter.Text = "se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLogin.Location = new System.Drawing.Point(139, 22);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(173, 23);
            this.txtLogin.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPwd.Location = new System.Drawing.Point(139, 60);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(173, 23);
            this.txtPwd.TabIndex = 5;
            // 
            // frmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 131);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLogin);
            this.Name = "frmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPwd;
    }
}

