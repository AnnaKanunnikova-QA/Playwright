using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class ExampleTest : PageTest
{
    [Test]
    public async Task HasTitle()
    {
       
        await Page.GotoAsync("https://demo.playwright.dev/todomvc/");
        await Page.PauseAsync();
        await Page.GotoAsync("https://demo.playwright.dev/todomvc/#/");
        await Page.GetByPlaceholder("What needs to be done?").ClickAsync();
        await Page.GetByPlaceholder("What needs to be done?").FillAsync("create a bug");
        await Page.GetByPlaceholder("What needs to be done?").PressAsync("Enter");
        await Page.GetByLabel("Toggle Todo").CheckAsync();
        await Page.GetByText("This is just a demo of TodoMVC for testing, not the real TodoMVC app. todosMark").ClickAsync();
        await Page.Locator("html").ClickAsync();
    }

    [Test]
    public async Task GetStartedLink()
    {
        await Page.GotoAsync("https://rozetka.com.ua/");
        await Page.GetByRole(AriaRole.Link, new() { Name = "Одежда, обувь и украшения" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Каталог" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Каталог" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Каталог" }).ClickAsync();
        await Page.GetByRole(AriaRole.Button, new() { Name = "Каталог" }).ClickAsync();
        await Page.GetByPlaceholder("Я ищу").ClickAsync();

    }
}