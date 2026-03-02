using System.Windows;
using System.Windows.Controls;
using GoFShapes.FactoryMethod;

namespace GoFShapes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColorBox.SelectedIndex = 0; 
        }

        private void ColorBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            if (ColorBox.SelectedItem is not ComboBoxItem item) return;

         
            CanvasPanel.Children.Clear();

            
            CircleCreator circleCreator;
            SquareCreator squareCreator;
            TriangleCreator triangleCreator;

            switch (item.Content?.ToString())
            {
                case "Красный":
                    circleCreator = new RedCircleCreator();
                    squareCreator = new RedSquareCreator();
                    triangleCreator = new RedTriangleCreator();
                    break;
                case "Синий":
                    circleCreator = new BlueCircleCreator();
                    squareCreator = new BlueSquareCreator();
                    triangleCreator = new BlueTriangleCreator();
                    break;
                case "Зелёный":
                    circleCreator = new GreenCircleCreator();
                    squareCreator = new GreenSquareCreator();
                    triangleCreator = new GreenTriangleCreator();
                    break;
                default:
                    return;
            }

        
            var circle = circleCreator.CreateCircle();
            var square = squareCreator.CreateSquare();
            var triangle = triangleCreator.CreateTriangle();

        
            CanvasPanel.Children.Add(circle.CreateUIElement());
            CanvasPanel.Children.Add(square.CreateUIElement());
            CanvasPanel.Children.Add(triangle.CreateUIElement());
        }
    }
}
