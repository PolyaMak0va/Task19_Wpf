using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_Wpf.Models
{
    static class Arithmetics
    {
        public static double AddСircumference(double rad)
        {
            try
            {
                if (rad >= 0)
                    return Math.Round((2 * Math.PI * rad), 4);
                else
                    return 0;
            }
            catch (FormatException ex)
            {
                rad.ToString(ex.Message);
                return rad;
            }
        }
        public static double AddSquare(double rad)
        {
            try
            {
                if (rad >= 0)
                    return Math.Round((Math.PI * rad * rad), 4);
                else
                    return 0;
            }
            catch (FormatException ex)
            {
                rad.ToString(ex.Message);
                return rad;
            }
        }
    }
}
