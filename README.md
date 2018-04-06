# AppHost.Selenium
integration package to host Selenium´s WebDrivers inside custom applications, easy peasy
this working demo was inspired by this [stackoverflow-question](https://stackoverflow.com/questions/43842311/how-to-embed-a-selenium-webdriver-as-a-wpf-control/44004670#44004670)
## WinForms

    var service = ChromeDriverService.CreateDefaultService();
    var driver = new ChromeDriver(service);
    var form = new Form();
    var host = new SeleniumHost();
    
    form.Children.Add(host);
    host.DriverService = service;

## WPF
### XAML
    <Window x:Class="..."
        ...
        xmlns:sh="https://github.com/earloc/AppHost.Selenium">
        <sh:SeleniumHost x:Name="_SeleniumHost" />
    </Window>
### CodeBehind
    var service = ChromeDriverService.CreateDefaultService();
    var driver = new ChromeDriver(service);
    _SeleniumHost.DriverService = service;
