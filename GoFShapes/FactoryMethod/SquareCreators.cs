using System.Windows.Media;
using GoFShapes.Figures;

namespace GoFShapes.FactoryMethod
{
    public abstract class SquareCreator
    {
        public abstract Square CreateSquare();
    }

    public sealed class RedSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Red };
    }

    public sealed class BlueSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Blue };
    }

    public sealed class GreenSquareCreator : SquareCreator
    {
        public override Square CreateSquare() => new Square { Color = Colors.Green };
    }
}
