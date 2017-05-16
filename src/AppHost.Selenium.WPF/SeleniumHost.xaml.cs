using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppHost.Selenium.WPF {
    /// <summary>
    /// Interaction logic for SeleniumHost.xaml
    /// </summary>
    public partial class SeleniumHost : UserControl {
        public SeleniumHost() {
            InitializeComponent();
        }

        public DriverService DriverService {
            get { return (DriverService)GetValue(DriverServiceProperty); }
            set { SetValue(DriverServiceProperty, value); }
        }

        public static readonly DependencyProperty DriverServiceProperty =
            DependencyProperty.Register(nameof(DriverService), typeof(DriverService), typeof(SeleniumHost), new PropertyMetadata(default(DriverService), DriverServicePropertyChanged));

        private static void DriverServicePropertyChanged (DependencyObject sender, DependencyPropertyChangedEventArgs e) {
            var that = sender as SeleniumHost;
            that._SeleniumHost.DriverService = e.NewValue as DriverService;
        }
    }
}
