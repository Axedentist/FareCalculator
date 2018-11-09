using System;
using System.Windows.Forms;
using System.Configuration;

namespace FareCalculator
{
    public partial class Form1 : Form
    {
        // field variables grabbed from config file. 
        double SeattleFare = double.Parse(ConfigurationManager.AppSettings["SeattleFare"]);
        double VanBCFare = double.Parse(ConfigurationManager.AppSettings["VanBCFare"]);
        double EugeneFare = double.Parse(ConfigurationManager.AppSettings["EugeneFare"]);

        public Form1()
        {
            InitializeComponent();

            // if config file changes, the form numbers will change with it
            ListBoxDestination.Items.Add("Seattle, WA " + SeattleFare.ToString("f2"));
            ListBoxDestination.Items.Add("Vancouver, BC " + VanBCFare.ToString("f2"));
            ListBoxDestination.Items.Add("Eugene, OR " + EugeneFare.ToString("f2"));
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            double TwoWayDiscount = .9;
            double Fare = 0.0;
            int TicketNum = 0;
            // setup the flags
            Boolean NoDestination = false;
            Boolean NoTickets = false;
            Boolean BadInt = false;
            Boolean NoRadio = false;
            // check text box
            if (int.TryParse(TextBoxNum.Text, out TicketNum))
            {
                if (TicketNum < 1 || TicketNum > 9)
                    BadInt = true;
            }
            else
            {
                BadInt = true;
            }
            // check that other inputs were selected.
            if (ListBoxDestination.SelectedIndex.Equals(-1))
                NoDestination = true;
            if (!RadioButtonRoundTrip.Checked && !RadioButtonOneWay.Checked)
                NoRadio = true;
            if (TextBoxNum.Text.Equals(string.Empty))
                NoTickets = true;
           
            // If flags were tripped, throw error
            if (NoDestination || NoTickets || NoRadio || BadInt)
            {
                LabelOutput.Text = "There are invalid inputs. Please fill out the entire form";
                // stop program due to errors
                return;
            }

            if (ListBoxDestination.SelectedIndex.Equals(0))
                Fare = SeattleFare;
            else if (ListBoxDestination.SelectedIndex.Equals(1))
                Fare = VanBCFare;
            else if (ListBoxDestination.SelectedIndex.Equals(2))
                Fare = EugeneFare;

            if (RadioButtonRoundTrip.Checked)
                Fare = Fare * 2 * TwoWayDiscount;

            Fare = Fare * TicketNum;
            LabelOutput.Text = "Fare: " + Fare.ToString("c");
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            ListBoxDestination.SelectedIndex = -1;
            LabelOutput.Text = string.Empty;
            RadioButtonRoundTrip.Checked = false;
            RadioButtonOneWay.Checked = false;
            TextBoxNum.Text = string.Empty;
        }
    }
}
