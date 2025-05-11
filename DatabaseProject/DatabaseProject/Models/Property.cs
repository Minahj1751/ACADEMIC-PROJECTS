using System;

namespace DatabaseProject.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public int PropertyOwnerId { get; set; }
        public string PropertyName { get; set; }
        public string City { get; set; }
        public decimal Rent { get; set; }
        public int FloorNo { get; set; }
        public int RoomNo { get; set; }
        public string Parking {  get; set; }
        public string FreshWater { get; set; }
        public string ImageBase64 { get; set; }
       
    }
}
