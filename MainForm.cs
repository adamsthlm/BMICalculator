/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


using System;
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


        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void RbtMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMetric.Checked)
            {
                lblHeight.Text = "Height in (cm)";
                lblWeight.Text = "Weight in (kg)";
            }
        }

        private void RbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUsUnit.Checked)
            {
                lblHeight.Text = "Height in (feet)";
                lblWeight.Text = "Height in (lbs)";
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();
            if (ok)
            {
                if (ReadHeight() && ReadWeight()) { DisplayResults(); }
            }
        }
        //TODO problem med utdata
        private void DisplayResults()
        {
            double myBmi;
            ReadHeight();
            myBmi = bmiCalc.CalculateBMI();
            string outDataString = (myBmi.ToString().Trim());
            label6.Text = outDataString;
        }

        private bool ReadInputBMI()
        {
            if (txtName.Text.Length.Equals(0))
            {
                return false;
            }
            else return true;
        }


        private bool ReadHeight()
        {
            bool ok = double.TryParse(txHeight.Text, out double outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        bmiCalc.SetHeight(outValue * 12.00);
                    }
                    else
                    {
                        bmiCalc.SetHeight(outValue / 100.00);
                    }
                }
                else
                    ok = false;

            }

            if (!ok)

                MessageBox.Show("Invalid height value!");
            return ok;

        }

        // ReadWeight is based on ReadHeight check calculation... P(false)
        private bool ReadWeight()
        {
            bool ok = double.TryParse(txWeight.Text, out double outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        bmiCalc.SetWeight(outValue / 2);

                    }
                    else
                    {
                        bmiCalc.SetWeight(outValue / 100);

                    }
                }
                else ok = false;
            }
            if (!ok)
                MessageBox.Show("Invalid weight value!");
            return ok;
        }

    } // end class
} // end namespace

