using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventOrganizer
{
    public partial class MainForm : Form
    {
        private EventManager eventManager;
        private GroupBox grpNewEvent, grpAddGuests, grpSummary;
        private Label lblMaxGuests, lblCostPerPerson, lblFeePerPerson, lblFirstName, lblLastName;
        private Label lblGuestList, lblNumGuestsValue, lblTotalCostValue, lblTotalFeesValue, lblSurplusDeficitValue;
        private TextBox txtMaxGuests, txtCostPerPerson, txtFeePerPerson, txtFirstName, txtLastName;
        private Button btnCreateList, btnAddGuest, btnEditGuest, btnRemoveGuest;
        private Label lblNumGuests, lblTotalCost, lblTotalFees, lblSurplusDeficit;
        private ListBox lstGuests;

        // constructor
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        // initialize gui components
        private void InitializeGUI()
        {
            // form properties
            this.Text = "Event Organizer by Obada Hana";
            // new event groupbox
            grpNewEvent = new GroupBox { Text = "New Event", Location = new Point(10, 10), Size = new Size(240, 150), Enabled = true };
            lblMaxGuests = new Label { Text = "Max number of guests", Location = new Point(10, 25), Size = new Size(130, 25) };
            txtMaxGuests = new TextBox { Name = "txtMaxGuests", Location = new Point(150, 25), Size = new Size(75, 25) };
            lblCostPerPerson = new Label { Text = "Cost per person", Location = new Point(10, 55), Size = new Size(130, 25) };
            txtCostPerPerson = new TextBox { Name = "txtCostPerPerson", Location = new Point(150, 55), Size = new Size(75, 25) };
            lblFeePerPerson = new Label { Text = "Fee per person", Location = new Point(10, 85), Size = new Size(130, 25) };
            txtFeePerPerson = new TextBox { Name = "txtFeePerPerson", Location = new Point(150, 85), Size = new Size(75, 25) };
            btnCreateList = new Button
            {
                Text = "Create List",
                Location = new Point(40, 115),
                Size = new Size(150, 30),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnCreateList.Click += btnCreateList_Click;
            grpNewEvent.Controls.AddRange(new Control[] { lblMaxGuests, txtMaxGuests, lblCostPerPerson, txtCostPerPerson, lblFeePerPerson, txtFeePerPerson, btnCreateList });
            this.Controls.Add(grpNewEvent);

            // add guests groupbox
            grpAddGuests = new GroupBox { Text = "Add Guests", Location = new Point(10, 170), Size = new Size(240, 120), Enabled = false };
            lblFirstName = new Label { Text = "First Name", Location = new Point(10, 25), Size = new Size(130, 25) };
            txtFirstName = new TextBox { Name = "txtFirstName", Location = new Point(150, 25), Size = new Size(75, 25) };
            lblLastName = new Label { Text = "Last Name", Location = new Point(10, 55), Size = new Size(130, 25) };
            txtLastName = new TextBox { Name = "txtLastName", Location = new Point(150, 55), Size = new Size(75, 25) };
            btnAddGuest = new Button
            {
                Text = "Add Guest",
                Location = new Point(40, 85),
                Size = new Size(150, 30),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            btnAddGuest.Click += btnAddGuest_Click;
            grpAddGuests.Controls.AddRange(new Control[] { lblFirstName, txtFirstName, lblLastName, txtLastName, btnAddGuest });
            this.Controls.Add(grpAddGuests);

            // summary groupbox
            grpSummary = new GroupBox { Text = "Summary", Location = new Point(10, 300), Size = new Size(240, 140) };
            lblNumGuests = new Label { Text = "Number of guests", Location = new Point(10, 25), Size = new Size(130, 25) };
            lblNumGuestsValue = new Label { Name = "lblNumGuestsValue", Location = new Point(150, 25), Size = new Size(75, 25) };
            lblTotalCost = new Label { Text = "Total Cost", Location = new Point(10, 55), Size = new Size(130, 25) };
            lblTotalCostValue = new Label { Name = "lblTotalCostValue", Location = new Point(150, 55), Size = new Size(75, 25) };
            lblTotalFees = new Label { Text = "Total fees", Location = new Point(10, 85), Size = new Size(130, 25) };
            lblTotalFeesValue = new Label { Name = "lblTotalFeesValue", Location = new Point(150, 85), Size = new Size(75, 25) };
            lblSurplusDeficit = new Label { Text = "Surplus/deficit", Location = new Point(10, 115), Size = new Size(130, 25) };
            lblSurplusDeficitValue = new Label { Name = "lblSurplusDeficitValue", Location = new Point(150, 115), Size = new Size(75, 25) };
            grpSummary.Controls.AddRange(new Control[] { lblNumGuests, lblNumGuestsValue, lblTotalCost, lblTotalCostValue, lblTotalFees, lblTotalFeesValue, lblSurplusDeficit, lblSurplusDeficitValue });
            this.Controls.Add(grpSummary);

            // guest list and buttons
            lblGuestList = new Label { Text = "Guest List", Location = new Point(270, 10), Size = new Size(120, 25) };
            lstGuests = new ListBox { Location = new Point(270, 35), Size = new Size(210, 380) };
            lstGuests.SelectedIndexChanged += lstGuests_SelectedIndexChanged;
            btnEditGuest = new Button
            {
                Text = "Edit Guest",
                Location = new Point(270, 420),
                Size = new Size(100, 30),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnEditGuest.Click += btnEditGuest_Click;
            btnRemoveGuest = new Button
            {
                Text = "Remove Guest",
                Location = new Point(380, 420),
                Size = new Size(100, 30),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };
            btnRemoveGuest.Click += btnRemoveGuest_Click;
            this.Controls.AddRange(new Control[] { lblGuestList, lstGuests, btnEditGuest, btnRemoveGuest });

            // clear initial controls
            ClearInputControls();
            ClearOutputControls();
        }

        // clear input controls
        private void ClearInputControls()
        {
            txtMaxGuests.Text = string.Empty;
            txtCostPerPerson.Text = string.Empty;
            txtFeePerPerson.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        // clear output controls
        private void ClearOutputControls()
        {
            lblNumGuestsValue.Text = "0";
            lblTotalCostValue.Text = "0.00 Sek";
            lblTotalFeesValue.Text = "0.00 Sek";
            lblSurplusDeficitValue.Text = "0.00 Sek";
            lstGuests.Items.Clear();
        }

        // create list button click event
        private void btnCreateList_Click(object sender, EventArgs e)
        {
            // validate inputs
            if (int.TryParse(txtMaxGuests.Text, out int maxGuests) &&
                double.TryParse(txtCostPerPerson.Text, out double cost) &&
                double.TryParse(txtFeePerPerson.Text, out double fee) &&
                maxGuests > 0 && cost >= 0 && fee >= 0)
            {
                // create new eventmanager instance
                eventManager = new EventManager(maxGuests);
                eventManager.CostPerPerson = cost;
                eventManager.FeePerPerson = fee;

                // enable add guests groupbox
                grpAddGuests.Enabled = true;
                grpNewEvent.Enabled = false;
                ClearInputControls();
                UpdateGuestList();
            }
            else
            {
                MessageBox.Show("Invalid input. Ensure all fields are numeric and non-negative.", "Error");
            }
        }

        // add guest button click event
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter both first and last names.", "Error");
                return;
            }

            bool added = eventManager.AddNewGuest(txtFirstName.Text, txtLastName.Text);
            if (added)
            {
                UpdateGuestList();
                ClearInputControls();
            }
            else
            {
                MessageBox.Show("Cannot add guest. List may be full.", "Error");
            }
        }

        // edit guest button click event
        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            if (lstGuests.SelectedIndex >= 0 &&
                !string.IsNullOrEmpty(txtFirstName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text))
            {
                bool changed = eventManager.ChangeAt(lstGuests.SelectedIndex, txtFirstName.Text, txtLastName.Text);
                if (changed)
                {
                    UpdateGuestList();
                    ClearInputControls();
                }
                else
                {
                    MessageBox.Show("Failed to edit guest.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Select a guest and enter valid names.", "Error");
            }
        }

        // remove guest button click event
        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
            if (lstGuests.SelectedIndex >= 0)
            {
                bool removed = eventManager.DeleteAt(lstGuests.SelectedIndex);
                if (removed)
                {
                    UpdateGuestList();
                }
                else
                {
                    MessageBox.Show("Failed to remove guest.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please select a guest to remove.", "Error");
            }
        }

        // listbox selection changed event
        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGuests.SelectedIndex >= 0)
            {
                string guest = eventManager.GetItemAt(lstGuests.SelectedIndex);
                if (!string.IsNullOrEmpty(guest))
                {
                    string[] names = guest.Split(new[] { ", " }, StringSplitOptions.None);
                    if (names.Length == 2)
                    {
                        txtLastName.Text = names[0];
                        txtFirstName.Text = names[1];
                    }
                }
            }
        }

        // update guest list and summary
        private void UpdateGuestList()
        {
            lstGuests.Items.Clear();
            string[] guests = eventManager.GetGuestList();
            int index = 1;
            foreach (string guest in guests)
            {
                lstGuests.Items.Add($"{index} {guest}");
                index++;
            }

            // update summary
            lblNumGuestsValue.Text = eventManager.Count.ToString();
            lblTotalCostValue.Text = eventManager.CalcTotalCost().ToString("C");
            lblTotalFeesValue.Text = eventManager.CalcTotalFees().ToString("C");
            double surplusDeficit = eventManager.CalcTotalFees() - eventManager.CalcTotalCost();
            lblSurplusDeficitValue.Text = surplusDeficit.ToString("C");
        }
    }
}