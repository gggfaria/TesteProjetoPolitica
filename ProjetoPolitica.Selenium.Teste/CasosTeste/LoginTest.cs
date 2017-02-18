using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using ProjetoPolitica.Selenium.Teste.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoPolitica.Selenium.Teste.CasosTeste
{
    [TestFixture]
    class LoginTest
    {
        [Test]
        public void LogarComEleitor(string login, string senha)
        {
            IWebDriver driver = new ChromeDriver();

            Thread.Sleep(1000);
            Login.FazerLoginEleitor(driver, login, senha);
            

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            wait.Until(ExpectedConditions.UrlContains("http://localhost:8080/Politica/"));

            Assert.AreEqual("http://localhost:8080/Politica/", driver.Url);

            driver.Close();
            
        }

        [Test]
        public void LogarComPolitico(string login, string senha)
        {
            IWebDriver driver = new ChromeDriver();

            Login.FazerLoginPolitico(driver, login, senha);

            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            wait.Until(ExpectedConditions.UrlContains("http://localhost:8080/Politica/"));

            Assert.AreEqual("http://localhost:8080/Politica/", driver.Url);

            driver.Close();

        }
    }
}
