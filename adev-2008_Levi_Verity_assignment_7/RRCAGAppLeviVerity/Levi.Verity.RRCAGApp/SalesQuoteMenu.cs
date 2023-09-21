/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-05-29
 * Updated: 2023-06-4
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Verity.Levi.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Cryptography.X509Certificates;
using System.CodeDom;
using System.Collections;

namespace Levi.Verity.RRCAGApp
{

    /// <summary>
    /// For the SalesQuoteMenu and extends from Form
    /// </summary>
    public partial class SalesQuoteMenu : Form
    {
        // Sets buttionValue to Standard 
        private ExteriorFinish buttonValue = ExteriorFinish.Standard;

        // Sets bovValue to none
        private Accessories boxValue = Accessories.None;
        
        /// <summary>
        /// where i superscribed to all the events 
        /// </summary>
        public SalesQuoteMenu()
        {
            InitializeComponent();

            this.Load += SalesQuoteMenu_Load;
            this.btnCalculate.Click += BtnCalculate_Click;
            this.boxComputerNavigation.CheckedChanged += CheckBox_CheckedChanged;
            this.boxStereoSystem.CheckedChanged += CheckBox_CheckedChanged;
            this.boxLeatherInterior.CheckedChanged += CheckBox_CheckedChanged;
            this.btnStandard.CheckedChanged += RadioButton_CheckedChanged;
            this.btnPearlized.CheckedChanged += RadioButton_CheckedChanged;
            this.btnCustomizedDetailing.CheckedChanged += RadioButton_CheckedChanged;
            this.numNoOfYears.ValueChanged += NumNoOfYears_ValueChanged;
            this.numAnnual.ValueChanged += NumAnnual_ValueChanged;
            this.txtVehiclesPrice.TextChanged += TxtVehiclesPrice_TextChanged;
            this.txtTradeInValue.TextChanged += TxtTradeInValue_TextChanged;
            this.btnReset.Click += BtnReset_Click;
            this.boxComputerNavigation.CheckedChanged += BtnCalculate_Click;
            this.boxStereoSystem.CheckedChanged += BtnCalculate_Click;
            this.boxLeatherInterior.CheckedChanged += BtnCalculate_Click;
            this.btnStandard.CheckedChanged += BtnCalculate_Click;

        }

        /// <summary>
        /// when this is used a dialog box comes if if yes it 
        /// cleans the program if no it stays how it was 
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Do you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (reset == DialogResult.Yes)
            {
                txtVehiclesPrice.Text = string.Empty;
                txtTradeInValue.Text = string.Empty;

                if (boxComputerNavigation.Checked || boxLeatherInterior.Checked || boxStereoSystem.Checked)
                {
                    boxComputerNavigation.Checked = false;
                    boxLeatherInterior.Checked = false;
                    boxStereoSystem.Checked = false;
                }
                if(btnCustomizedDetailing.Checked || btnPearlized.Checked || btnStandard.Checked)
                {
                    btnCustomizedDetailing.Checked = false;
                    btnPearlized.Checked = false;   
                }
            }
        }

        /// <summary>
        /// if the test in TxtTradeInValue is changed it cleans all other values 
        /// </summary>
        private void TxtTradeInValue_TextChanged(object sender, EventArgs e)
        {
            SalesQuoteMenu_Load(sender, e);
        }

        /// <summary>
        /// if the test in TxtVehiclesPrice is changed it cleans all other values 
        /// </summary>
        private void TxtVehiclesPrice_TextChanged(object sender, EventArgs e)
        {
            SalesQuoteMenu_Load(sender, e);
        }

        /// <summary>
        /// this is for the numAnnual lets max and min values how much it 
        /// increases when clicked and hoe many decimal places 
        /// </summary>
        private void NumAnnual_ValueChanged(object sender, EventArgs e)
        {
            this.numAnnual.DecimalPlaces = 2;
            this.numAnnual.Minimum = 1.00m;
            this.numAnnual.Maximum = 25.00m;
            this.numAnnual.Increment = 0.25m;
        }

        /// <summary>
        /// this is for the  NumNoOfYears lets max and min values how much it 
        /// increases when clicked and hoe many decimal places 
        /// </summary>
        private void NumNoOfYears_ValueChanged(object sender, EventArgs e)
        {
            this.numNoOfYears.Minimum = 1;
            this.numNoOfYears.Maximum = 10;
            this.numNoOfYears.Increment = 1;
        }

        /// <summary>
        /// Clears all labels 
        /// </summary>
        private void SalesQuoteMenu_Load(object sender, EventArgs e)
        {
            btnStandard.Checked = true;
            this.lblTradeIn.Text = string.Empty;
            this.lblVehicleSales.Text = string.Empty;
            this.lblSubTotal.Text = string.Empty;
            this.lblSalesTax.Text = string.Empty;
            this.lblAmountDue.Text = string.Empty;
            this.lblOptions.Text = string.Empty;
            this.lblTotal.Text = string.Empty;
            this.lblMonthlyPayment.Text = string.Empty;
        }

        /// <summary>
        /// This method is triggered when the Calculate button is clicked.
        /// It calculates and displays the sales quote information based on the entered values.
        /// It is also in control of the error messages.
        /// </summary>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            const decimal SALES_TAX = 0.12M;

            decimal VehiclesPrice = 1,
                    TradeIn = 1,
                    numberOfYears = 1.00m,
                    annual = 5.00m;

            this.errorVehicle.SetError(this.txtVehiclesPrice, String.Empty);
            this.errorTradeIn.SetError(this.txtTradeInValue, String.Empty);

            try
            {
                VehiclesPrice = decimal.Parse(this.txtVehiclesPrice.Text);
                TradeIn = decimal.Parse(this.txtTradeInValue.Text);

                SalesQuote quote = new SalesQuote(VehiclesPrice, TradeIn, SALES_TAX, boxValue, buttonValue);

                this.lblVehicleSales.Text = VehiclesPrice.ToString("$###,###,##0.00");
                this.lblTradeIn.Text = TradeIn.ToString("-###,###,##0.00");
                this.lblSubTotal.Text = quote.SubTotal.ToString("$###,###,##0.00");   
                this.lblSalesTax.Text = quote.SalesTax.ToString();
                this.lblTotal.Text = quote.Total.ToString("$###,###,##0.00");
                this.lblAmountDue.Text = quote.AmountDue.ToString("$###,###,##0.00");
                this.lblOptions.Text = quote.TotalOptions.ToString();

                numberOfYears = numNoOfYears.Value * 12;
                annual = numAnnual.Value % 100;
                decimal monthlyPayment = Math.Round((quote.AmountDue * annual) / (numberOfYears),2);
            
                this.lblMonthlyPayment.Text = monthlyPayment.ToString("$###,###,##0.00");

            }
            catch (FormatException)
            {
                this.errorVehicle.SetError(this.txtVehiclesPrice, "Vehicles Price not valid.");
               
                this.errorTradeIn.SetError(this.txtTradeInValue, "Trade in price not valid");
            }

            catch(ArgumentOutOfRangeException) 
            {
                this.errorVehicle.SetError(this.txtVehiclesPrice, "Vehicles Price not valid.");
                this.errorTradeIn.SetError(this.txtTradeInValue, "Trade in price not valid");
            }
        }

        /// <summary>
        /// This is for the RadioButtons it takes old 
        /// enums to set values to the radio butt ions also
        /// if it changes it uses the calculate button 
        /// </summary>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStandard.Checked)
            {
                buttonValue = ExteriorFinish.Standard;
            }
            else if (btnPearlized.Checked)
            {
                BtnCalculate_Click(sender, e);
                buttonValue = ExteriorFinish.Pearlized;
            }
            else if (btnCustomizedDetailing.Checked)
            {
                BtnCalculate_Click(sender, e);
                buttonValue = ExteriorFinish.Custom;
            }
        }

        /// <summary>
        /// This is for CheckBox it uses the old enums to set 
        /// values and if clicked triggers the calculate button 
        /// </summary>
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
         
            if (boxComputerNavigation.Checked)
            {
                boxValue = Accessories.ComputerNavigation;
            }      

            if (boxStereoSystem.Checked)
            {           
                boxValue = Accessories.StereoSystem;
            }

            if (boxLeatherInterior.Checked)
            {
                boxValue = Accessories.LeatherInterior;
            }

            if (boxComputerNavigation.Checked && boxStereoSystem.Checked)
            {
                boxValue = Accessories.StereoAndNavigation;
            }

            if (boxComputerNavigation.Checked && boxLeatherInterior.Checked)
            {
                boxValue = Accessories.LeatherAndNavigation;
            }

            if (boxStereoSystem.Checked && boxLeatherInterior.Checked)
            {
                boxValue = Accessories.StereoAndLeather;
            }

            if (boxStereoSystem.Checked && boxLeatherInterior.Checked && boxComputerNavigation.Checked)
            {
                boxValue = Accessories.All;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblVehicleSales_Click(object sender, EventArgs e)
       {

       }

        private void SalesQuoteMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void boxStereoSystem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

