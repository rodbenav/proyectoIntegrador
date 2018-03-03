using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace UnitTest
{
    [TestClass]
    public class TestHuellaLatente
    {
        [TestMethod]
        public void testHuellaLatente()
        {
            // Inicializar chrome driver
            using (var driver = new ChromeDriver())
            {
                // Variables a utilizar
                IWebElement element;
                Actions actions = new Actions(driver);
                // Pantalla completa
                driver.Manage().Window.Maximize();
                // Ir al índice
                driver.Navigate().GoToUrl("http://localhost:49290/");
                // Ir a la sección Huellas latentes
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[1]/a"));
                element.Click();
                Thread.Sleep(2000);
                // Ver detalle
                element = driver.FindElement(By.Id("detalle1"));
                element.Click();
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("detalle2"));
                // Se hace scroll a la pantalla hasta el emento
                actions.MoveToElement(element);
                actions.Perform();
                element.Click();
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("detalle3"));
                // Se hace scroll a la pantalla hasta el emento
                actions.MoveToElement(element);
                actions.Perform();
                Thread.Sleep(2000);
                element.Click();
                Thread.Sleep(2000);
                element.Click();
                Thread.Sleep(2000);
                // Probar el filtro
                element = driver.FindElement(By.Id("filter"));
                actions.MoveToElement(element);
                actions.Perform();
                element.SendKeys("34.1");
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("detalle3"));
                element.Click();
                Thread.Sleep(2000);
                // Volver al índice
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                element.Click();
                Thread.Sleep(2000);
                // Termina test
                Console.WriteLine("Prueba Completada");
            }
        }
    }
}