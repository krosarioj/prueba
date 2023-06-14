using ACardWeb.Keywords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACardWeb.Tests
{
    [TestClass]
    public class Login : BrowserDriver.DriverHelper
    {
        string ciudadrandom;
        string sector;
        [TestMethod ("Iniciar sesion con las credenciales correctas")]

        public void IniciarSesion_CredencialesCorrectas()
        {

            Iniciar("CHROME");
            driver.Navigate().GoToUrl(Profiles.QA.URL);
            Random ls = new Random();
            List<string> numbers = new List<string>() { "Distrito Nacional", "Santo Domingo", "San Cristóbal", "La Vega", "Santiago" }; //, "Santo Domingo", "San Cristóbal", "La Vega", "Santiago"
            int randIndex = ls.Next(numbers.Count);
            string random = Convert.ToString(numbers[randIndex]);
            //string ciudadrandom;
          if (random == "Distrito Nacional")
            {
                ciudadrandom = "Distrito Nacional";
            }
          else if (random == "Santo Domingo")
            {
                ciudadrandom = "Santo Domingo Este";
            }
            else if (random == "San Cristóbal")
            {
                ciudadrandom = "Bajos de Haina";
            }
            else if (random == "La Vega")
            {
                ciudadrandom = "Constanza";
            }
            else if (random == "Santiago")
            {
                ciudadrandom = "Jánico";
            }

            if (ciudadrandom == "Distrito Nacional")
            {
                sector = "Cacique";
            }
            else if (ciudadrandom == "Santo Domingo Este")
            {
                sector = "Cancino";
            }
            else if (ciudadrandom == "Bajos de Haina")
            {
                sector = "N/A"; 
            }
            else if (ciudadrandom == "Constanza")
            {
                sector = "N/A";
            }
            else if (ciudadrandom == "Jánico")
            {
                sector = "Arenilla"; 
            }


            /* List<string> ciudad = new List<string>() { "Distrito Nacional", "Santo Domingo Este", "San Cristóbal", "La Vega", "Santiago" };
             int ciudadIndex = ls.Next(ciudad.Count);
             string ciudadrandom = Convert.ToString(ciudad[ciudadIndex]); */
            LoginMethods.IngresarUsuario(driver, Convert.ToString(ls.Next(1, 9)), Convert.ToString(ls.Next(1985, 1999)), random, ciudadrandom, "Hombre", sector);
        
            //Validaciones
        }
     /*(   [TestMethod("Iniciar sesion con las credenciales incorrectas")]
        public void IniciarSesion_CredencialesInorrectas()
        {
            Iniciar("CHROME");
            LoginMethods.IngresarUsuario(driver, Profiles.QA.Usuario);
            LoginMethods.IngresarClave(driver, "asasas");
            LoginMethods.PresionarEntrar(driver);
            //Validaciones
        } */
    }
}
