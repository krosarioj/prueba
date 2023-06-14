using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserDriver;
using ACardWeb.ObjectRepository;
using System.Threading;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace ACardWeb.Keywords
{
    public class LoginMethods
    {
        public static void IngresarUsuario(WebDriver driver, string value, string val, string va, string ciudad, string genero, string sector)
        {
                 Random rnd = new Random();
        

            Thread.Sleep(4000);
             driver.FindElement(day.cookies).Click();
            driver.FindElement(LoginObjects.Year1).SendKeys(Convert.ToString(1));
            driver.FindElement(LoginObjects.Year2).SendKeys(Convert.ToString(9));
            driver.FindElement(month.month2).SendKeys(Convert.ToString(1));
            driver.FindElement(month.month1).SendKeys(Convert.ToString(2));
            driver.FindElement(LoginObjects.Year3).SendKeys(Convert.ToString(9));
            driver.FindElement(LoginObjects.Year4).SendKeys(Convert.ToString(9));
            
             driver.FindElement(day.day2).SendKeys(Convert.ToString(1));
           driver.FindElement(day.day1).SendKeys(Convert.ToString(2));
            Thread.Sleep(4000);
            driver.FindElement(day.check1).Click();
            Thread.Sleep(4000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            driver.FindElement(day.button).Click();
           
            driver.FindElement(day.votar).Click();
            driver.FindElement(day.votar_aqui).Click();

            /* string[] correos = { "kevin@gmail.com", "josue@gmail.com", "sammy@gmail.com", "nose@gmail.com" };
             for (int i = 0; i < correos.Length; i++)
             {*/
            List<string> correos = new List<string>() { "Pedr45o@gmail.com", "javier4@gmail.com", "rau5l@gmail.com", "juan7@gmail.com", "kevin55@gmail.com" };

            
            int correosIndex = rnd.Next(correos.Count);
            string correosrandom = Convert.ToString(correos[correosIndex]);
            driver.FindElement(day.correo).SendKeys(correosrandom);

                driver.FindElement(day.ingresar).Click();
            Thread.Sleep(4000);
            driver.FindElement(day.nombre).Click();
            // driver.FindElement(day.nombre).SendKeys("kevin");

            List<string> numbers = new List<string>() { "Pedro","javier", "raul","juan", "kevin" };

            Random rd = new Random();
            int randIndex = rd.Next(numbers.Count);
            string random = Convert.ToString(numbers[randIndex]);

            driver.FindElement(day.nombre).SendKeys(random);


            List<string> apellido = new List<string>() { "rosario", "jimenez", "hernadez", "garcia", "guzman" };

            Random apel = new Random();
            int randapellido = rd.Next(apellido.Count);
            string randomapell = Convert.ToString(apellido[randapellido]);
            Byte[] b = new Byte[10];
            driver.FindElement(day.apellido).SendKeys(randomapell);
            driver.FindElement(day.telefono).SendKeys("8295592502");

            driver.FindElement(day.DayNacimiento).Click();
            var dropdown = new SelectElement(driver.FindElement(day.DayNacimiento));
            dropdown.SelectByText(value);
            Assert.That(dropdown.SelectedOption.Text, Is.EqualTo(value));


            driver.FindElement(day.monthNacimiento).Click();
            var dropdowns = new SelectElement(driver.FindElement(day.monthNacimiento));
            dropdowns.SelectByText(value);
            Assert.That(dropdowns.SelectedOption.Text, Is.EqualTo(value));

            driver.FindElement(day.yearNacimiento).Click();
            var dropdow = new SelectElement(driver.FindElement(day.yearNacimiento));
            dropdow.SelectByText(val);
            Assert.That(dropdow.SelectedOption.Text, Is.EqualTo(val));
            driver.FindElement(day.cedula).SendKeys(Convert.ToString(apel.Next()));

            driver.FindElement(day.provincia).Click();
            var dropdo = new SelectElement(driver.FindElement(day.provincia));
            dropdo.SelectByText(va);
            Assert.That(dropdo.SelectedOption.Text, Is.EqualTo(va));
            Thread.Sleep(4000);

            driver.FindElement(day.ciudad).Click();
            var dropd = new SelectElement(driver.FindElement(day.ciudad));
            dropd.SelectByText(ciudad);
            Assert.That(dropd.SelectedOption.Text, Is.EqualTo(ciudad));
            Thread.Sleep(2000);

            driver.FindElement(day.sector).Click();
            var drop = new SelectElement(driver.FindElement(day.sector));
            drop.SelectByText(sector);
            Assert.That(drop.SelectedOption.Text, Is.EqualTo(sector));

            Thread.Sleep(2000);
            driver.FindElement(day.genero).Click();
            var dro = new SelectElement(driver.FindElement(day.genero));
            dro.SelectByText(genero);
            Assert.That(dro.SelectedOption.Text, Is.EqualTo(genero));

            driver.FindElement(day.password).SendKeys("qwerty12");
            driver.FindElement(day.passwordConfirm).SendKeys("qwerty12");

            driver.FindElement(day.check2).Click();
            driver.FindElement(day.check3).Click();
            driver.FindElement(day.registrar).Click();
            Thread.Sleep(30000);

            driver.FindElement(day.validar).Click();
            driver.FindElement(day.buscar).Click();
            driver.FindElement(day.buscar).SendKeys("mc");
            driver.FindElement(day.mc).Click();
            //Convert.ToString(apel.Next(1985, 1999))
            // }



        }
        /*
               public static void IngresarClave(WebDriver driver)
               {



               }

               public static void PresionarEntrar(WebDriver driver)
               {
                   driver.FindElement(LoginObjects.button_Entrar).Click();
               }*/
    }
}
