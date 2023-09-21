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
    public static class Financial
    {

        /// <summary>
        /// Calculates the regular payment required to pay off a loan based on the interest rate, number of payment periods and present value of the loan
        /// </summary>
        /// <param name="rate">The interest rate of the loan, expressed as a decimal</param>
        /// <param name="numberOfPaymentPeriods">The number of payment periods (e.g. months) it will take to pay off the loan</param>
        /// <param name="presentValue">The present value of the loan (i.e. the amount borrowed)</param>
        /// <returns>The regular payment required to pay off the loan</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the rate is less than 0 or greater than 1,
        /// the number of payment periods is less than or equal to 0, 
        /// or the present value is less than or equal to 0</exception>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods, decimal presentValue)
        {
            if (rate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rate), "The argument cannot be less than 0.");
            }

            if (rate > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rate), "The argument cannot be greater than 1.");
            }

            if (numberOfPaymentPeriods <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numberOfPaymentPeriods), "The argument cannot be less than or equal to 0.");
            }

            if (presentValue <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(presentValue), "The argument cannot be less than or equal to 0.");
            }

            decimal futureValue = 0;
            decimal type = 0;
            decimal payment = 0;

            if (rate == 0)
            {
                payment = presentValue / numberOfPaymentPeriods;        
            }
            else
            {
                payment = rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));
            }

            return Math.Round(payment, 2);

        }

    }

}