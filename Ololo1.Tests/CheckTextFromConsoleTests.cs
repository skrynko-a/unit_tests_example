using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [TestCase("")]
        [TestCase(null)]
        [Test]
        public void CheckTextFromConsoleByEmptyStringTesting(string text)
        {
            var result = SimpleClass.CheckTextFromConsole(text);
            Assert.IsFalse(result, "Для значения " +  text + " метод отработал некорректно");
            Assert.IsFalse(result, "For the value " +  text + " the method worked incorrectly ");
        }
        
        [TestCase("jjdfhddgdf")]
        [Test]
        public void CheckTextFromConsoleByNonEmptyStringTesting(string text)
        {
            var result = SimpleClass.CheckTextFromConsole(text);
            Assert.IsTrue(result, "Для значения " +  text + " метод отработал некорректно");
            Assert.IsTrue(result, "Для значения " +  text + " метод отработал некорректно");
            Assert.IsTrue(result, "Для значения " +  text + " метод отработал некорректно");
            Assert.IsTrue(result, "For the value " +  text + " the method worked incorrectly ");
        }
    }
}