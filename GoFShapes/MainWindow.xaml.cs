using System.Windows;
using System.Windows.Controls;
using GoFShapes.AbstractFactory;

namespace GoFShapes
{
    public partial class MainWindow : Window
    {
        private IFigureFactory? _currentFactory;

        public MainWindow()
        {
            InitializeComponent();
            ColorBox.SelectedIndex = 0;
        }

        private void ColorBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!IsLoaded) return;
            if (ColorBox.SelectedItem is not ComboBoxItem item) return;

    
            switch (item.Content?.ToString())
            {
                case "Красный":
                    _currentFactory = new RedFactory();
                    break;
                case "Синий":
                    _currentFactory = new BlueFactory();
                    break;
                case "Зелёный":
                    _currentFactory = new GreenFactory();
                    break;
                default:
                    return;
            }


            CanvasPanel.Children.Clear();

            var circle = _currentFactory.CreateCircle();
            var square = _currentFactory.CreateSquare();
            var triangle = _currentFactory.CreateTriangle();

            CanvasPanel.Children.Add(circle.CreateUIElement());
            CanvasPanel.Children.Add(square.CreateUIElement());
            CanvasPanel.Children.Add(triangle.CreateUIElement());
        }
    }
}
