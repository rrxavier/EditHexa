namespace editeurHexadecimal {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnFileData = new System.Windows.Forms.Button();
            this.btnHexaData = new System.Windows.Forms.Button();
            this.detailedDataPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.detailedDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(351, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(437, 179);
            this.dataGridView.TabIndex = 3;
            // 
            // btnFileData
            // 
            this.btnFileData.Location = new System.Drawing.Point(3, 3);
            this.btnFileData.Name = "btnFileData";
            this.btnFileData.Size = new System.Drawing.Size(116, 23);
            this.btnFileData.TabIndex = 4;
            this.btnFileData.Text = "Infos sur le fichier";
            this.btnFileData.UseVisualStyleBackColor = true;
            // 
            // btnHexaData
            // 
            this.btnHexaData.Location = new System.Drawing.Point(125, 3);
            this.btnHexaData.Name = "btnHexaData";
            this.btnHexaData.Size = new System.Drawing.Size(99, 23);
            this.btnHexaData.TabIndex = 5;
            this.btnHexaData.Text = "Info sur l\'octet";
            this.btnHexaData.UseVisualStyleBackColor = true;
            // 
            // detailedDataPanel
            // 
            this.detailedDataPanel.Controls.Add(this.btnFileData);
            this.detailedDataPanel.Controls.Add(this.btnHexaData);
            this.detailedDataPanel.Location = new System.Drawing.Point(22, 78);
            this.detailedDataPanel.Name = "detailedDataPanel";
            this.detailedDataPanel.Size = new System.Drawing.Size(304, 314);
            this.detailedDataPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 646);
            this.Controls.Add(this.detailedDataPanel);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.detailedDataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnFileData;
        private System.Windows.Forms.Button btnHexaData;
        private System.Windows.Forms.Panel detailedDataPanel;
    }
}

