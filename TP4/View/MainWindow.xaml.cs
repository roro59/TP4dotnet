using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TP4.Model;
using TP4.ViewModel;

namespace TP4.View
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void WebBrowser_OnNavigating(object sender, NavigatingCancelEventArgs e)
        {
          

        }
    }
}
