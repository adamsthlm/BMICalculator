using System;
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
    }
}
