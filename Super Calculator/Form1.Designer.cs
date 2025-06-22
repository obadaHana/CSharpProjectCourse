namespace Super_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Daily Water Intake GroupBox
            this.groupBoxDailyWater = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.labelFt = new System.Windows.Forms.Label();
            this.txtInches = new System.Windows.Forms.TextBox();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.labelActivity = new System.Windows.Forms.Label();
            this.comboActivity = new System.Windows.Forms.ComboBox();
            this.labelBirthYear = new System.Windows.Forms.Label();
            this.txtBirthYear = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.radioImperial = new System.Windows.Forms.RadioButton();
            this.labelWaterResult = new System.Windows.Forms.Label();
            this.lblWaterIntake = new System.Windows.Forms.Label();
            this.btnCalculateWater = new System.Windows.Forms.Button();

            // Retirement Saving GroupBox
            this.groupBoxRetirement = new System.Windows.Forms.GroupBox();
            this.labelRetireAge = new System.Windows.Forms.Label();
            this.comboRetireAge = new System.Windows.Forms.ComboBox();
            this.labelCurrentSavings = new System.Windows.Forms.Label();
            this.txtCurrentSavings = new System.Windows.Forms.TextBox();
            this.labelMonthlySaving = new System.Windows.Forms.Label();
            this.txtMonthlySaving = new System.Windows.Forms.TextBox();
            this.labelAnnualInterest = new System.Windows.Forms.Label();
            this.txtAnnualInterest = new System.Windows.Forms.TextBox();
            this.labelYearsToRetire = new System.Windows.Forms.Label();
            this.lblYearsToRetire = new System.Windows.Forms.Label();
            this.labelTotalFutureAmount = new System.Windows.Forms.Label();
            this.lblTotalFutureAmount = new System.Windows.Forms.Label();
            this.labelTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.labelTotalInvestment = new System.Windows.Forms.Label();
            this.lblTotalInvestment = new System.Windows.Forms.Label();
            this.labelGrowth = new System.Windows.Forms.Label();
            this.lblGrowth = new System.Windows.Forms.Label();
            this.btnCalculateRetirement = new System.Windows.Forms.Button();

            // Suspend layout for better performance
            this.groupBoxDailyWater.SuspendLayout();
            this.groupBoxRetirement.SuspendLayout();
            this.SuspendLayout();

            // 
            // groupBoxDailyWater
            // 
            this.groupBoxDailyWater.Controls.Add(this.labelName);
            this.groupBoxDailyWater.Controls.Add(this.txtName);
            this.groupBoxDailyWater.Controls.Add(this.labelHeight);
            this.groupBoxDailyWater.Controls.Add(this.txtFeet);
            this.groupBoxDailyWater.Controls.Add(this.labelFt);
            this.groupBoxDailyWater.Controls.Add(this.txtInches);
            this.groupBoxDailyWater.Controls.Add(this.labelIn);
            this.groupBoxDailyWater.Controls.Add(this.labelWeight);
            this.groupBoxDailyWater.Controls.Add(this.txtWeight);
            this.groupBoxDailyWater.Controls.Add(this.radioFemale);
            this.groupBoxDailyWater.Controls.Add(this.radioMale);
            this.groupBoxDailyWater.Controls.Add(this.labelActivity);
            this.groupBoxDailyWater.Controls.Add(this.comboActivity);
            this.groupBoxDailyWater.Controls.Add(this.labelBirthYear);
            this.groupBoxDailyWater.Controls.Add(this.txtBirthYear);
            this.groupBoxDailyWater.Controls.Add(this.labelUnit);
            this.groupBoxDailyWater.Controls.Add(this.radioMetric);
            this.groupBoxDailyWater.Controls.Add(this.radioImperial);
            this.groupBoxDailyWater.Controls.Add(this.labelWaterResult);
            this.groupBoxDailyWater.Controls.Add(this.btnCalculateWater);
            this.groupBoxDailyWater.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDailyWater.Name = "groupBoxDailyWater";
            this.groupBoxDailyWater.Size = new System.Drawing.Size(560, 180);
            this.groupBoxDailyWater.TabIndex = 0;
            this.groupBoxDailyWater.TabStop = false;
            this.groupBoxDailyWater.Text = "Daily Water Intake";

            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 1;

            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(10, 50);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(84, 13);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height (ft and in)";

            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(100, 50);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(50, 20);
            this.txtFeet.TabIndex = 3;

            // 
            // labelFt
            // 
            this.labelFt.AutoSize = true;
            this.labelFt.Location = new System.Drawing.Point(155, 50);
            this.labelFt.Name = "labelFt";
            this.labelFt.Size = new System.Drawing.Size(15, 13);
            this.labelFt.TabIndex = 4;
            this.labelFt.Text = "ft";

            // 
            // txtInches
            // 
            this.txtInches.Location = new System.Drawing.Point(170, 50);
            this.txtInches.Name = "txtInches";
            this.txtInches.Size = new System.Drawing.Size(50, 20);
            this.txtInches.TabIndex = 5;

            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(225, 50);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(15, 13);
            this.labelIn.TabIndex = 6;
            this.labelIn.Text = "in";

            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(10, 80);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 13);
            this.labelWeight.TabIndex = 7;
            this.labelWeight.Text = "Weight (lbs)";

            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(100, 80);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(50, 20);
            this.txtWeight.TabIndex = 8;

            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(260, 20);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(62, 17);
            this.radioFemale.TabIndex = 9;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.Checked = true;

            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(340, 20);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 10;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";

            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Location = new System.Drawing.Point(260, 50);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(74, 13);
            this.labelActivity.TabIndex = 11;
            this.labelActivity.Text = "Activity level";

            // 
            // comboActivity
            // 
            this.comboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboActivity.Items.AddRange(new object[] { "Low", "Medium", "High" });
            this.comboActivity.Location = new System.Drawing.Point(340, 50);
            this.comboActivity.Name = "comboActivity";
            this.comboActivity.Size = new System.Drawing.Size(100, 21);
            this.comboActivity.TabIndex = 12;

            // 
            // labelBirthYear
            // 
            this.labelBirthYear.AutoSize = true;
            this.labelBirthYear.Location = new System.Drawing.Point(260, 80);
            this.labelBirthYear.Name = "labelBirthYear";
            this.labelBirthYear.Size = new System.Drawing.Size(58, 13);
            this.labelBirthYear.TabIndex = 13;
            this.labelBirthYear.Text = "Birth year";

            // 
            // txtBirthYear
            // 
            this.txtBirthYear.Location = new System.Drawing.Point(340, 80);
            this.txtBirthYear.Name = "txtBirthYear";
            this.txtBirthYear.Size = new System.Drawing.Size(50, 20);
            this.txtBirthYear.TabIndex = 14;

            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(260, 110);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(28, 13);
            this.labelUnit.TabIndex = 15;
            this.labelUnit.Text = "Unit";

            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Location = new System.Drawing.Point(310, 110);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(98, 17);
            this.radioMetric.TabIndex = 16;
            this.radioMetric.TabStop = true;
            this.radioMetric.Text = "Metric (kg, cm)";
            this.radioMetric.CheckedChanged += new System.EventHandler(this.radioMetric_CheckedChanged);

            // 
            // radioImperial
            // 
            this.radioImperial.AutoSize = true;
            this.radioImperial.Location = new System.Drawing.Point(310, 140);
            this.radioImperial.Name = "radioImperial";
            this.radioImperial.Size = new System.Drawing.Size(96, 17);
            this.radioImperial.TabIndex = 17;
            this.radioImperial.TabStop = true;
            this.radioImperial.Text = "Imperial (ft, lbs)";
            this.radioImperial.Checked = true;
            this.radioImperial.CheckedChanged += new System.EventHandler(this.radioImperial_CheckedChanged);

            // 
            // labelWaterResult
            // 
            this.labelWaterResult.AutoSize = false;
            this.labelWaterResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWaterResult.Location = new System.Drawing.Point(10, 110);
            this.labelWaterResult.Name = "labelWaterResult";
            this.labelWaterResult.Size = new System.Drawing.Size(240, 40);
            this.labelWaterResult.TabIndex = 18;
            this.labelWaterResult.Text = "Recommended daily water consumption for ";

            // 
            // lblWaterIntake
            // 
            this.lblWaterIntake.AutoSize = false;
            this.lblWaterIntake.Location = new System.Drawing.Point(10, 20);
            this.lblWaterIntake.Name = "lblWaterIntake";
            this.lblWaterIntake.Size = new System.Drawing.Size(220, 20);
            this.lblWaterIntake.TabIndex = 0;
            this.lblWaterIntake.Text = "0 glasses (0 oz)";
            this.labelWaterResult.Controls.Add(this.lblWaterIntake);

            // 
            // btnCalculateWater
            // 
            this.btnCalculateWater.Location = new System.Drawing.Point(200, 150);
            this.btnCalculateWater.Name = "btnCalculateWater";
            this.btnCalculateWater.Size = new System.Drawing.Size(100, 30);
            this.btnCalculateWater.TabIndex = 19;
            this.btnCalculateWater.Text = "Calculate";
            this.btnCalculateWater.UseVisualStyleBackColor = true;
            this.btnCalculateWater.Click += new System.EventHandler(this.btnCalculateWater_Click);

            // 
            // groupBoxRetirement
            // 
            this.groupBoxRetirement.Controls.Add(this.labelRetireAge);
            this.groupBoxRetirement.Controls.Add(this.comboRetireAge);
            this.groupBoxRetirement.Controls.Add(this.labelCurrentSavings);
            this.groupBoxRetirement.Controls.Add(this.txtCurrentSavings);
            this.groupBoxRetirement.Controls.Add(this.labelMonthlySaving);
            this.groupBoxRetirement.Controls.Add(this.txtMonthlySaving);
            this.groupBoxRetirement.Controls.Add(this.labelAnnualInterest);
            this.groupBoxRetirement.Controls.Add(this.txtAnnualInterest);
            this.groupBoxRetirement.Controls.Add(this.labelYearsToRetire);
            this.groupBoxRetirement.Controls.Add(this.lblYearsToRetire);
            this.groupBoxRetirement.Controls.Add(this.labelTotalFutureAmount);
            this.groupBoxRetirement.Controls.Add(this.lblTotalFutureAmount);
            this.groupBoxRetirement.Controls.Add(this.labelTotalInterest);
            this.groupBoxRetirement.Controls.Add(this.lblTotalInterest);
            this.groupBoxRetirement.Controls.Add(this.labelTotalInvestment);
            this.groupBoxRetirement.Controls.Add(this.lblTotalInvestment);
            this.groupBoxRetirement.Controls.Add(this.labelGrowth);
            this.groupBoxRetirement.Controls.Add(this.lblGrowth);
            this.groupBoxRetirement.Controls.Add(this.btnCalculateRetirement);
            this.groupBoxRetirement.Location = new System.Drawing.Point(12, 200);
            this.groupBoxRetirement.Name = "groupBoxRetirement";
            this.groupBoxRetirement.Size = new System.Drawing.Size(560, 180);
            this.groupBoxRetirement.TabIndex = 1;
            this.groupBoxRetirement.TabStop = false;
            this.groupBoxRetirement.Text = "Retirement Saving";

            // 
            // labelRetireAge
            // 
            this.labelRetireAge.AutoSize = true;
            this.labelRetireAge.Location = new System.Drawing.Point(10, 20);
            this.labelRetireAge.Name = "labelRetireAge";
            this.labelRetireAge.Size = new System.Drawing.Size(65, 13);
            this.labelRetireAge.TabIndex = 0;
            this.labelRetireAge.Text = "Retiring age";

            // 
            // comboRetireAge
            // 
            this.comboRetireAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRetireAge.Items.AddRange(new object[] { "62", "63", "64", "65", "66", "67", "68", "69", "70" });
            this.comboRetireAge.Location = new System.Drawing.Point(110, 20);
            this.comboRetireAge.Name = "comboRetireAge";
            this.comboRetireAge.Size = new System.Drawing.Size(50, 21);
            this.comboRetireAge.TabIndex = 1;

            // 
            // labelCurrentSavings
            // 
            this.labelCurrentSavings.AutoSize = true;
            this.labelCurrentSavings.Location = new System.Drawing.Point(10, 50);
            this.labelCurrentSavings.Name = "labelCurrentSavings";
            this.labelCurrentSavings.Size = new System.Drawing.Size(87, 13);
            this.labelCurrentSavings.TabIndex = 2;
            this.labelCurrentSavings.Text = "Current savings";

            // 
            // txtCurrentSavings
            // 
            this.txtCurrentSavings.Location = new System.Drawing.Point(110, 50);
            this.txtCurrentSavings.Name = "txtCurrentSavings";
            this.txtCurrentSavings.Size = new System.Drawing.Size(50, 20);
            this.txtCurrentSavings.TabIndex = 3;

            // 
            // labelMonthlySaving
            // 
            this.labelMonthlySaving.AutoSize = true;
            this.labelMonthlySaving.Location = new System.Drawing.Point(10, 80);
            this.labelMonthlySaving.Name = "labelMonthlySaving";
            this.labelMonthlySaving.Size = new System.Drawing.Size(82, 13);
            this.labelMonthlySaving.TabIndex = 4;
            this.labelMonthlySaving.Text = "Monthly saving";

            // 
            // txtMonthlySaving
            // 
            this.txtMonthlySaving.Location = new System.Drawing.Point(110, 80);
            this.txtMonthlySaving.Name = "txtMonthlySaving";
            this.txtMonthlySaving.Size = new System.Drawing.Size(50, 20);
            this.txtMonthlySaving.TabIndex = 5;

            // 
            // labelAnnualInterest
            // 
            this.labelAnnualInterest.AutoSize = true;
            this.labelAnnualInterest.Location = new System.Drawing.Point(10, 110);
            this.labelAnnualInterest.Name = "labelAnnualInterest";
            this.labelAnnualInterest.Size = new System.Drawing.Size(91, 13);
            this.labelAnnualInterest.TabIndex = 6;
            this.labelAnnualInterest.Text = "Annual interest (%)";

            // 
            // txtAnnualInterest
            // 
            this.txtAnnualInterest.Location = new System.Drawing.Point(110, 110);
            this.txtAnnualInterest.Name = "txtAnnualInterest";
            this.txtAnnualInterest.Size = new System.Drawing.Size(50, 20);
            this.txtAnnualInterest.TabIndex = 7;

            // 
            // labelYearsToRetire
            // 
            this.labelYearsToRetire.AutoSize = true;
            this.labelYearsToRetire.Location = new System.Drawing.Point(300, 20);
            this.labelYearsToRetire.Name = "labelYearsToRetire";
            this.labelYearsToRetire.Size = new System.Drawing.Size(94, 13);
            this.labelYearsToRetire.TabIndex = 8;
            this.labelYearsToRetire.Text = "Years to retirement";

            // 
            // lblYearsToRetire
            // 
            this.lblYearsToRetire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYearsToRetire.Location = new System.Drawing.Point(410, 20);
            this.lblYearsToRetire.Name = "lblYearsToRetire";
            this.lblYearsToRetire.Size = new System.Drawing.Size(100, 20);
            this.lblYearsToRetire.TabIndex = 9;

            // 
            // labelTotalFutureAmount
            // 
            this.labelTotalFutureAmount.AutoSize = true;
            this.labelTotalFutureAmount.Location = new System.Drawing.Point(300, 50);
            this.labelTotalFutureAmount.Name = "labelTotalFutureAmount";
            this.labelTotalFutureAmount.Size = new System.Drawing.Size(98, 13);
            this.labelTotalFutureAmount.TabIndex = 10;
            this.labelTotalFutureAmount.Text = "Total future amount";

            // 
            // lblTotalFutureAmount
            // 
            this.lblTotalFutureAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalFutureAmount.Location = new System.Drawing.Point(410, 50);
            this.lblTotalFutureAmount.Name = "lblTotalFutureAmount";
            this.lblTotalFutureAmount.Size = new System.Drawing.Size(100, 20);
            this.lblTotalFutureAmount.TabIndex = 11;

            // 
            // labelTotalInterest
            // 
            this.labelTotalInterest.AutoSize = true;
            this.labelTotalInterest.Location = new System.Drawing.Point(300, 80);
            this.labelTotalInterest.Name = "labelTotalInterest";
            this.labelTotalInterest.Size = new System.Drawing.Size(67, 13);
            this.labelTotalInterest.TabIndex = 12;
            this.labelTotalInterest.Text = "Total interest";

            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalInterest.Location = new System.Drawing.Point(410, 80);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(100, 20);
            this.lblTotalInterest.TabIndex = 13;

            // 
            // labelTotalInvestment
            // 
            this.labelTotalInvestment.AutoSize = true;
            this.labelTotalInvestment.Location = new System.Drawing.Point(300, 110);
            this.labelTotalInvestment.Name = "labelTotalInvestment";
            this.labelTotalInvestment.Size = new System.Drawing.Size(82, 13);
            this.labelTotalInvestment.TabIndex = 14;
            this.labelTotalInvestment.Text = "Total investment";

            // 
            // lblTotalInvestment
            // 
            this.lblTotalInvestment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalInvestment.Location = new System.Drawing.Point(410, 110);
            this.lblTotalInvestment.Name = "lblTotalInvestment";
            this.lblTotalInvestment.Size = new System.Drawing.Size(100, 20);
            this.lblTotalInvestment.TabIndex = 15;

            // 
            // labelGrowth
            // 
            this.labelGrowth.AutoSize = true;
            this.labelGrowth.Location = new System.Drawing.Point(300, 140);
            this.labelGrowth.Name = "labelGrowth";
            this.labelGrowth.Size = new System.Drawing.Size(61, 13);
            this.labelGrowth.TabIndex = 16;
            this.labelGrowth.Text = "Growth in %";

            // 
            // lblGrowth
            // 
            this.lblGrowth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrowth.Location = new System.Drawing.Point(410, 140);
            this.lblGrowth.Name = "lblGrowth";
            this.lblGrowth.Size = new System.Drawing.Size(100, 20);
            this.lblGrowth.TabIndex = 17;

            // 
            // btnCalculateRetirement
            // 
            this.btnCalculateRetirement.Location = new System.Drawing.Point(200, 150);
            this.btnCalculateRetirement.Name = "btnCalculateRetirement";
            this.btnCalculateRetirement.Size = new System.Drawing.Size(100, 30);
            this.btnCalculateRetirement.TabIndex = 18;
            this.btnCalculateRetirement.Text = "Calculate";
            this.btnCalculateRetirement.UseVisualStyleBackColor = true;
            this.btnCalculateRetirement.Click += new System.EventHandler(this.btnCalculateRetirement_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.groupBoxRetirement);
            this.Controls.Add(this.groupBoxDailyWater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Super Calculator by Obada Hana";
            this.groupBoxDailyWater.ResumeLayout(false);
            this.groupBoxDailyWater.PerformLayout();
            this.groupBoxRetirement.ResumeLayout(false);
            this.groupBoxRetirement.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDailyWater;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.Label labelFt;
        private System.Windows.Forms.TextBox txtInches;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label labelActivity;
        private System.Windows.Forms.ComboBox comboActivity;
        private System.Windows.Forms.Label labelBirthYear;
        private System.Windows.Forms.TextBox txtBirthYear;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.RadioButton radioMetric;
        private System.Windows.Forms.RadioButton radioImperial;
        private System.Windows.Forms.Label labelWaterResult;
        private System.Windows.Forms.Label lblWaterIntake;
        private System.Windows.Forms.Button btnCalculateWater;
        private System.Windows.Forms.GroupBox groupBoxRetirement;
        private System.Windows.Forms.Label labelRetireAge;
        private System.Windows.Forms.ComboBox comboRetireAge;
        private System.Windows.Forms.Label labelCurrentSavings;
        private System.Windows.Forms.TextBox txtCurrentSavings;
        private System.Windows.Forms.Label labelMonthlySaving;
        private System.Windows.Forms.TextBox txtMonthlySaving;
        private System.Windows.Forms.Label labelAnnualInterest;
        private System.Windows.Forms.TextBox txtAnnualInterest;
        private System.Windows.Forms.Label labelYearsToRetire;
        private System.Windows.Forms.Label lblYearsToRetire;
        private System.Windows.Forms.Label labelTotalFutureAmount;
        private System.Windows.Forms.Label lblTotalFutureAmount;
        private System.Windows.Forms.Label labelTotalInterest;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label labelTotalInvestment;
        private System.Windows.Forms.Label lblTotalInvestment;
        private System.Windows.Forms.Label labelGrowth;
        private System.Windows.Forms.Label lblGrowth;
        private System.Windows.Forms.Button btnCalculateRetirement;
    }
}