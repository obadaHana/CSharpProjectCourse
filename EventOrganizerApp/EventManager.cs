public class EventManager
{
    private ParticipantManager participantManager = new ParticipantManager();
    private string title;
    private double costPerPerson;
    private double feePerPerson;

    // properties
    public string Title
    {
        get => title;
        set => title = value;
    }

    public double CostPerPerson
    {
        get => costPerPerson;
        set => costPerPerson = value;
    }

    public double FeePerPerson
    {
        get => feePerPerson;
        set => feePerPerson = value;
    }

    public ParticipantManager Participants => participantManager;

    // calculations
    public double CalcTotalCost() => costPerPerson * participantManager.Count;
    public double CalcTotalFees() => feePerPerson * participantManager.Count;
}