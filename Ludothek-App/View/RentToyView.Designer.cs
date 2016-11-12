namespace Ludothek.Application.View
{
    partial class RentToyView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToyNo = new System.Windows.Forms.TextBox();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.btnToys = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPricePerWeek = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spielzeugnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kundennummer:";
            // 
            // txtToyNo
            // 
            this.txtToyNo.Location = new System.Drawing.Point(126, 14);
            this.txtToyNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtToyNo.Name = "txtToyNo";
            this.txtToyNo.Size = new System.Drawing.Size(206, 20);
            this.txtToyNo.TabIndex = 1;
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(126, 42);
            this.txtCustomerNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(206, 20);
            this.txtCustomerNo.TabIndex = 3;
            // 
            // btnToys
            // 
            this.btnToys.Location = new System.Drawing.Point(334, 12);
            this.btnToys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToys.Name = "btnToys";
            this.btnToys.Size = new System.Drawing.Size(90, 20);
            this.btnToys.TabIndex = 2;
            this.btnToys.Text = "Spielzeuge...";
            this.btnToys.UseVisualStyleBackColor = true;
            this.btnToys.Click += new System.EventHandler(this.btnToys_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(334, 41);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(90, 20);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Kunden...";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preis pro Woche:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CHF";
            // 
            // lblPricePerWeek
            // 
            this.lblPricePerWeek.AutoSize = true;
            this.lblPricePerWeek.Location = new System.Drawing.Point(238, 103);
            this.lblPricePerWeek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPricePerWeek.MinimumSize = new System.Drawing.Size(50, 0);
            this.lblPricePerWeek.Name = "lblPricePerWeek";
            this.lblPricePerWeek.Size = new System.Drawing.Size(50, 13);
            this.lblPricePerWeek.TabIndex = 5;
            this.lblPricePerWeek.Text = "0";
            this.lblPricePerWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 202);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 20);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(334, 202);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(90, 20);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Annehmen";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // RentToyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 235);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblPricePerWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnToys);
            this.Controls.Add(this.txtCustomerNo);
            this.Controls.Add(this.txtToyNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RentToyView";
            this.Text = "Spielzeug ausleihen";
            this.Load += new System.EventHandler(this.RentToyView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToyNo;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.Button btnToys;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPricePerWeek;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}