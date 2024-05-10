using AreaOfFigures.Interfaces;

namespace AreaOfFigures
{
    public class Area
    {
        public static AreaResult GetFigureArea(IFigure figure) 
        {
            return figure.GetArea();
        }
    }
}
