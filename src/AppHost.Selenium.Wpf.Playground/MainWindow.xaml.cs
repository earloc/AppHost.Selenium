using AppHost.Selenium.WPF;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
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

namespace AppHost.Selenium.Wpf.Playground {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private IWebDriver _Driver;

        private void _btnLoadChrome_Click(object sender, RoutedEventArgs e) {
            var service = ChromeDriverService.CreateDefaultService();
            var driver = new ChromeDriver(service);

            Replace(ref _Driver, driver, service, _SeleniumHost);
        }

        private void _btnLoadInternetExplorer_Click(object sender, RoutedEventArgs e) {
            var service = InternetExplorerDriverService.CreateDefaultService();
            var driver = new InternetExplorerDriver(service);

            Replace(ref _Driver, driver, service, _SeleniumHost);
        }

        private void _btnLoadFireFox_Click(object sender, RoutedEventArgs e) {
            var service = FirefoxDriverService.CreateDefaultService();
            var driver = new FirefoxDriver(service);

            Replace(ref _Driver, driver, service, _SeleniumHost);
        }

        private void Replace(ref IWebDriver target, IWebDriver driver, DriverService service, SeleniumHost host) {
            if (target != null)
                target.Dispose();
            target = driver;

            host.DriverService = service;
        }


    }
}
