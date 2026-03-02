using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GoFShapes.Figures
{
    public sealed class Circle : Figure
    {
        public override UIElement CreateUIElement(double size = 80)
        {
            return new Ellipse
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
