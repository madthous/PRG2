using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
public class Rectangle
        {
            public double width;
            public double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public double CalculateArea()
            {
                return width * height;
            }
            public string DetermineType()
            {
                if (width == height)
                {
                    return "Čtverec";
                }
                else if (width > height)
                {
                    return "široký";
                }
                else { return "vysoký"; }
            }
        }
    }
