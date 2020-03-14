/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/

using System;

namespace Assignment3
{
    class BMICalculator
    {
        private string name = "No Name";

        private double height = 0;
        private double weight = 0;

        private UnitTypes unit;


        /// <summary>
        /// Getters och setters, först gjorde jag som i Java fast detta är mycket snyggare med propertys alltså..-------------- Getters och setter starts -----------
        /// </summary>
        /// <returns></returns>
        public string Name
        {
            get => name;
            set
            {
                //Validate before accepting it
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public double Height => height; // en snyggare getter och setter

        public void SetHeight(double value)
        {
            if (value >= 0)
            {
                height = value;
            }
        }
        // snyggare getter och setter tack alt-enter!
        public double Weight
        {
            get => weight;
            set
            {
                if (value >= 0)
                {
                    weight = value;
                }
            }
        }

        public UnitTypes Unit { get => unit; set => unit = value; }

        // ------------------------------------------------------------------ getter and setter ends 

        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI;
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
        // Jag kunde inte låtabli att kolla på videon till slut... :( && jag trycker alt-enter på allt möjligt nu, hehe!
        // 
        public double CalculateBMI
        {
            get
            {
                double factor;
                if (unit == UnitTypes.American)
                {
                    factor = 703.0;
                }
                else
                {
                    factor = 1.0;
                }
                double bmiValue = factor * weight / (height * height);
                double bmiValueRounded = Math.Round((double)bmiValue, 1);
                bmiValue = bmiValueRounded;


                return bmiValue;
            }
        }
    } //end class


} // end namespace



