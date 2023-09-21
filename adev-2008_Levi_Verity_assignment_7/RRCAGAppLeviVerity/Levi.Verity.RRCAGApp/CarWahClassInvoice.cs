/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-06-14
 * Updated: 2023-06-15
 */

using ACE.BIT.ADEV.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verity.Levi.Business;

namespace Levi.Verity.RRCAGApp
{

    /// <summary>
    /// car wash class invoice extends from car wash invoice 
    /// form so i can edit it and have function
    /// </summary>
    internal class CarWahClassInvoice : CarWashInvoiceForm
    {
        private BindingSource bindingSourceCalculationsForm;
        private BindingSource bindingSourcetest;
        private CarWahClassInvoice washCalculations;
     

        /// <summary>
        /// this class doses data binding for 4 of the 6 i needed 
        /// the reason not all 6 is i was having issues 
        /// with the Price as the other class did not have that functionality
        /// </summary>
        /// <param name="source">
        /// source is so that i can call the other data 
        /// bind to fill up the 4 labels i have filled 
        /// </param>
        public CarWahClassInvoice(BindingSource source)
        {
            this.Text = "Car Wash Invoice";

            this.bindingSourceCalculationsForm = new BindingSource();
            this.bindingSourceCalculationsForm.DataSource = source;

            this.bindingSourcetest = new BindingSource();

            //this.bindingSourcetest.DataSource = new washCalculations;
           
           // this.bindingSourcetest.DataSource = washCalculations;

            //Binding fragrancePrices = new Binding("Text", this.bindingSourcetest, "Price");
            //fragrancePrices.FormatString = "C";
            //this.lblFragrancePrice.DataBindings.Add(fragrancePrices);

            Binding gsts = new Binding("Text", this.bindingSourceCalculationsForm, "GoodsAndServicesTaxCharged");
            gsts.FormatString = "C";
            this.lblGoodsAndServicesTax.DataBindings.Add(gsts);

            //Binding packagePrices = new Binding("Text", this.bindingSourceCalculationsForm, "Price");
            //packagePrices.FormatString = "C";
            //this.lblPackagePrice.DataBindings.Add(packagePrices);

            Binding psts = new Binding("Text", this.bindingSourceCalculationsForm, "ProvincialSalesTaxCharged");
            psts.FormatString = "C";
            this.lblProvincialSalesTax.DataBindings.Add(psts);

            Binding subtotals = new Binding("Text", this.bindingSourceCalculationsForm, "SubTotal");
            subtotals.FormatString = "C";
            this.lblSubtotal.DataBindings.Add(subtotals);

            Binding totals = new Binding("Text", this.bindingSourceCalculationsForm, "Total");
            totals.FormatString = "C";
            this.lblTotal.DataBindings.Add(totals);
        }
    }
}
