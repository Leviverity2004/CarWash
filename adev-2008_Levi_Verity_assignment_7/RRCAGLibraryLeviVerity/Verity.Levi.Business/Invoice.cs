/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-05-10
 * Updated: 2019-05-14
 */
using System;

namespace Verity.Levi.Business
{

    /// <summary>
    /// Class for an invoice 
    /// </summary>
    public abstract class Invoice
    {
        private decimal provincialSalesTaxRate;
        private decimal goodsAndServicesTaxRate;

        /// <summary>
        /// happens when provincialSalesTaxRate is changed  
        /// </summary>
        public event EventHandler ProvincialSalesTaxRateChanged;

        /// <summary>
        /// happens when goodsAndServicesTaxRate is changed 
        /// </summary>
        public event EventHandler GoodsAndServicesTaxRateChanged;

        /// <summary>
        /// gets and sets the Provincial sales tax 
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// happens when ProvincialSalesTaxRate is less then 0 or more then1
        /// </exception
        public decimal ProvincialSalesTaxRate
        {
            get 
            {
                return this.provincialSalesTaxRate;
            }
            set
            {
                if (provincialSalesTaxRate < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0");
                }
                else if (provincialSalesTaxRate > 1)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be greater than 1");
                }

                if (this.provincialSalesTaxRate != value)
                {
                    this.provincialSalesTaxRate = value;
                    OnProvincialSalesTaxRateChanged();
                }
                this.provincialSalesTaxRate = value;
            }
        }


        /// <summary>
        /// gets and sets the goods and services tax rate
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// happens when GoodsAndServicesTaxRate is less then 0 or more then 1
        /// </exception
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return this.goodsAndServicesTaxRate;
            }
            set
            {
                if(goodsAndServicesTaxRate < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }
                else if (goodsAndServicesTaxRate > 1)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be greater than 1.");
                }

                if (this.goodsAndServicesTaxRate != value)
                {
                    this.goodsAndServicesTaxRate = value;
                    OnGoodsAndServicesTaxRateChanged();
                }

                this.goodsAndServicesTaxRate = value;

                }
            }

        /// <summary>
        /// gets the provincial sales tax charge 
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged 
        { 
            get; 
        }

        /// <summary>
        /// gets the goods and services tax charge
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged 
        {
            get; 
        }

        /// <summary>
        /// gets the sub total
        /// </summary>
        public abstract decimal SubTotal 
        { 
            get; 
        }

        /// <summary>
        /// gets the total
        /// </summary>
        public decimal Total
        {
            get
            { 
                return SubTotal + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged; 
            }
        }

        /// <summary>
        /// Check if there are any subscribers to the ProvincialSalesTaxRate
        /// </summary>
        protected virtual void OnProvincialSalesTaxRateChanged()
        {
            if(ProvincialSalesTaxRateChanged != null)
            {
                ProvincialSalesTaxRateChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Check if there are any subscribers to the GoodsAndServicesTaxRate
        /// </summary>
        protected virtual void OnGoodsAndServicesTaxRateChanged()
        {
            if(GoodsAndServicesTaxRateChanged != null)
            {
                GoodsAndServicesTaxRateChanged(this, EventArgs.Empty);
            }
           
        }

        /// <summary>
        /// constructor for invoice class 
        /// </summary>
        /// <param name="provincialSalesTaxRate"> can set the provincial sales tax rate. </param>
        /// <param name="goodsAndServicesTaxRate"> can set the goods and services tax rate. </param>
        /// <exception cref="ArgumentOutOfRangeException"> happens when ProvincialSalesTaxRate is less then 0 or more then1 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> happens when GoodsAndServicesTaxRate is less then 0 or more then 1 </exception>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be less than 0.");
            }

            if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be greater than 1.");
            }

            if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be less than 0.");
            }

            if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be greater than 1.");
            }

            this.provincialSalesTaxRate = provincialSalesTaxRate;
            this.goodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }
    }
}