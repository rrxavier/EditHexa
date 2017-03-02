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
            this.lblDouble = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFloat = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl32BitsNS = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl32BitsSigned = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl16BitsNS = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl16BitSigned = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl8BitsNS = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl8BitsSigned = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblOctal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBinary = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tctrlData.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.tpBite.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(353, 33);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(437, 406);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.VirtualMode = true;
            // 
            // tctrlData
            // 
            this.tctrlData.Controls.Add(this.tpFile);
            this.tctrlData.Controls.Add(this.tpBite);
            this.tctrlData.Location = new System.Drawing.Point(14, 11);
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
            this.tpBite.Controls.Add(this.lblDouble);
            this.tpBite.Controls.Add(this.label15);
            this.tpBite.Controls.Add(this.lblFloat);
            this.tpBite.Controls.Add(this.label18);
            this.tpBite.Controls.Add(this.lbl32BitsNS);
            this.tpBite.Controls.Add(this.label20);
            this.tpBite.Controls.Add(this.lbl32BitsSigned);
            this.tpBite.Controls.Add(this.label22);
            this.tpBite.Controls.Add(this.lbl16BitsNS);
            this.tpBite.Controls.Add(this.label16);
            this.tpBite.Controls.Add(this.lbl16BitSigned);
            this.tpBite.Controls.Add(this.label14);
            this.tpBite.Controls.Add(this.lbl8BitsNS);
            this.tpBite.Controls.Add(this.label13);
            this.tpBite.Controls.Add(this.lbl8BitsSigned);
            this.tpBite.Controls.Add(this.label11);
            this.tpBite.Controls.Add(this.lblOctal);
            this.tpBite.Controls.Add(this.label10);
            this.tpBite.Controls.Add(this.lblBinary);
            this.tpBite.Controls.Add(this.label9);
            this.tpBite.Controls.Add(this.lblChar);
            this.tpBite.Controls.Add(this.label8);
            this.tpBite.Location = new System.Drawing.Point(4, 22);
            this.tpBite.Name = "tpBite";
            this.tpBite.Padding = new System.Windows.Forms.Padding(3);
            this.tpBite.Size = new System.Drawing.Size(289, 373);
            this.tpBite.TabIndex = 1;
            this.tpBite.Text = "Détails Octet";
            this.tpBite.UseVisualStyleBackColor = true;
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(74, 318);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(16, 13);
            this.lblDouble.TabIndex = 23;
            this.lblDouble.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Double :";
            // 
            // lblFloat
            // 
            this.lblFloat.AutoSize = true;
            this.lblFloat.Location = new System.Drawing.Point(73, 288);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(16, 13);
            this.lblFloat.TabIndex = 21;
            this.lblFloat.Text = "...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Float :";
            // 
            // lbl32BitsNS
            // 
            this.lbl32BitsNS.AutoSize = true;
            this.lbl32BitsNS.Location = new System.Drawing.Point(74, 260);
            this.lbl32BitsNS.Name = "lbl32BitsNS";
            this.lbl32BitsNS.Size = new System.Drawing.Size(16, 13);
            this.lbl32BitsNS.TabIndex = 19;
            this.lbl32BitsNS.Text = "...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 260);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "32 bits (ns) :";
            // 
            // lbl32BitsSigned
            // 
            this.lbl32BitsSigned.AutoSize = true;
            this.lbl32BitsSigned.Location = new System.Drawing.Point(74, 226);
            this.lbl32BitsSigned.Name = "lbl32BitsSigned";
            this.lbl32BitsSigned.Size = new System.Drawing.Size(16, 13);
            this.lbl32BitsSigned.TabIndex = 17;
            this.lbl32BitsSigned.Text = "...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 226);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "32 bits (s) :";
            // 
            // lbl16BitsNS
            // 
            this.lbl16BitsNS.AutoSize = true;
            this.lbl16BitsNS.Location = new System.Drawing.Point(72, 191);
            this.lbl16BitsNS.Name = "lbl16BitsNS";
            this.lbl16BitsNS.Size = new System.Drawing.Size(16, 13);
            this.lbl16BitsNS.TabIndex = 15;
            this.lbl16BitsNS.Text = "...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "16 bits (ns) :";
            // 
            // lbl16BitSigned
            // 
            this.lbl16BitSigned.AutoSize = true;
            this.lbl16BitSigned.Location = new System.Drawing.Point(72, 160);
            this.lbl16BitSigned.Name = "lbl16BitSigned";
            this.lbl16BitSigned.Size = new System.Drawing.Size(16, 13);
            this.lbl16BitSigned.TabIndex = 11;
            this.lbl16BitSigned.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "16 bits (s) :";
            // 
            // lbl8BitsNS
            // 
            this.lbl8BitsNS.AutoSize = true;
            this.lbl8BitsNS.Location = new System.Drawing.Point(72, 129);
            this.lbl8BitsNS.Name = "lbl8BitsNS";
            this.lbl8BitsNS.Size = new System.Drawing.Size(16, 13);
            this.lbl8BitsNS.TabIndex = 9;
            this.lbl8BitsNS.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "8 bits (ns) :";
            // 
            // lbl8BitsSigned
            // 
            this.lbl8BitsSigned.AutoSize = true;
            this.lbl8BitsSigned.Location = new System.Drawing.Point(72, 94);
            this.lbl8BitsSigned.Name = "lbl8BitsSigned";
            this.lbl8BitsSigned.Size = new System.Drawing.Size(16, 13);
            this.lbl8BitsSigned.TabIndex = 7;
            this.lbl8BitsSigned.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "8 bits (s) :";
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(73, 62);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(16, 13);
            this.lblOctal.TabIndex = 5;
            this.lblOctal.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Octal :";
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(73, 35);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(16, 13);
            this.lblBinary.TabIndex = 3;
            this.lblBinary.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Binaire :";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(73, 7);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(16, 13);
            this.lblChar.TabIndex = 1;
            this.lblChar.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Caractère :";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(81, 416);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(122, 23);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "Ouvrir un fichier";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 646);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tctrlData);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tctrlData.ResumeLayout(false);
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            this.tpBite.ResumeLayout(false);
            this.tpBite.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFloat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl32BitsNS;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbl32BitsSigned;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl16BitsNS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl16BitSigned;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl8BitsNS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl8BitsSigned;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOctal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label label9;
    }
}

