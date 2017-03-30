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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hexaGridView = new System.Windows.Forms.DataGridView();
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
            this.lbl64BitsSigned = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
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
            this.asciiGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hexaGridView)).BeginInit();
            this.tctrlData.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.tpBite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asciiGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hexaGridView
            // 
            this.hexaGridView.AllowUserToAddRows = false;
            this.hexaGridView.AllowUserToResizeColumns = false;
            this.hexaGridView.AllowUserToResizeRows = false;
            this.hexaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hexaGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.hexaGridView.Location = new System.Drawing.Point(411, 51);
            this.hexaGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hexaGridView.MultiSelect = false;
            this.hexaGridView.Name = "hexaGridView";
            this.hexaGridView.RowHeadersVisible = false;
            this.hexaGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hexaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.hexaGridView.Size = new System.Drawing.Size(642, 611);
            this.hexaGridView.TabIndex = 3;
            this.hexaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // tctrlData
            // 
            this.tctrlData.Controls.Add(this.tpFile);
            this.tctrlData.Controls.Add(this.tpBite);
            this.tctrlData.Location = new System.Drawing.Point(21, 17);
            this.tctrlData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tctrlData.Name = "tctrlData";
            this.tctrlData.SelectedIndex = 0;
            this.tctrlData.Size = new System.Drawing.Size(363, 645);
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
            this.tpFile.Location = new System.Drawing.Point(4, 29);
            this.tpFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpFile.Size = new System.Drawing.Size(355, 612);
            this.tpFile.TabIndex = 0;
            this.tpFile.Text = "Détails Fichier";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // lblShortName
            // 
            this.lblShortName.AutoSize = true;
            this.lblShortName.Location = new System.Drawing.Point(10, 112);
            this.lblShortName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortName.Name = "lblShortName";
            this.lblShortName.Size = new System.Drawing.Size(21, 20);
            this.lblShortName.TabIndex = 13;
            this.lblShortName.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nom court :";
            // 
            // lblAttribute
            // 
            this.lblAttribute.AutoSize = true;
            this.lblAttribute.Location = new System.Drawing.Point(15, 500);
            this.lblAttribute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttribute.Name = "lblAttribute";
            this.lblAttribute.Size = new System.Drawing.Size(21, 20);
            this.lblAttribute.TabIndex = 11;
            this.lblAttribute.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 474);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Attributs :";
            // 
            // lblModifyOn
            // 
            this.lblModifyOn.AutoSize = true;
            this.lblModifyOn.Location = new System.Drawing.Point(16, 435);
            this.lblModifyOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModifyOn.Name = "lblModifyOn";
            this.lblModifyOn.Size = new System.Drawing.Size(21, 20);
            this.lblModifyOn.TabIndex = 9;
            this.lblModifyOn.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modifié le :";
            // 
            // lblLastAccess
            // 
            this.lblLastAccess.AutoSize = true;
            this.lblLastAccess.Location = new System.Drawing.Point(16, 354);
            this.lblLastAccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastAccess.Name = "lblLastAccess";
            this.lblLastAccess.Size = new System.Drawing.Size(21, 20);
            this.lblLastAccess.TabIndex = 7;
            this.lblLastAccess.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dernier accès le :";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(21, 274);
            this.lblCreatedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(21, 20);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Créé le :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(16, 185);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(21, 20);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taille :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 37);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(21, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // tpBite
            // 
            this.tpBite.Controls.Add(this.lbl64BitsSigned);
            this.tpBite.Controls.Add(this.lbl11);
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
            this.tpBite.Location = new System.Drawing.Point(4, 29);
            this.tpBite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBite.Name = "tpBite";
            this.tpBite.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpBite.Size = new System.Drawing.Size(355, 612);
            this.tpBite.TabIndex = 1;
            this.tpBite.Text = "Détails Octet";
            this.tpBite.UseVisualStyleBackColor = true;
            // 
            // lbl64BitsSigned
            // 
            this.lbl64BitsSigned.AutoSize = true;
            this.lbl64BitsSigned.Location = new System.Drawing.Point(108, 448);
            this.lbl64BitsSigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl64BitsSigned.Name = "lbl64BitsSigned";
            this.lbl64BitsSigned.Size = new System.Drawing.Size(21, 20);
            this.lbl64BitsSigned.TabIndex = 25;
            this.lbl64BitsSigned.Text = "...";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(8, 448);
            this.lbl11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(86, 20);
            this.lbl11.TabIndex = 24;
            this.lbl11.Text = "64 bits (s) :";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(111, 531);
            this.lblDouble.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(21, 20);
            this.lblDouble.TabIndex = 23;
            this.lblDouble.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 531);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Double :";
            // 
            // lblFloat
            // 
            this.lblFloat.AutoSize = true;
            this.lblFloat.Location = new System.Drawing.Point(110, 492);
            this.lblFloat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFloat.Name = "lblFloat";
            this.lblFloat.Size = new System.Drawing.Size(21, 20);
            this.lblFloat.TabIndex = 21;
            this.lblFloat.Text = "...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 492);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 20;
            this.label18.Text = "Float :";
            // 
            // lbl32BitsNS
            // 
            this.lbl32BitsNS.AutoSize = true;
            this.lbl32BitsNS.Location = new System.Drawing.Point(108, 398);
            this.lbl32BitsNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl32BitsNS.Name = "lbl32BitsNS";
            this.lbl32BitsNS.Size = new System.Drawing.Size(21, 20);
            this.lbl32BitsNS.TabIndex = 19;
            this.lbl32BitsNS.Text = "...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 398);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 20);
            this.label20.TabIndex = 18;
            this.label20.Text = "32 bits (ns) :";
            // 
            // lbl32BitsSigned
            // 
            this.lbl32BitsSigned.AutoSize = true;
            this.lbl32BitsSigned.Location = new System.Drawing.Point(108, 346);
            this.lbl32BitsSigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl32BitsSigned.Name = "lbl32BitsSigned";
            this.lbl32BitsSigned.Size = new System.Drawing.Size(21, 20);
            this.lbl32BitsSigned.TabIndex = 17;
            this.lbl32BitsSigned.Text = "...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 346);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "32 bits (s) :";
            // 
            // lbl16BitsNS
            // 
            this.lbl16BitsNS.AutoSize = true;
            this.lbl16BitsNS.Location = new System.Drawing.Point(108, 292);
            this.lbl16BitsNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl16BitsNS.Name = "lbl16BitsNS";
            this.lbl16BitsNS.Size = new System.Drawing.Size(21, 20);
            this.lbl16BitsNS.TabIndex = 15;
            this.lbl16BitsNS.Text = "...";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 292);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "16 bits (ns) :";
            // 
            // lbl16BitSigned
            // 
            this.lbl16BitSigned.AutoSize = true;
            this.lbl16BitSigned.Location = new System.Drawing.Point(108, 245);
            this.lbl16BitSigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl16BitSigned.Name = "lbl16BitSigned";
            this.lbl16BitSigned.Size = new System.Drawing.Size(21, 20);
            this.lbl16BitSigned.TabIndex = 11;
            this.lbl16BitSigned.Text = "...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 245);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "16 bits (s) :";
            // 
            // lbl8BitsNS
            // 
            this.lbl8BitsNS.AutoSize = true;
            this.lbl8BitsNS.Location = new System.Drawing.Point(108, 198);
            this.lbl8BitsNS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8BitsNS.Name = "lbl8BitsNS";
            this.lbl8BitsNS.Size = new System.Drawing.Size(21, 20);
            this.lbl8BitsNS.TabIndex = 9;
            this.lbl8BitsNS.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 198);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "8 bits (ns) :";
            // 
            // lbl8BitsSigned
            // 
            this.lbl8BitsSigned.AutoSize = true;
            this.lbl8BitsSigned.Location = new System.Drawing.Point(108, 145);
            this.lbl8BitsSigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl8BitsSigned.Name = "lbl8BitsSigned";
            this.lbl8BitsSigned.Size = new System.Drawing.Size(21, 20);
            this.lbl8BitsSigned.TabIndex = 7;
            this.lbl8BitsSigned.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "8 bits (s) :";
            // 
            // lblOctal
            // 
            this.lblOctal.AutoSize = true;
            this.lblOctal.Location = new System.Drawing.Point(110, 95);
            this.lblOctal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOctal.Name = "lblOctal";
            this.lblOctal.Size = new System.Drawing.Size(21, 20);
            this.lblOctal.TabIndex = 5;
            this.lblOctal.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Octal :";
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Location = new System.Drawing.Point(110, 54);
            this.lblBinary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(21, 20);
            this.lblBinary.TabIndex = 3;
            this.lblBinary.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Binaire :";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(110, 11);
            this.lblChar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(21, 20);
            this.lblChar.TabIndex = 1;
            this.lblChar.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Caractère :";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(92, 686);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(183, 35);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "Ouvrir un fichier";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // asciiGridView
            // 
            this.asciiGridView.AllowUserToAddRows = false;
            this.asciiGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.asciiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.asciiGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.asciiGridView.Location = new System.Drawing.Point(1083, 51);
            this.asciiGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asciiGridView.MinimumSize = new System.Drawing.Size(484, 611);
            this.asciiGridView.Name = "asciiGridView";
            this.asciiGridView.Size = new System.Drawing.Size(484, 611);
            this.asciiGridView.TabIndex = 9;
            this.asciiGridView.VirtualMode = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 745);
            this.Controls.Add(this.asciiGridView);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tctrlData);
            this.Controls.Add(this.hexaGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1598, 773);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.hexaGridView)).EndInit();
            this.tctrlData.ResumeLayout(false);
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            this.tpBite.ResumeLayout(false);
            this.tpBite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asciiGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView hexaGridView;
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
        private System.Windows.Forms.DataGridView asciiGridView;
        private System.Windows.Forms.Label lbl64BitsSigned;
        private System.Windows.Forms.Label lbl11;
    }
}

