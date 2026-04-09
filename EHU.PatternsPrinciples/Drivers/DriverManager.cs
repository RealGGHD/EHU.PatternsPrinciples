using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EHU.PatternsPrinciples.Drivers;

public class DriverManager
{
    private static IWebDriver _driver;

    private DriverManager() { }

    public static IWebDriver GetDriver()
    {
        if (_driver == null)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Size = new System.Drawing.Size(1920, 1080);
        }
        return _driver;
    }

    public static void QuitDriver()
    {
        _driver?.Quit();
        _driver = null;
    }
}