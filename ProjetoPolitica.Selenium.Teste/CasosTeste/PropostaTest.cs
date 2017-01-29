using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ProjetoPolitica.Selenium.Teste.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPolitica.Selenium.Teste.CasosTeste
{
    [TestFixture]
    class PropostaTest
    {
        [Test]
        public void EditarProposta()
        {
            IWebDriver driver = new FirefoxDriver();
            Login.FazerLoginEleitor(driver);

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/proposta/index");

            IWebElement linkFormEditar = driver.FindElement(By.Id("1"));

            linkFormEditar.Submit();

        }
    }
}
