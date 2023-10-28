namespace BuyMyHouse.Models
{
    public class House
    {
        //House: Price, Location, Description, Address, Date 

        public int HouseId { get; set; }
        public string PropertyTitle { get; set; }
        public string PropertyDescription { get; set; }
        public double Price { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Streetname { get; set; }
    }
}
