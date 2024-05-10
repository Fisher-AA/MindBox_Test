using AreaOfFigures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Figures
{
    public class Circle : IFigure
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public AreaResult GetArea()
        {
            AreaResult areaResult = new AreaResult();
            if (radius <= 0) 
            { 
                areaResult.Success = false;
                areaResult.Error = "Использовано не валидное значение для радиуса. Радиус должен быть болше 0";
            }
            else
            {
                areaResult.Success = true;
                areaResult.AreaValue = Math.PI * Math.Pow(radius,2);
            }
            return areaResult;
        }
    }
}
