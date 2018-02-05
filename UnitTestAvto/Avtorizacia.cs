using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TeacoSubscribeNunit
{
    public class Avtorizacia
    {
        public IWebDriver driver { get; set; }
        public string text { get; set; }

        public Avtorizacia(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Test()
        {
            TimeSpan timeout = new TimeSpan(00, 01, 00);

            driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/");
            driver.Manage().Window.Maximize();
            driver.Navigate().Refresh();

            var vxod = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/header/nav/div/div/ul/li[2]/a")));
            vxod.Click();

            var mail = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[5]/div[1]/div[2]/div[2]/div[1]/div/form/div/div[2]/div[2]/input")));
            mail.SendKeys("stefan999@mail.ru");
            var password = driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div[2]/div[2]/div[1]/div/form/div/div[2]/div[3]/input"));
            password.SendKeys("123456");
            var sub = driver.FindElement(By.XPath("//*[@id=\"js_auth_button\"]"));
            sub.Click();
            text = (new WebDriverWait(driver, timeout)).Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[3]/header/div/div/div[4]/div/div/table/tbody/tr/td[1]/span"))).Text;

        }
    }
}