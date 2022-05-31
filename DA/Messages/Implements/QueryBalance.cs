using DA.Actors;

namespace DA.Messages.Implements;

/// <summary>
/// To check the balance we send a QueryBalance message.
/// The result of the query should be sent as a message to another actor,
/// so we include the receiver in the query message.
/// </summary>
public class QueryBalance : Message
{
    public Actor Receiver { get; set; }
}