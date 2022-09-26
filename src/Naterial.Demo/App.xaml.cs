using System;
using System.Collections.Generic;
using System.Windows;

namespace Naterial.Demo
{
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            ThemeHelper.ThemeDictionaries = new Dictionary<object, Uri>
            {
                { ThemeMode.Light, new Uri("pack://application:,,,/Naterial.Demo;component/Themes/Light.xaml") },
                { ThemeMode.Dark, new Uri("pack://application:,,,/Naterial.Demo;component/Themes/Dark.xaml") }
            };
        }
    }
}
