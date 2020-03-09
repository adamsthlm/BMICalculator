namespace Assignment3
{
    class BMICalculator
    {
        private string name = "No Name";

        private double height = 0;
        private double weight = 0;

        private UnitTypes unit;


        /// <summary>
        /// Getter name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            //Validate before accepting it
            if (!string.IsNullOrEmpty(value))
            {
                name = value;
            }
        }

        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double value)
        {
            if (value >= 0)
            {
                height = value;
            }
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double value)
        {
            if (value >= 0)
            {
                weight = value;
            }
        }
        public UnitTypes GetUnit()
        {
            return unit;
        }

        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringout = string.Empty;
            if (bmi > 30)
                stringout = "Overweight (Obesity class III)";
            else if (bmi < 30 && bmi > 25)
            {
                stringout = "Overweight";
            }
            else if (bmi < 25 && bmi > 18.5)
            {
                stringout = "Normal weight";

            }
            else if (bmi < 18.5)
            {
                stringout = "Underweight";
            }
            return stringout;
        }

        // TODO: this is my last entry, på tisdag borde jag kunna pressentera resultat textBoxen
        public double CalculateBMI()
        {
            double bmi = GetHeight() / GetWeight() * GetWeight();
            return bmi;
        }
    } //end class


} // end namespace



