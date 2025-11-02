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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchClientByName = new System.Windows.Forms.Button();
            this.textBoxSearchClientByName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearchEntrepriseByCientName = new System.Windows.Forms.Button();
            this.textBoxSearchEntrepriseByClientName = new System.Windows.Forms.TextBox();
            this.labelSearchEntrepriseByClientName = new System.Windows.Forms.Label();
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
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewClients.Location = new System.Drawing.Point(27, 23);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewClients.Size = new System.Drawing.Size(1775, 412);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellClick);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClient.Location = new System.Drawing.Point(1908, 290);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(159, 28);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Ajouter Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditClient.Location = new System.Drawing.Point(1908, 337);
            this.buttonEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(159, 28);
            this.buttonEditClient.TabIndex = 2;
            this.buttonEditClient.Text = "Modifier Client";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteClient.Location = new System.Drawing.Point(1908, 386);
            this.buttonDeleteClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(159, 28);
            this.buttonDeleteClient.TabIndex = 3;
            this.buttonDeleteClient.Text = "Supprimer Client";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSearchClientByName);
            this.groupBox1.Controls.Add(this.textBoxSearchClientByName);
            this.groupBox1.Controls.Add(this.buttonDeleteClient);
            this.groupBox1.Controls.Add(this.buttonEditClient);
            this.groupBox1.Controls.Add(this.buttonAddClient);
            this.groupBox1.Controls.Add(this.dataGridViewClients);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1907, 482);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1868, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chercher un client par Nom :";
            // 
            // buttonSearchClientByName
            // 
            this.buttonSearchClientByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchClientByName.Location = new System.Drawing.Point(1925, 111);
            this.buttonSearchClientByName.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchClientByName.Name = "buttonSearchClientByName";
            this.buttonSearchClientByName.Size = new System.Drawing.Size(104, 36);
            this.buttonSearchClientByName.TabIndex = 5;
            this.buttonSearchClientByName.Text = "Rechercher";
            this.buttonSearchClientByName.UseVisualStyleBackColor = true;
            this.buttonSearchClientByName.Click += new System.EventHandler(this.buttonSearchClientByName_Click);
            // 
            // textBoxSearchClientByName
            // 
            this.textBoxSearchClientByName.Location = new System.Drawing.Point(1873, 68);
            this.textBoxSearchClientByName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchClientByName.Name = "textBoxSearchClientByName";
            this.textBoxSearchClientByName.Size = new System.Drawing.Size(224, 22);
            this.textBoxSearchClientByName.TabIndex = 4;
            this.textBoxSearchClientByName.TextChanged += new System.EventHandler(this.textBoxSearchClientByName_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearchEntrepriseByCientName);
            this.groupBox2.Controls.Add(this.textBoxSearchEntrepriseByClientName);
            this.groupBox2.Controls.Add(this.labelSearchEntrepriseByClientName);
            this.groupBox2.Controls.Add(this.buttonDeleteEntreprise);
            this.groupBox2.Controls.Add(this.buttonEditEntreprise);
            this.groupBox2.Controls.Add(this.buttonAddEntreprise);
            this.groupBox2.Controls.Add(this.dataGridViewEntreprises);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 495);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(2107, 507);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entreprises";
            // 
            // buttonSearchEntrepriseByCientName
            // 
            this.buttonSearchEntrepriseByCientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchEntrepriseByCientName.Location = new System.Drawing.Point(1917, 101);
            this.buttonSearchEntrepriseByCientName.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchEntrepriseByCientName.Name = "buttonSearchEntrepriseByCientName";
            this.buttonSearchEntrepriseByCientName.Size = new System.Drawing.Size(148, 32);
            this.buttonSearchEntrepriseByCientName.TabIndex = 6;
            this.buttonSearchEntrepriseByCientName.Text = "Rechercher";
            this.buttonSearchEntrepriseByCientName.UseVisualStyleBackColor = true;
            this.buttonSearchEntrepriseByCientName.Click += new System.EventHandler(this.buttonSearchEntrepriseByClientName_Click);
            // 
            // textBoxSearchEntrepriseByClientName
            // 
            this.textBoxSearchEntrepriseByClientName.Location = new System.Drawing.Point(1892, 53);
            this.textBoxSearchEntrepriseByClientName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchEntrepriseByClientName.Name = "textBoxSearchEntrepriseByClientName";
            this.textBoxSearchEntrepriseByClientName.Size = new System.Drawing.Size(203, 23);
            this.textBoxSearchEntrepriseByClientName.TabIndex = 5;
            // 
            // labelSearchEntrepriseByClientName
            // 
            this.labelSearchEntrepriseByClientName.AutoSize = true;
            this.labelSearchEntrepriseByClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchEntrepriseByClientName.Location = new System.Drawing.Point(1889, 21);
            this.labelSearchEntrepriseByClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchEntrepriseByClientName.Name = "labelSearchEntrepriseByClientName";
            this.labelSearchEntrepriseByClientName.Size = new System.Drawing.Size(201, 17);
            this.labelSearchEntrepriseByClientName.TabIndex = 4;
            this.labelSearchEntrepriseByClientName.Text = "Entreprise par nom client :";
            // 
            // buttonDeleteEntreprise
            // 
            this.buttonDeleteEntreprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEntreprise.Location = new System.Drawing.Point(1908, 298);
            this.buttonDeleteEntreprise.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteEntreprise.Name = "buttonDeleteEntreprise";
            this.buttonDeleteEntreprise.Size = new System.Drawing.Size(191, 27);
            this.buttonDeleteEntreprise.TabIndex = 3;
            this.buttonDeleteEntreprise.Text = "Supprimer une Entreprise";
            this.buttonDeleteEntreprise.UseVisualStyleBackColor = true;
            this.buttonDeleteEntreprise.Click += new System.EventHandler(this.buttonDeleteEntreprise_Click);
            // 
            // buttonEditEntreprise
            // 
            this.buttonEditEntreprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditEntreprise.Location = new System.Drawing.Point(1908, 260);
            this.buttonEditEntreprise.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditEntreprise.Name = "buttonEditEntreprise";
            this.buttonEditEntreprise.Size = new System.Drawing.Size(191, 26);
            this.buttonEditEntreprise.TabIndex = 2;
            this.buttonEditEntreprise.Text = "Editer une Entreprise";
            this.buttonEditEntreprise.UseVisualStyleBackColor = true;
            this.buttonEditEntreprise.Click += new System.EventHandler(this.buttonEditEntreprise_Click);
            // 
            // buttonAddEntreprise
            // 
            this.buttonAddEntreprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEntreprise.Location = new System.Drawing.Point(1908, 219);
            this.buttonAddEntreprise.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddEntreprise.Name = "buttonAddEntreprise";
            this.buttonAddEntreprise.Size = new System.Drawing.Size(191, 28);
            this.buttonAddEntreprise.TabIndex = 1;
            this.buttonAddEntreprise.Text = "Ajouter une Entreprise";
            this.buttonAddEntreprise.UseVisualStyleBackColor = true;
            this.buttonAddEntreprise.Click += new System.EventHandler(this.buttonAddEntreprise_Click);
            // 
            // dataGridViewEntreprises
            // 
            this.dataGridViewEntreprises.AllowUserToAddRows = false;
            this.dataGridViewEntreprises.AllowUserToDeleteRows = false;
            this.dataGridViewEntreprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntreprises.Location = new System.Drawing.Point(33, 23);
            this.dataGridViewEntreprises.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEntreprises.MultiSelect = false;
            this.dataGridViewEntreprises.Name = "dataGridViewEntreprises";
            this.dataGridViewEntreprises.RowHeadersWidth = 51;
            this.dataGridViewEntreprises.Size = new System.Drawing.Size(1847, 427);
            this.dataGridViewEntreprises.TabIndex = 0;
            this.dataGridViewEntreprises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntreprises_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gestionnaire de clientèle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntreprises)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxSearchClientByName;
        private System.Windows.Forms.Button buttonSearchClientByName;

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
        private System.Windows.Forms.Label labelSearchEntrepriseByClientName;
        private System.Windows.Forms.TextBox textBoxSearchEntrepriseByClientName;
        private System.Windows.Forms.Button buttonSearchEntrepriseByCientName;
    }
}

