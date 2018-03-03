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
    public class TestCuenta
    {
        [TestMethod]
        public void testMiCuenta()
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
                element = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/ul/li[4]/a"));
                element.Click();
                // Ver detalle
                Thread.Sleep(2000);
                element = driver.FindElement(By.XPath(@"//*[@id=""history""]/thead/tr/th[1]"));
                element.Click();
                // Probar el filtro
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("filter"));
                element.SendKeys("33.1");
                // Probar botón para nueva identificación
                Thread.Sleep(2000);
                element = driver.FindElement(By.Id("nuevaIdentificacion"));
                element.Click();              
                // Termina test
                Console.WriteLine("Prueba Completada");
            }
        }
    }
}