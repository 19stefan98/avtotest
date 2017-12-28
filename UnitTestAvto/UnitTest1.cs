using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace TeacoSubscribeNunit
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;

        //[OneTimeSetUp] // вызывается перед началом запуска всех тестов
        //public void OneTimeSetUp()
        //{
         
        //}

        //[OneTimeTearDown] //вызывается после завершения всех тестов
        //public void OneTimeTearDown()
        //{

        //}

        [SetUp] // вызывается перед каждым тестом
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown] // вызывается после каждого теста
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestMethod1()
        {
            var actual = "Пользователь";

            Avtorizacia avto = new Avtorizacia(driver);
                        avto.Test();

            Assert.AreEqual(avto.text, actual);
        }
    }
}

