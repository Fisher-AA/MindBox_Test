using AreaOfFigures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures.Figures
{
    public class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;
        public Triangle(double sideA, double sideB, double sideC) 
        { 
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public AreaResult GetArea()
        {
            AreaResult areaResult = new AreaResult();
            if (sideA <=0 || sideB <= 0 || sideC <= 0)
            {
                areaResult.Success = false;
                areaResult.Error = "Не валидные входящие значения. Стороны треугольник должны быть болше 0";
            }
            else if ((sideA + sideB) <= sideC || (sideA + sideC) <= sideB || (sideC + sideB) <= sideA)
            {
                areaResult.Success = false;
                areaResult.Error = "Не валидные входящие значения. Длина любой стороны треугольника меньше суммы длин двух других его сторон";
            }
            else
            {
                double p = (sideA + sideB + sideC) / 2;
                areaResult.Success = true;
                areaResult.AreaValue=Math.Sqrt(p*(p - sideA)*(p - sideB)*(p - sideC));
            }
            return areaResult;
        }
    }
}
