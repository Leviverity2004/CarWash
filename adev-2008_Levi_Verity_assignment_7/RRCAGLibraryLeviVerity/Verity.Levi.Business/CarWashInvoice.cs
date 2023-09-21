/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-05-10
 * Updated: 2023-05-14
 */
using System;

namespace Verity.Levi.Business
{

    /// <summary>
    /// A class for a car wash that extends invoice
    /// </summary>
    public class CarWashInvoice : Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;

        /// <summary>
        /// happens when PackageCostChanged is changed  
        /// </summary>
        public event EventHandler PackageCostChanged;

        /// <summary>
        /// happens when FragranceCostChanged is changed  
        /// </summary>
        public event EventHandler FragranceCostChanged;

        /// <summary>
        /// gets and sets the package cost
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"> package cost cant be less then 0 </exception>
        public decimal PackageCost
        {
            get
            {
                return packageCost;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                if(packageCost != value)
                {
                    this.packageCost = value;
                    OnPackageCostChanged(); 
                }
                packageCost = value;
            }
        }

        /// <summary>
        /// gets and sets the fragrance cost
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"> fragrance cost cant be less then 0 </exception>
        public decimal FragranceCost
        {
            get
            {
                return fragranceCost;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }

                if (fragranceCost != value)
                {
                    this.fragranceCost = value;
                    OnFragranceCostChanged();
                }

                fragranceCost = value;
            }
        }

        /// <summary>
        /// gets the provincial sales tax charged unless you get a car wash
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {   
                    return 0m;
            }
        }

        /// <summary>
        /// gets the goods and services tax charged
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get
            {
                return Math.Round(SubTotal * GoodsAndServicesTaxRate, 2);
            }
        }

        /// <summary>
        /// gets sub total
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                return PackageCost + FragranceCost;
            }
        }

        /// <summary>
        /// Check if there are any subscribers to the PackageCost
        /// </summary>
        protected virtual void OnPackageCostChanged()
        {
            if (PackageCostChanged != null)
            {
                PackageCostChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Check if there are any subscribers to the FragranceCost
        /// </summary>
        protected virtual void OnFragranceCostChanged()
        {
            if(FragranceCostChanged != null)
            {
                FragranceCostChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// constructor for CarWashInvoice
        /// </summary>
        /// <param name="provincialSalesTaxRate"> can set the provincial sales tax rate</param>
        /// <param name="goodsAndServicesTaxRate"> can set the goods and services tax rate</param>
        /// <exception cref="ArgumentOutOfRangeException"> provincial Sales TaxRate cant be less then 0 or more then 1 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> goods And Services TaxRate cant be less then 0 or more then 1 </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {

        }

        /// <summary>
        /// constructor for CarWashInvoice
        /// </summary>
        /// <param name="provincialSalesTaxRate"> can set the provincial sales tax rate</param>
        /// <param name="goodsAndServicesTaxRate"> can set the goods and services tax rate</param>
        /// <param name="packageCost"> can set the package cost </param>
        /// <param name="fragranceCost"> can set the fragrance cost</param>
        /// <exception cref="ArgumentOutOfRangeException"> provincial Sales TaxRate cant be less then 0 or more then 1 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> goods And Services TaxRate cant be less then 0 or more then 1 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> package cost can not be less then 0 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> fragrance cost can not be less then 0 </exception>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate, decimal packageCost, decimal fragranceCost) : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if (packageCost < 0)
                throw new ArgumentOutOfRangeException("packageCost", "The argument cannot be less than 0.");
            if (fragranceCost < 0)
                throw new ArgumentOutOfRangeException("fragranceCost", "The argument cannot be less than 0.");

            this.packageCost = packageCost;
            this.fragranceCost = fragranceCost;
        }
    }
}
