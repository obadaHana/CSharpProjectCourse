public class Participant
{
    private string firstName, lastName;
    private Address address;

    // Properties
    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    public Address Address
    {
        get => address;
        set => address = value;
    }

    public string FullName => $"{lastName}, {firstName}";

    // Constructor
    public Participant()
    {
        address = new Address();
    }

    // Validation
    public bool Validate() =>
        !string.IsNullOrEmpty(firstName) &&
        !string.IsNullOrEmpty(lastName) &&
        address.Validate();

    public override string ToString() => $"{FullName} - {address}";
}