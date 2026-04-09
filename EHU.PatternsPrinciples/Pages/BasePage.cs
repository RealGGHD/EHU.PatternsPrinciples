using EHU.PatternsPrinciples.Drivers;
using OpenQA.Selenium;

namespace EHU.PatternsPrinciples.Pages;

public class BasePage
{
    protected IWebDriver driver;

    public BasePage()
    {
        driver = DriverManager.GetDriver();
    }
}