using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoPolitica.Selenium.Teste.CasosTeste
{
    [TestFixture]
    class EleitorTest
    {
        [Test]
        public void ValidarEmailNaoCadastrado()
        {
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(500);

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/");
            IWebElement linkCadastrar = driver.FindElement(By.LinkText("Cadastrar"));
            linkCadastrar.Click();

            Thread.Sleep(500);

            String emailGuid;
            emailGuid = Guid.NewGuid().ToString() + "@mail.com";

            IWebElement inputEmail = driver.FindElement(By.Id("nome_cadastro"));
            IWebElement inputSenha = driver.FindElement(By.Id("senha"));

            inputEmail.SendKeys(emailGuid);
            inputSenha.SendKeys("");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("notifyjs-bootstrap-base")));

            IWebElement divSucesso = driver.FindElement(By.ClassName("notifyjs-bootstrap-success"));

            Assert.NotNull(divSucesso);
            driver.Close();
        }
    }
}
