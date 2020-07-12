# UIAutomation Framework using Selenium C#
This solution demonstrates automated testing of web pages with Selenium and C#.NET for Vacation Direct application. It can also be used as a template for new Selenium test projects. This solution contain 2 projects - UIAutomationFramework which defines framework components and UIAutomationForVacationDirect which define pages and test cases.
Three tests are included that run tests on the website 'http://www.vacationsdirect.com', the tests can be executed on three browsers: Firefox and chrome by passing browser type from the calling test case/feature file.

Uses:
- SpecFlow (BDD)
- Selenium (WebDriver)
- NUnit 2.x
- specflow-report-templates (for reporting)
- pickles (documentation generator for features and scenarios)
- utilises Page Object Model pattern
- takes screenshots on failure of web tests

#Getting started
To run the tests:
1. Install Visual Studio (Enterprise 2019)
2. Install NuGet (package manager)
3. Connect to github project (View > Team Explorer)
4. clone 


download the solution and run the feature files using specflow MSTest Test runner. All selenium and specflow dependencies are included in the solution.
Below are the dependancies used for developing this solution:
- Selenium Web Driver
- Specflow
- NUnit
- MSTest

The tests are structured according to the Page Object Pattern, Web Elements and element operations are binded together in a file and exposed as methods. Out of the box Selenium supports locating elements using the element id or an xpath selector etc.
Element interactions like send data to an element, get data from an element, button clicks, wait for an element to be displayed on a page, producing driver context for executing test cases etc. are defined and produced from framework components.
