using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace YourNamespace.Tests
{
    public class StudentTableTest : IDisposable
    {
        private IWebDriver? _driver;
        private WebDriverWait? _wait;

        [Fact]
        public void StudentRegTest()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Moved WebDriverWait instantiation here

            _driver.Navigate().GoToUrl("http://localhost:4200");

            _driver.FindElement(By.LinkText("Students")).Click();

            _wait.Until(drv => drv.FindElement(By.Id("student-table")).FindElements(By.TagName("tr")).Count > 1);

            var table = _driver.FindElement(By.Id("student-table"));
            var rows = table.FindElements(By.TagName("tr"));
            AssertTableRowCount(table, 1);

            //var expectedValues = new[] { "3", "Diego", "Jaumandreu", "ButtonPresent" };
            //AssertTableValues(rows, expectedValues);

            AddEntity("Add Student", "Enter student name", "Enter student surname", "Diego", "Jaumandreu Ondaro");
            // Wait until the modal with the ID "myModal" is no longer visible
            
            AssertTableRowCount(table, 2);
            DeleteEntityByName(table, "Diego", "Jaumandreu Ondaro", "delete-student");
            AssertTableRowCount(table, 1);
        }
        [Fact]
        public void CourseRegTest()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Moved WebDriverWait instantiation here

            _driver.Navigate().GoToUrl("http://localhost:4200");

            _driver.FindElement(By.LinkText("Courses")).Click();

            _wait.Until(drv => drv.FindElement(By.Id("course-table")).FindElements(By.TagName("tr")).Count > 1);

            var table = _driver.FindElement(By.Id("course-table"));
            var rows = table.FindElements(By.TagName("tr"));
            AssertTableRowCount(table, 1);

            //var expectedValues = new[] { "3", "Diego", "Jaumandreu", "ButtonPresent" };
            //AssertTableValues(rows, expectedValues);

            AddEntity("Add Course", "Enter course name", "Enter course description", "English", "English 101");
            // Wait until the modal with the ID "myModal" is no longer visible

            AssertTableRowCount(table, 2);
            DeleteEntityByName(table, "English", "English 101", "delete-course");
            AssertTableRowCount(table, 1);
        }
        [Fact]
        public void SubjectRegTest()
        {
            _driver = new ChromeDriver();
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Moved WebDriverWait instantiation here

            _driver.Navigate().GoToUrl("http://localhost:4200");

            _driver.FindElement(By.LinkText("Subjects")).Click();

            _wait.Until(drv => drv.FindElement(By.Id("subject-table")).FindElements(By.TagName("tr")).Count > 1);

            var table = _driver.FindElement(By.Id("subject-table"));
            var rows = table.FindElements(By.TagName("tr"));
            AssertTableRowCount(table, 1);

            AddEntity("Add Subject", "Enter subject name", "Enter subject description", "Calculus", "A study of change and motion using derivatives and integrals.");
            // Wait until the modal with the ID "myModal" is no longer visible

            AssertTableRowCount(table, 2);
            DeleteEntityByName(table, "Calculus", "A study of change and motion using derivatives and integrals.", "delete-subject");
            AssertTableRowCount(table, 1);
        }
        public void Dispose()
        {
            // Quit the driver, closing every associated window
            _driver.Quit();
        }
        private void AssertTableValues(IEnumerable<IWebElement> rows, string[] expectedValues)
        {
            if (expectedValues.Length == 0)
            {
                // Assert the table only contains the header row
                Assert.Single(rows);
            }
            else
            {
                foreach (var row in rows.Skip(1)) // skip the header row
                {
                    var cols = row.FindElements(By.TagName("td")).ToList();

                    for (var i = 0; i < cols.Count; i++)
                    {
                        if (i < cols.Count - 1)
                        {
                            // Assert that the cell text matches the expected value
                            Assert.Equal(expectedValues[i], cols[i].Text);
                        }
                        else
                        {
                            // For the last column, check if the button is present
                            var button = cols[i].FindElement(By.Id("delete-student"));
                            Assert.NotNull(button); // The "ButtonPresent" check
                        }
                    }
                }
            }
        }
        private void AddEntity(string buttonName, string placeholder1, string placeholder2, string value1, string value2)
        {
            // Click on the specified button
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//button[normalize-space()='{buttonName}']"))).Click();

            // Wait for the first input to be visible and then send the value
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//input[@placeholder='{placeholder1}']"))).SendKeys(value1);

            // Wait for the second input to be visible and then send the value
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath($"//input[@placeholder='{placeholder2}']"))).SendKeys(value2);

            // Submit the form (assuming the submit button's text is 'Add' for all entities, adjust if not the case)
            _driver.FindElement(By.XPath("//button[normalize-space()='Add']")).Click();
        }
        private void AssertTableRowCount(IWebElement table, int expectedRowCount)
        {
            _wait.Until(drv => table.FindElements(By.TagName("tr")).Count - 1 == expectedRowCount);

            var rows = table.FindElements(By.TagName("tr")).Count;

            // Subtracting 1 to exclude the header row from the count.
            rows--;

            Assert.Equal(expectedRowCount, rows);
        }
        private void DeleteEntityByName(IWebElement table, string firstName, string surname, string deleteButtonId)
        {
            var rows = table.FindElements(By.TagName("tr")).Skip(1); // Skip the header row

            foreach (var row in rows)
            {
                var cols = row.FindElements(By.TagName("td")).ToList();

                // Assuming the structure: ID, First Name, Last Name, ...
                if (cols[1].Text.Equals(firstName) && cols[2].Text.Equals(surname))
                {
                    // Click the delete button for the matched entity
                    var deleteButton = row.FindElement(By.Id(deleteButtonId));
                    deleteButton.Click();
                    return; // Exit the function after deleting
                }
            }
            throw new Exception($"Entity with the name {firstName} {surname} not found in the table.");
        }
    }
}
