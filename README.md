# UIAutomation Framework using Selenium C#
This solution demonstrates automated testing of web pages with Selenium and C#.NET for Vacation Direct application. It can also be used as a template for new Selenium test projects. This solution contain 2 projects - UIAutomationFramework which defines framework components and UIAutomationForVacationDirect which define pages and test cases.
Three tests are included that run tests on the website 'http://www.vacationsdirect.com', the tests can be executed on three browsers: Firefox and chrome by passing browser type from the calling test case/feature file. 
The tests are structured according to the Page Object Pattern, Web Elements and element operations are binded together in a file and exposed as methods. Out of the box Selenium supports locating elements using the element id or an xpath selector etc.
Element interactions like send data to an element, get data from an element, button clicks, wait for an element to be displayed on a page, producing driver context for executing test cases etc. are defined and produced from framework components.

# Uses:
- SpecFlow (BDD)
- Selenium (WebDriver)
- NUnit 2.x
- specflow-report-templates (for reporting)
- pickles (documentation generator for features and scenarios)
- utilises Page Object Model pattern
- takes screenshots on failure of web tests

# Getting started
To run the tests:
1. Install Visual Studio 
2. Install NuGet (package manager)
3. Connect to github project (View > Team Explorer)
4. clone repository: https://github.com/ashokpunnam/UIAutomation.git
5. Use NuGet (Project > Manage NuGet packages) to install below packages: 
  - Selenium Web Driver
  - NUnit   
  - NUnit3TestAdaptor
  - SpecFlow
  - SpecFlow.Assist.Dynamic
  - SpecFlow.MSTest
  - SpecFlow.Tools.MsBuild.Generation
  - Cucumber.Messages
  - Gherkin
  - Microsoft.CodeCoverage
 6. Create folder 'dependencies'. Download chrome, IE, Edge drivers directly here via NuGet packages
   - Right click on the chromedriver.exe and select Properties
   - Ensure the Build Action Content is selected Copy to Output Directory Copy Always has been selected.
   - This will ensure that chromedriver.exe is always in the folder of the running assembly so it can be used.
 7. As part of the NuGet installs, you will notice that an App.config file was generated in the structure of the project. -- If we chosen to use MSTest instead of NUnit as a         test runner, we need to update this file.
 8. In Visual Studio, select Tools > Extensions and Updates > Online. Install SpecFlow extension and restart VS
 9. Install SpecRun (NuGet) for enhanced reporting and IDE intellisense, formatting etc.
 
Reporting
