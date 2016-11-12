namespace Ludothek.Application.View
{
    partial class CustomersView
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
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAllCustomers
            // 
            this.listAllCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name,
            this.Vorname});
            this.listAllCustomers.Location = new System.Drawing.Point(17, 18);
            this.listAllCustomers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listAllCustomers.Name = "listAllCustomers";
            this.listAllCustomers.Size = new System.Drawing.Size(687, 609);
            this.listAllCustomers.TabIndex = 26;
            this.listAllCustomers.UseCompatibleStateImageBehavior = false;
            this.listAllCustomers.View = System.Windows.Forms.View.Details;
            this.listAllCustomers.SelectedIndexChanged += new System.EventHandler(this.listAllCustomers_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 150;
            // 
            // Vorname
            // 
            this.Vorname.Text = "Vorname";
            this.Vorname.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 638);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 40);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(519, 638);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(187, 40);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "Auswählen";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 698);
            this.Controls.Add(this.listAllCustomers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "Kunden";
            this.Load += new System.EventHandler(this.CustomersView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAllCustomers;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Vorname;
    }
}