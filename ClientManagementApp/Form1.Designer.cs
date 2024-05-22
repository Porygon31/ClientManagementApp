namespace ClientManagementApp
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteEntreprise = new System.Windows.Forms.Button();
            this.buttonEditEntreprise = new System.Windows.Forms.Button();
            this.buttonAddEntreprise = new System.Windows.Forms.Button();
            this.dataGridViewEntreprises = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntreprises)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(20, 18);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(440, 262);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellClick);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(485, 45);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(119, 23);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Ajouter Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Location = new System.Drawing.Point(485, 83);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(119, 23);
            this.buttonEditClient.TabIndex = 2;
            this.buttonEditClient.Text = "Modifier Client";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(485, 122);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(119, 23);
            this.buttonDeleteClient.TabIndex = 3;
            this.buttonDeleteClient.Text = "Supprimer Client";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteClient);
            this.groupBox1.Controls.Add(this.buttonEditClient);
            this.groupBox1.Controls.Add(this.buttonAddClient);
            this.groupBox1.Controls.Add(this.dataGridViewClients);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteEntreprise);
            this.groupBox2.Controls.Add(this.buttonEditEntreprise);
            this.groupBox2.Controls.Add(this.buttonAddEntreprise);
            this.groupBox2.Controls.Add(this.dataGridViewEntreprises);
            this.groupBox2.Location = new System.Drawing.Point(658, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 371);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entreprises";
            // 
            // buttonDeleteEntreprise
            // 
            this.buttonDeleteEntreprise.Location = new System.Drawing.Point(331, 332);
            this.buttonDeleteEntreprise.Name = "buttonDeleteEntreprise";
            this.buttonDeleteEntreprise.Size = new System.Drawing.Size(138, 22);
            this.buttonDeleteEntreprise.TabIndex = 3;
            this.buttonDeleteEntreprise.Text = "Supprimer une Entreprise";
            this.buttonDeleteEntreprise.UseVisualStyleBackColor = true;
            this.buttonDeleteEntreprise.Click += new System.EventHandler(this.buttonDeleteEntreprise_Click);
            // 
            // buttonEditEntreprise
            // 
            this.buttonEditEntreprise.Location = new System.Drawing.Point(171, 333);
            this.buttonEditEntreprise.Name = "buttonEditEntreprise";
            this.buttonEditEntreprise.Size = new System.Drawing.Size(117, 21);
            this.buttonEditEntreprise.TabIndex = 2;
            this.buttonEditEntreprise.Text = "Editer une Entreprise";
            this.buttonEditEntreprise.UseVisualStyleBackColor = true;
            this.buttonEditEntreprise.Click += new System.EventHandler(this.buttonEditEntreprise_Click);
            // 
            // buttonAddEntreprise
            // 
            this.buttonAddEntreprise.Location = new System.Drawing.Point(25, 332);
            this.buttonAddEntreprise.Name = "buttonAddEntreprise";
            this.buttonAddEntreprise.Size = new System.Drawing.Size(124, 23);
            this.buttonAddEntreprise.TabIndex = 1;
            this.buttonAddEntreprise.Text = "Ajouter une Entreprise";
            this.buttonAddEntreprise.UseVisualStyleBackColor = true;
            this.buttonAddEntreprise.Click += new System.EventHandler(this.buttonAddEntreprise_Click);
            // 
            // dataGridViewEntreprises
            // 
            this.dataGridViewEntreprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntreprises.Location = new System.Drawing.Point(25, 19);
            this.dataGridViewEntreprises.Name = "dataGridViewEntreprises";
            this.dataGridViewEntreprises.Size = new System.Drawing.Size(477, 291);
            this.dataGridViewEntreprises.TabIndex = 0;
            this.dataGridViewEntreprises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntreprises_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntreprises)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewEntreprises;
        private System.Windows.Forms.Button buttonDeleteEntreprise;
        private System.Windows.Forms.Button buttonEditEntreprise;
        private System.Windows.Forms.Button buttonAddEntreprise;
    }
}

