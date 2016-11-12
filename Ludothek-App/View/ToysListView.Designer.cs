namespace Ludothek.Application.View
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
            this.NachName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(952, 588);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Neues Spielzeug:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(568, 581);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(188, 40);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "Übernehmen";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnNewToy
            // 
            this.btnNewToy.Location = new System.Drawing.Point(1148, 581);
            this.btnNewToy.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewToy.Name = "btnNewToy";
            this.btnNewToy.Size = new System.Drawing.Size(188, 40);
            this.btnNewToy.TabIndex = 24;
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
            this.groupBox1.Location = new System.Drawing.Point(48, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(708, 246);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spielzeugdetails";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(624, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "CHF";
            // 
            // txtPricePerWeek
            // 
            this.txtPricePerWeek.Location = new System.Drawing.Point(240, 194);
            this.txtPricePerWeek.Margin = new System.Windows.Forms.Padding(4);
            this.txtPricePerWeek.Name = "txtPricePerWeek";
            this.txtPricePerWeek.Size = new System.Drawing.Size(376, 31);
            this.txtPricePerWeek.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
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
            this.combCategory.Location = new System.Drawing.Point(240, 148);
            this.combCategory.Margin = new System.Windows.Forms.Padding(4);
            this.combCategory.Name = "combCategory";
            this.combCategory.Size = new System.Drawing.Size(440, 33);
            this.combCategory.TabIndex = 6;
            // 
            // txtToyName
            // 
            this.txtToyName.Location = new System.Drawing.Point(240, 108);
            this.txtToyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtToyName.Name = "txtToyName";
            this.txtToyName.Size = new System.Drawing.Size(440, 31);
            this.txtToyName.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(240, 69);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(440, 31);
            this.txtBrand.TabIndex = 5;
            // 
            // txtToyNo
            // 
            this.txtToyNo.Location = new System.Drawing.Point(240, 31);
            this.txtToyNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtToyNo.Name = "txtToyNo";
            this.txtToyNo.ReadOnly = true;
            this.txtToyNo.Size = new System.Drawing.Size(440, 31);
            this.txtToyNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spielzeugnummer:";
            // 
            // listAllToys
            // 
            this.listAllToys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NachName});
            this.listAllToys.Location = new System.Drawing.Point(788, 40);
            this.listAllToys.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listAllToys.Name = "listAllToys";
            this.listAllToys.Size = new System.Drawing.Size(548, 498);
            this.listAllToys.TabIndex = 14;
            this.listAllToys.UseCompatibleStateImageBehavior = false;
            this.listAllToys.View = System.Windows.Forms.View.Details;
            this.listAllToys.SelectedIndexChanged += new System.EventHandler(this.listAllToys_SelectedIndexChanged);
            // 
            // NachName
            // 
            this.NachName.Text = "Name";
            this.NachName.Width = 398;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // ToysListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 648);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnNewToy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listAllToys);
            this.Margin = new System.Windows.Forms.Padding(4);
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