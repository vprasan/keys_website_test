using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using testspecflow.Utility;
using System.Drawing.Imaging;


namespace testspecflow
{
    [Binding]
    public class Hooks
    {

        //Global Variable for Extend report
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        // private readonly IObjectContainer _objectContainer;


        /*
        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        */

        [BeforeTestRun]
        public static void InitializeReport()

        {

            //Initialize Extent report before test starts
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\vprasan\source\repos\testspecflow\testspecflow\reports\ExtentReport.html");
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            //Attach report to reporter
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }


        [AfterTestRun]

        public static void TearDownReport()
        {

            //Flush report once test completes
            extent.Flush();

        }


        [BeforeFeature]
        public static void BeforeFeature()
        {

            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);

        }

        [AfterStep]
        public void InsertReportingSteps()
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            //   PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
            //  MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            //  object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            //Pending Status
            /*
            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }*/
        }

        [BeforeScenario]

        public void Initialize()
        {

            IWebDriver driver = BrowserFactory.BrowserInit();
            ConfigFile.driver = driver;

            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterScenario]

        public void CleanUp()

        {

          //  if (ScenarioContext.Current.TestError == null)
           // {
               
                Console.WriteLine("driver" + ConfigFile.driver);

                string title = ScenarioContext.Current.ScenarioInfo.Title;
            //    title = "first";
              //  Screenshot screenshot = ((ITakesScreenshot)ConfigFile.driver).GetScreenshot();
               // screenshot.SaveAsFile(@"C:\Users\vprasan\source\repos\testspecflow\testspecflow\screenshots\" + title + ".png", System.Drawing.Imaging.ImageFormat.Png);

                getscreenshot.capture(title);
                BrowserFactory.Close();
            //}



        }
    }

}