using System;
using System.Collections.Generic;
using System.Text;

namespace IdealWeightCalculator
{
   public class WeightRepository
    {
        IEnumerable<WeightCalculator> weights;


        public WeightRepository()
        {
            weights = new List<WeightCalculator>()
            { 
           new WeightCalculator {    Hight = 175,Sex = 'w'}, //62.5
            new WeightCalculator { Hight = 167,Sex = 'm'}, //62.75
             new WeightCalculator { Hight = 182,Sex = 'm'} //74
                
            };  
        }


        public IEnumerable<WeightCalculator> GetWeight() { 
            
         return weights; 
        }

    }
}
