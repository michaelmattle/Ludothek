namespace PersonenverwaltungMVC_2
{
    partial class PersonenListView
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
            this.listAllCustomers = new System.Windows.Forms.ListView();
            this.NachName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurename = new System.Windows.Forms.TextBox();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.dateBirthday = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtZIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbClubMember = new System.Windows.Forms.CheckBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAllCustomers
            // 
            this.listAllCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NachName,
            this.Vorname});
            this.listAllCustomers.Location = new System.Drawing.Point(566, 14);
            this.listAllCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listAllCustomers.Name = "listAllCustomers";
            this.listAllCustomers.Size = new System.Drawing.Size(412, 719);
            this.listAllCustomers.TabIndex = 0;
            this.listAllCustomers.UseCompatibleStateImageBehavior = false;
            this.listAllCustomers.View = System.Windows.Forms.View.Details;
            // 
            // NachName
            // 
            this.NachName.Text = "Name";
            this.NachName.Width = 194;
            // 
            // Vorname
            // 
            this.Vorname.Text = "Vorname";
            this.Vorname.Width = 211;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSurename);
            this.groupBox1.Controls.Add(this.txtCustomerNo);
            this.groupBox1.Controls.Add(this.dateBirthday);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 400);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kundendetails";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtSurename
            // 
            this.txtSurename.Location = new System.Drawing.Point(181, 55);
            this.txtSurename.Name = "txtSurename";
            this.txtSurename.Size = new System.Drawing.Size(330, 26);
            this.txtSurename.TabIndex = 5;
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(181, 25);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(330, 26);
            this.txtCustomerNo.TabIndex = 5;
            // 
            // dateBirthday
            // 
            this.dateBirthday.Location = new System.Drawing.Point(242, 127);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geburtsdatum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundennummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Controls.Add(this.txtCountry);
            this.groupBox2.Controls.Add(this.txtPlace);
            this.groupBox2.Controls.Add(this.txtZIP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 163);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adresse";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(180, 28);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(330, 26);
            this.txtStreet.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(180, 123);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(330, 26);
            this.txtCountry.TabIndex = 6;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(180, 92);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(330, 26);
            this.txtPlace.TabIndex = 6;
            // 
            // txtZIP
            // 
            this.txtZIP.Location = new System.Drawing.Point(180, 60);
            this.txtZIP.Name = "txtZIP";
            this.txtZIP.Size = new System.Drawing.Size(330, 26);
            this.txtZIP.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Land:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ort:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Postleitzahl:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Strasse:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "E-Mail-Adresse:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Telefonnummer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 714);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Vereinsmitglied:";
            // 
            // cbClubMember
            // 
            this.cbClubMember.AutoSize = true;
            this.cbClubMember.Location = new System.Drawing.Point(193, 715);
            this.cbClubMember.Name = "cbClubMember";
            this.cbClubMember.Size = new System.Drawing.Size(22, 21);
            this.cbClubMember.TabIndex = 11;
            this.cbClubMember.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(180, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(328, 26);
            this.txtMail.TabIndex = 6;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(180, 60);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(328, 26);
            this.txtPhoneNo.TabIndex = 6;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(402, 741);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(140, 32);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Übernehmen";
            this.btnAccept.UseVisualStyleBackColor = true;
            //this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(837, 741);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(140, 32);
            this.btnNewCustomer.TabIndex = 12;
            this.btnNewCustomer.Text = "Erfassen...";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            //this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(690, 747);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Neuer Kunde:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMail);
            this.groupBox3.Controls.Add(this.txtPhoneNo);
            this.groupBox3.Location = new System.Drawing.Point(13, 596);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontaktdaten";
            // 
            // PersonenListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 786);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbClubMember);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listAllCustomers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonenListView";
            this.Text = "Personen";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonenListView_FormClosing);
            //this.Load += new System.EventHandler(this.PersonenListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listAllCustomers;
        private System.Windows.Forms.ColumnHeader NachName;
        private System.Windows.Forms.ColumnHeader Vorname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurename;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.MonthCalendar dateBirthday;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtZIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbClubMember;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}