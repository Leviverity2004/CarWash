/*
 * Name: Levi Verity
 * Program: Business Information Technology
 * Course: ADEV-2008 Programming 2
 * Created: 2023-05-29
 * Updated: 2023-06-4
 */

using ACE.BIT.ADEV.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Levi.Verity.RRCAGApp
{

    /// <summary>
    /// this is the main menu for my program
    /// </summary>
    public partial class MainMenuForm : Form
    {

        /// <summary>
        /// where i subscribed to all the events
        /// </summary>
        public MainMenuForm()
        {
            //this.IsMdiContainer = true;
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.nmuExit.Click += NmuExit_Click;
            this.nmuAbout.Click += NmuAbout_Click;
            this.nmuSalesQuote.Click += NmuSalesQuote_Click;
            this.nmuCarWash.Click += NmuCarWash_Click;
            this.nmuVehicle.Click += NmuVehicle_Click;
        }

        /// <summary>
        /// where i can pull up VehiclesMenu
        /// </summary>
        private void NmuVehicle_Click(object sender, EventArgs e)
        {
            VehicleDataClass form = new VehicleDataClass();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        /// <summary>
        /// where i can pull up CarWashForm
        /// </summary>
        private void NmuCarWash_Click(object sender, EventArgs e)
        {
            CarWashClass form = new CarWashClass();

            form.MdiParent = this; 
            form.Show();
        }

        /// <summary>
        /// where i can pull up SalesQuoteMenu
        /// </summary>
        private void NmuSalesQuote_Click(object sender, EventArgs e)
        {
            SalesQuoteMenu form;

            form = new SalesQuoteMenu();

            form.ShowDialog();
        }

        /// <summary>
        /// where you can go to the AboutForm
        /// </summary>
        private void NmuAbout_Click(object sender, EventArgs e)
        {
            AboutForm form;

            form = new AboutForm();

            form.ShowDialog();
        }
        
        /// <summary>
        /// can close the application here 
        /// </summary>
        private void NmuExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void nmuFile_Click(object sender, EventArgs e)
        {

        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nmuOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
