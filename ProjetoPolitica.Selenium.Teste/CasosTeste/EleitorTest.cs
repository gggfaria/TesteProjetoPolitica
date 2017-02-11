using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        public void ValidacaoEmail()
        {
            IWebDriver driver = new ChromeDriver();
            Thread.Sleep(500);

        }
    }
}
