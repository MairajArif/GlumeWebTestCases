using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GlumeWebSelenium
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.initilize();

            obj.login();

            //obj.Project();
            //obj.Delete_Project();

            //obj.Create_Client();
            //obj.Delete_Client();

            //obj.Invoice_Detail();
            //obj.Invoice_Detail_LOOPCHECK();

            //obj.Billing();

            obj.Subscription_Psckages();
        }
        public void initilize()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://glume-client.herokuapp.com/");
            Console.WriteLine("Website Open Successfully");

        }

        public void login()
        {
            driver.FindElement(By.XPath("//*[@id='root']/div/section/div/div[2]/div/form/div/div[2]/input")).SendKeys("admin@demo.com");
            driver.FindElement(By.XPath("//*[@id='root']/div/section/div/div[2]/div/form/div/div[3]/input")).SendKeys("123456");
            driver.FindElement(By.XPath("//*[@id='root']/div/section/div/div[2]/div/form/div/div[5]/button")).Click();
            Thread.Sleep(2000);
            Console.WriteLine("Login Successfully");
           
        }

        public void Project()
        {
            driver.FindElement(By.XPath("//*[@id='root']/div/div[1]/div[2]/ul/a[2]/li/span[1]/img")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/a/div/div[1]/img")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[1]/input")).SendKeys("Selenium_Testing Project");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[2]/div/select")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[2]/div/select/option[19]")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[3]/input")).SendKeys("New_Domain.com");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[4]/input")).SendKeys("25000");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[5]/div/select")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[5]/div/select/option[3]")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[6]/div/select")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[6]/div/select/option[2]")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[7]/div/select")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[7]/div/select/option[3]")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[8]/input")).SendKeys("10");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[9]/textarea")).SendKeys("A project description is a high-level overview of why you're doing a project. The document explains a project's objectives and its essential qualities. ... The project description should include an overview of the following: Project goals and objectives. Stakeholders and their roles.");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[10]/button")).Click();
            Thread.Sleep(1000);
        }
        public void Delete_Project()
        {
            driver.FindElement(By.XPath("//*[@id='root']/div/div[1]/div[2]/ul/a[2]/li/span[1]/img")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div[5]/div/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]")).Click();
        }

        public void Create_Client()
        {
            driver.FindElement(By.XPath("//*[@id='root']/div/div[1]/div[2]/ul/a[3]/li/span[1]/img")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/a/div/div[1]/img")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[1]/input")).SendKeys("QATest");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[2]/input")).SendKeys("Selenium");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[3]/input")).SendKeys("Selenium@QA.com");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[4]/input")).SendKeys("123456");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[5]/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div")).Click();
            Thread.Sleep(1000);
        }
        public void Delete_Client()
        {
            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div[6]/div/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/main/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div[6]/div/button[2]")).Click();
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]")).Click();
        }

        public void Invoice_Detail()
        {
            Thread.Sleep(200);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[1]/div[2]/ul/a[4]/li/span[1]/img")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div/div/div[2]/main/div/div/div/div[2]/div[2]/div/div/div/div/div/div[1]/div[6]/div/button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/header/div/a")).Click();
        }
        //Same as above function contin loop 
        public void Invoice_Detail_LOOPCHECK()
        {
            Thread.Sleep(200);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[1]/div[2]/ul/a[4]/li/span[1]/img")).Click();
            Thread.Sleep(2000);

            for (int i = 1; i<= 10;)
            {
                string BeforLink = "/html/body/div/div/div[2]/main/div/div/div/div[2]/div[2]/div/div/div/div/div/div[";
                string AfterLink = "]/div[6]/div/button";
                Thread.Sleep(2000);
                driver.FindElement(By.XPath(""+BeforLink+i+AfterLink)).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/header/div/a")).Click();

                if (i == 10)
                {
                    Thread.Sleep(3000);
                    driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div/div/div/div[3]/div/div[2]/div/div[2]/button[2]")).Click();
                    i = 1;
                    continue;
                }
               
                else
                {
                    i++;
                }
            }
        }


        public void Billing()
        {
            Thread.Sleep(200);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[1]/div[2]/ul/a[5]/li/span[1]/img")).Click();
            Thread.Sleep(2000);

            for (int i = 1; i <= 3;)
            {
                string BeforLink = "/html/body/div/div/div[2]/main/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/div[";
                string AfterLink = "]/div[5]/div/button";
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("" + BeforLink + i + AfterLink)).Click();
                Thread.Sleep(3000);
                
                    if (i == 3)
                    {
                         var check = driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div/div/div[1]/div[3]/div/div[2]/div/div[2]/button[2]")).GetAttribute("disabled");
                        if (check == null)
                        {
                            Thread.Sleep(3000);
                            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div/div/div[1]/div[3]/div/div[2]/div/div[2]/button[2]")).Click();
                            i = 1;
                            continue;
                         }
                         else
                         {
                           break;
                         }
                    }
                    else
                    {
                        i++;
                    }
                }
        }
       
        public void Subscription_Psckages()
        {
            Thread.Sleep(200);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[1]/div[2]/ul/a[6]/li/span[1]/img")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/a/div/div[1]/img")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[1]/input")).SendKeys("Selenium_Package");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[2]/input")).SendKeys("420");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[3]/div/select")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[3]/div/select/option[8]")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[4]/div/select")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[4]/div/select/option[3]")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[5]/div/div[1]/input")).SendKeys("420,pack#1,pack#2,");
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/main/div[2]/div/div[6]/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div")).Click();
            Thread.Sleep(3000);
            Delete_Subscription_Package();
        }
        public void Delete_Subscription_Package()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/main/div/div/div[2]/div[2]/div[2]/div/div/div/div/div/div[1]/div[6]/div/button[2]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/button[2]")).Click();
        }


    }
}
