using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricForms
{
    public class Rectangul: Geometric_sFormDad
    {
        private double length;
        private double width;

        public Rectangul()
        {
        }

        public Rectangul(double l, double w)
        {
            this.length = l;
            this.width = w;
        }
       /* public double GetLength()
        {
            return length;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetLength(double l)
        {
            this.length =l ;
        }
        public void SetWidth(double w)
        {
           this.width = w;
        }
      */
      
        public override double GetArea()
        {
            return length * width;
        }

        public override double GetParimeter()
        {
            return 2 * width * length;
        }
    }
}
