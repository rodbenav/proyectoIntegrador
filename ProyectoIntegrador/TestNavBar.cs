using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace UnitTest
{
    [TestClass]
    public class TestNavBar
    {
        [TestMethod]
        public void testNavBar()
        {
            // Inicializar chrome driver
            using (var driver = new ChromeDriver())
            {
                // Variables a utilizar
                IWebElement element;
                // Pantalla completa
                driver.Manage().Window.Maximize();
                // Ir al índice
                driver.Navigate().GoToUrl("http://localhost:49290/");
                // Ir a la sección Huellas latentes
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[1]/a"));
                element.Click();
                // Ir a la sección Impresiones de huellas
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[2]/a"));
                element.Click();
                // Ir a la sección Historial
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[3]/a"));
                element.Click();
                // Ir a la sección Mi cuenta
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[4]/a"));
                element.Click();
                // Volver al índice
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                element.Click();
                // Termina test
                Console.WriteLine("Prueba Completada");
            }
        }
    }
}