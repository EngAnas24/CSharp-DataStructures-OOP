using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricForms 
{
    public class CIrcle: Geometric_sFormDad
    {
        private double redius;
        public static double Pi = 3.14;
        public CIrcle(double r) { 
        this.redius = r;
        }

        public double GetRaduis()
        {
            return this.redius;
        }
        public void SetRaduis(double redius)
        {
             this.redius = redius;
        }


      

        public override double GetArea()
        {
            return Pi * (redius * redius);
        }

        public override double GetParimeter()
        {
            return 2 * Pi * redius;

        }
    }
}
