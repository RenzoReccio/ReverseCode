namespace ReversingCodeTest
{
    public class Tests
    {
        [TestFixture]
        public class UnitTests
        {
            [Test]
            [TestCase("A4B5C2", ExpectedResult = "AAAABBBBBCC")]
            [TestCase("C2F1E5", ExpectedResult = "CCFEEEEE")]
            [TestCase("T4S2V2", ExpectedResult = "TTTTSSVV")]
            [TestCase("A1B2C3D4", ExpectedResult = "ABBCCCDDDD")]
            [TestCase("ABCD", ExpectedResult = "")]
            [TestCase("1234", ExpectedResult = "")]
            [TestCase("", ExpectedResult = "")]
            public static string MysteryFunc(string str)
            {
                Console.WriteLine($"Input: {str}");
                return Program.MysteryFunc(str);
            }
        }
    }
}