using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Try catch block to catch any exceptions
            try 
            {
                // Named constants
                decimal MIN_SALARY = 40000m;
                int MIN_YEARS = 2;

                // Local variables
                decimal annualSalary;
                int years;

                // Get the annual salary
                annualSalary = decimal.Parse(salaryTextBox.Text);
                years = int.Parse(yearsTextBox.Text);

                // Determine whether the user qualifies for the loan
                if (annualSalary >= MIN_SALARY)
                {
                    if (years >= MIN_YEARS)
                    {
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        decisionLabel.Text = "I am sorry, you must have been on your current job " +
                                                       "for at least two years to qualify for the loan.";
                    }
                }
                else 
                {
                    decisionLabel.Text = "I am sorry, but you do not meet the minimum salary requirements";
                }
            }
            catch (Exception ex) 
            {
                // Display an error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salaryTextBox.Clear();
            yearsTextBox.Clear();
            decisionLabel.Text = String.Empty;

            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
