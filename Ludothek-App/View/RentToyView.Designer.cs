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
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spielzeugnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kundennummer:";
            // 
            // txtToyNo
            // 
            this.txtToyNo.Location = new System.Drawing.Point(188, 21);
            this.txtToyNo.Name = "txtToyNo";
            this.txtToyNo.Size = new System.Drawing.Size(307, 26);
            this.txtToyNo.TabIndex = 1;
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(188, 64);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(307, 26);
            this.txtCustomerNo.TabIndex = 1;
            // 
            // btnToys
            // 
            this.btnToys.Location = new System.Drawing.Point(501, 19);
            this.btnToys.Name = "btnToys";
            this.btnToys.Size = new System.Drawing.Size(134, 30);
            this.btnToys.TabIndex = 2;
            this.btnToys.Text = "Spielzeuge...";
            this.btnToys.UseVisualStyleBackColor = true;
            this.btnToys.Click += new System.EventHandler(this.btnToys_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(501, 62);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(134, 30);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Kunden...";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preis pro Woche:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CHF";
            // 
            // lblPricePerWeek
            // 
            this.lblPricePerWeek.AutoSize = true;
            this.lblPricePerWeek.Location = new System.Drawing.Point(405, 158);
            this.lblPricePerWeek.Name = "lblPricePerWeek";
            this.lblPricePerWeek.Size = new System.Drawing.Size(18, 20);
            this.lblPricePerWeek.TabIndex = 5;
            this.lblPricePerWeek.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(221, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(361, 310);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(134, 30);
            this.btnCalculatePrice.TabIndex = 7;
            this.btnCalculatePrice.Text = "Preis berechnen";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(501, 310);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(134, 30);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Text = "Annehmen";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // RentToyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 361);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCalculatePrice);
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
            this.Name = "RentToyView";
            this.Text = "Spielzeug ausleihen";
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
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.Button btnAccept;
    }
}