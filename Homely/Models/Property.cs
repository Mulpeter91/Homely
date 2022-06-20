namespace Homely.Models
{
    public class Property
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set;  }
        public string? Description { get; set; }
        public DateTime Created { get; set; }
        public Address? Address { get; set; }
        public PropertySpecifications? Specifications { get; set; }
        public List<Image>? Images { get; set; }
    }

    public class Image
    {
        public string? ImageBase64 { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }

    public class Address
    {
        public int? Number { get; set; }
        public string? Name { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Postcode { get; set; }
        public Counties County { get; set; }
        public Countries Country { get; set; }
    }

    public class PropertySpecifications
    {
        public PropertyTypes PropertyType { get; set; }
        public double SquareMeters { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }
        public HeatRatings HeatRating { get; set; }
    }

    public enum PropertyTypes
    {
        House,
        Apartment
    }

    public enum Counties
    {
        Cavan,
        Cork,
        Dublin,
        Meath,
        Wexford,
        Tipperary
    }

    public enum Countries
    {
        RepublicOfIreland
    }

    public enum HeatRatings
    {
        A,
        B,
        C,
        D
    }
}