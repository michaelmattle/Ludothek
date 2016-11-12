namespace Ludothek.Application.View
{
    partial class ToysView
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
            this.listAllToys = new System.Windows.Forms.ListView();
            this.NachName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listAllToys
            // 
            this.listAllToys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NachName});
            this.listAllToys.Location = new System.Drawing.Point(9, 9);
            this.listAllToys.Name = "listAllToys";
            this.listAllToys.Size = new System.Drawing.Size(345, 319);
            this.listAllToys.TabIndex = 15;
            this.listAllToys.UseCompatibleStateImageBehavior = false;
            this.listAllToys.View = System.Windows.Forms.View.Details;
            this.listAllToys.SelectedIndexChanged += new System.EventHandler(this.listAllToys_SelectedIndexChanged);
            // 
            // NachName
            // 
            this.NachName.Text = "Name";
            this.NachName.Width = 509;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(259, 331);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(93, 21);
            this.btnSelect.TabIndex = 25;
            this.btnSelect.Text = "Auswählen";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 331);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 21);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ToysView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listAllToys);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ToysView";
            this.Text = "Spielzeuge";
            this.Load += new System.EventHandler(this.ToysView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAllToys;
        private System.Windows.Forms.ColumnHeader NachName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}