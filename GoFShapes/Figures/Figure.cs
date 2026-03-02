using System.Windows;
using System.Windows.Media;

namespace GoFShapes.Figures
{
    public abstract class Figure
    {
        public Color Color { get; set; }

        // Создаёт визуальный элемент для отображения
        public abstract UIElement CreateUIElement(double size = 80);
    }
}
