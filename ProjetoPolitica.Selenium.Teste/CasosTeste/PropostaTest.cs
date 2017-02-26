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
    class PropostaTest
    {
        [Test]
        public void EditarProposta()
        {
            IWebDriver driver = new FirefoxDriver();

            Login.FazerLoginPolitico(driver);

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/proposta/index");
         

            Thread.Sleep(1000);
            IWebElement linkFormEditar = driver.FindElement(By.XPath("//a[@title='Abrir edição da proposta']"));
            linkFormEditar.Click();

            Thread.Sleep(500);
            IWebElement inputDescricao = driver.FindElement(By.Name("descricao"));
            IWebElement inputResumo = driver.FindElement(By.Name("resumo"));
            IWebElement inputTitulo = driver.FindElement(By.Name("titulo"));
            IWebElement selectArea = driver.FindElement(By.Name("area"));

            inputDescricao.Clear();
            inputResumo.Clear();
            inputTitulo.Clear();

            
            inputDescricao.SendKeys("Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente.");
            inputResumo.SendKeys("Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente.");
            inputTitulo.SendKeys("Proposta para diminuir o desmatamento da amazonia");
            selectArea.SendKeys("6");


            inputTitulo.Submit();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));            
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("notifyjs-bootstrap-base")));

            IWebElement divSucesso = driver.FindElement(By.ClassName("notifyjs-bootstrap-success"));

            Assert.NotNull(divSucesso);
            driver.Close();
        }

        [Test]
        public void AvaliarProposta()
        {
            IWebDriver driver = new ChromeDriver();

          
            Login.FazerLoginEleitor(driver);

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/proposta/detalhes/1");
            IWebElement inputRating = driver.FindElement(By.CssSelector("label[for=rating4]"));
            inputRating.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("notifyjs-bootstrap-base")));

            IWebElement divSucesso = driver.FindElement(By.ClassName("notifyjs-bootstrap-success"));
            Assert.NotNull(divSucesso);
            driver.Close();
        }


        [Test]
        public void EditarStatus()
        {
            IWebDriver driver = new ChromeDriver();

            Login.FazerLoginPolitico(driver);

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/proposta/index");
            IWebElement linkFormEditar = driver.FindElement(By.Name("status1"));
            linkFormEditar.Click();
            Thread.Sleep(1000);
            IWebElement selectArea = driver.FindElement(By.Name("status"));
            selectArea.SendKeys("CUMPRIDA");
            selectArea.Submit();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("notifyjs-bootstrap-base")));
            IWebElement divSucesso = driver.FindElement(By.ClassName("notifyjs-bootstrap-success"));
            Assert.NotNull(divSucesso);
            driver.Close();

        }

        [Test]
        public void CadastrarProposta()
        {
            IWebDriver driver = new ChromeDriver();

            Login.FazerLoginPolitico(driver);

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/proposta/cadastrar");
            
            Thread.Sleep(1000);
            IWebElement inputDescricao = driver.FindElement(By.Name("descricao"));
            IWebElement inputResumo = driver.FindElement(By.Name("resumo"));
            IWebElement inputTitulo = driver.FindElement(By.Name("titulo"));
            IWebElement selectArea = driver.FindElement(By.Name("area"));
            inputDescricao.SendKeys("Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente.");
            inputResumo.SendKeys("Teste Proposta nova sobre meio ambiente Teste Proposta nova sobre meio ambiente.");
            inputTitulo.SendKeys("Proposta para diminuir o desmatamento da amazonia");
            selectArea.SendKeys("6");               
            inputTitulo.Submit();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("notifyjs-bootstrap-base")));
            IWebElement divSucesso = driver.FindElement(By.ClassName("notifyjs-bootstrap-success"));
            Assert.NotNull(divSucesso);

        }

    }
}
