using OpenQA.Selenium;
using EHU.PatternsPrinciples.Drivers;

namespace EHU.PatternsPrinciples.Pages;

public class HomePage : BasePage
{
    private By _contactsLink = By.PartialLinkText("Contacts");

    public void Open(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    public void GoToContacts()
    {
        driver.FindElement(_contactsLink).Click();
    }

    public string GetPageSource()
    {
        return driver.PageSource;
    }

    public string GetUrl()
    {
        return driver.Url;
    }
}