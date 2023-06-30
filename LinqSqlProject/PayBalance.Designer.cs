namespace LinqSqlProject
{
    partial class PayBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayBalance));
            this.EnterPaymentLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.EnterAmountMaskTextbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // EnterPaymentLabel
            // 
            this.EnterPaymentLabel.AutoSize = true;
            this.EnterPaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.EnterPaymentLabel.Location = new System.Drawing.Point(60, 46);
            this.EnterPaymentLabel.Name = "EnterPaymentLabel";
            this.EnterPaymentLabel.Size = new System.Drawing.Size(256, 17);
            this.EnterPaymentLabel.TabIndex = 0;
            this.EnterPaymentLabel.Text = "Enter the amount you would like to pay:";
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PayButton.Location = new System.Drawing.Point(149, 136);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(92, 42);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // EnterAmountMaskTextbox
            // 
            this.EnterAmountMaskTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EnterAmountMaskTextbox.Location = new System.Drawing.Point(172, 87);
            this.EnterAmountMaskTextbox.Mask = "00000";
            this.EnterAmountMaskTextbox.Name = "EnterAmountMaskTextbox";
            this.EnterAmountMaskTextbox.Size = new System.Drawing.Size(43, 26);
            this.EnterAmountMaskTextbox.TabIndex = 3;
            this.EnterAmountMaskTextbox.ValidatingType = typeof(int);
            this.EnterAmountMaskTextbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.EnterAmountMaskTextbox_MaskInputRejected);
            // 
            // PayBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 203);
            this.Controls.Add(this.EnterAmountMaskTextbox);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.EnterPaymentLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayBalance";
            this.Text = "PayBalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterPaymentLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.MaskedTextBox EnterAmountMaskTextbox;
    }
}