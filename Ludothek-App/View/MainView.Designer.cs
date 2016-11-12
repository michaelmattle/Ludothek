namespace Ludothek.Application.View
{
    partial class MainView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRentToy = new System.Windows.Forms.Button();
            this.btnReturnToy = new System.Windows.Forms.Button();
            this.btnToys = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.listDueReturns = new System.Windows.Forms.ListView();
            this.Spiel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kunde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnProlong = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spielzeugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausleihenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zurückgebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.übersichtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Rückgabedatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRentToy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReturnToy, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnToys, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCustomers, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 85);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 679);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRentToy
            // 
            this.btnRentToy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentToy.Location = new System.Drawing.Point(6, 6);
            this.btnRentToy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRentToy.Name = "btnRentToy";
            this.btnRentToy.Size = new System.Drawing.Size(379, 327);
            this.btnRentToy.TabIndex = 0;
            this.btnRentToy.Text = "Spielzeug ausleihen";
            this.btnRentToy.UseVisualStyleBackColor = true;
            this.btnRentToy.Click += new System.EventHandler(this.btnRentToy_Click);
            // 
            // btnReturnToy
            // 
            this.btnReturnToy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToy.Location = new System.Drawing.Point(397, 6);
            this.btnReturnToy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReturnToy.Name = "btnReturnToy";
            this.btnReturnToy.Size = new System.Drawing.Size(379, 327);
            this.btnReturnToy.TabIndex = 1;
            this.btnReturnToy.Text = "Spielzeug zurückgeben";
            this.btnReturnToy.UseVisualStyleBackColor = true;
            this.btnReturnToy.Click += new System.EventHandler(this.btnReturnToy_Click);
            // 
            // btnToys
            // 
            this.btnToys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToys.Location = new System.Drawing.Point(6, 345);
            this.btnToys.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnToys.Name = "btnToys";
            this.btnToys.Size = new System.Drawing.Size(379, 328);
            this.btnToys.TabIndex = 2;
            this.btnToys.Text = "Spielzeuge";
            this.btnToys.UseVisualStyleBackColor = true;
            this.btnToys.Click += new System.EventHandler(this.btnToys_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomers.Location = new System.Drawing.Point(397, 345);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(379, 328);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Kunden";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // listDueReturns
            // 
            this.listDueReturns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listDueReturns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Spiel,
            this.Kunde,
            this.Rückgabedatum});
            this.tableLayoutPanel2.SetColumnSpan(this.listDueReturns, 2);
            this.listDueReturns.Location = new System.Drawing.Point(6, 84);
            this.listDueReturns.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listDueReturns.Name = "listDueReturns";
            this.listDueReturns.Size = new System.Drawing.Size(550, 748);
            this.listDueReturns.TabIndex = 6;
            this.listDueReturns.UseCompatibleStateImageBehavior = false;
            this.listDueReturns.View = System.Windows.Forms.View.Details;
            // 
            // Spiel
            // 
            this.Spiel.Text = "Spiel";
            this.Spiel.Width = 173;
            // 
            // Kunde
            // 
            this.Kunde.Text = "Kunde";
            this.Kunde.Width = 113;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fällige Rückgaben:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProlong
            // 
            this.btnProlong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProlong.Location = new System.Drawing.Point(287, 6);
            this.btnProlong.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnProlong.Name = "btnProlong";
            this.btnProlong.Size = new System.Drawing.Size(269, 66);
            this.btnProlong.TabIndex = 4;
            this.btnProlong.Text = "Verlängern";
            this.btnProlong.UseVisualStyleBackColor = true;
            this.btnProlong.Click += new System.EventHandler(this.btnProlong_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listDueReturns, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnProlong, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(800, 6);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.403669F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.59633F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(562, 838);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 52);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1370, 854);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielzeugToolStripMenuItem,
            this.kundenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1418, 44);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spielzeugToolStripMenuItem
            // 
            this.spielzeugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausleihenToolStripMenuItem,
            this.zurückgebenToolStripMenuItem,
            this.übersichtToolStripMenuItem});
            this.spielzeugToolStripMenuItem.Name = "spielzeugToolStripMenuItem";
            this.spielzeugToolStripMenuItem.Size = new System.Drawing.Size(131, 36);
            this.spielzeugToolStripMenuItem.Text = "Spielzeug";
            // 
            // ausleihenToolStripMenuItem
            // 
            this.ausleihenToolStripMenuItem.Name = "ausleihenToolStripMenuItem";
            this.ausleihenToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.ausleihenToolStripMenuItem.Text = "ausleihen";
            this.ausleihenToolStripMenuItem.Click += new System.EventHandler(this.ausleihenToolStripMenuItem_Click);
            // 
            // zurückgebenToolStripMenuItem
            // 
            this.zurückgebenToolStripMenuItem.Name = "zurückgebenToolStripMenuItem";
            this.zurückgebenToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.zurückgebenToolStripMenuItem.Text = "zurückgeben";
            this.zurückgebenToolStripMenuItem.Click += new System.EventHandler(this.zurückgebenToolStripMenuItem_Click);
            // 
            // übersichtToolStripMenuItem
            // 
            this.übersichtToolStripMenuItem.Name = "übersichtToolStripMenuItem";
            this.übersichtToolStripMenuItem.Size = new System.Drawing.Size(253, 38);
            this.übersichtToolStripMenuItem.Text = "Übersicht";
            this.übersichtToolStripMenuItem.Click += new System.EventHandler(this.übersichtToolStripMenuItem_Click);
            // 
            // kundenToolStripMenuItem
            // 
            this.kundenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.übersichtToolStripMenuItem1});
            this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
            this.kundenToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.kundenToolStripMenuItem.Text = "Kunden";
            // 
            // übersichtToolStripMenuItem1
            // 
            this.übersichtToolStripMenuItem1.Name = "übersichtToolStripMenuItem1";
            this.übersichtToolStripMenuItem1.Size = new System.Drawing.Size(215, 38);
            this.übersichtToolStripMenuItem1.Text = "Übersicht";
            this.übersichtToolStripMenuItem1.Click += new System.EventHandler(this.übersichtToolStripMenuItem1_Click);
            // 
            // Rückgabedatum
            // 
            this.Rückgabedatum.Text = "Rückgabedatum";
            this.Rückgabedatum.Width = 180;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 929);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainView";
            this.Text = "Ludothek";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRentToy;
        private System.Windows.Forms.Button btnReturnToy;
        private System.Windows.Forms.Button btnToys;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProlong;
        private System.Windows.Forms.ListView listDueReturns;
        private System.Windows.Forms.ColumnHeader Spiel;
        private System.Windows.Forms.ColumnHeader Kunde;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem spielzeugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausleihenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zurückgebenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem übersichtToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader Rückgabedatum;
    }
}