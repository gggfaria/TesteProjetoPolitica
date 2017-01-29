using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPolitica.Selenium.Teste.Comum
{
    static class Login
    {
        public static void FazerLoginEleitor(IWebDriver driver)
        {
          
            driver.Navigate().GoToUrl("http://localhost:8080/Politica/login/logar");

            IWebElement userName = driver.FindElement(By.Name("j_username"));
            IWebElement password = driver.FindElement(By.Name("j_password"));

            userName.SendKeys("gabrielguima@mail.com");
            password.SendKeys("senha");

            userName.Submit();
            
        }

        public static void FazerLoginPolitico(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/login/logar");

            IWebElement userName = driver.FindElement(By.Name("j_username"));
            IWebElement password = driver.FindElement(By.Name("j_password"));

            userName.SendKeys("joao.silva@mail.com");
            password.SendKeys("senha");
            userName.Submit();

        }

    }
}
