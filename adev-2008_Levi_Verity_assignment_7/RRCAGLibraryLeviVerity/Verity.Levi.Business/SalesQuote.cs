/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-05-10
 * Updated: 2019-05-14
 */

using System;
using System.ComponentModel;

namespace Verity.Levi.Business
{
    /// <summary>
    /// Class for a sales quote
    /// </summary>
    public class SalesQuote
    {
        private decimal vehicleSalePrice;
        private decimal tradeInAmount;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;
        private decimal salesTaxRate;

        /// <summary>
        /// happens when vehicle price is changed 
        /// </summary>
        public event EventHandler VehiclePriceChanged;

        /// <summary>
        /// happens when trade in amount price is changed 
        /// </summary>
        public event EventHandler TradeInAmountChanged;

        /// <summary>
        /// happens when accessories price is changed 
        /// </summary>
        public event EventHandler AccessoriesChosenChanged;

        /// <summary>
        /// happens when exterior finish price is changed 
        /// </summary>
        public event EventHandler ExteriorFinishChosenChanged;

        /// <summary>
        /// gets and sets vehicle sale price.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// happens when Vehicle Sale Price is less then or equal to 0
        /// </exception>
        public decimal VehicleSalePrice
        {
            get
            {
                return this.vehicleSalePrice;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Value", "The value cannot be less than or equal to 0.");
                }

                if (this.vehicleSalePrice != value)
                {
                    this.vehicleSalePrice = value;
                    OnVehiclePriceChanged();
                }
                this.vehicleSalePrice = value;
            }
        }

        /// <summary>
        /// gets and sets trade in amount.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// happens when trade in amount is less then 0.
        /// </exception>
        public decimal TradeInAmount
        {
            get
            {
                return this.tradeInAmount;
            }
            set
            {
              
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The value cannot be less than 0.");
                }

                if (this.tradeInAmount != value)
                {
                    this.tradeInAmount = value;
                    OnTradeInAmountChanged();
                }
               
                this.tradeInAmount = value;
            }
        }


        /// <summary>
        /// gets and sets Accessories.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">
        /// happens when use enum thats not in the code.
        /// </exception>
        public Accessories AccessoriesChosen
        {
            get
            {
                return this.accessoriesChosen;
            }
            set
            {
                if (!Enum.IsDefined(typeof(Accessories), value))
                {
                    throw new InvalidEnumArgumentException("The value is an invalid enumeration value.", (int)value, typeof(Accessories));
                }
                if (this.accessoriesChosen != value)
                {
                    this.accessoriesChosen = value;
                    OnAccessoriesChosenChanged();
                }

                this.accessoriesChosen = value;
            }
        }

        /// <summary>
        /// gets and sets Exterior Finish.
        /// </summary>
        /// <exception cref="InvalidEnumArgumentException">
        /// happens when use enum thats not in the code.
        /// </exception>
        public ExteriorFinish ExteriorFinishChosen
        {
            get
            {
                return this.exteriorFinishChosen;
            }
            set
            {
                
                if (!Enum.IsDefined(typeof(ExteriorFinish), value))
                {
                    throw new InvalidEnumArgumentException("The value is an invalid enumeration value.", (int)value, typeof(ExteriorFinish));
                }

                if (this.exteriorFinishChosen != value)
                {
                    this.exteriorFinishChosen = value;
                    OnExteriorFinishChosenChanged();
                }
                this.exteriorFinishChosen = value;
            }
        }

        /// <summary>
        /// gets the price of an accessory.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                const decimal StereoSystem = 202.02m;
                const decimal LeatherInterior = 1010.10m;
                const decimal ComputerNavigation = 1515.15m;

                decimal accessoriesCost = 0;

                if (accessoriesChosen == Accessories.StereoSystem)
                {
                    accessoriesCost = StereoSystem;
                }
                else if (accessoriesChosen == Accessories.LeatherInterior)
                {
                    accessoriesCost = LeatherInterior;
                }
                else if (accessoriesChosen == Accessories.ComputerNavigation)
                {
                    accessoriesCost = ComputerNavigation;
                }
                else if (accessoriesChosen == Accessories.StereoAndLeather)
                {
                    accessoriesCost = StereoSystem + LeatherInterior;
                }
                else if (accessoriesChosen == Accessories.StereoAndNavigation)
                {
                    accessoriesCost = StereoSystem + ComputerNavigation;
                }
                else if (accessoriesChosen == Accessories.LeatherAndNavigation)
                {
                    accessoriesCost = LeatherInterior + ComputerNavigation;
                }
                else if (accessoriesChosen == Accessories.All)
                {
                    accessoriesCost = StereoSystem + ComputerNavigation + LeatherInterior;
                }
                else if (accessoriesChosen == Accessories.None)
                {
                    accessoriesCost = 0;
                }

                return accessoriesCost;
            }

        }

        /// <summary>
        /// gets the price of the fish cost.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                const decimal Standard = 202.02m;
                const decimal Pearlized = 404.04m;
                const decimal Custom = 606.06m;
                const decimal None = 0m;

                decimal exteriorCost = None;

                switch (exteriorFinishChosen)
                {
                    case ExteriorFinish.Standard:
                        exteriorCost = Standard;
                        break;
                    case ExteriorFinish.Pearlized:
                        exteriorCost = Pearlized;
                        break;
                    case ExteriorFinish.Custom:
                        exteriorCost = Custom;
                        break;
                    default:
                        break;
                }

                return exteriorCost;
            }
        }

        /// <summary>
        /// gets the price of the fish cost and accessory.
        /// </summary>
        public decimal TotalOptions
        {
            get
            {
                decimal optionsCost = AccessoryCost + FinishCost;
                return Math.Round(optionsCost, 2);
            }
        }

        /// <summary>
        /// gets the price of the car accessory's and finishes cost.
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                decimal subTotal = VehicleSalePrice + AccessoryCost + FinishCost;
                return Math.Round(subTotal, 2);
            }
        }

        /// <summary>
        /// gets the price of the sales tax on the car.
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                decimal salesTax = SubTotal * salesTaxRate;
                return Math.Round(salesTax, 2);
            }
        }

        /// <summary>
        /// gets the total price of the car.
        /// </summary>
        public decimal Total
        {
            get
            {
                decimal total = SubTotal + SalesTax;
                return Math.Round(total, 2);
            }
        }

        /// <summary>
        /// gets the price of the car after trade in amount.
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                decimal amountDue = Total - TradeInAmount;
                return Math.Round(amountDue, 2);
            }
        }

        /// <summary>
        /// Check if there are any subscribers to the VehiclePrice
        /// </summary>
        protected virtual void OnVehiclePriceChanged()
        {
            if (VehiclePriceChanged != null)
            {
                VehiclePriceChanged(this, new EventArgs());
            }      
        }

        /// <summary>
        /// Check if there are any subscribers to the TradeInAmount
        /// </summary>
        protected virtual void OnTradeInAmountChanged()
        {
            if (TradeInAmountChanged != null)
            {
                TradeInAmountChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Check if there are any subscribers to the AccessoriesChosen
        /// </summary>
        protected virtual void OnAccessoriesChosenChanged()
        {
            if (AccessoriesChosenChanged != null)
            {
                AccessoriesChosenChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Check if there are any subscribers to the ExteriorFinishChosen
        /// </summary>
        protected virtual void OnExteriorFinishChosenChanged()
        {
            if (ExteriorFinishChosenChanged != null)
            {
                ExteriorFinishChosenChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// constructor for the Sales Quote class 
        /// </summary>
        /// <param name="vehicleSalePrice"> Where you can set the cars sales price </param>
        /// <param name="tradeInAmount"> where you can set the trade in amount </param>
        /// <param name="salesTaxRate"> where you can set the sales tax </param>
        /// <param name="accessoriesChosen"> where you can set the accessories </param>
        /// <param name="exteriorFinishChosen"> where you can set the exterior finish </param>
        /// <exception cref="ArgumentOutOfRangeException"> happens when Vehicle Sale Price is less then or equal to 0 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> happens when trade in amount is less then 0. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> happens when sales tax is more then 1 and less then 0. </exception>
        /// <exception cref="InvalidEnumArgumentException"> happens for both accessories and exterior finish if you pick one thats not in the code</exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate, Accessories accessoriesChosen, ExteriorFinish exteriorFinishChosen)
        {
            if (vehicleSalePrice <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(vehicleSalePrice), "The argument cannot be less than or equal to 0.");
            }

            if (tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(tradeInAmount), "The argument cannot be less than 0.");
            }

            if (salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(salesTaxRate), "The argument cannot be less than 0.");
            }

            if (salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(salesTaxRate), "The argument cannot be greater than 1.");
            }

            if (!Enum.IsDefined(typeof(Accessories), accessoriesChosen))
            {
                throw new InvalidEnumArgumentException(nameof(accessoriesChosen), (int)accessoriesChosen, typeof(Accessories));
            }

            if (!Enum.IsDefined(typeof(ExteriorFinish), exteriorFinishChosen))
            {
                throw new InvalidEnumArgumentException(nameof(exteriorFinishChosen), (int)exteriorFinishChosen, typeof(ExteriorFinish));
            }

            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }


        /// <summary>
        /// another constructor without accessories and exterior finish
        /// </summary>
        /// <param name="vehicleSalePrice"> Where you can set the cars sales price </param>
        /// <param name="tradeInAmount"> where you can set the trade in amount </param>
        /// <param name="salesTaxRate"> where you can set the sales tax </param>
        /// <exception cref="ArgumentOutOfRangeException"> happens when Vehicle Sale Price is less then or equal to 0 </exception>
        /// <exception cref="ArgumentOutOfRangeException"> happens when trade in amount is less then 0. </exception>
        /// <exception cref="ArgumentOutOfRangeException"> happens when sales tax is more then 1 and less then 0. </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
         : this(vehicleSalePrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None)
        {

        }

    }
}

    