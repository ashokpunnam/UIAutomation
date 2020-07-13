# UIAutomation Framework using Selenium C#
This solution demonstrates automated testing of web pages with Selenium and C#.NET for Vacation Direct application. It can also be used as a template for new Selenium test projects. This solution contain 2 projects - UIAutomationFramework which defines framework components and UIAutomationForVacationDirect which define pages and test cases.
Three tests are included that run tests on the website 'http://www.vacationsdirect.com', the tests can be executed on three browsers: Firefox and chrome by passing browser type from the calling test case/feature file. 
The tests are structured according to the Page Object Pattern, Web Elements and element operations are binded together in a file and exposed as methods. Out of the box Selenium supports locating elements using the element id or an xpath selector etc.
Element interactions like send data to an element, get data from an element, button clicks, wait for an element to be displayed on a page, producing driver context for executing test cases etc. are defined and produced from framework components.

# Uses:
- SpecFlow (BDD)
- Selenium (WebDriver)
- NUnit 
- MSTest


# Getting started
To run the tests:
1. Install Visual Studio and then .Net Test.SDK & .Net Desktop Development package
2. Install NuGet (package manager)
3. Connect to github project (View > Team Explorer)
4. clone repository: https://github.com/ashokpunnam/UIAutomation.git
5. Use NuGet (Project > Manage NuGet packages) to install below packages if they are not already downloaded from github while cloning the project:
  - Selenium Web Driver
  - Selenium Chrome Driver
  - Selenium Firefox Driver
  - NUnit   
  - NUnit3TestAdaptor
  - SpecFlow
  - SpecFlow.Assist.Dynamic
  - SpecFlow.MSTest
  - SpecFlow.Tools.MsBuild.Generation
  - Cucumber.Messages
  - Gherkin
  - Microsoft.CodeCoverage  
  - SpecRun
 6. In Visual Studio, select Tools > Extensions and Updates > Online. Install SpecFlow extension and restart VS 
 
# Below Items are considered while developing the solution:
  1.  Create seperate projects for defining and developing framework components and Test components
  2. Create Hooks and Base paages to communicate between Framework components and test components
  3. Develop framework in such a way that it can be easily manintainable, reusable and scalable
  4. Framework can be made readable by adding comments, indentations and documentation. This was not done due to time constraints
  5. All classes/files in framework and test projects are designed keeping in mind some of below principals
      - Object Oriented and Generic/functional programming principals in mind
      - Do Not Repeat and clean code
      - Modular      
 
# Below are the to do items and can be added to the framework/test project:
  1. Log Utility to log test execution for tracing and debugging
  2. Reporting utility to customize and generate test execution and summary report
  3. Generic page to handle page objects in test cases/step definitions in effiecient and cleaner way
  4. Comments and documentation
  5. Solution can be integrated in a Jenkins/Azure pipeline and can be executed as part of CICD/DevOps process
  6. Code Review and Refactoring
  7. Configuration Readers and Settings to control environment variables in an efficient way
