namespace mediatekApp.vue
{
    partial class frmPersonnel
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbModifier = new System.Windows.Forms.GroupBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbModifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAbsences);
            this.grbPersonnel.Controls.Add(this.btnSupprimer);
            this.grbPersonnel.Controls.Add(this.btnAjouter);
            this.grbPersonnel.Controls.Add(this.btnModifier);
            this.grbPersonnel.Controls.Add(this.dataGridView1);
            this.grbPersonnel.Location = new System.Drawing.Point(12, 11);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(783, 358);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "personnel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // grbModifier
            // 
            this.grbModifier.Controls.Add(this.cboService);
            this.grbModifier.Controls.Add(this.txtMail);
            this.grbModifier.Controls.Add(this.txtTel);
            this.grbModifier.Controls.Add(this.txtPrenom);
            this.grbModifier.Controls.Add(this.txtNom);
            this.grbModifier.Controls.Add(this.lblService);
            this.grbModifier.Controls.Add(this.lblMail);
            this.grbModifier.Controls.Add(this.lblTel);
            this.grbModifier.Controls.Add(this.lblPrenom);
            this.grbModifier.Controls.Add(this.lblNom);
            this.grbModifier.Location = new System.Drawing.Point(12, 375);
            this.grbModifier.Name = "grbModifier";
            this.grbModifier.Size = new System.Drawing.Size(783, 135);
            this.grbModifier.TabIndex = 1;
            this.grbModifier.TabStop = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblService.Location = new System.Drawing.Point(559, 36);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(51, 15);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "service :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMail.Location = new System.Drawing.Point(307, 88);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 15);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "mail :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTel.Location = new System.Drawing.Point(320, 36);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(26, 15);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "tel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPrenom.Location = new System.Drawing.Point(3, 88);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(56, 15);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "prenom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNom.Location = new System.Drawing.Point(6, 36);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom :";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifier.Location = new System.Drawing.Point(115, 322);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 30);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAjouter.Location = new System.Drawing.Point(20, 322);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 30);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSupprimer.Location = new System.Drawing.Point(216, 322);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(94, 30);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(61, 33);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(217, 20);
            this.txtNom.TabIndex = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(61, 87);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(217, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(350, 33);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(350, 83);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(185, 20);
            this.txtMail.TabIndex = 8;
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(616, 33);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(161, 21);
            this.cboService.TabIndex = 9;
            // 
            // btnAbsences
            // 
            this.btnAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAbsences.Location = new System.Drawing.Point(539, 322);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(178, 30);
            this.btnAbsences.TabIndex = 4;
            this.btnAbsences.Text = "gestion des absences";
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // frmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 520);
            this.Controls.Add(this.grbModifier);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "frmPersonnel";
            this.Text = "Personnel";
            this.grbPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbModifier.ResumeLayout(false);
            this.grbModifier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbModifier;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
    }
}