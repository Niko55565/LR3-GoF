using System.Windows.Media;
using GoFShapes.Figures;

namespace GoFShapes.FactoryMethod
{
    public abstract class CircleCreator
    {
        public abstract Circle CreateCircle();
    }

    public sealed class RedCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Red };
    }

    public sealed class BlueCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Blue };
    }

    public sealed class GreenCircleCreator : CircleCreator
    {
        public override Circle CreateCircle() => new Circle { Color = Colors.Green };
    }
}
