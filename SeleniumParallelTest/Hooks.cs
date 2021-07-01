﻿using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SeleniumParallelTest
{
    [TestFixture]
    public class Hooks : Base
    {

        public Hooks()
        {
            Driver = new FirefoxDriver();
        }
    
    }
}
