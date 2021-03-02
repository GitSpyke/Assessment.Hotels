using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Hotels.Core
{
    public class Destination
    {
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }
        public Destination(string name)
        {
            Name = name;
            Hotels = new List<Hotel>();
        }

        public void AddHotel(string v1, int v2)
        {
            Hotels.Add(new Hotel(v1, v2));
        }

        public int TotalNumberOfPools()
        {   
            int pools = 0;
            foreach (var hotel in Hotels)
                pools += hotel.Pools;
            return pools;
        }

        public int TotalNumberOfPools_Linq()
        {
            return (Hotels.Sum(h => h.Pools));
        }

        public string GetName()
        {
            return "DESTINATION " + Name.ToUpper();
        }

        public List<string> HotelNames()
        {
            List<string> hotelnames = new List<string>();
            foreach (var hotel in Hotels)
                hotelnames.Add(hotel.Name);
            return hotelnames;
        }

        public int MaxPools()
        {
            int max = 0;
            foreach (var hotel in Hotels)
                if (hotel.Pools > max)
                    max = hotel.Pools;
            return max;
        }

        public int MaxPools_Linq()
        {
            return Hotels.Max(h => h.Pools);
        }

        public List<string> HotelNames_Linq()
        {
            return Hotels.Select(h => h.Name).ToList();
        }
    }
}
