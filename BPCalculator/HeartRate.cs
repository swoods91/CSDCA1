using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace HeartRateCalculator
{


    public class HeartRate
    {
        public const int ageMin = 0;
        public const int ageMax = 132; //Oldest Human that ever lived Jeanne Calment 122, added 10 years for argumenets sake
        public const int percentRateMin = 0;
        public const int percentRateMax = 100;

        [Range(ageMin, ageMax, ErrorMessage = "Invalid Age Value")]
        public int ageValue { get; set; }

        [Range(percentRateMin, percentRateMax, ErrorMessage = "Invalid Percentage Value")]
        public double PercentRate { get; set; }

        private double targetHeartRate;

        public int TargetHeartRate
        {
            get
         
        {
                if (ageValue > 0 && ageValue <= 132 && PercentRate >= 0 && PercentRate <= 100)
                {
                    targetHeartRate = (220 - ageValue) * (PercentRate / 100);
                    int inttargetHeartRate = Convert.ToInt32(targetHeartRate);
                    return inttargetHeartRate;
                }
                else
                {
                    int targetHeartRate = 0;
                    return targetHeartRate;
                }
            }

        }
        }
}
