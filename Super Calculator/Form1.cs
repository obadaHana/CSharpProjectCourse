using System;
using System.Windows.Forms;

namespace Super_Calculator
{
    public enum Gender { Male, Female }
    public enum ActivityLevel { Low, Medium, High }

    public class Person
    {
        private double height; // in cm or feet/inches depending on unit
        private double weight; // in kg or lbs depending on unit
        private Gender gender;
        private int birthYear;
        private ActivityLevel activityLevel;

        public Person(double height, double weight, Gender gender, int birthYear, ActivityLevel activityLevel)
        {
            this.height = height;
            this.weight = weight;
            this.gender = gender;
            this.birthYear = birthYear;
            this.activityLevel = activityLevel;
        }

        public double GetHeight() { return height; }
        public void SetHeight(double height) { this.height = height; }
        public double GetWeight() { return weight; }
        public void SetWeight(double weight) { this.weight = weight; }
        public Gender GetGender() { return gender; }
        public void SetGender(Gender gender) { this.gender = gender; }
        public int GetBirthYear() { return birthYear; }
        public void SetBirthYear(int birthYear) { this.birthYear = birthYear; }
        public ActivityLevel GetActivityLevel() { return activityLevel; }
        public void SetActivityLevel(ActivityLevel activityLevel) { this.activityLevel = activityLevel; }

        public int GetAge()
        {
            return DateTime.Now.Year - birthYear;
        }
    }

    internal class WaterIntakeCalculator
    {
        private Person person;

        public WaterIntakeCalculator(Person person)
        {
            this.person = person;
        }

        public double CalculateWaterIntake(bool isMetric, double inches = 0)
        {
            double height = person.GetHeight();
            double weight = person.GetWeight();
            int age = person.GetAge();

            if (!isMetric)
            {
                height = (height * 12.0 + inches) * 2.54; // feet/inches to cm
                weight *= 0.453592; // lbs to kg
            }

            double baseIntake = weight * 33;
            double genderFactor = (person.GetGender() == Gender.Male) ? 1.1 : 0.9;
            baseIntake *= genderFactor;
            double ageFactor = (age < 30) ? 1.1 : (age > 55) ? 0.9 : 1.0;
            baseIntake *= ageFactor;
            double heightFactor = (height > 175) ? 1.05 : (height < 160) ? 0.95 : 1.0;
            baseIntake *= heightFactor;
            double activityFactor = person.GetActivityLevel() switch
            {
                ActivityLevel.Low => 1.0,
                ActivityLevel.Medium => 1.2,
                ActivityLevel.High => 1.5,
                _ => 1.0
            };
            baseIntake *= activityFactor;

            return baseIntake; // in milliliters
        }

        public double ConvertToOunces(double milliliters)
        {
            return milliliters * 0.033814;
        }

        public int CalculateGlasses(double milliliters)
        {
            return (int)(milliliters / 240);
        }
    }

    internal class RetirementSavingCalculator
    {
        private Person person;

        public RetirementSavingCalculator(Person person)
        {
            this.person = person;
        }

        public (double futureValue, double totalInterest, double totalFees, double totalPaid) CalculateSavings(
            double initialInvestment, double monthlyContribution, double annualInterestRate, double annualFees, int retirementAge)
        {
            int periodInYears = retirementAge - person.GetAge();
            int months = periodInYears * 12;
            double monthlyInterest = (annualInterestRate / 100) / 12;
            double monthlyFees = (annualFees / 100) / 12;
            double balance = initialInvestment + monthlyContribution;
            double totalInterest = 0;
            double totalFees = 0;

            for (int month = 1; month < months; month++)
            {
                double interest = balance * monthlyInterest;
                double fees = balance * monthlyFees;
                balance += interest - fees + monthlyContribution;
                totalInterest += interest;
                totalFees += fees;
            }

            double totalPaid = initialInvestment + (months * monthlyContribution);
            return (balance, totalInterest, totalFees, totalPaid);
        }
    }

    public partial class Form1 : Form
    {
        private WaterIntakeCalculator waterCalc;
        private RetirementSavingCalculator retirementCalc;

        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Set default values
            comboActivity.SelectedIndex = 0; // Low
            comboRetireAge.SelectedIndex = 0; // 62
            txtInches.Visible = radioImperial.Checked; // Show inches by default
        }

        private void radioImperial_CheckedChanged(object sender, EventArgs e)
        {
            txtInches.Visible = radioImperial.Checked;
            labelHeight.Text = radioImperial.Checked ? "Height (ft and in)" : "Height (cm)";
            labelWeight.Text = radioImperial.Checked ? "Weight (lbs)" : "Weight (kg)";
        }

        private void radioMetric_CheckedChanged(object sender, EventArgs e)
        {
            txtInches.Visible = !radioMetric.Checked;
            labelHeight.Text = radioMetric.Checked ? "Height (cm)" : "Height (ft and in)";
            labelWeight.Text = radioMetric.Checked ? "Weight (kg)" : "Weight (lbs)";
        }

        private void btnCalculateWater_Click(object sender, EventArgs e)
        {
            try
            {
                double height = double.Parse(txtFeet.Text);
                double inches = radioImperial.Checked ? double.Parse(txtInches.Text) : 0;
                double weight = double.Parse(txtWeight.Text);
                int birthYear = int.Parse(txtBirthYear.Text);
                Gender gender = radioMale.Checked ? Gender.Male : Gender.Female;
                ActivityLevel activity = (ActivityLevel)comboActivity.SelectedIndex;

                Person person = new Person(height, weight, gender, birthYear, activity);
                waterCalc = new WaterIntakeCalculator(person);

                bool isMetric = radioMetric.Checked;
                double waterMl = waterCalc.CalculateWaterIntake(isMetric, inches);
                double waterOz = waterCalc.ConvertToOunces(waterMl);
                int glasses = waterCalc.CalculateGlasses(waterMl);

                labelWaterResult.Text = $"Recommended daily water consumption for {txtName.Text}";
                lblWaterIntake.Text = isMetric
                    ? $"{glasses} glasses ({waterMl:F1} ml)"
                    : $"{glasses} glasses ({waterOz:F1} oz)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCalculateRetirement_Click(object sender, EventArgs e)
        {
            try
            {
                double initialInvestment = double.Parse(txtCurrentSavings.Text);
                double monthlyContribution = double.Parse(txtMonthlySaving.Text);
                double annualInterestRate = double.Parse(txtAnnualInterest.Text);
                double annualFees = 0; // Assuming no fees for simplicity
                int retirementAge = int.Parse(comboRetireAge.SelectedItem.ToString());
                int birthYear = int.Parse(txtBirthYear.Text);
                Person person = new Person(0, 0, Gender.Male, birthYear, ActivityLevel.Medium); // Dummy data
                retirementCalc = new RetirementSavingCalculator(person);

                var (futureValue, totalInterest, totalFees, totalPaid) =
                    retirementCalc.CalculateSavings(initialInvestment, monthlyContribution, annualInterestRate, annualFees, retirementAge);

                lblYearsToRetire.Text = (retirementAge - person.GetAge()).ToString();
                lblTotalFutureAmount.Text = futureValue.ToString("F2");
                lblTotalInterest.Text = totalInterest.ToString("F2");
                lblTotalInvestment.Text = totalPaid.ToString("F2");
                lblGrowth.Text = ((totalInterest / totalPaid) * 100).ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}