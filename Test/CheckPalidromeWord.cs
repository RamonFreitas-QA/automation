using Core;
using Data;
using Xunit;

namespace Test
{
    public class CheckPalindromeWord
    {
        [Fact]
        public void CheckPalindromeWordTest()
        {
            var liststring = new DataString().DataJson();

            foreach (var text in liststring.Data)
            {
                bool palidrome = new CheckString(text)
                                        .CheckPalindromeString();

                if (palidrome)
                    Assert.True(palidrome, $"A palavra {text} é palidrome!");           

            }
        }

        [Fact]
        public void CheckPalindromeWordTestFalse()
        {
            var liststring = new DataString().DataJson();

            foreach (var text in liststring.Data)
            {
                bool palidrome = new CheckString(text)
                                        .CheckPalindromeString();

                if (!palidrome)
                    Assert.False(palidrome, $"A palavra {text} é palidrome!");

            }
        }
    }
}
