using System;
using System.Collections.Generic;

namespace Assessment.Hotels.Core
{
    public class Hotel
    {
        public string Name { get; set; }
        public int Pools { get; set; }
        public string Description { get; set; }
        public List<string> HotelSuits { get; set; } = new List<string>();
        public Hotel(string name, int pools)
        {
            Name = name;
            Pools = pools;
            Description = $"{Name} has {Pools} pools";
        }

        public void SuitsGroup(string group)
        {
            if (HotelSuits.Contains(group))
                throw new ArgumentException("Group already added!");
            if (!System.Enum.IsDefined(typeof(Core.Suits), group))
                throw new ArgumentException("Group doesn't exist!");
            HotelSuits.Add(group);
        }

        public bool Suits(Suits suit)
        {
            return HotelSuits.Contains(suit.ToString());
        }
    }
}
