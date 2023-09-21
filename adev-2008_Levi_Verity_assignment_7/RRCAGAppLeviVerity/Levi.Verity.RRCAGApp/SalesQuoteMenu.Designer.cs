namespace Levi.Verity.RRCAGApp
{
    partial class SalesQuoteMenu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehiclesPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxComputerNavigation = new System.Windows.Forms.CheckBox();
            this.boxLeatherInterior = new System.Windows.Forms.CheckBox();
            this.boxStereoSystem = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCustomizedDetailing = new System.Windows.Forms.RadioButton();
            this.btnPearlized = new System.Windows.Forms.RadioButton();
            this.btnStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numAnnual = new System.Windows.Forms.NumericUpDown();
            this.numNoOfYears = new System.Windows.Forms.NumericUpDown();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.lblVehicleSales = new System.Windows.Forms.Label();
            this.errorVehicle = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTradeIn = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfYears)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTradeIn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle\'s sales Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVehiclesPrice
            // 
            this.txtVehiclesPrice.Location = new System.Drawing.Point(168, 20);
            this.txtVehiclesPrice.Name = "txtVehiclesPrice";
            this.txtVehiclesPrice.Size = new System.Drawing.Size(123, 22);
            this.txtVehiclesPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trade In Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(172, 59);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(119, 22);
            this.txtTradeInValue.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxComputerNavigation);
            this.groupBox1.Controls.Add(this.boxLeatherInterior);
            this.groupBox1.Controls.Add(this.boxStereoSystem);
            this.groupBox1.Location = new System.Drawing.Point(33, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accessories";
            // 
            // boxComputerNavigation
            // 
            this.boxComputerNavigation.AutoSize = true;
            this.boxComputerNavigation.Location = new System.Drawing.Point(37, 106);
            this.boxComputerNavigation.Name = "boxComputerNavigation";
            this.boxComputerNavigation.Size = new System.Drawing.Size(155, 20);
            this.boxComputerNavigation.TabIndex = 2;
            this.boxComputerNavigation.Text = "Computer Navigation";
            this.boxComputerNavigation.UseVisualStyleBackColor = true;
            // 
            // boxLeatherInterior
            // 
            this.boxLeatherInterior.AutoSize = true;
            this.boxLeatherInterior.Location = new System.Drawing.Point(37, 69);
            this.boxLeatherInterior.Name = "boxLeatherInterior";
            this.boxLeatherInterior.Size = new System.Drawing.Size(117, 20);
            this.boxLeatherInterior.TabIndex = 1;
            this.boxLeatherInterior.Text = "Leather Interior";
            this.boxLeatherInterior.UseVisualStyleBackColor = true;
            // 
            // boxStereoSystem
            // 
            this.boxStereoSystem.AutoSize = true;
            this.boxStereoSystem.Location = new System.Drawing.Point(37, 32);
            this.boxStereoSystem.Name = "boxStereoSystem";
            this.boxStereoSystem.Size = new System.Drawing.Size(117, 20);
            this.boxStereoSystem.TabIndex = 0;
            this.boxStereoSystem.Text = "Stereo System";
            this.boxStereoSystem.UseVisualStyleBackColor = true;
            this.boxStereoSystem.CheckedChanged += new System.EventHandler(this.boxStereoSystem_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCustomizedDetailing);
            this.groupBox2.Controls.Add(this.btnPearlized);
            this.groupBox2.Controls.Add(this.btnStandard);
            this.groupBox2.Location = new System.Drawing.Point(32, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish";
            // 
            // btnCustomizedDetailing
            // 
            this.btnCustomizedDetailing.AutoSize = true;
            this.btnCustomizedDetailing.Location = new System.Drawing.Point(38, 125);
            this.btnCustomizedDetailing.Name = "btnCustomizedDetailing";
            this.btnCustomizedDetailing.Size = new System.Drawing.Size(154, 20);
            this.btnCustomizedDetailing.TabIndex = 2;
            this.btnCustomizedDetailing.TabStop = true;
            this.btnCustomizedDetailing.Text = "Customized Detailing";
            this.btnCustomizedDetailing.UseVisualStyleBackColor = true;
            // 
            // btnPearlized
            // 
            this.btnPearlized.AutoSize = true;
            this.btnPearlized.Location = new System.Drawing.Point(38, 78);
            this.btnPearlized.Name = "btnPearlized";
            this.btnPearlized.Size = new System.Drawing.Size(85, 20);
            this.btnPearlized.TabIndex = 1;
            this.btnPearlized.TabStop = true;
            this.btnPearlized.Text = "Pearlized";
            this.btnPearlized.UseVisualStyleBackColor = true;
            // 
            // btnStandard
            // 
            this.btnStandard.AutoSize = true;
            this.btnStandard.Location = new System.Drawing.Point(38, 29);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(83, 20);
            this.btnStandard.TabIndex = 0;
            this.btnStandard.TabStop = true;
            this.btnStandard.Text = "Standard";
            this.btnStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numAnnual);
            this.groupBox3.Controls.Add(this.numNoOfYears);
            this.groupBox3.Controls.Add(this.lblMonthlyPayment);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(353, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 114);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finance";
            // 
            // numAnnual
            // 
            this.numAnnual.Location = new System.Drawing.Point(145, 58);
            this.numAnnual.Name = "numAnnual";
            this.numAnnual.Size = new System.Drawing.Size(97, 22);
            this.numAnnual.TabIndex = 7;
            this.numAnnual.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numNoOfYears
            // 
            this.numNoOfYears.Location = new System.Drawing.Point(17, 58);
            this.numNoOfYears.Name = "numNoOfYears";
            this.numNoOfYears.Size = new System.Drawing.Size(97, 22);
            this.numNoOfYears.TabIndex = 6;
            this.numNoOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(271, 59);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(112, 20);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monthly Payment ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Annual \r\nInterest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. of Years";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(585, 506);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(151, 32);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Quote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(35, 506);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 32);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vehicle\'s sales Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Options:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "SubTotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sales Tax (12%):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Trade In:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Amount Due:";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmountDue.Location = new System.Drawing.Point(155, 308);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(146, 20);
            this.lblAmountDue.TabIndex = 9;
            this.lblAmountDue.Text = "lable";
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.SystemColors.Control;
            this.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOptions.Location = new System.Drawing.Point(155, 77);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(146, 20);
            this.lblOptions.TabIndex = 10;
            this.lblOptions.Text = "lable";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.lblSalesTax);
            this.groupBox4.Controls.Add(this.lblSubTotal);
            this.groupBox4.Controls.Add(this.lblTradeIn);
            this.groupBox4.Controls.Add(this.lblVehicleSales);
            this.groupBox4.Controls.Add(this.lblOptions);
            this.groupBox4.Controls.Add(this.lblAmountDue);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(353, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(398, 350);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Summary";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(155, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(146, 23);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "label13";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTax.Location = new System.Drawing.Point(155, 165);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(146, 23);
            this.lblSalesTax.TabIndex = 18;
            this.lblSalesTax.Text = "label13";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Location = new System.Drawing.Point(155, 122);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(146, 23);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "label13";
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeIn.Location = new System.Drawing.Point(155, 263);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(146, 20);
            this.lblTradeIn.TabIndex = 16;
            this.lblTradeIn.Text = "label15";
            // 
            // lblVehicleSales
            // 
            this.lblVehicleSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSales.Location = new System.Drawing.Point(155, 39);
            this.lblVehicleSales.Name = "lblVehicleSales";
            this.lblVehicleSales.Size = new System.Drawing.Size(146, 20);
            this.lblVehicleSales.TabIndex = 15;
            this.lblVehicleSales.Text = "label14";
            this.lblVehicleSales.Click += new System.EventHandler(this.lblVehicleSales_Click);
            // 
            // errorVehicle
            // 
            this.errorVehicle.ContainerControl = this;
            // 
            // errorTradeIn
            // 
            this.errorTradeIn.ContainerControl = this;
            // 
            // SalesQuoteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(768, 556);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVehiclesPrice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteMenu";
            this.Text = "Vehicle Sales Quote";
            this.Load += new System.EventHandler(this.SalesQuoteMenu_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoOfYears)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTradeIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehiclesPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox boxComputerNavigation;
        private System.Windows.Forms.CheckBox boxLeatherInterior;
        private System.Windows.Forms.CheckBox boxStereoSystem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton btnCustomizedDetailing;
        private System.Windows.Forms.RadioButton btnPearlized;
        private System.Windows.Forms.RadioButton btnStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblVehicleSales;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numAnnual;
        private System.Windows.Forms.NumericUpDown numNoOfYears;
        private System.Windows.Forms.ErrorProvider errorVehicle;
        private System.Windows.Forms.ErrorProvider errorTradeIn;
    }
}