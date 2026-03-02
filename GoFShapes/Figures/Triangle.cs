using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GoFShapes.Figures
{
    public sealed class Triangle : Figure
    {
        public override UIElement CreateUIElement(double size = 80)
        {
            return new Polygon
            {
                Points = new PointCollection
                {
                    new Point(size / 2, 0),
                    new Point(0, size),
                    new Point(size, size)
                },
                Fill = new SolidColorBrush(Color),
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Margin = new Thickness(8),
                Width = size,
                Height = size,
                Stretch = Stretch.Fill
            };
        }
    }
}
