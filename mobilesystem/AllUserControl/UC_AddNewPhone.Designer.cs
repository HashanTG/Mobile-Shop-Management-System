namespace mobilesystem.AllUserControl
{
    partial class UC_AddNewPhone
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInternal = new System.Windows.Forms.ComboBox();
            this.txtExpandable = new System.Windows.Forms.ComboBox();
            this.txtDisplay = new System.Windows.Forms.ComboBox();
            this.txtRear = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFront = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFingerprint = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSim = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNetwork = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW PHONE RECORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCompany.Location = new System.Drawing.Point(88, 130);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(422, 28);
            this.txtCompany.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ram";
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModel.Location = new System.Drawing.Point(88, 207);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(422, 28);
            this.txtModel.TabIndex = 6;
            this.txtModel.TextChanged += new System.EventHandler(this.txtModel_TextChanged);
            // 
            // txtRam
            // 
            this.txtRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRam.FormattingEnabled = true;
            this.txtRam.Items.AddRange(new object[] {
            "1 GB",
            "2 GB",
            "3 GB",
            "4 GB",
            "8 GB",
            "16 GB"});
            this.txtRam.Location = new System.Drawing.Point(88, 286);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(422, 30);
            this.txtRam.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Internal Storage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Expandable Memory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Display";
            // 
            // txtInternal
            // 
            this.txtInternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInternal.FormattingEnabled = true;
            this.txtInternal.Items.AddRange(new object[] {
            "4 GB",
            "8 GB",
            "16 GB",
            "32 GB",
            "64 GB"});
            this.txtInternal.Location = new System.Drawing.Point(88, 365);
            this.txtInternal.Name = "txtInternal";
            this.txtInternal.Size = new System.Drawing.Size(422, 30);
            this.txtInternal.TabIndex = 11;
            // 
            // txtExpandable
            // 
            this.txtExpandable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpandable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExpandable.FormattingEnabled = true;
            this.txtExpandable.Items.AddRange(new object[] {
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB"});
            this.txtExpandable.Location = new System.Drawing.Point(88, 452);
            this.txtExpandable.Name = "txtExpandable";
            this.txtExpandable.Size = new System.Drawing.Size(422, 30);
            this.txtExpandable.TabIndex = 12;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDisplay.FormattingEnabled = true;
            this.txtDisplay.Items.AddRange(new object[] {
            "5.0 inch",
            "5.5 inch",
            "6.0 inch"});
            this.txtDisplay.Location = new System.Drawing.Point(88, 532);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(422, 30);
            this.txtDisplay.TabIndex = 13;
            // 
            // txtRear
            // 
            this.txtRear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRear.FormattingEnabled = true;
            this.txtRear.Items.AddRange(new object[] {
            "5MP",
            "8 MP",
            "10 MP",
            "11 MP",
            "12 MP",
            "13 MP",
            "15 MP",
            "17 MP",
            "20 MP"});
            this.txtRear.Location = new System.Drawing.Point(625, 130);
            this.txtRear.Name = "txtRear";
            this.txtRear.Size = new System.Drawing.Size(422, 30);
            this.txtRear.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rear Camera";
            // 
            // txtFront
            // 
            this.txtFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFront.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFront.FormattingEnabled = true;
            this.txtFront.Items.AddRange(new object[] {
            "2 MP",
            "3 MP",
            "5 MP",
            "8 MP",
            "10 MP",
            "20 MP",
            "24 MP",
            "30 MP"});
            this.txtFront.Location = new System.Drawing.Point(625, 214);
            this.txtFront.Name = "txtFront";
            this.txtFront.Size = new System.Drawing.Size(422, 30);
            this.txtFront.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(621, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Front Camera";
            // 
            // txtFingerprint
            // 
            this.txtFingerprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFingerprint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFingerprint.FormattingEnabled = true;
            this.txtFingerprint.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.txtFingerprint.Location = new System.Drawing.Point(625, 289);
            this.txtFingerprint.Name = "txtFingerprint";
            this.txtFingerprint.Size = new System.Drawing.Size(422, 30);
            this.txtFingerprint.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(621, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fingerprint Sensor";
            // 
            // txtSim
            // 
            this.txtSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSim.FormattingEnabled = true;
            this.txtSim.Items.AddRange(new object[] {
            "One Sim",
            "Dual Sim",
            "Triple Sim"});
            this.txtSim.Location = new System.Drawing.Point(625, 365);
            this.txtSim.Name = "txtSim";
            this.txtSim.Size = new System.Drawing.Size(422, 30);
            this.txtSim.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(621, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sim Type";
            // 
            // txtNetwork
            // 
            this.txtNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNetwork.FormattingEnabled = true;
            this.txtNetwork.Items.AddRange(new object[] {
            "2G ",
            "2G , 3G",
            "2G , 3G & 4G VOLT"});
            this.txtNetwork.Location = new System.Drawing.Point(625, 439);
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.Size = new System.Drawing.Size(422, 30);
            this.txtNetwork.TabIndex = 23;
            this.txtNetwork.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(621, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 22);
            this.label12.TabIndex = 22;
            this.label12.Text = "Network Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1106, 1081);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 22);
            this.label13.TabIndex = 26;
            this.label13.Text = "Network Type";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(625, 525);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(422, 28);
            this.txtPrice.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(621, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = "Price";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::mobilesystem.Properties.Resources.reset21;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(915, 588);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(181, 40);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::mobilesystem.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(722, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 40);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mobilesystem.Properties.Resources.new_phone_record3;
            this.pictureBox1.Location = new System.Drawing.Point(59, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 81);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UC_AddNewPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNetwork);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFingerprint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFront);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtExpandable);
            this.Controls.Add(this.txtInternal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddNewPhone";
            this.Size = new System.Drawing.Size(1162, 735);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox txtRam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtInternal;
        private System.Windows.Forms.ComboBox txtExpandable;
        private System.Windows.Forms.ComboBox txtDisplay;
        private System.Windows.Forms.ComboBox txtRear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtFront;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtFingerprint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtSim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtNetwork;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
    }
}
