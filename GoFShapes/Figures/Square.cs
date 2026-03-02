using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GoFShapes.Figures
{
    public sealed class Square : Figure
    {
        public override UIElement CreateUIElement(double size = 80)
        {
            return new Rectangle
            {
                Width = size,
                Height = size,
                Fill = new SolidColorBrush(Color),
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Margin = new Thickness(8)
            };
        }
    }
}
