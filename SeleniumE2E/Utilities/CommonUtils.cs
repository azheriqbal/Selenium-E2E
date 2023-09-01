/*using Ocelot.Infrastructure;
using OpenQA.Selenium;
using Telerik.JustMock;

namespace SeleniumE2E.Utilities
{
    public class CommonUtils
    {
        private IWebDriver driver;

        public CommonUtils(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TakeScreenshot(string screenshotName)
        {
            // Implement the screenshot functionality using the driver
            // For example:
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }

        public void ScrollToElement(IWebElement element)
        {
            // Implement scrolling functionality to bring the element into view
            // For example:
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void WaitUntilElementVisible(By locator, int timeoutInSeconds)
        {
            Wait.Timeout = TimeSpan.FromSeconds(timeoutInSeconds);
            Wait.Until(driver => driver.FindElement(locator).Displayed);
        }

        public void SwitchToFrame(By frameLocator)
        {
            // Implement switching to an iframe
            // For example:
            var frameElement = driver.FindElement(frameLocator);
            driver.SwitchTo().Frame(frameElement);
        }

        public void SwitchToDefaultContent()
        {
            // Implement switching back to the default content from an iframe
            driver.SwitchTo().DefaultContent();
        }

        public void OpenNewWindow(string url)
        {
            // Implement opening a new browser window with the given URL
            // For example:
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("window.open(arguments[0]);", url);
        }
    }


}
*/