
using Assessment.Hotels.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Hotels.Test
{
    [TestClass]
    public class Level1Tests
    {
        // Create a class "Destination" and make the following test pass.

        [TestMethod]
        public void destination_rhodos()
        {
            // Create a destination with the namn Rhodos
            var d = new Destination("Rhodos");

            // Add hotels with pools 
            d.AddHotel("Miramare", 2);    // the hotel "Miramare" has 2 pools 
            d.AddHotel("Kallithea", 1);
            d.AddHotel("Aquagrand", 3);

            // There are 2+1+3 = 6 pools in Rhodos
            // Create two methods. One of the methods should use LINQ (and the other not)
            Assert.AreEqual(6, d.TotalNumberOfPools());      
            Assert.AreEqual(6, d.TotalNumberOfPools_Linq());

            // GetName should give DESTINATION and then the name in uppercase
            Assert.AreEqual("DESTINATION RHODOS", d.GetName());

            // HotelNames should return a list of all hotelnames
            // Create two methods. One of the methods should use LINQ (and the other not)
            var hotelnames = d.HotelNames();
            var hotelnames_linq = d.HotelNames_Linq();

            Assert.AreEqual(3, hotelnames.Count);
            Assert.AreEqual("Miramare", hotelnames[0]);
            Assert.AreEqual("Kallithea", hotelnames[1]);
            Assert.AreEqual("Aquagrand", hotelnames[2]);

            // The following checks that "HotelNames_Linq" also returns correct values
            CollectionAssert.AreEqual(hotelnames, hotelnames_linq);

            // "MaxPools" should tell the maximum number of pools in a hotel on this destination 
            // Create two methods. One of the methods should use LINQ (and the other not)
            Assert.AreEqual(3, d.MaxPools());
            Assert.AreEqual(3, d.MaxPools_Linq()); 

        }

        [TestMethod]
        public void destination_yyy()
        {
            var d = new Destination("yyy");
            d.AddHotel("AA", 20);
            d.AddHotel("BB", 19);

            Assert.AreEqual(39, d.TotalNumberOfPools());
            Assert.AreEqual(39, d.TotalNumberOfPools_Linq());

            Assert.AreEqual("DESTINATION YYY", d.GetName());

            var hotelnames = d.HotelNames();
            var hotelnames_linq = d.HotelNames();

            Assert.AreEqual(2, hotelnames.Count);
            Assert.AreEqual("AA", hotelnames[0]);
            Assert.AreEqual("BB", hotelnames[1]);

            CollectionAssert.AreEqual(hotelnames, hotelnames_linq);

            Assert.AreEqual(20, d.MaxPools());
            Assert.AreEqual(20, d.MaxPools_Linq());

        }
        [TestMethod]
        public void destination_zzz()
        {
            var d = new Destination("zzz");
            d.AddHotel("AA", 4);
            d.AddHotel("BB", 8);
            d.AddHotel("CC", 2);
            d.AddHotel("DD", 1);

            Assert.AreEqual(15, d.TotalNumberOfPools());
            Assert.AreEqual(15, d.TotalNumberOfPools_Linq());

            Assert.AreEqual("DESTINATION ZZZ", d.GetName());

            var hotelnames = d.HotelNames();
            var hotelnames_linq = d.HotelNames_Linq();

            Assert.AreEqual(4, hotelnames.Count);
            Assert.AreEqual("AA", hotelnames[0]);
            Assert.AreEqual("BB", hotelnames[1]);
            Assert.AreEqual("CC", hotelnames[2]);
            Assert.AreEqual("DD", hotelnames[3]);

            CollectionAssert.AreEqual(hotelnames, hotelnames_linq);

            Assert.AreEqual(8, d.MaxPools());
            Assert.AreEqual(8, d.MaxPools_Linq());


        }
    }
}
