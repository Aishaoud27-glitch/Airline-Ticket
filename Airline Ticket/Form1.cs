using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtPassengerName.Text;
            int age;
            int tickets;
            double baggage;

            if (string.IsNullOrWhiteSpace(name) ||
                !int.TryParse(txtPassengerAge.Text, out age) ||
                !int.TryParse(txtNumberOfTicket.Text, out tickets) ||
                !double.TryParse(txtBaggageWeight.Text, out baggage))
            {
                MessageBox.Show("Please enter valid passenger details.");
                return;
            }

            if (tickets <= 0 || age <= 0 || baggage < 0)
            {
                MessageBox.Show("Please enter valid positive values.");
                return;
            }

            double price = 0;

            if (rdoFirstClass.Checked)
                price = 300;
            else if (rdoNormalClass.Checked)
                price = 100;
            else if (rdoBusinessClass.Checked)
                price = 200;
            else
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            double insurance = chkTravelInsurance.Checked
                ? 10 * tickets : 0;

            double total = (price * tickets) + insurance;

            lstBooking.Items.Add("Passenger: " + name);
            lstBooking.Items.Add("Age: " + age);
            lstBooking.Items.Add("Tickets: " + tickets);
            lstBooking.Items.Add("Baggage: " + baggage + " kg");
            lstBooking.Items.Add("Ticket price: $" + price);
            lstBooking.Items.Add("Insurance: $" + insurance);
            lstBooking.Items.Add("Total: $" + total);
            lstBooking.Items.Add("-------------------------");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTicket.Clear();
            txtBaggageWeight.Clear();

            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;
            chkTravelInsurance.Checked = false;

            lstBooking.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
