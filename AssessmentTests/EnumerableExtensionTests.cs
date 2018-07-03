using Assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AssessmentTests
{
    [TestClass]
    public class EnumerableExtensionTests
    {
        [TestMethod]
        public void CustomWhereShouldFilterItems()
        {
            var sequence = Enumerable.Range(0, 10);

            var evenNumbers = sequence.CustomWhere(item => item % 2 == 0);

            Assert.AreEqual(5, evenNumbers.Count());
        }
    }
}
