using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
    class PerguntaTest
    {
        [Test]
        public void EditarPerguntaAindaNaoRespondida()
        {
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(500);

            Login.FazerLoginEleitor(driver);

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/pergunta/listar");
            IWebElement linkFormEditar = driver.FindElement(By.ClassName("fa-pencil-square-o"));
            linkFormEditar.Click();
            Thread.Sleep(1000);
            IWebElement textAreaEditar = driver.FindElement(By.Id("descricao"));
            textAreaEditar.Clear();
            textAreaEditar.SendKeys("Editando pergunta pelo selenium");
            textAreaEditar.Submit();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("notifyjs-bootstrap-base")));

            IWebElement divSucesso = driver.FindElement(By.ClassName("notifyjs-bootstrap-success"));

            Assert.NotNull(divSucesso);
            driver.Close();

        }
    }
}
