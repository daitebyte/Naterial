using System.Windows;

namespace Naterial.Demo.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private bool _isDark;


        private void ThemeToggle_OnClick(object sender, RoutedEventArgs e)
        {
            _isDark = !_isDark;

            ThemeHelper.SetTheme(Application.Current.Resources, _isDark ? ThemeMode.Dark : ThemeMode.Light);
        }
    }
}
