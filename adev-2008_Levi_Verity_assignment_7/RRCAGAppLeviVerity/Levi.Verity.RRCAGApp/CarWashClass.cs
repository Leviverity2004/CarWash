/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-06-8
 * Updated: 2019-06-15
 */
using ACE.BIT.ADEV.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Verity.Levi.Business;
using System.IO;
using System.Diagnostics;
using ACE.BIT.ADEV.CarWash;
using System.IO.Pipes;

namespace Levi.Verity.RRCAGApp
{

    /// <summary>
    /// car wash class extends from car wash form so i 
    /// can edit the form and make it have function
    /// </summary>
    internal class CarWashClass : CarWashForm 
    {
        private BindingSource bindingSourceCalculations;
        private BindingSource bindingSourcePackages;
        private BindingSource bindingSourceFragrances;
        private BindingList<Package> packages;
        private BindingList<CarWashItem> fragrances;

        /// <summary>
        /// I call methods here and set up some data Binding 
        /// i also hard code in the packages here
        /// </summary>
        public CarWashClass()
        {
                this.Text = "Car Wash";

                this.bindingSourceCalculations = new BindingSource();

                this.fragrances = new BindingList<CarWashItem>();
                fragrances.Add(new CarWashItem("Pine", 0.00m));
                this.bindingSourceFragrances = new BindingSource();
                this.bindingSourceFragrances.DataSource = this.fragrances;


                this.packages = new BindingList<Package>();
                packages.Add(new Package("Standard", 7.50m, new List<string> { }, new List<string> { "Hand Wash" }));
                packages.Add(new Package("Deluxe", 15.00m, new List<string> { "Shampoo Carpets" }, new List<string> { "Hand Wash", "Hand Wax" }));
                packages.Add(new Package("Executive", 35.00m, new List<string> { "Shampoo Carpets", "Shampoo Upholstery" }, new List<string> { "Hand Wash", "Hand Wax", "Wheel Polish" }));
                packages.Add(new Package("Luxury", 55.00m, new List<string> { "Shampoo Carpets", "Shampoo Upholstery", "Interior Protection Coat" }, new List<string> { "Hand Wash", "Hand Wax", "Wheel Polish", "Detail Engine Compartment" }));
                this.bindingSourcePackages = new BindingSource();
                this.bindingSourcePackages.DataSource = packages;

                this.mnuToolsGenerateInvoice.Click += MnuToolsGenerateInvoice_Click;
                mnuFileClose.Click += MnuFileClose_Click; ;

                ReadData();

                BindControls();          
        }

        /// <summary>
        /// sets up closing the form
        /// </summary>
        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// brings up another form
        /// </summary>
        private void MnuToolsGenerateInvoice_Click(object sender, EventArgs e)
        {
                CarWahClassInvoice form = new CarWahClassInvoice(bindingSourceCalculations);
                form.ShowDialog();
        }

        /// <summary>
        /// when package is changed the data bind sends 
        /// data so the list fills up with everything you get in that package
        /// its also where the text boxes know when to change
        /// </summary>
        private void CboPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Package selectedPackage = (Package)cboPackage.SelectedItem;
            CarWashItem selectedFragrance = (CarWashItem)cboFragrance.SelectedItem;

           if (selectedFragrance != null && selectedPackage != null)
           {
                lstExterior.DataSource = selectedPackage.ExteriorServices;

                List<string> combinedServices = new List<string>();
                combinedServices.Add("Fragrance - " + selectedFragrance.Description);
                combinedServices.AddRange(selectedPackage.InteriorServices);

                lstInterior.DataSource = combinedServices;

                Calculations();
            }
            else
            {
                lstInterior.DataSource = null;
                lstExterior.DataSource = null;
            }
        }

        /// <summary>
        /// when fragrance is changed the data bind sends 
        /// data so the list fills up with everything you get in that package
        /// its also where the text boxes know when to change
        /// </summary>
        private void CboFragrance_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarWashItem selectedFragrance = (CarWashItem)cboFragrance.SelectedItem;
            Package selectedPackage = (Package)cboPackage.SelectedItem;

            CarWashInvoice carwashinvoice = new CarWashInvoice(0.05m, 0.10m, selectedPackage.Price, selectedFragrance.Price);

            if (selectedFragrance != null && selectedPackage != null)
            {
                List<string> combinedServices = new List<string>();
                combinedServices.Add("Fragrance - " + selectedFragrance.Description);
                combinedServices.AddRange(selectedPackage.InteriorServices);

                lstInterior.DataSource = combinedServices;

                Calculations();
            }
            else
            {
                lstInterior.DataSource = null;
            }
        }

        /// <summary>
        /// where i do some of the data binding 
        /// </summary>
        private void BindControls()
        {
            this.cboFragrance.DataSource = this.bindingSourceFragrances;
            this.cboPackage.DataSource = this.bindingSourcePackages;
            this.cboPackage.SelectedIndex = -1;

            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;
        }

        /// <summary>
        /// where i do all the data binding for the calculations
        /// </summary>
        private void Calculations()
        {
            CarWashItem selectedFragrance = (CarWashItem)cboFragrance.SelectedItem;
            Package selectedPackage = (Package)cboPackage.SelectedItem;

            CarWashInvoice carwashinvoice = new CarWashInvoice(0.05m, 0.10m, selectedPackage.Price, selectedFragrance.Price);
            this.bindingSourceCalculations.DataSource = carwashinvoice;

            Binding subtotal = new Binding("Text", this.bindingSourceCalculations, "SubTotal");
            subtotal.FormatString = "C";
            this.lblSubtotal.DataBindings.Clear();
            this.lblSubtotal.DataBindings.Add(subtotal);

            Binding total = new Binding("Text", this.bindingSourceCalculations, "Total");
            total.FormatString = "C";
            this.lblTotal.DataBindings.Clear();
            this.lblTotal.DataBindings.Add(total);

            Binding pst = new Binding("Text", this.bindingSourceCalculations, "ProvincialSalesTaxCharged");
            pst.FormatString = "C";
            this.lblProvincialSalesTax.DataBindings.Clear();
            this.lblProvincialSalesTax.DataBindings.Add(pst);

            Binding gst = new Binding("Text", this.bindingSourceCalculations, "GoodsAndServicesTaxCharged");
            gst.FormatString = "C";
            this.lblGoodsAndServicesTax.DataBindings.Clear();
            this.lblGoodsAndServicesTax.DataBindings.Add(gst);

            this.cboPackage.SelectedIndexChanged += CboPackage_SelectedIndexChanged;
            this.cboFragrance.SelectedIndexChanged += CboFragrance_SelectedIndexChanged;

        }

        /// <summary>
        /// where i get the fragrances from 
        /// </summary>
        private void ReadData()
        { 
            //BindControls();
            FileStream fileStream;
            fileStream = new FileStream(@"fragrances.txt", FileMode.Open, FileAccess.Read);
           
            StreamReader fileReader;
            fileReader = new StreamReader(fileStream);

            while (fileReader.Peek() != -1)
            {
                CarWashItem carWash;
                string record = fileReader.ReadLine();

                char[] delimiters = { ',' };

                string[] fields = record.Split(delimiters);
           
                string fragranceText = fields[0];
                decimal fragranceValue = decimal.Parse(fields[1]);

                carWash = new CarWashItem(fragranceText, fragranceValue);

                fragrances.Add(carWash);
            }
            fileReader.Close();
        }
    }
}

