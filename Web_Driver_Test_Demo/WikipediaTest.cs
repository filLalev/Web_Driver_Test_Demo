using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//create new chrome browser instance
var driver = new ChromeDriver();
//navigate to wiki
driver.Url="https://wikipedia.org";
System.Console.WriteLine("Current Title:"+driver.Title);
//locate search field by id
var searchField = driver.FindElement(By.Id("searchInput"));
//click on element
searchField.Click();
searchField.SendKeys("QA");
//fill QA and press enter
searchField.SendKeys(Keys.Enter);
//close browser
driver.Quit();
