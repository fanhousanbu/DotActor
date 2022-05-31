namespace DA.Messages.Implements;

/// <summary>
/// The final message is the result of the balance check.
/// </summary>
public class Balance : Message
{
    public decimal Amount { get; set; }
}