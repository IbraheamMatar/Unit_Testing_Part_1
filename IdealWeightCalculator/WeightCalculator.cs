﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWeightCalculator
{
   public class WeightCalculator
    {
        public double Hight { get; set; }

        public char Sex { get; set; }



        public double GetIdealBodyWeight()
        {
            switch (Sex)
            {
                case 'm':
                    return (Hight - 100) - ((Hight - 150) / 4);

                case 'w':
                    return (Hight - 100) - ((Hight - 150) / 2);

                default:
                   throw new ArgumentException("The sex argument is not valid");

            }
        }

    }
}
