using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V120.Debugger;
namespace TestDNDK
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void TestDangKi()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:22222/");
            
            IWebElement botton = driver.FindElement(By.ClassName("fa-user-plus"));
            if (botton != null)
            {
                botton.Click();
                Thread.Sleep(1000);
                
            }
            IWebElement tenDangNhap = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/form/div[1]/input[1]"));
            tenDangNhap.SendKeys("tienze1233");
            Thread.Sleep(1000);
            IWebElement hoTen = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/form/div[1]/input[2]"));
            hoTen.SendKeys("Phan Anh Tien");
            Thread.Sleep(1000);
            IWebElement matKhau = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/form/div[1]/input[3]"));
            matKhau.SendKeys("123456");
            Thread.Sleep(1000);
            IWebElement xacNhanMK = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/form/div[1]/input[4]"));
            xacNhanMK.SendKeys("123456");
            Thread.Sleep(1000);
            IWebElement email = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/form/div[1]/input[5]"));
            email.SendKeys("tienze@gmail.com");
            Thread.Sleep(1000);
            IWebElement soDienThoai = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/form/div[1]/input[6]"));
            soDienThoai.SendKeys("0123456789");
            Thread.Sleep(1000);
            IWebElement bottonDK = driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/form/div[1]/button"));
            if(bottonDK != null)
            {
                bottonDK.Click();
                Thread.Sleep(1000);
            }    
            Assert.IsNotNull(driver);
        }
        [Test]
        public void TestDangNhap()
        {
            driver.Navigate().GoToUrl("http://localhost:22222/");
            IWebElement botton = driver.FindElement(By.ClassName("fa-sign-in-alt"));
            if(botton != null )
            {
                botton.Click();
                Thread.Sleep(1000);
            }
            IWebElement tenDangNhap = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div/form/div[1]/input[1]"));
            tenDangNhap.Clear();
            Thread.Sleep(1000);
            tenDangNhap.SendKeys("tienze1233");
            IWebElement matKhau = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div/form/div[1]/input[2]"));
            matKhau.Clear();
            Thread.Sleep(1000);
            matKhau.SendKeys("123456");
            IWebElement bottonDN = driver.FindElement(By.XPath("/html/body/div[8]/div/div/div/form/div[1]/button"));
            if(bottonDN != null)
            {
                bottonDN.Click();
                Thread.Sleep(1000);
            }
            Assert.IsNotNull(driver);
        }
    }
}