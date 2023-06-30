namespace LinqSqlProject
{
    partial class PurchaseListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseListForm));
            this.PurchaseList = new System.Windows.Forms.ListView();
            this.AllPurchases = new System.Windows.Forms.RadioButton();
            this.byDatePurchases = new System.Windows.Forms.RadioButton();
            this.ShowByPrice = new System.Windows.Forms.RadioButton();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DisplayPurchasesButton = new System.Windows.Forms.Button();
            this.MinPrice = new System.Windows.Forms.TextBox();
            this.MaxPrice = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PurchaseList
            // 
            this.PurchaseList.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PurchaseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PurchaseList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PurchaseList.HideSelection = false;
            this.PurchaseList.Location = new System.Drawing.Point(364, 28);
            this.PurchaseList.Name = "PurchaseList";
            this.PurchaseList.Size = new System.Drawing.Size(424, 387);
            this.PurchaseList.TabIndex = 0;
            this.PurchaseList.UseCompatibleStateImageBehavior = false;
            this.PurchaseList.View = System.Windows.Forms.View.List;
            this.PurchaseList.SelectedIndexChanged += new System.EventHandler(this.PurchaseList_SelectedIndexChanged);
            // 
            // AllPurchases
            // 
            this.AllPurchases.AutoSize = true;
            this.AllPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AllPurchases.Location = new System.Drawing.Point(37, 39);
            this.AllPurchases.Name = "AllPurchases";
            this.AllPurchases.Size = new System.Drawing.Size(180, 24);
            this.AllPurchases.TabIndex = 1;
            this.AllPurchases.TabStop = true;
            this.AllPurchases.Text = "Show All Purchases";
            this.AllPurchases.UseVisualStyleBackColor = true;
            this.AllPurchases.CheckedChanged += new System.EventHandler(this.AllPurchases_CheckedChanged);
            // 
            // byDatePurchases
            // 
            this.byDatePurchases.AutoSize = true;
            this.byDatePurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.byDatePurchases.Location = new System.Drawing.Point(37, 137);
            this.byDatePurchases.Name = "byDatePurchases";
            this.byDatePurchases.Size = new System.Drawing.Size(137, 24);
            this.byDatePurchases.TabIndex = 2;
            this.byDatePurchases.TabStop = true;
            this.byDatePurchases.Text = "Show By Date";
            this.byDatePurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.byDatePurchases.UseVisualStyleBackColor = true;
            this.byDatePurchases.CheckedChanged += new System.EventHandler(this.byDatePurchases_CheckedChanged);
            // 
            // ShowByPrice
            // 
            this.ShowByPrice.AutoSize = true;
            this.ShowByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ShowByPrice.Location = new System.Drawing.Point(37, 290);
            this.ShowByPrice.Name = "ShowByPrice";
            this.ShowByPrice.Size = new System.Drawing.Size(140, 24);
            this.ShowByPrice.TabIndex = 3;
            this.ShowByPrice.TabStop = true;
            this.ShowByPrice.Text = "Show By Price";
            this.ShowByPrice.UseVisualStyleBackColor = true;
            this.ShowByPrice.CheckedChanged += new System.EventHandler(this.ShowByPrice_CheckedChanged);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(69, 176);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(252, 22);
            this.fromDatePicker.TabIndex = 4;
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(69, 238);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(252, 22);
            this.toDatePicker.TabIndex = 5;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // DisplayPurchasesButton
            // 
            this.DisplayPurchasesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DisplayPurchasesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DisplayPurchasesButton.Location = new System.Drawing.Point(141, 387);
            this.DisplayPurchasesButton.Name = "DisplayPurchasesButton";
            this.DisplayPurchasesButton.Size = new System.Drawing.Size(180, 51);
            this.DisplayPurchasesButton.TabIndex = 9;
            this.DisplayPurchasesButton.Text = "Display Purchases";
            this.DisplayPurchasesButton.UseVisualStyleBackColor = true;
            this.DisplayPurchasesButton.Click += new System.EventHandler(this.DisplayPurchasesButton_Click);
            // 
            // MinPrice
            // 
            this.MinPrice.Location = new System.Drawing.Point(69, 346);
            this.MinPrice.Name = "MinPrice";
            this.MinPrice.Size = new System.Drawing.Size(100, 22);
            this.MinPrice.TabIndex = 10;
            this.MinPrice.TextChanged += new System.EventHandler(this.MinPrice_TextChanged);
            // 
            // MaxPrice
            // 
            this.MaxPrice.Location = new System.Drawing.Point(221, 346);
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(100, 22);
            this.MaxPrice.TabIndex = 11;
            this.MaxPrice.TextChanged += new System.EventHandler(this.MaxPrice_TextChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(105, 327);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 16);
            this.minLabel.TabIndex = 12;
            this.minLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(256, 327);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(32, 16);
            this.MaxLabel.TabIndex = 13;
            this.MaxLabel.Text = "Max";
            // 
            // PurchaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.MaxPrice);
            this.Controls.Add(this.MinPrice);
            this.Controls.Add(this.DisplayPurchasesButton);
            this.Controls.Add(this.toDatePicker);
            this.Controls.Add(this.fromDatePicker);
            this.Controls.Add(this.ShowByPrice);
            this.Controls.Add(this.byDatePurchases);
            this.Controls.Add(this.AllPurchases);
            this.Controls.Add(this.PurchaseList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseListForm";
            this.Text = "Purchase List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PurchaseList;
        private System.Windows.Forms.RadioButton AllPurchases;
        private System.Windows.Forms.RadioButton byDatePurchases;
        private System.Windows.Forms.RadioButton ShowByPrice;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.Button DisplayPurchasesButton;
        private System.Windows.Forms.TextBox MinPrice;
        private System.Windows.Forms.TextBox MaxPrice;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label MaxLabel;
    }
}