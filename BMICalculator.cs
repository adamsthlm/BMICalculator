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




    } //end class


} // end namespace



