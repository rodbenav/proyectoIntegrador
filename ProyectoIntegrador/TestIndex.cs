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
    public class TestIndex
    {
        [TestMethod]
        public void testIndex()
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
                // Ir a la sección de identificación de huella latente
                element = driver.FindElement(By.Id("identificacionLatente"));
                element.Click();
                Thread.Sleep(2000);
                // Volver al índice
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                element.Click();
                Thread.Sleep(2000);
                // Ir a la sección de identificación de huella impresión
                element = driver.FindElement(By.Id("identificacionImpresion"));
                element.Click();
                Thread.Sleep(2000);
                // Volver al índice
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                element.Click();
                Thread.Sleep(2000);
                // Ir a la sección de identificaciones guardadas
                element = driver.FindElement(By.Id("verHistorial"));
                element.Click();
                Thread.Sleep(2000);
                // Volver al índice
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/a"));
                element.Click();
                Thread.Sleep(1000);
                // Termina test
                Console.WriteLine("Prueba Completada");
            }
        }
    }
}