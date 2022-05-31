namespace DA.Messages.Implements;

/// <summary>
/// To deposit money we send a deposit message with an amount.
/// </summary>
public class Deposit : Message
{
    public decimal Amount { get; set; }
}