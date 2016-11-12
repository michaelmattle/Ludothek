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
            this.NachName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAllCustomers
            // 
            this.listAllCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NachName});
            this.listAllCustomers.Location = new System.Drawing.Point(13, 14);
            this.listAllCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listAllCustomers.Name = "listAllCustomers";
            this.listAllCustomers.Size = new System.Drawing.Size(516, 488);
            this.listAllCustomers.TabIndex = 26;
            this.listAllCustomers.UseCompatibleStateImageBehavior = false;
            this.listAllCustomers.View = System.Windows.Forms.View.Details;
            // 
            // NachName
            // 
            this.NachName.Text = "Name";
            this.NachName.Width = 509;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(243, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 32);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(389, 510);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(140, 32);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "Auswählen";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 558);
            this.Controls.Add(this.listAllCustomers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Name = "CustomersView";
            this.Text = "Kunden";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAllCustomers;
        private System.Windows.Forms.ColumnHeader NachName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
    }
}