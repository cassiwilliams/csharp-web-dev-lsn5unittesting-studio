using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void CheckIfBracketsAreInRightOrder()
        {
            string testString = "]test[";

            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void CheckIfEvenNumberOfOpeningAndClosingBrackets()
        {
            string testString = "[testSring][";

            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void ReturnTrueIfStrngIsEmpty()
        {
            string testString = "";

            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void ReturnsTrueRegardlessofBracketPlacement()
        {
            string testString = "Test[String]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void ReturnsTrueIfWordWithNoBracket()
        {
            string testString = "Test";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void AcceptsWhiteSpaceWithinBrackets()
        {
            string testString = "[    ]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void AcceptsWhiteSpace()
        {
            string testString = "     ";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void AcceptsSpecialChar()
        {
            string testString = "$%^[^&]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void AccountsForMultipleBracketPairs()
        {
            string testString = "Test[String][idv]hin";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void RejectsUnorderedMultipleBracketPairs()
        {
            string testString = "test[]te]s[t";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void AcceptsProperlyNestedBrackets()
        {
            string testString = "[[[[]]]]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
        [TestMethod]
        public void RejectsImproperlyNestedBrackets()
        {
            string testString = "[[[[[]]]]";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

    }
}
