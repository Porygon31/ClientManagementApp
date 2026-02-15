namespace ClientManagementApp
{
    partial class AideForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.richTextBoxAide = new System.Windows.Forms.RichTextBox();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // richTextBoxAide
            //
            this.richTextBoxAide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxAide.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxAide.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.richTextBoxAide.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxAide.Name = "richTextBoxAide";
            this.richTextBoxAide.ReadOnly = true;
            this.richTextBoxAide.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxAide.Size = new System.Drawing.Size(660, 470);
            this.richTextBoxAide.TabIndex = 0;
            this.richTextBoxAide.Text = "";
            //
            // buttonFermer
            //
            this.buttonFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFermer.Location = new System.Drawing.Point(572, 495);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(100, 30);
            this.buttonFermer.TabIndex = 1;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            //
            // AideForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 537);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.richTextBoxAide);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "AideForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aide - Gestionnaire de clientèle";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAide;
        private System.Windows.Forms.Button buttonFermer;
    }
}
