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
    public class TestHistorial
    {
        [TestMethod]
        public void testHistorial()
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
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[3]/a"));
                element.Click();
                // Ver detalle
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("detalle1"));
                element.Click();
                // Se regresa a la pantalla de huellas latentes
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[3]/a"));
                element.Click();
                // Probar el filtro
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("filter"));
                element.SendKeys("2018");
                // Probar botón para nueva identificación
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("nuevaIdentificacion"));
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