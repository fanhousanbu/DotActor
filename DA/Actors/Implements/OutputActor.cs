using DA.Messages.Implements;

namespace DA.Actors.Implements;

public class OutputActor : Actor
{
    public void Handle(Balance message)
    {
        Console.WriteLine("Balance is {0}", message.Amount);
    }
}