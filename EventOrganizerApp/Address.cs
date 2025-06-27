public class Address
{
    private string street, city, zipCode;

    private Countries country;

    // Properties
    public string Street
    {
        get => street;
        set => street = value;
    }

    public string City
    {
        get => city;
        set => city = value;
    }

    public string ZipCode
    {
        get => zipCode;
        set => zipCode = value;
    }

    public Countries Country
    {
        get => country;
        set => country = value;
    }

    // Constructors with chain-calling
    public Address() : this(string.Empty, string.Empty, string.Empty) { }

    public Address(string street, string zip, string city)
        : this(street, zip, city, Countries.Sverige) { }

    public Address(string street, string zip, string city, Countries country)
    {
        this.street = street;
        zipCode = zip;
        this.city = city;
        this.country = country;
    }

    // Validation
    public bool Validate() => !string.IsNullOrEmpty(city);

    // Format country name (optional)
    private string GetCountryString() => country.ToString().Replace('_', ' ');

    public override string ToString() => $"{street} - {city} - {zipCode} - {GetCountryString()}";
}