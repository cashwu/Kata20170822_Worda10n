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

        [TestMethod]
        public void input_are_feeling_should_return_are_f5g()
        {
            AbbreviateShouldBe("are f5g", "are feeling");
        }

        [TestMethod]
        public void input_isnt_are_should_return_isnt_are()
        {
            AbbreviateShouldBe("isn't are", "isn't are");
        }

        [TestMethod]
        public void input_i_should_return_i()
        {
            AbbreviateShouldBe("my. dog, isn't f5g v2y w2l.", "my. dog, isn't feeling very well.");
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
            return string.Join(" ", input.Split(' ').Select(SymbolReviate));
        }

        private static string SymbolReviate(string item)
        {
            var symbol = new[] { ',', '\'', '.' };

            foreach (var s in symbol)
            {
                if (item.Contains(s))
                {
                    return string.Join(s.ToString(), item.Split(s).Select(Reviate));
                }
            }

            return Reviate(item);
        }

        private static string Reviate(string item)
        {
            return item.Length < 4 ? item : $"{item.First()}{item.Length - 2}{item.Last()}";
        }
    }
}
