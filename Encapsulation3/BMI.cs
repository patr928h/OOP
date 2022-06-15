using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation3
{
    class BMI
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }


        public double Getbmi()
        {
            return Height/Weight;
        }
        public string BmiDescription()
        {
            return $"BMI status:        under 18,5: undervægtig      18,5-24.9: normal vægt   25,0-29,9: pre overvægt      30,0-34,9: overvægt klasse 1      35,0-39,9: overvægt klasse 2        over 40: overvægt klasse 3";
        }
        public string Description()
        {
            return $""
        }
    }
}
