using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_App
{
    public partial class Payment_Portal : Form
    {
        public Payment_Portal()
        {
            InitializeComponent();
        }

        // validate card number
        private bool IsValidCardNumber(string cardNumber)
        {
            return Regex.IsMatch(cardNumber, @"^\d{16}$");
        }

        // validate CVV
        private bool IsValidCVV(string cvv)
        {
            return Regex.IsMatch(cvv, @"^\d{3}$");
        }

        // validate expiration date
        private bool IsValidExpDate(string expDate)
        {
            return Regex.IsMatch(expDate, @"^\d{2}/\d{2}$");
        }

        // validate cardholder name
        private bool IsValidCardholderName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        private void paynw_Click(object sender, EventArgs e)
        {
            // Validate card number
            if (!IsValidCardNumber(cno.Text))
            {
                MessageBox.Show("Invalid card number.");
                return;
            }

            // Validate CVV
            if (!IsValidCVV(cvv.Text))
            {
                MessageBox.Show("Invalid CVV.");
                return;
            }

            // Validate expiration date
            if (!IsValidExpDate(exp.Text))
            {
                MessageBox.Show("Invalid expiration date. 4-digit date in MM/YY format.");
                return;
            }

            // Validate cardholder name
            if (!IsValidCardholderName(chname.Text))
            {
                MessageBox.Show("Invalid cardholder name.");
                return;
            }

            // Payment successful
            MessageBox.Show("Payment successful");

            this.Close();
        }

        private void clss_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
