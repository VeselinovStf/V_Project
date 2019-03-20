using ES.Models.Abstract;
using System;

namespace ES.Models
{
    public class Estate : Entity
    {
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int StreetAddress { get; set; }

        public decimal Size { get; set; }

        public string Description { get; set; }

        public bool IsPublic { get; set; }
        
        public bool IsRentable { get; set; }

        public bool IsSellable { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal RentingPrice { get; set; }
        
        public int Capacity { get; set; }

        public byte[] Image { get; set; }


    }
}
