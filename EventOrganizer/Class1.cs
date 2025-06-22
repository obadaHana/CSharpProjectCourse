public class EventManager
{
    private double costPerPerson; // cost per guest (expense)
    private double feePerPerson; // fee per guest (income)
    private string[] guestList; // array to store guest names
    private int numOfGuests = 0; // tracks number of registered guests

    // constructor
    public EventManager(int maxNumOfGuests)
    {
        guestList = new string[maxNumOfGuests];
    }

    // properties
    public double CostPerPerson
    {
        get { return costPerPerson; }
        set { if (value >= 0.0) costPerPerson = value; }
    }

    public double FeePerPerson
    {
        get { return feePerPerson; }
        set { if (value >= 0.0) feePerPerson = value; }
    }

    public int Count
    {
        get { return numOfGuests; }
    }

    // methods
    public bool AddNewGuest(string firstName, string lastName)
    {
        if (numOfGuests < guestList.Length && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
        {
            guestList[numOfGuests] = $"{lastName.ToUpper()}, {firstName}";
            numOfGuests++;
            return true;
        }
        return false;
    }

    public bool ChangeAt(int index, string firstName, string lastName)
    {
        if (CheckIndex(index) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
        {
            guestList[index] = $"{lastName.ToUpper()}, {firstName}";
            return true;
        }
        return false;
    }

    public bool DeleteAt(int index)
    {
        if (CheckIndex(index))
        {
            guestList[index] = string.Empty;
            numOfGuests--;
            MoveElementsOneStepToLeft(index);
            return true;
        }
        return false;
    }

    private void MoveElementsOneStepToLeft(int index)
    {
        for (int i = index; i < guestList.Length - 1; i++)
        {
            guestList[i] = guestList[i + 1];
            guestList[i + 1] = string.Empty;
        }
    }

    private bool CheckIndex(int index)
    {
        return index >= 0 && index < numOfGuests;
    }

    public double CalcTotalCost()
    {
        return numOfGuests * costPerPerson;
    }

    public double CalcTotalFees()
    {
        return numOfGuests * feePerPerson;
    }

    public string[] GetGuestList()
    {
        string[] currentGuests = new string[numOfGuests];
        for (int i = 0; i < numOfGuests; i++)
        {
            currentGuests[i] = guestList[i];
        }
        return currentGuests;
    }

    public string GetItemAt(int index)
    {
        if (CheckIndex(index))
            return guestList[index];
        return string.Empty;
    }
}