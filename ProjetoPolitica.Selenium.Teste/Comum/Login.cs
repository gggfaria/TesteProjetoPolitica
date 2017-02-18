using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjetoPolitica.Selenium.Teste.Comum
{
    static class Login
    {
        public static void FazerLoginEleitor(IWebDriver driver, string login, string senha)
        {
          
            driver.Navigate().GoToUrl("http://localhost:8080/Politica/login/logar");

            IWebElement userName = driver.FindElement(By.Id("login_usuario"));
            IWebElement password = driver.FindElement(By.Id("login_senha"));

            userName.SendKeys(login);
            password.SendKeys(senha);

            Thread.Sleep(1000);
            userName.Submit();
            
        }

        public static void FazerLoginPolitico(IWebDriver driver, string login, string senha)
        {

            driver.Navigate().GoToUrl("http://localhost:8080/Politica/login/logar");

            IWebElement userName = driver.FindElement(By.Id("login_usuario"));
            IWebElement password = driver.FindElement(By.Id("login_senha"));



            Thread.Sleep(500);
            userName.SendKeys("joao.silva@mail.com");
            password.SendKeys("senha");
           

            userName.Submit();
            Thread.Sleep(1000);
      
        }

    }
}
