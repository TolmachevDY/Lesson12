using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Circle
    {
        static public double GetLenght(double r)
        {
            return 2.0*Math.PI*r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI*r*r;
        } 
        static public double GetPoint(double ox, double oy, double mx, double my)
        {
            return Math.Sqrt(Math.Pow(ox-mx,2)+Math.Pow(oy-my,2));            
        }
    }
}
