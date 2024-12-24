namespace mobilesystem
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_DeletePhoneRecord1 = new mobilesystem.AllUserControl.UC_DeletePhoneRecord();
            this.uC_CustomerRecords1 = new mobilesystem.AllUserControl.UC_CustomerRecords();
            this.uC_Stock1 = new mobilesystem.AllUserControl.UC_Stock();
            this.uC_Customer1 = new mobilesystem.AllUserControl.UC_Customer();
            this.uC_AddNewPhone1 = new mobilesystem.AllUserControl.UC_AddNewPhone();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCRecords = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnAddNewPhone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.uC_Login1 = new mobilesystem.AllUserControl.UC_Login();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnDeletePhone);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnCRecords);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnAddNewPhone);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 724);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(199, 664);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Black;
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(40, 664);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(149, 40);
            this.btnVerify.TabIndex = 8;
            this.btnVerify.Text = "Verify\r\n";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(40, 630);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(308, 30);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.uC_Login1);
            this.panel2.Controls.Add(this.uC_DeletePhoneRecord1);
            this.panel2.Controls.Add(this.uC_CustomerRecords1);
            this.panel2.Controls.Add(this.uC_Stock1);
            this.panel2.Controls.Add(this.uC_Customer1);
            this.panel2.Controls.Add(this.uC_AddNewPhone1);
            this.panel2.Location = new System.Drawing.Point(397, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 724);
            this.panel2.TabIndex = 1;
            // 
            // uC_DeletePhoneRecord1
            // 
            this.uC_DeletePhoneRecord1.BackColor = System.Drawing.Color.White;
            this.uC_DeletePhoneRecord1.Location = new System.Drawing.Point(0, 0);
            this.uC_DeletePhoneRecord1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_DeletePhoneRecord1.Name = "uC_DeletePhoneRecord1";
            this.uC_DeletePhoneRecord1.Size = new System.Drawing.Size(1252, 832);
            this.uC_DeletePhoneRecord1.TabIndex = 4;
            // 
            // uC_CustomerRecords1
            // 
            this.uC_CustomerRecords1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRecords1.Location = new System.Drawing.Point(2, 0);
            this.uC_CustomerRecords1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_CustomerRecords1.Name = "uC_CustomerRecords1";
            this.uC_CustomerRecords1.Size = new System.Drawing.Size(1252, 832);
            this.uC_CustomerRecords1.TabIndex = 3;
            // 
            // uC_Stock1
            // 
            this.uC_Stock1.BackColor = System.Drawing.Color.White;
            this.uC_Stock1.Location = new System.Drawing.Point(0, 0);
            this.uC_Stock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Stock1.Name = "uC_Stock1";
            this.uC_Stock1.Size = new System.Drawing.Size(1188, 785);
            this.uC_Stock1.TabIndex = 2;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.White;
            this.uC_Customer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Customer1.Location = new System.Drawing.Point(0, 0);
            this.uC_Customer1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1157, 796);
            this.uC_Customer1.TabIndex = 1;
            // 
            // uC_AddNewPhone1
            // 
            this.uC_AddNewPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_AddNewPhone1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewPhone1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_AddNewPhone1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddNewPhone1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_AddNewPhone1.Name = "uC_AddNewPhone1";
            this.uC_AddNewPhone1.Size = new System.Drawing.Size(1275, 750);
            this.uC_AddNewPhone1.TabIndex = 0;
            this.uC_AddNewPhone1.Load += new System.EventHandler(this.uC_AddNewPhone1_Load);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Image = global::mobilesystem.Properties.Resources.minimize_icon_3;
            this.btnMinimize.Location = new System.Drawing.Point(40, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 32);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.BackColor = System.Drawing.Color.Gray;
            this.btnDeletePhone.FlatAppearance.BorderSize = 0;
            this.btnDeletePhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDeletePhone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDeletePhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePhone.ForeColor = System.Drawing.Color.White;
            this.btnDeletePhone.Image = global::mobilesystem.Properties.Resources.filled_trash;
            this.btnDeletePhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePhone.Location = new System.Drawing.Point(30, 535);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(329, 80);
            this.btnDeletePhone.TabIndex = 5;
            this.btnDeletePhone.Text = "Delete Phone Record";
            this.btnDeletePhone.UseVisualStyleBackColor = false;
            this.btnDeletePhone.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::mobilesystem.Properties.Resources.customer1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(30, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(329, 79);
            this.button4.TabIndex = 4;
            this.button4.Text = "Customers";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCRecords
            // 
            this.btnCRecords.BackColor = System.Drawing.Color.Gray;
            this.btnCRecords.FlatAppearance.BorderSize = 0;
            this.btnCRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCRecords.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCRecords.ForeColor = System.Drawing.Color.White;
            this.btnCRecords.Image = global::mobilesystem.Properties.Resources.customer_record;
            this.btnCRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRecords.Location = new System.Drawing.Point(30, 419);
            this.btnCRecords.Name = "btnCRecords";
            this.btnCRecords.Size = new System.Drawing.Size(329, 79);
            this.btnCRecords.TabIndex = 3;
            this.btnCRecords.Text = "Customer Records";
            this.btnCRecords.UseVisualStyleBackColor = false;
            this.btnCRecords.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.Gray;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = global::mobilesystem.Properties.Resources.stock;
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(30, 309);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(329, 79);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddNewPhone
            // 
            this.btnAddNewPhone.BackColor = System.Drawing.Color.Gray;
            this.btnAddNewPhone.FlatAppearance.BorderSize = 0;
            this.btnAddNewPhone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddNewPhone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnAddNewPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPhone.Image = global::mobilesystem.Properties.Resources.add_new_phone2;
            this.btnAddNewPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPhone.Location = new System.Drawing.Point(30, 88);
            this.btnAddNewPhone.Name = "btnAddNewPhone";
            this.btnAddNewPhone.Size = new System.Drawing.Size(329, 79);
            this.btnAddNewPhone.TabIndex = 1;
            this.btnAddNewPhone.Text = "Add New Phone";
            this.btnAddNewPhone.UseVisualStyleBackColor = false;
            this.btnAddNewPhone.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::mobilesystem.Properties.Resources.close1;
            this.btnExit.Location = new System.Drawing.Point(4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // uC_Login1
            // 
            this.uC_Login1.BackColor = System.Drawing.Color.Navy;
            this.uC_Login1.Location = new System.Drawing.Point(0, 0);
            this.uC_Login1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(1253, 832);
            this.uC_Login1.TabIndex = 5;
            this.uC_Login1.VisibleChanged += new System.EventHandler(this.uC_Login1_VisibleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1528, 791);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddNewPhone;
        private System.Windows.Forms.Button btnDeletePhone;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCRecords;
        private System.Windows.Forms.Button btnStock;
        private AllUserControl.UC_AddNewPhone uC_AddNewPhone1;
        private AllUserControl.UC_Customer uC_Customer1;
        private AllUserControl.UC_Stock uC_Stock1;
        private System.Windows.Forms.Button btnMinimize;
        private AllUserControl.UC_CustomerRecords uC_CustomerRecords1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVerify;
        private AllUserControl.UC_DeletePhoneRecord uC_DeletePhoneRecord1;
        private AllUserControl.UC_Login uC_Login1;
    }
}

