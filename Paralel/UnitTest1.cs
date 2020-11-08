using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;

namespace Paralel
{
    [TestFixture]
    [Parallelizable]
    public class Google1
    {
        [Test]
        public void GoogleTest1()
        {
            //var nodeUrl = "http://192.168.99.1:4444/";
            //ChromeOptions options = new ChromeOptions();
            //var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);
            //var Driver = new ChromeDriver();
            var Driver =  new PhantomJSDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            for (int i = 0; i < 20; i++)
            {
                Driver.Navigate().Refresh();
                Thread.Sleep(2000);
            }
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }

    [TestFixture]
    [Parallelizable]

    public class Google2
    {
        [Test]
        public void GoogleTest2()
        {
            Thread.Sleep(20000);
            var nodeUrl = "http://192.168.99.1:4444/";
            ChromeOptions options = new ChromeOptions();

            var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);

            //var Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            for (int i = 0; i < 20; i++)
            {
                Driver.Navigate().Refresh();
                Thread.Sleep(2000);
            }
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }

    [TestFixture]
    [Parallelizable]

    public class Google3
    {
        [Test]
        public void GoogleTest3()
        {
            var nodeUrl = "http://192.168.99.1:4444/";

            ChromeOptions options = new ChromeOptions();

            var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);
            //var Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            for (int i = 0; i < 20; i++)
            {
                Driver.Navigate().Refresh();
                Thread.Sleep(2000);
            }
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }

    [TestFixture]
    [Parallelizable]

    public class Google4
    {
        [Test]
        public void GoogleTest4()
        {
            var nodeUrl = "http://192.168.99.1:4444/";
            ChromeOptions options = new ChromeOptions();

            var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);
            //var Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            for (int i = 0; i < 20; i++)
            {
                Driver.Navigate().Refresh();
                Thread.Sleep(2000);
            }
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }

    [TestFixture]
    [Parallelizable]

    public class Google5
    {
        [Test]
        public void GoogleTest5()
        {
            var nodeUrl = "http://192.168.99.1:4444/";
            ChromeOptions options = new ChromeOptions();

            var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);
            //var Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }

    [TestFixture]
    [Parallelizable]

    public class Google6
    {
        [Test]
        public void GoogleTest6()
        {
            var nodeUrl = "http://192.168.99.1:4444/";
            ChromeOptions options = new ChromeOptions();

            var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);
            //var Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }

    [TestFixture]
    [Parallelizable]

    public class Google7
    {
        [Test]
        public void GoogleTest7()
        {
            var nodeUrl = "http://192.168.99.1:4444/";
            ChromeOptions options = new ChromeOptions();

            var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);
            // var Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }

    [TestFixture]
    [Parallelizable]

    public class Google8
    {
        [Test]
        public void GoogleTest8()
        {
            var nodeUrl = "http://192.168.99.1:4444/";
            ChromeOptions options = new ChromeOptions();

            var Driver = new RemoteWebDriver(new Uri(nodeUrl), options);
            //var Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Navigate().GoToUrl("https://www.google.com/");
            Driver.Close();
            Driver.Quit();
            //while (true)
            //{
            //    Driver.Navigate().Refresh();
            //    Thread.Sleep(2000);
            //}
        }
    }


}
