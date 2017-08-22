using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170822_Worda10n
{
    [TestClass]
    public class Worda10nTests
    {
        [TestMethod]
        public void input_are_should_return_are()
        {
            AbbreviateShouldBe("are", "are");
        }

        private static void AbbreviateShouldBe(string expected, string input)
        {
            var abbreviator = new Abbreviator();
            var actual = abbreviator.Abbreviate(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Abbreviator
    {
        public string Abbreviate(string input)
        {
            return input;
        }
    }
}
