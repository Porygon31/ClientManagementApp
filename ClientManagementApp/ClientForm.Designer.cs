namespace ClientManagementApp
{
    partial class ClientForm
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
            this.groupBoxAddClient = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumeroSS = new System.Windows.Forms.TextBox();
            this.textBoxNumeroTel = new System.Windows.Forms.TextBox();
            this.textBoxAdresseMail = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBoxSexe = new System.Windows.Forms.ListBox();
            this.dateTimePickerDateDeNaissance = new System.Windows.Forms.DateTimePicker();
            this.textBoxLieuDeNaissance = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSIP = new System.Windows.Forms.GroupBox();
            this.textBoxMotDePasseSIP = new System.Windows.Forms.TextBox();
            this.labelMotDePasseSIP = new System.Windows.Forms.Label();
            this.textBoxIdentifiantSIP = new System.Windows.Forms.TextBox();
            this.labelIdentifiantSIP = new System.Windows.Forms.Label();
            this.groupBoxAddClient.SuspendLayout();
            this.groupBoxSIP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddClient
            // 
            this.groupBoxAddClient.Controls.Add(this.label8);
            this.groupBoxAddClient.Controls.Add(this.label7);
            this.groupBoxAddClient.Controls.Add(this.label6);
            this.groupBoxAddClient.Controls.Add(this.textBoxNumeroSS);
            this.groupBoxAddClient.Controls.Add(this.textBoxNumeroTel);
            this.groupBoxAddClient.Controls.Add(this.textBoxAdresseMail);
            this.groupBoxAddClient.Controls.Add(this.listBoxSexe);
            this.groupBoxAddClient.Controls.Add(this.dateTimePickerDateDeNaissance);
            this.groupBoxAddClient.Controls.Add(this.textBoxLieuDeNaissance);
            this.groupBoxAddClient.Controls.Add(this.textBoxPrenom);
            this.groupBoxAddClient.Controls.Add(this.textBoxNom);
            this.groupBoxAddClient.Controls.Add(this.label5);
            this.groupBoxAddClient.Controls.Add(this.label4);
            this.groupBoxAddClient.Controls.Add(this.label3);
            this.groupBoxAddClient.Controls.Add(this.label2);
            this.groupBoxAddClient.Controls.Add(this.label1);
            this.groupBoxAddClient.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddClient.Name = "groupBoxAddClient";
            this.groupBoxAddClient.Size = new System.Drawing.Size(601, 316);
            this.groupBoxAddClient.TabIndex = 0;
            this.groupBoxAddClient.TabStop = false;
            this.groupBoxAddClient.Text = "Ajouter Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Numéro de Sécurité Sociale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Numéro de téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adresse Mail";
            // 
            // textBoxNumeroSS
            // 
            this.textBoxNumeroSS.Location = new System.Drawing.Point(157, 276);
            this.textBoxNumeroSS.Name = "textBoxNumeroSS";
            this.textBoxNumeroSS.Size = new System.Drawing.Size(201, 20);
            this.textBoxNumeroSS.TabIndex = 14;
            // 
            // textBoxNumeroTel
            // 
            this.textBoxNumeroTel.Location = new System.Drawing.Point(157, 242);
            this.textBoxNumeroTel.Name = "textBoxNumeroTel";
            this.textBoxNumeroTel.Size = new System.Drawing.Size(201, 20);
            this.textBoxNumeroTel.TabIndex = 13;
            // 
            // textBoxAdresseMail
            // 
            this.textBoxAdresseMail.Location = new System.Drawing.Point(157, 205);
            this.textBoxAdresseMail.Name = "textBoxAdresseMail";
            this.textBoxAdresseMail.Size = new System.Drawing.Size(201, 20);
            this.textBoxAdresseMail.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(659, 216);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(165, 64);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBoxSexe
            // 
            this.listBoxSexe.FormattingEnabled = true;
            this.listBoxSexe.Location = new System.Drawing.Point(153, 171);
            this.listBoxSexe.Name = "listBoxSexe";
            this.listBoxSexe.Size = new System.Drawing.Size(206, 17);
            this.listBoxSexe.TabIndex = 10;
            // 
            // dateTimePickerDateDeNaissance
            // 
            this.dateTimePickerDateDeNaissance.Location = new System.Drawing.Point(154, 106);
            this.dateTimePickerDateDeNaissance.Name = "dateTimePickerDateDeNaissance";
            this.dateTimePickerDateDeNaissance.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerDateDeNaissance.TabIndex = 9;
            // 
            // textBoxLieuDeNaissance
            // 
            this.textBoxLieuDeNaissance.Location = new System.Drawing.Point(154, 137);
            this.textBoxLieuDeNaissance.Name = "textBoxLieuDeNaissance";
            this.textBoxLieuDeNaissance.Size = new System.Drawing.Size(205, 20);
            this.textBoxLieuDeNaissance.TabIndex = 8;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(154, 75);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(205, 20);
            this.textBoxPrenom.TabIndex = 6;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(154, 36);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(205, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sexe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lieu de Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de Naissance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // groupBoxSIP
            // 
            this.groupBoxSIP.Controls.Add(this.textBoxMotDePasseSIP);
            this.groupBoxSIP.Controls.Add(this.labelMotDePasseSIP);
            this.groupBoxSIP.Controls.Add(this.textBoxIdentifiantSIP);
            this.groupBoxSIP.Controls.Add(this.labelIdentifiantSIP);
            this.groupBoxSIP.Location = new System.Drawing.Point(659, 23);
            this.groupBoxSIP.Name = "groupBoxSIP";
            this.groupBoxSIP.Size = new System.Drawing.Size(375, 131);
            this.groupBoxSIP.TabIndex = 1;
            this.groupBoxSIP.TabStop = false;
            this.groupBoxSIP.Text = "SIP";
            // 
            // textBoxMotDePasseSIP
            // 
            this.textBoxMotDePasseSIP.Location = new System.Drawing.Point(119, 81);
            this.textBoxMotDePasseSIP.Name = "textBoxMotDePasseSIP";
            this.textBoxMotDePasseSIP.Size = new System.Drawing.Size(194, 20);
            this.textBoxMotDePasseSIP.TabIndex = 3;
            // 
            // labelMotDePasseSIP
            // 
            this.labelMotDePasseSIP.AutoSize = true;
            this.labelMotDePasseSIP.Location = new System.Drawing.Point(19, 87);
            this.labelMotDePasseSIP.Name = "labelMotDePasseSIP";
            this.labelMotDePasseSIP.Size = new System.Drawing.Size(71, 13);
            this.labelMotDePasseSIP.TabIndex = 2;
            this.labelMotDePasseSIP.Text = "Mot de passe";
            // 
            // textBoxIdentifiantSIP
            // 
            this.textBoxIdentifiantSIP.Location = new System.Drawing.Point(119, 32);
            this.textBoxIdentifiantSIP.Name = "textBoxIdentifiantSIP";
            this.textBoxIdentifiantSIP.Size = new System.Drawing.Size(192, 20);
            this.textBoxIdentifiantSIP.TabIndex = 1;
            // 
            // labelIdentifiantSIP
            // 
            this.labelIdentifiantSIP.AutoSize = true;
            this.labelIdentifiantSIP.Location = new System.Drawing.Point(17, 32);
            this.labelIdentifiantSIP.Name = "labelIdentifiantSIP";
            this.labelIdentifiantSIP.Size = new System.Drawing.Size(73, 13);
            this.labelIdentifiantSIP.TabIndex = 0;
            this.labelIdentifiantSIP.Text = "Identifiant SIP";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 366);
            this.Controls.Add(this.groupBoxSIP);
            this.Controls.Add(this.groupBoxAddClient);
            this.Controls.Add(this.buttonSave);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.groupBoxAddClient.ResumeLayout(false);
            this.groupBoxAddClient.PerformLayout();
            this.groupBoxSIP.ResumeLayout(false);
            this.groupBoxSIP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddClient;
        private System.Windows.Forms.ListBox listBoxSexe;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDeNaissance;
        private System.Windows.Forms.TextBox textBoxLieuDeNaissance;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumeroSS;
        private System.Windows.Forms.TextBox textBoxNumeroTel;
        private System.Windows.Forms.TextBox textBoxAdresseMail;
        private System.Windows.Forms.GroupBox groupBoxSIP;
        private System.Windows.Forms.Label labelMotDePasseSIP;
        private System.Windows.Forms.TextBox textBoxIdentifiantSIP;
        private System.Windows.Forms.Label labelIdentifiantSIP;
        private System.Windows.Forms.TextBox textBoxMotDePasseSIP;
    }
}