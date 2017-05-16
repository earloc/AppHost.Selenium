using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHost.Selenium.WinForms.Playground {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e) {
            base.OnClosed(e);

            _ChromeDriver?.Dispose();
            _InternetExplorerDriver?.Dispose();
        }

        private void _btnLoadChromt_Click(object sender, EventArgs e) {
            var service = ChromeDriverService.CreateDefaultService();
            var driver = new ChromeDriver(service);

            Replace(ref _ChromeDriver, driver, service, _ChromeHost);
        }
        private IWebDriver _ChromeDriver;

        private void _btnLoadInternetExplorer_Click(object sender, EventArgs e) {
            var service = InternetExplorerDriverService.CreateDefaultService();
            var driver = new InternetExplorerDriver(service);

            Replace(ref _InternetExplorerDriver, driver, service, _InternetExplorerHost);
        }
        private IWebDriver _InternetExplorerDriver;

        private void Replace(ref IWebDriver target, IWebDriver driver, DriverService service, SeleniumHost host) {
            if (target != null)
                target.Dispose();
            target = driver;

            host.DriverService = service;
        }
    }
}
