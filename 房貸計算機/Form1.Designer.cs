namespace 房貸計算機
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHousePrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPercent = new System.Windows.Forms.RadioButton();
            this.rbAmount = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.numInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoanYears = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGracePeriod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHousePrice
            // 
            this.txtHousePrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtHousePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHousePrice.Location = new System.Drawing.Point(110, 20);
            this.txtHousePrice.Name = "txtHousePrice";
            this.txtHousePrice.Size = new System.Drawing.Size(100, 22);
            this.txtHousePrice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "房屋總價";
            // 
            // rbPercent
            // 
            this.rbPercent.AutoSize = true;
            this.rbPercent.Checked = true;
            this.rbPercent.Location = new System.Drawing.Point(239, 55);
            this.rbPercent.Name = "rbPercent";
            this.rbPercent.Size = new System.Drawing.Size(59, 16);
            this.rbPercent.TabIndex = 2;
            this.rbPercent.TabStop = true;
            this.rbPercent.Text = "百分比";
            this.rbPercent.UseVisualStyleBackColor = true;
            // 
            // rbAmount
            // 
            this.rbAmount.AutoSize = true;
            this.rbAmount.Location = new System.Drawing.Point(239, 77);
            this.rbAmount.Name = "rbAmount";
            this.rbAmount.Size = new System.Drawing.Size(47, 16);
            this.rbAmount.TabIndex = 3;
            this.rbAmount.Text = "金額";
            this.rbAmount.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "自備款比例";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.BackColor = System.Drawing.SystemColors.Window;
            this.txtDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownPayment.Location = new System.Drawing.Point(110, 63);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(100, 22);
            this.txtDownPayment.TabIndex = 5;
            // 
            // numInterestRate
            // 
            this.numInterestRate.DecimalPlaces = 2;
            this.numInterestRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numInterestRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numInterestRate.Location = new System.Drawing.Point(110, 117);
            this.numInterestRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numInterestRate.Name = "numInterestRate";
            this.numInterestRate.Size = new System.Drawing.Size(58, 22);
            this.numInterestRate.TabIndex = 6;
            this.numInterestRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "貸款利率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(216, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "元";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(216, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "%";
            // 
            // txtLoanYears
            // 
            this.txtLoanYears.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoanYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoanYears.Location = new System.Drawing.Point(110, 164);
            this.txtLoanYears.Name = "txtLoanYears";
            this.txtLoanYears.Size = new System.Drawing.Size(100, 22);
            this.txtLoanYears.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "貸款年限";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "寬限期(選填)";
            // 
            // txtGracePeriod
            // 
            this.txtGracePeriod.BackColor = System.Drawing.SystemColors.Window;
            this.txtGracePeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGracePeriod.Location = new System.Drawing.Point(110, 200);
            this.txtGracePeriod.Name = "txtGracePeriod";
            this.txtGracePeriod.Size = new System.Drawing.Size(100, 22);
            this.txtGracePeriod.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(174, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(216, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "年";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(216, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "年";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 17;
            this.button1.Text = "開始計算";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 63);
            this.button2.TabIndex = 18;
            this.button2.Text = "清除重填";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGracePeriod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoanYears);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numInterestRate);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbAmount);
            this.Controls.Add(this.rbPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHousePrice);
            this.Name = "Form1";
            this.Text = "房貸計算機";
            ((System.ComponentModel.ISupportInitialize)(this.numInterestRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHousePrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPercent;
        private System.Windows.Forms.RadioButton rbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.NumericUpDown numInterestRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoanYears;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGracePeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

