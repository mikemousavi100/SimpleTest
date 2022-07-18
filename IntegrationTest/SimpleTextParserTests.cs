

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTest;

namespace IntegrationTest
{
    [TestClass]
    public class SimpleTextParserTests
    {
        private ILogger _logger = new ConsoleLogger();

        [TestMethod]
        public void WordSort()
        {
            // Arrange
            var parser = new SimpleTextParser(_logger);
            string input = "Zoom Boom";
            string expected = "Boom Zoom";

            // Act
            var actual = parser.SortStringParagraph(input);

            // Assert
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void CaseSort()
        {
            // Arrange
            var parser = new SimpleTextParser(_logger);
            string input = "boom Boom";
            string expected = "Boom boom";

            // Act
            var actual = parser.SortStringParagraph(input);

            // Assert
            Assert.AreEqual<string>(expected, actual);
        }

         [TestMethod]
        public void RemoveInvalidChars()
        {
            // Arrange
            var parser = new SimpleTextParser(_logger);
            string input = "b, b";
            string expected = "b b";

            // Act
            var actual = parser.SortStringParagraph(input);

            // Assert
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void SimpleTest1()
        {
            // Arrange
            var parser = new SimpleTextParser(_logger);
            string input = "Go baby, go";
            string expected = "baby Go go";

            // Act
            var actual = parser.SortStringParagraph(input);

            // Assert
            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            // Arrange
            var parser = new SimpleTextParser(_logger);
            string input = "CBA, abc aBc ABC cba CBA.";
            string expected = "ABC aBc abc CBA CBA cba";

            // Act
            var actual = parser.SortStringParagraph(input);

            // Assert
            Assert.AreEqual<string>(expected, actual);
        }
    }
}