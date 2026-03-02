using GoFShapes.Figures;

namespace GoFShapes.AbstractFactory
{
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }
}
