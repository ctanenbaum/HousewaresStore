namespace LinqSqlProject
{
    partial class HousewaresApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HousewaresApp));
            this.SaleItemListView = new System.Windows.Forms.ListView();
            this.SaleItemsListLabel = new System.Windows.Forms.Label();
            this.CheckBalanceButton = new System.Windows.Forms.Button();
            this.PayBalanceButton = new System.Windows.Forms.Button();
            this.CheckPurchasesButton = new System.Windows.Forms.Button();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleItemListView
            // 
            this.SaleItemListView.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaleItemListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SaleItemListView.ForeColor = System.Drawing.SystemColors.Window;
            this.SaleItemListView.HideSelection = false;
            this.SaleItemListView.Location = new System.Drawing.Point(281, 26);
            this.SaleItemListView.Name = "SaleItemListView";
            this.SaleItemListView.Size = new System.Drawing.Size(458, 311);
            this.SaleItemListView.TabIndex = 4;
            this.SaleItemListView.UseCompatibleStateImageBehavior = false;
            this.SaleItemListView.View = System.Windows.Forms.View.List;
            this.SaleItemListView.SelectedIndexChanged += new System.EventHandler(this.SaleItemListView_SelectedIndexChanged);
            // 
            // SaleItemsListLabel
            // 
            this.SaleItemsListLabel.AutoSize = true;
            this.SaleItemsListLabel.Location = new System.Drawing.Point(383, 12);
            this.SaleItemsListLabel.Name = "SaleItemsListLabel";
            this.SaleItemsListLabel.Size = new System.Drawing.Size(251, 16);
            this.SaleItemsListLabel.TabIndex = 5;
            this.SaleItemsListLabel.Text = "Select an item you would like to purchase";
            // 
            // CheckBalanceButton
            // 
            this.CheckBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckBalanceButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CheckBalanceButton.Location = new System.Drawing.Point(47, 35);
            this.CheckBalanceButton.Name = "CheckBalanceButton";
            this.CheckBalanceButton.Size = new System.Drawing.Size(180, 51);
            this.CheckBalanceButton.TabIndex = 6;
            this.CheckBalanceButton.Text = "Check Balance";
            this.CheckBalanceButton.UseVisualStyleBackColor = true;
            this.CheckBalanceButton.Click += new System.EventHandler(this.CheckBalanceButton_Click);
            // 
            // PayBalanceButton
            // 
            this.PayBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PayBalanceButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PayBalanceButton.Location = new System.Drawing.Point(47, 160);
            this.PayBalanceButton.Name = "PayBalanceButton";
            this.PayBalanceButton.Size = new System.Drawing.Size(180, 51);
            this.PayBalanceButton.TabIndex = 7;
            this.PayBalanceButton.Text = "Pay To Balance";
            this.PayBalanceButton.UseVisualStyleBackColor = true;
            this.PayBalanceButton.Click += new System.EventHandler(this.PayBalanceButton_Click);
            // 
            // CheckPurchasesButton
            // 
            this.CheckPurchasesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CheckPurchasesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CheckPurchasesButton.Location = new System.Drawing.Point(47, 295);
            this.CheckPurchasesButton.Name = "CheckPurchasesButton";
            this.CheckPurchasesButton.Size = new System.Drawing.Size(180, 51);
            this.CheckPurchasesButton.TabIndex = 8;
            this.CheckPurchasesButton.Text = "Check Purchases";
            this.CheckPurchasesButton.UseVisualStyleBackColor = true;
            this.CheckPurchasesButton.Click += new System.EventHandler(this.CheckPurchasesButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PurchaseButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PurchaseButton.Location = new System.Drawing.Point(404, 378);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(228, 48);
            this.PurchaseButton.TabIndex = 9;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.QuantityLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.QuantityLabel.Location = new System.Drawing.Point(426, 343);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(76, 20);
            this.QuantityLabel.TabIndex = 10;
            this.QuantityLabel.Text = "Quantity:";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(523, 342);
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(44, 22);
            this.quantityNumericUpDown.TabIndex = 11;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.quantityNumericUpDown_ValueChanged);
            // 
            // HousewaresApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.CheckPurchasesButton);
            this.Controls.Add(this.PayBalanceButton);
            this.Controls.Add(this.CheckBalanceButton);
            this.Controls.Add(this.SaleItemsListLabel);
            this.Controls.Add(this.SaleItemListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HousewaresApp";
            this.Text = "Housewares App";
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView SaleItemListView;
        private System.Windows.Forms.Label SaleItemsListLabel;
        private System.Windows.Forms.Button CheckBalanceButton;
        private System.Windows.Forms.Button PayBalanceButton;
        private System.Windows.Forms.Button CheckPurchasesButton;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
    }
}

