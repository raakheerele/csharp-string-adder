using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringConcatenatorLogic;

namespace StringConcatenatorModule
{
    [TestClass]
    public class StringConcatenatorTest
    {
        [TestMethod]
        public void test_add_two_strings_result_lh_space_rh()
        {
            StringConcatenator cut = new StringConcatenator();
            string lh = "AA";
            string rh = "BB";

            string expected = "AA BB";

            string actual = cut.addStrings(lh, rh);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void test_add_two_strings_lh_space_result_lh_space_rh()
        {
            StringConcatenator cut = new StringConcatenator();
            string lh = "AA ";
            string rh = "BB";

            string expected = "AA BB";

            string actual = cut.addStrings(lh, rh);

            Assert.AreEqual(expected, actual);
        }
    }
}
