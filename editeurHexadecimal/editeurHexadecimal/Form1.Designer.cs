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
            this.tctrlData = new System.Windows.Forms.TabControl();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.lblShortName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAttribute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblModifyOn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastAccess = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpBite = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tctrlData.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(351, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(437, 373);
            this.dataGridView.TabIndex = 3;
            // 
            // tctrlData
            // 
            this.tctrlData.Controls.Add(this.tpFile);
            this.tctrlData.Controls.Add(this.tpBite);
            this.tctrlData.Location = new System.Drawing.Point(12, 12);
            this.tctrlData.Name = "tctrlData";
            this.tctrlData.SelectedIndex = 0;
            this.tctrlData.Size = new System.Drawing.Size(297, 399);
            this.tctrlData.TabIndex = 7;
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.lblShortName);
            this.tpFile.Controls.Add(this.label7);
            this.tpFile.Controls.Add(this.lblAttribute);
            this.tpFile.Controls.Add(this.label6);
            this.tpFile.Controls.Add(this.lblModifyOn);
            this.tpFile.Controls.Add(this.label5);
            this.tpFile.Controls.Add(this.lblLastAccess);
            this.tpFile.Controls.Add(this.label4);
            this.tpFile.Controls.Add(this.lblCreatedDate);
            this.tpFile.Controls.Add(this.label2);
            this.tpFile.Controls.Add(this.lblSize);
            this.tpFile.Controls.Add(this.label3);
            this.tpFile.Controls.Add(this.lblName);
            this.tpFile.Controls.Add(this.label1);
            this.tpFile.Location = new System.Drawing.Point(4, 22);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(289, 373);
            this.tpFile.TabIndex = 0;
            this.tpFile.Text = "Détails Fichier";
            this.tpFile.UseVisualStyleBackColor = true;
            this.tpFile.Click += new System.EventHandler(this.tpFile_Click);
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Location = new System.Drawing.Point(7, 73);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(16, 13);
            this.lblShortName.TabIndex = 13;
            this.lblShortName.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nom court :";
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Location = new System.Drawing.Point(10, 325);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(16, 13);
            this.lblAttribute.TabIndex = 11;
            this.lblAttribute.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Attributs :";
            // 
            // lblModifyOn
            // 
            this.lblModifyOn.AutoSize = true;
            this.lblModifyOn.Location = new System.Drawing.Point(11, 283);
            this.lblModifyOn.Name = "lblModifyOn";
            this.lblModifyOn.Size = new System.Drawing.Size(16, 13);
            this.lblModifyOn.TabIndex = 9;
            this.lblModifyOn.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modifié le :";
            // 
            // lblLastAccess
            // 
            this.lblLastAccess.AutoSize = true;
            this.lblLastAccess.Location = new System.Drawing.Point(11, 230);
            this.lblLastAccess.Name = "lblLastAccess";
            this.lblLastAccess.Size = new System.Drawing.Size(16, 13);
            this.lblLastAccess.TabIndex = 7;
            this.lblLastAccess.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dernier accès le :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(14, 178);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(16, 13);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Créé le :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(11, 120);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(16, 13);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taille :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // tpBite
            // 
            this.tpBite.Location = new System.Drawing.Point(4, 22);
            this.tpBite.Name = "tpBite";
            this.tpBite.Padding = new System.Windows.Forms.Padding(3);
            this.tpBite.Size = new System.Drawing.Size(289, 373);
            this.tpBite.TabIndex = 1;
            this.tpBite.Text = "Détails Octet";
            this.tpBite.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 646);
            this.Controls.Add(this.tctrlData);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tctrlData.ResumeLayout(false);
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tctrlData;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpBite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModifyOn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLastAccess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShortName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAttribute;
    }
}

