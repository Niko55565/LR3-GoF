using System.Windows.Media;
using GoFShapes.Figures;

namespace GoFShapes.FactoryMethod
{
    public abstract class TriangleCreator
    {
        public abstract Triangle CreateTriangle();
    }

    public sealed class RedTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Red };
    }

    public sealed class BlueTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Blue };
    }

    public sealed class GreenTriangleCreator : TriangleCreator
    {
        public override Triangle CreateTriangle() => new Triangle { Color = Colors.Green };
    }
}
