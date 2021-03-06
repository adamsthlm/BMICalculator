﻿/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Skapare: Carl-Adam Berglund
e-mail: adam@carl-adam.tech
StudentID: ak7764
*/


using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        // create an instance of BMICalculatior
        private readonly BMICalculator bmiCalc = new BMICalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "The Body Mass Calculator, by Carl-Adam Berglund a Superior programmer";

            //input controls
            rbtnUsUnit.Checked = true;
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";

            // output controls
            txHeight.Text = string.Empty;
            txWeight.Text = string.Empty;
            

        }


        // Här märkte jag att om jag bara remmar här så får jag ett fel i den autogenererade delen och måste remma där med..
        //private void MainForm_Load(object sender, EventArgs e)
        //{

        //}

        private void RbtMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMetric.Checked)
            {
                lblHeight.Text = "Height in (cm)";
                lblWeight.Text = "Weight in (kg)";
                bmiCalc.Unit = UnitTypes.Metric;
            }
        }

        private void RbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height in (feet)";
                lblWeight.Text = "Weight in (lbs)";
                bmiCalc.Unit = UnitTypes.American;
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                bmiCalc.Name = txtName.Text;
                bmiCalc.Weight = double.Parse(txWeight.Text);
                bmiCalc.SetHeight(double.Parse(txHeight.Text));
                DisplayResults();
            }
        }
        
        private void DisplayResults()
        {
            double myBmi;
            ReadHeight();
            myBmi = bmiCalc.CalculateBMI;
            string outDataString = (myBmi.ToString());
            label6.Text = outDataString;
            label7.Text = bmiCalc.BmiWeightCategory(); 
            groupBox2.Text = "Result for " + bmiCalc.Name;
        }

        private bool ReadInputBMI()
        {
            // Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            Regex regex = new Regex(@"^[0-9]+$"); // Bantad expression bättre anpassad för mina behov?

            if (!regex.IsMatch(txHeight.Text))
            {
                MessageBox.Show("Incorrect value (Height), only numbers are allowed");
                return false;
            }

            if (!regex.IsMatch(txWeight.Text))
            {
                MessageBox.Show("Incorrect value (Weight), only numbers are allowed");
                return false;
            }

            
            if (txtName.Text.Length.Equals(0))
            {
                MessageBox.Show("Please enter a name!");
                return false;
            }
            else if (txHeight.Text.Length.Equals(0)) // eller om inte ett nummer v
            {
                MessageBox.Show("Please enter height!");
                return false;
            }
            else if (txWeight.Text.Length.Equals(0))
            {
                MessageBox.Show("Please enter weight!");
                return false;
            } return true;
        }


        private bool ReadHeight()
        {
            bool ok = double.TryParse(txHeight.Text, out double outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.Unit == UnitTypes.American)
                    {
                        bmiCalc.SetHeight(outValue * 12.00); // * 12.00
                    }
                    else
                    {
                        bmiCalc.SetHeight(outValue / 100.00); // delat med 100.00
                    }
                }
                else
                    ok = false;

            }

            if (!ok)

                MessageBox.Show("Invalid height value!");
            return ok;

        }

        // ReadWeight is based on ReadHeight check calculation... Den funkar nästan ... fast jag tycker jag har rört till det.
        //private bool ReadWeight()
        //{
        //    bool ok = double.TryParse(txWeight.Text, out double outValue);
        //    if (ok)
        //    {
        //        if (outValue > 0)
        //        {
        //            if (bmiCalc.Unit == UnitTypes.American)
        //            {
        //                bmiCalc.Weight = outValue;

        //            }
        //            else
        //            {
        //                bmiCalc.Weight = outValue;

        //            }
        //        }
        //        else ok = false;
        //    }
        //    if (!ok)
        //        MessageBox.Show("Invalid weight value!");
        //    return ok;
        //}

      
    } // end class
} // end namespace

