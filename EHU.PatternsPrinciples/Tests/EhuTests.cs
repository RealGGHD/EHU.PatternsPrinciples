using NUnit.Framework;
using EHU.PatternsPrinciples.Pages;
using EHU.PatternsPrinciples.Drivers;

namespace EHU.PatternsPrinciples.Tests;

[TestFixture]
public class EhuTests
{
    private HomePage homePage;

    [SetUp]
    public void Setup()
    {
        homePage = new HomePage();
    }

    [Test]
    public void OpenEnglishContactsTest()
    {
        homePage.Open("https://en.ehu.lt/");
        homePage.GoToContacts();

        var url = homePage.GetUrl();
        var page = homePage.GetPageSource();

        Assert.That(url.Contains("contacts"), Is.True);
        Assert.That(page.Contains("office@ehu.lt"), Is.True);
    }

    [Test]
    public void CheckLithuanianPageTest()
    {
        homePage.Open("https://lt.ehu.lt/");

        var page = homePage.GetPageSource();

        Assert.That(page.Contains("+370"), Is.True);
    }

    [TearDown]
    public void TearDown()
    {
        DriverManager.QuitDriver();
    }
}