using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACardWeb.ObjectRepository
{
    public class LoginObjects
    {
        public static By Year1 = By.XPath("//input[@class='agv2__input'][@placeholder='A'][@data-qadp='age_gate_year_1']");
        public static By Year2 = By.XPath("//input[@class='agv2__input'][@placeholder='A'][@data-qadp='age_gate_year_2']");
        public static By Year3 = By.XPath("//input[@class='agv2__input'][@placeholder='A'][@data-qadp='age_gate_year_3']");
        public static By Year4 = By.XPath("//input[@class='agv2__input'][@placeholder='A'][@data-qadp='age_gate_year_4']");
    }
    public class month {

        public static By month2 = By.XPath("//input[@data-next='month-02']");
        public static By month1 = By.XPath("//input[@class='agv2__input'][@data-qadp='age_gate_month_2'][@data-previous='month-01']");

    }
    public class day { 
        public static By day2 = By.XPath("//input[@class='agv2__input'][@data-next='day-02']");
        public static By day1 = By.XPath("//input[@class='agv2__input'][@data-qadp='age_gate_day_2'][@data-element='day-02']");

        public static By check1 = By.XPath("//input[@type='checkbox'][@data-element='remember-date']");
        public static By button = By.XPath("//div[@class='agegate__btns']");
        public static By cookies = By.XPath("//button[@id='onetrust-accept-btn-handler']");
        public static By votar = By.XPath("//a[@id='presidenteStudiosButton']");
        public static By votar_aqui = By.XPath("//a[@id='voteHere']");
        public static By correo = By.XPath("//input[@id='edit-mail--3']");
        public static By ingresar = By.XPath("//input[@id='edit-submit'][@name='op'][@data-drupal-selector='edit-submit'][@value='INGRESAR']");
        public static By nombre = By.XPath("//input[@id='edit-name'][@name='name'][@data-drupal-selector='edit-name']");
       public static By apellido = By.XPath("//input[@id='edit-lastname']");
        public static By telefono = By.XPath("//input[@id='edit-phone']");
        public static By DayNacimiento = By.XPath("//select[@id='edit-day']");
         public static By monthNacimiento = By.XPath("//select[@id='edit-month'][@name='month']");
        public static By yearNacimiento = By.XPath("//select[@id='edit-year'][@name='year']");
        public static By cedula = By.XPath("//input[@id='edit-dni'][@name='dni']");
        public static By provincia = By.XPath("//select[@id='edit-provinces'][@name='provinces']");
        public static By ciudad = By.XPath("//select[@data-drupal-selector='edit-city'][@data-once='drupal-ajax']");
        public static By sector = By.XPath("//select[@data-drupal-selector='edit-sector']");
        public static By genero = By.XPath("//select[@id='edit-gender'][@name='gender']");
        public static By password = By.XPath("//input[@id='edit-passconfirm-pass1'][@name='passconfirm[pass1]']");
        public static By passwordConfirm = By.XPath("//input[@id='edit-passconfirm-pass2']");
        public static By check2 = By.XPath("//input[@id='edit-terms'][@name='terms']");
        public static By check3 = By.XPath("//input[@id='edit-marketing']");
        public static By registrar = By.XPath("//input[@id='edit-submit'][@value='REGISTRARME']");
        public static By validar = By.XPath("//button[@class='prsdnt-code-popup__button prsdnt-code-popup__button--primary prsdnt-code-popup__validate']");
        public static By buscar = By.XPath("//input[@id='search']");
        public static By mc = By.XPath("//button[@data-node-id='941']");



    }
}
