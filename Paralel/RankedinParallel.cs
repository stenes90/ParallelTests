﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Remote;

namespace Paralel
{
   

    [TestFixture]
    [Parallelizable]
    public class RankedinTests
    {
        public void SetImplicitWait(int status, IWebDriver Driver)
        {
            if (status == 1)
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            else if (status == 0)
            {
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            }
            else throw new Exception();


        }

        public void WaitUntillPageLoad(IWebDriver Driver)
        {


            int currentWait = 10000;
            Thread.Sleep(200);
            //WaitUntilSpinnerStops();
            while (currentWait > 0) // Handle timeout somewhere
            {
                Thread.Sleep(100);
                currentWait -= 100;

                var ajaxIsComplete = (bool)(Driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                    break;
            }
            //WaitUntilSpinnerStops();
            Thread.Sleep(500);
        }

        public void WaitUntilElementExist(By by, IWebDriver Driver)
        {
            int wait = 25000;
            SetImplicitWait(0, Driver);
            var elements = Driver.FindElements(by);
            while (elements.Count < 1)
            {
                elements = Driver.FindElements(by);
                Thread.Sleep(200);
                wait -= 200;
                if (wait == 0)
                {
                    throw new Exception("Element not exist after 15 sec");
                }
            }


            SetImplicitWait(1, Driver);

        }


        public void test()
        {

            //var Driver = new PhantomJSDriver();
            var Driver = new ChromeDriver();
            var rnd = new Random();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://rankedindev-staging.azurewebsites.net/");
            //var extensionImgString = "C:\\Selenium\\Rankedin.Selenium\\Images\\reload_extension.jpg";
            Driver.FindElement(By.CssSelector(".btn-ghost.pro")).Click();
            Thread.Sleep(300);
            Driver.FindElement(By.Id("email")).SendKeys("player1@sele.com");
            Thread.Sleep(300);
            Driver.FindElement(By.Id("password")).SendKeys("kralimarko");
            Thread.Sleep(rnd.Next(100, 5000));
            Driver.FindElement(By.Id("dropdown-login-button")).Click();
            Thread.Sleep(rnd.Next(100, 5000));
            //Browser.WaitUntilElementExist(By.CssSelector("p.id"));
            var profilePageURL = "https://rankedindev-staging.azurewebsites.net/en/player/R000028193/seleplayer-player1";
            var eventHomeURL = "https://rankedindev-staging.azurewebsites.net/en/tournament/2963/load-test-tn";
            var scoreboardsPageURL = "https://rankedindev-staging.azurewebsites.net/en/livescore/courtview/2963";
            var timetablePageURL = "https://rankedindev-staging.azurewebsites.net/en/tournament/timetable/2963";
            var enterResultPageURL = "https://rankedindev-staging.azurewebsites.net/en/tournament/enterresult/2963";
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    Driver.Navigate().GoToUrl(profilePageURL);
                    WaitUntilElementExist(By.CssSelector(".profile-match .btn-warning"), Driver);
                    rnd.Next(100, 5000);
                    Driver.Navigate().GoToUrl(eventHomeURL);
                    WaitUntillPageLoad(Driver);
                    rnd.Next(100, 5000);
                    Driver.Navigate().GoToUrl(scoreboardsPageURL);
                    WaitUntillPageLoad(Driver);
                    rnd.Next(100, 5000);
                    Driver.Navigate().GoToUrl(timetablePageURL);
                    WaitUntilElementExist(By.CssSelector(".cell-handle"), Driver);
                    rnd.Next(100, 5000);
                    Driver.Navigate().GoToUrl(enterResultPageURL);
                    WaitUntilElementExist(By.CssSelector("td.no-right-border .btn-info"), Driver);
                    rnd.Next(100, 5000);
                }
                catch (Exception)
                {
                    Driver.Close();
                    Driver.Quit();
                    test();
                }
               

            }
            //{
            //    Driver.Navigate().GoToUrl(profilePageURL);
            //    Thread.Sleep(5000);
            //    Driver.Navigate().GoToUrl(eventHomeURL);
            //    Thread.Sleep(5000);
            //    Driver.Navigate().GoToUrl(scoreboardsPageURL);
            //    Thread.Sleep(5000);
            //    Driver.Navigate().GoToUrl(timetablePageURL);
            //    Thread.Sleep(5000);
            //    Driver.Navigate().GoToUrl(enterResultPageURL);
            //    Thread.Sleep(5000);
            //}
        }
        //[Test]
        //public void fuckMultiThread()
        //{
        //    var driver = new PhantomJSDriver();
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        //    driver.Manage().Window.Maximize();
        //    void OpenNewTab()
        //    {
        //        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        //    }
        //    for (int i = 0; i < 30; i++)
        //    {
        //        OpenNewTab();
        //        Thread.Sleep(100);
        //    }
        //    Thread.Sleep(500);
        //    //Browser.Driver.SwitchTo().Window(Browser.Driver.WindowHandles.ToList()[i]);
        //    var tabs = driver.WindowHandles.ToList();
        //    Thread.Sleep(500);
        //    for (int i = 0; i < tabs.Count; i++)
        //    {
        //        driver.SwitchTo().Window(driver.WindowHandles.ToList()[i]);
        //        driver.Navigate().GoToUrl("https://rankedindev-staging.azurewebsites.net/");
        //        Thread.Sleep(100);
        //    }
        //    Thread.Sleep(100);
        //    for (int i = 0; i < tabs.Count; i++)
        //    {
        //        driver.SwitchTo().Window(driver.WindowHandles.ToList()[i]);
        //        driver.FindElement(By.CssSelector(".btn-ghost.pro")).Click();
        //        Thread.Sleep(300);
        //        driver.FindElement(By.Id("email")).SendKeys("player1@sele.com");
        //        Thread.Sleep(300);
        //        driver.FindElement(By.Id("password")).SendKeys("kralimarko");
        //        Thread.Sleep(300);
        //        driver.FindElement(By.Id("dropdown-login-button")).Click();
        //        Thread.Sleep(100);

        //    }
        //    Thread.Sleep(100);

        //}



        [Parallelizable]
        [Test]
        public void Test1()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test2()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test3()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test4()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test5()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test6()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test7()
        {
           // var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test8()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test9()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test10()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test11()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test12()
        {
           // var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test13()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test14()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test15()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test16()
        {
           // var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test17()
        {
           // var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test18()
        {
           // var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test19()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }

        [Parallelizable]
        [Test]
        public void Test20()
        {
            //var Driver = new PhantomJSDriver();
            test();
        }
    }




}
