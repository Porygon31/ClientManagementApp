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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
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
            this.dataGridViewClients.Location = new System.Drawing.Point(20, 19);
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
            this.dataGridViewClients.Size = new System.Drawing.Size(1375, 335);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellClick);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClient.Location = new System.Drawing.Point(1431, 236);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(119, 23);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Ajouter Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditClient.Location = new System.Drawing.Point(1431, 274);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(119, 23);
            this.buttonEditClient.TabIndex = 2;
            this.buttonEditClient.Text = "Modifier Client";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.buttonEditClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteClient.Location = new System.Drawing.Point(1431, 314);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(119, 23);
            this.buttonDeleteClient.TabIndex = 3;
            this.buttonDeleteClient.Text = "Supprimer Client";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.buttonDeleteClient);
            this.groupBox1.Controls.Add(this.buttonEditClient);
            this.groupBox1.Controls.Add(this.buttonAddClient);
            this.groupBox1.Controls.Add(this.dataGridViewClients);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1580, 392);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1401, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cherchre un client par Nom :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(1437, 92);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(78, 29);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(1421, 66);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(109, 20);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteEntreprise);
            this.groupBox2.Controls.Add(this.buttonEditEntreprise);
            this.groupBox2.Controls.Add(this.buttonAddEntreprise);
            this.groupBox2.Controls.Add(this.dataGridViewEntreprises);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1580, 412);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entreprises";
            // 
            // buttonDeleteEntreprise
            // 
            this.buttonDeleteEntreprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteEntreprise.Location = new System.Drawing.Point(1431, 242);
            this.buttonDeleteEntreprise.Name = "buttonDeleteEntreprise";
            this.buttonDeleteEntreprise.Size = new System.Drawing.Size(143, 22);
            this.buttonDeleteEntreprise.TabIndex = 3;
            this.buttonDeleteEntreprise.Text = "Supprimer une Entreprise";
            this.buttonDeleteEntreprise.UseVisualStyleBackColor = true;
            this.buttonDeleteEntreprise.Click += new System.EventHandler(this.buttonDeleteEntreprise_Click);
            // 
            // buttonEditEntreprise
            // 
            this.buttonEditEntreprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditEntreprise.Location = new System.Drawing.Point(1431, 211);
            this.buttonEditEntreprise.Name = "buttonEditEntreprise";
            this.buttonEditEntreprise.Size = new System.Drawing.Size(143, 21);
            this.buttonEditEntreprise.TabIndex = 2;
            this.buttonEditEntreprise.Text = "Editer une Entreprise";
            this.buttonEditEntreprise.UseVisualStyleBackColor = true;
            this.buttonEditEntreprise.Click += new System.EventHandler(this.buttonEditEntreprise_Click);
            // 
            // buttonAddEntreprise
            // 
            this.buttonAddEntreprise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEntreprise.Location = new System.Drawing.Point(1431, 178);
            this.buttonAddEntreprise.Name = "buttonAddEntreprise";
            this.buttonAddEntreprise.Size = new System.Drawing.Size(143, 23);
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
            this.dataGridViewEntreprises.Location = new System.Drawing.Point(25, 19);
            this.dataGridViewEntreprises.MultiSelect = false;
            this.dataGridViewEntreprises.Name = "dataGridViewEntreprises";
            this.dataGridViewEntreprises.Size = new System.Drawing.Size(1385, 347);
            this.dataGridViewEntreprises.TabIndex = 0;
            this.dataGridViewEntreprises.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEntreprises_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 828);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestionnaire de clientèle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntreprises)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;

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

