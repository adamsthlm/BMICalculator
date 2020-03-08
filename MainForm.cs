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



        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
