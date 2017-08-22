using System;
using System.Linq;
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

        [TestMethod]
        public void input_feeling_should_return_f5g()
        {
            AbbreviateShouldBe("f5g", "feeling");
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
            if (input.Length < 4)
            {
                return input;
            }

            return $"{input.First()}{input.Length-2}{input.Last()}";
        }
    }
}
