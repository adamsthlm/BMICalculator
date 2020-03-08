﻿using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        // create an instance of BMICalculatior
        private BMICalculator bmiCalc = new BMICalculator();

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


        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void rbtMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMetric.Checked)
            {
                lblHeight.Text = "Height in (cm)";
                lblWeight.Text = "Weight in (kg)";
            }
        }

        private void rbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height in (feet)";
                lblWeight.Text = "Height in (lbs)";
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                DisplayResults();
            }
        }

        private void DisplayResults()
        {
            MessageBox.Show("Not implemeneted yet!!");
        }

        private bool ReadInputBMI()
        {
            if (txtName.Text.Length.Equals(0))
            {
                return false;
            }
            else return true;
        }
    }
}
