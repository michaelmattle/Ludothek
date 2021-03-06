﻿namespace Ludothek.Application.View
{
    partial class ToysListView
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
            this.label12 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnNewToy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPricePerWeek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combCategory = new System.Windows.Forms.ComboBox();
            this.txtToyName = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtToyNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listAllToys = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NachName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 306);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Neues Spielzeug:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(284, 302);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(94, 21);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Übernehmen";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnNewToy
            // 
            this.btnNewToy.Location = new System.Drawing.Point(574, 302);
            this.btnNewToy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewToy.Name = "btnNewToy";
            this.btnNewToy.Size = new System.Drawing.Size(94, 21);
            this.btnNewToy.TabIndex = 6;
            this.btnNewToy.Text = "Erfassen...";
            this.btnNewToy.UseVisualStyleBackColor = true;
            this.btnNewToy.Click += new System.EventHandler(this.btnNewToy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPricePerWeek);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combCategory);
            this.groupBox1.Controls.Add(this.txtToyName);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.txtToyNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(354, 128);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spielzeugdetails";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CHF";
            // 
            // txtPricePerWeek
            // 
            this.txtPricePerWeek.Location = new System.Drawing.Point(120, 101);
            this.txtPricePerWeek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPricePerWeek.Name = "txtPricePerWeek";
            this.txtPricePerWeek.Size = new System.Drawing.Size(190, 20);
            this.txtPricePerWeek.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preis pro Woche:";
            // 
            // combCategory
            // 
            this.combCategory.FormattingEnabled = true;
            this.combCategory.Items.AddRange(new object[] {
            "Kindergarten",
            "Unterstufe",
            "Oberstufe"});
            this.combCategory.Location = new System.Drawing.Point(120, 77);
            this.combCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combCategory.Name = "combCategory";
            this.combCategory.Size = new System.Drawing.Size(222, 21);
            this.combCategory.TabIndex = 3;
            // 
            // txtToyName
            // 
            this.txtToyName.Location = new System.Drawing.Point(120, 56);
            this.txtToyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtToyName.Name = "txtToyName";
            this.txtToyName.Size = new System.Drawing.Size(222, 20);
            this.txtToyName.TabIndex = 2;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(120, 36);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(222, 20);
            this.txtBrand.TabIndex = 1;
            // 
            // txtToyNo
            // 
            this.txtToyNo.Location = new System.Drawing.Point(120, 16);
            this.txtToyNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtToyNo.Name = "txtToyNo";
            this.txtToyNo.ReadOnly = true;
            this.txtToyNo.Size = new System.Drawing.Size(222, 20);
            this.txtToyNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spielzeugnummer:";
            // 
            // listAllToys
            // 
            this.listAllToys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NachName});
            this.listAllToys.Location = new System.Drawing.Point(394, 21);
            this.listAllToys.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listAllToys.Name = "listAllToys";
            this.listAllToys.Size = new System.Drawing.Size(276, 261);
            this.listAllToys.TabIndex = 14;
            this.listAllToys.UseCompatibleStateImageBehavior = false;
            this.listAllToys.View = System.Windows.Forms.View.Details;
            this.listAllToys.SelectedIndexChanged += new System.EventHandler(this.listAllToys_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // NachName
            // 
            this.NachName.Text = "Name";
            this.NachName.Width = 398;
            // 
            // ToysListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 337);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnNewToy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listAllToys);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ToysListView";
            this.Text = "Spielzeuge";
            this.Load += new System.EventHandler(this.ToysListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnNewToy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPricePerWeek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combCategory;
        private System.Windows.Forms.TextBox txtToyName;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtToyNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listAllToys;
        private System.Windows.Forms.ColumnHeader NachName;
        private System.Windows.Forms.ColumnHeader Id;
    }
}