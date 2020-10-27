using System.Windows;
using System.Windows.Controls;

namespace Actividad5_UT3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultadoTexBlock.Text = resultadoTexBlock.Text + (sender as Button).Tag.ToString();
        }
    }
}
