using System.Collections.Generic;
using System.Linq;
public class ParticipantManager
{
    private List<Participant> participants = new List<Participant>();

    // Add participant
    public bool AddParticipant(Participant participant)
    {
        if (participant == null || !participant.Validate())
            return false;

        participants.Add(participant);
        return true;
    }

    // Change participant
    public bool ChangeParticipantAt(Participant participant, int index)
    {
        if (!CheckIndex(index) || !participant.Validate())
            return false;

        participants[index] = participant;
        return true;
    }

    // Remove participant
    public bool RemoveParticipantAt(int index)
    {
        if (!CheckIndex(index))
            return false;

        participants.RemoveAt(index);
        return true;
    }

    // Get participant
    public Participant GetParticipantAt(int index) =>
        CheckIndex(index) ? participants[index] : null;

    // Get all participants as string array
    public string[] GetParticipantsInfo()
    {
        return participants
            .Select(p => p.ToString())
            .ToArray();
    }

    // Helper methods
    public int Count => participants.Count;
    private bool CheckIndex(int index) => index >= 0 && index < participants.Count;
}