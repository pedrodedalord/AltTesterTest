using AltTester.AltTesterUnitySDK.Driver;
using NUnit.Framework;

namespace Editor
{
    public class MyFirstTest
    {   //Important! If your test file is inside a folder that contains an .asmdef file, please make sure that the assembly definition references NUnit.
        private AltDriver _altDriver;
    
        //Before any test it connects with the socket
        [OneTimeSetUp]
        public void SetUp()
        {
            _altDriver = new AltDriver();
        }

        //At the end of the test closes the connection with the socket
        [OneTimeTearDown]
        public void TearDown()
        {
            _altDriver.Stop();
        }

        [Test]
        public void StartButtonLoadsMainScene()
        {
            _altDriver.LoadScene("Start");

            _altDriver.FindObject(By.NAME, "StartButton").Click();
            _altDriver.WaitForCurrentSceneToBe("Main");
        }

        public void RunButtonStartsRun()
        {
            _altDriver.WaitForCurrentSceneToBe("Main");
            _altDriver.FindObject(By.NAME, "StartButton").Click();
            _altDriver.WaitForObject(By.NAME, "Game").enabled = true;
        }

    }
}
