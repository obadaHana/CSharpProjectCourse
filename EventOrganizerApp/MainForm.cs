using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public partial class MainForm : Form
{
    // Event manager instance
    private EventManager eventManager = new EventManager();

    // GUI Controls
    private Label lblHeader;
    private GroupBox grpNewEvent;
    private TextBox txtEventTitle;
    private TextBox txtCostPerPerson;
    private TextBox txtFeePerPerson;
    private Button btnCreateEvent;

    private GroupBox grpAddParticipant;
    private TextBox txtFirstName;
    private TextBox txtLastName;
    private TextBox txtStreet;
    private TextBox txtZip;
    private TextBox txtCity;
    private ComboBox cmbCountry;
    private Button btnAdd;
    private Button btnChange;
    private Button btnDelete;

    private GroupBox grpParticipants;
    private ListBox lstParticipants;

    private GroupBox grpSummary;
    private Label lblNumParticipantsLabel;
    private Label lblNumParticipants;
    private Label lblTotalCostLabel;
    private Label lblTotalCost;
    private Label lblTotalFeesLabel;
    private Label lblEventTitle;
    private Label lblCost;
    private Label lblFee;
    private Label lblFirstName;
    private Label lblLastName;
    private Label lblStreet;
    private Label lblZip;
    private Label lblCity;
    private Label lblCountry;
    private Label lblTotalFees;

    public MainForm()
    {
        InitializeComponent();
        InitializeGUI();
    }

    private void InitializeComponent()
    {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpNewEvent = new System.Windows.Forms.GroupBox();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCostPerPerson = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtFeePerPerson = new System.Windows.Forms.TextBox();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.grpAddParticipant = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpParticipants = new System.Windows.Forms.GroupBox();
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblNumParticipantsLabel = new System.Windows.Forms.Label();
            this.lblNumParticipants = new System.Windows.Forms.Label();
            this.lblTotalCostLabel = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalFeesLabel = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.grpNewEvent.SuspendLayout();
            this.grpAddParticipant.SuspendLayout();
            this.grpParticipants.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(367, 21);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Event manager By Obada Hana";
            // 
            // grpNewEvent
            // 
            this.grpNewEvent.Controls.Add(this.lblEventTitle);
            this.grpNewEvent.Controls.Add(this.txtEventTitle);
            this.grpNewEvent.Controls.Add(this.lblCost);
            this.grpNewEvent.Controls.Add(this.txtCostPerPerson);
            this.grpNewEvent.Controls.Add(this.lblFee);
            this.grpNewEvent.Controls.Add(this.txtFeePerPerson);
            this.grpNewEvent.Controls.Add(this.btnCreateEvent);
            this.grpNewEvent.Location = new System.Drawing.Point(20, 60);
            this.grpNewEvent.Name = "grpNewEvent";
            this.grpNewEvent.Size = new System.Drawing.Size(740, 100);
            this.grpNewEvent.TabIndex = 1;
            this.grpNewEvent.TabStop = false;
            this.grpNewEvent.Text = "New Event";
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Location = new System.Drawing.Point(20, 25);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(62, 15);
            this.lblEventTitle.TabIndex = 0;
            this.lblEventTitle.Text = "Event title:";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(100, 22);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(300, 23);
            this.txtEventTitle.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(420, 25);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(114, 15);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "Cost per participant:";
            // 
            // txtCostPerPerson
            // 
            this.txtCostPerPerson.Location = new System.Drawing.Point(550, 22);
            this.txtCostPerPerson.Name = "txtCostPerPerson";
            this.txtCostPerPerson.Size = new System.Drawing.Size(80, 23);
            this.txtCostPerPerson.TabIndex = 3;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(420, 55);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(108, 15);
            this.lblFee.TabIndex = 4;
            this.lblFee.Text = "Fee per participant:";
            // 
            // txtFeePerPerson
            // 
            this.txtFeePerPerson.Location = new System.Drawing.Point(550, 52);
            this.txtFeePerPerson.Name = "txtFeePerPerson";
            this.txtFeePerPerson.Size = new System.Drawing.Size(80, 23);
            this.txtFeePerPerson.TabIndex = 5;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(640, 22);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(80, 50);
            this.btnCreateEvent.TabIndex = 6;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click_1);
            // 
            // grpAddParticipant
            // 
            this.grpAddParticipant.Controls.Add(this.lblFirstName);
            this.grpAddParticipant.Controls.Add(this.txtFirstName);
            this.grpAddParticipant.Controls.Add(this.lblLastName);
            this.grpAddParticipant.Controls.Add(this.txtLastName);
            this.grpAddParticipant.Controls.Add(this.lblStreet);
            this.grpAddParticipant.Controls.Add(this.txtStreet);
            this.grpAddParticipant.Controls.Add(this.lblZip);
            this.grpAddParticipant.Controls.Add(this.txtZip);
            this.grpAddParticipant.Controls.Add(this.lblCity);
            this.grpAddParticipant.Controls.Add(this.txtCity);
            this.grpAddParticipant.Controls.Add(this.lblCountry);
            this.grpAddParticipant.Controls.Add(this.cmbCountry);
            this.grpAddParticipant.Controls.Add(this.btnAdd);
            this.grpAddParticipant.Controls.Add(this.btnChange);
            this.grpAddParticipant.Controls.Add(this.btnDelete);
            this.grpAddParticipant.Location = new System.Drawing.Point(20, 166);
            this.grpAddParticipant.Name = "grpAddParticipant";
            this.grpAddParticipant.Size = new System.Drawing.Size(360, 264);
            this.grpAddParticipant.TabIndex = 2;
            this.grpAddParticipant.TabStop = false;
            this.grpAddParticipant.Text = "Add participant";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 23);
            this.txtLastName.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(20, 100);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(40, 15);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Street:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(120, 97);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(200, 23);
            this.txtStreet.TabIndex = 5;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(20, 135);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(58, 15);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "Zip Code:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(120, 132);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(200, 23);
            this.txtZip.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 170);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 15);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 167);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 23);
            this.txtCity.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(20, 205);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(53, 15);
            this.lblCountry.TabIndex = 10;
            this.lblCountry.Text = "Country:";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Location = new System.Drawing.Point(120, 202);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(200, 23);
            this.cmbCountry.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(130, 240);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(90, 30);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "Change";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // grpParticipants
            // 
            this.grpParticipants.Controls.Add(this.lstParticipants);
            this.grpParticipants.Location = new System.Drawing.Point(400, 180);
            this.grpParticipants.Name = "grpParticipants";
            this.grpParticipants.Size = new System.Drawing.Size(360, 250);
            this.grpParticipants.TabIndex = 3;
            this.grpParticipants.TabStop = false;
            this.grpParticipants.Text = "Participants";
            // 
            // lstParticipants
            // 
            this.lstParticipants.Font = new System.Drawing.Font("Consolas", 9F);
            this.lstParticipants.ItemHeight = 14;
            this.lstParticipants.Location = new System.Drawing.Point(20, 30);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(320, 172);
            this.lstParticipants.TabIndex = 0;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblNumParticipantsLabel);
            this.grpSummary.Controls.Add(this.lblNumParticipants);
            this.grpSummary.Controls.Add(this.lblTotalCostLabel);
            this.grpSummary.Controls.Add(this.lblTotalCost);
            this.grpSummary.Controls.Add(this.lblTotalFeesLabel);
            this.grpSummary.Controls.Add(this.lblTotalFees);
            this.grpSummary.Location = new System.Drawing.Point(20, 440);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(740, 100);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblNumParticipantsLabel
            // 
            this.lblNumParticipantsLabel.AutoSize = true;
            this.lblNumParticipantsLabel.Location = new System.Drawing.Point(20, 30);
            this.lblNumParticipantsLabel.Name = "lblNumParticipantsLabel";
            this.lblNumParticipantsLabel.Size = new System.Drawing.Size(133, 15);
            this.lblNumParticipantsLabel.TabIndex = 0;
            this.lblNumParticipantsLabel.Text = "Number of participants:";
            // 
            // lblNumParticipants
            // 
            this.lblNumParticipants.AutoSize = true;
            this.lblNumParticipants.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumParticipants.Location = new System.Drawing.Point(180, 30);
            this.lblNumParticipants.Name = "lblNumParticipants";
            this.lblNumParticipants.Size = new System.Drawing.Size(14, 15);
            this.lblNumParticipants.TabIndex = 1;
            this.lblNumParticipants.Text = "0";
            // 
            // lblTotalCostLabel
            // 
            this.lblTotalCostLabel.AutoSize = true;
            this.lblTotalCostLabel.Location = new System.Drawing.Point(20, 60);
            this.lblTotalCostLabel.Name = "lblTotalCostLabel";
            this.lblTotalCostLabel.Size = new System.Drawing.Size(61, 15);
            this.lblTotalCostLabel.TabIndex = 2;
            this.lblTotalCostLabel.Text = "Total cost:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCost.Location = new System.Drawing.Point(180, 60);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(31, 15);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "0.00";
            // 
            // lblTotalFeesLabel
            // 
            this.lblTotalFeesLabel.AutoSize = true;
            this.lblTotalFeesLabel.Location = new System.Drawing.Point(300, 60);
            this.lblTotalFeesLabel.Name = "lblTotalFeesLabel";
            this.lblTotalFeesLabel.Size = new System.Drawing.Size(60, 15);
            this.lblTotalFeesLabel.TabIndex = 4;
            this.lblTotalFeesLabel.Text = "Total fees:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.Location = new System.Drawing.Point(380, 60);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(31, 15);
            this.lblTotalFees.TabIndex = 5;
            this.lblTotalFees.Text = "0.00";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.grpNewEvent);
            this.Controls.Add(this.grpAddParticipant);
            this.Controls.Add(this.grpParticipants);
            this.Controls.Add(this.grpSummary);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Organizer By Obada Hana";
            this.grpNewEvent.ResumeLayout(false);
            this.grpNewEvent.PerformLayout();
            this.grpAddParticipant.ResumeLayout(false);
            this.grpAddParticipant.PerformLayout();
            this.grpParticipants.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void InitializeGUI()
    {
        // Disable participant group initially
        grpAddParticipant.Enabled = false;

        // Set up country combo box
        cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
    }

    // Event handler methods
    private void btnCreateEvent_Click_1(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtEventTitle.Text))
        {
            MessageBox.Show("Event title is required!");
            return;
        }

        eventManager.Title = txtEventTitle.Text;
        eventManager.CostPerPerson = ReadDouble(txtCostPerPerson, 0.0);
        eventManager.FeePerPerson = ReadDouble(txtFeePerPerson, 0.0);

        grpAddParticipant.Enabled = true;
        lblHeader.Text = $"{eventManager.Title} By Obada Hana";
        UpdateGUI();
    }

    private void btnAdd_Click_1(object sender, EventArgs e)
    {
        Participant participant = new Participant();
        if (ReadParticipantData(ref participant))
        {
            if (eventManager.Participants.AddParticipant(participant))
                UpdateGUI();
        }
    }

    private void btnChange_Click_1(object sender, EventArgs e)
    {
        int index = lstParticipants.SelectedIndex;
        if (index < 0) return;

        Participant participant = eventManager.Participants.GetParticipantAt(index);
        if (participant == null) return;

        if (ReadParticipantData(ref participant))
        {
            if (eventManager.Participants.ChangeParticipantAt(participant, index))
                UpdateGUI();
        }
    }

    private void btnDelete_Click_1(object sender, EventArgs e)
    {
        int index = lstParticipants.SelectedIndex;
        if (index < 0) return;

        if (eventManager.Participants.RemoveParticipantAt(index))
            UpdateGUI();
    }

    // Helper methods
    private void UpdateGUI()
    {
        // Clear and repopulate participants list
        lstParticipants.Items.Clear();
        string[] participants = eventManager.Participants.GetParticipantsInfo();
        if (participants != null)
        {
            lstParticipants.Items.AddRange(participants);
        }

        // Update summary
        lblNumParticipants.Text = eventManager.Participants.Count.ToString();
        lblTotalCost.Text = eventManager.CalcTotalCost().ToString("0.00");
        lblTotalFees.Text = eventManager.CalcTotalFees().ToString("0.00");

        // Clear input fields
        ClearParticipantInputs();
    }

    private bool ReadParticipantData(ref Participant participant)
    {
        participant.FirstName = txtFirstName.Text;
        participant.LastName = txtLastName.Text;

        participant.Address.Street = txtStreet.Text;
        participant.Address.ZipCode = txtZip.Text;
        participant.Address.City = txtCity.Text;
        participant.Address.Country = (Countries)cmbCountry.SelectedItem;

        if (!participant.Validate())
        {
            MessageBox.Show("First name, last name, and city are required!");
            return false;
        }
        return true;
    }

    private double ReadDouble(TextBox textBox, double defaultValue)
    {
        return double.TryParse(textBox.Text, out double result) ? result : defaultValue;
    }

    private void ClearParticipantInputs()
    {
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtStreet.Text = "";
        txtZip.Text = "";
        txtCity.Text = "";
        cmbCountry.SelectedIndex = 0;
    }
 
}