/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-05-10
 * Updated: 2019-05-14
 */

namespace Verity.Levi.Business
{
    /// <summary>
    /// Enumeration to represent accessories available for purchase
    /// </summary>
   
    public enum Accessories
    {
        /// <summary>
        /// can use if want StereoSystem in car
        /// </summary>
        StereoSystem = 0,

        /// <summary>
        /// can use if want LeatherInterior in car
        /// </summary>
        LeatherInterior = 1,

        /// <summary>
        /// can use if want StereoAndLeather in car
        /// </summary>
        StereoAndLeather = 2,

        /// <summary>
        /// can use if want ComputerNavigation in car
        /// </summary>
        ComputerNavigation = 3,

        /// <summary>
        /// can use if want StereoAndNavigation in car
        /// </summary>
        StereoAndNavigation = 4,

        /// <summary>
        /// can use if want LeatherAndNavigation in car
        /// </summary>
        LeatherAndNavigation = 5,

        /// <summary>
        /// can use if want All in car
        /// </summary>
        All = 6,

        /// <summary>
        /// can use if want None in car
        /// </summary>
        None = 7,

    }
}