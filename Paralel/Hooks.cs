using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralel
{
    public class Hooks : Base
    {
        public Hooks()
        {
            var nodeUrl = "http://192.168.99.100:4444";
            ChromeOptions options = new ChromeOptions();

            Driver = new RemoteWebDriver(new Uri(nodeUrl), options);

            // Driver = new ChromeDriver();
        }
    }
}
