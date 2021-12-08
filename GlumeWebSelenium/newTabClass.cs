using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlumeWebSelenium
{
    class newTabClass
    {
    }
}
// public void challengeDescriptionPageLinks()
//        {
//              driver.FindElement(By.ClassName("ft-activity")).Click();
//              Console.WriteLine("Click challenge icon");
//              Thread.Sleep(2000);
//              driver.FindElement(By.XPath("//*[@id='dTable_length']/label/select/option[4]")).Click();
//              var item = driver.FindElement(By.Id("dTable")).FindElements(By.TagName("a")).Select(x => x.GetAttribute("href"));
//              var item = driver.FindElement(By.xpath(//*[@id='root']/div/div[2]/main/div/div/div/div[2]/div[2]/div/div/div/div).FindElements(By.TagName("button"))
//            for (int i = 0; i <= item.Count() - 1; i++)
//            {
//                var tablelink = driver.FindElement(By.Id("dTable")).FindElements(By.TagName("a")).ToList()[i].GetAttribute("href");
//                Console.WriteLine("All the internal Links of that specific Link --> " + tablelink);
//                string Linkvariable = "\"" + tablelink + "\"";
//                string str = "window.open(" + Linkvariable + ")";
//                ((IJavaScriptExecutor)driver).ExecuteScript(str);
//                driver.SwitchTo().Window(driver.WindowHandles.Last());
//                Thread.Sleep(10000);
//                var nexttablink = driver.FindElement(By.Id("user-area")).FindElements(By.TagName("a")).Select(x => x.GetAttribute("href"));

//                List<string> link = new List<string>();

//                foreach (var check in nexttablink)
//                {
//                    if (check == null)
//                    {
//                        continue;
//                    }

//                    else
//                    {
//                        link.Add(check);
//                    }
//                }

//                for (int j = 0; j <= link.Count() - 1; j++)
//                {
//                    //var links = driver.FindElement(By.Id("user-area")).FindElements(By.TagName("a")).ToList()[j].GetAttribute("href");
//                    Console.WriteLine(" " + link.ToList()[j].ToString());
//                    writeToFile2(link.ToList()[j].ToString());
//                }


//                driver.Close();
//                driver.SwitchTo().Window(driver.WindowHandles.First());
//                Thread.Sleep(8000);
//            }

// writeToFil