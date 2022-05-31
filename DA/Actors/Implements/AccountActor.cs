using DA.Messages.Implements;

namespace DA.Actors.Implements;

public class AccountActor : Actor
{
    private decimal _balance;

    public void Handle(Deposit message)
    {
        _balance += message.Amount;
    }

    public void Handle(QueryBalance message)
    {
        message.Receiver.Send(new Balance {Amount = _balance});
    }
}