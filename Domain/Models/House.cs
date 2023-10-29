namespace BuyMyHouse.Models
{
    public class House
    {
        //House: Price, Location, Description, Address, Date 

        public int HouseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CityName { get; set; }
        public string Zipcode { get; set; }
        public string StreetName { get; set; }
        public DateTime Date { get; set; }

    }
}
