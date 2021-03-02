using Assessment.Hotels.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assessment.Hotels.Test
{
    [TestClass]
    public class Level2Tests
    {
        // Note: keep in mind that the Suits-enum in the future may change (and your methods should keep on working)

        [TestMethod]
        public void hotel_miramare()
        {
            var h1 = new Hotel("Miramare", 2);
            h1.SuitsGroup("Adult");
            h1.SuitsGroup("Family");
            h1.SuitsGroup("Senior");

            Assert.IsTrue(h1.Suits(Suits.Adult));
            Assert.IsTrue(h1.Suits(Suits.Family));
            Assert.IsTrue(h1.Suits(Suits.Senior));

            Assert.AreEqual("Miramare has 2 pools", h1.Description);

        }

        [TestMethod]
        public void hotel_x()
        {
            var h1 = new Hotel("X", 5);
            h1.SuitsGroup("Family");
            h1.SuitsGroup("Senior");

            Assert.IsTrue(h1.Suits(Suits.Senior));
            Assert.IsTrue(h1.Suits(Suits.Family));

            Assert.AreEqual("X has 5 pools", h1.Description);

        }

        [TestMethod]
        public void cant_add_same_group_twice()
        {
            var h1 = new Hotel("X", 5);

            h1.SuitsGroup("Family");
            h1.SuitsGroup("Senior");

            Assert.ThrowsException<ArgumentException>(() =>
            {
                h1.SuitsGroup("Family");
            });
        }

        [TestMethod]
        public void cant_add_group_that_doesnt_exist()
        {
            var h1 = new Hotel("X", 5);

            Assert.ThrowsException<ArgumentException>(() =>
            {
                h1.SuitsGroup("Familyyyyyyyyyyy");
            });
        }

    }
}
