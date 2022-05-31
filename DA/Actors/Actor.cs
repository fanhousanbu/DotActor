using System.Threading.Tasks.Dataflow;
using DA.Messages;

namespace DA.Actors;

/// <summary>
/// We implement an actor using an ActionBlock from the DataFlow library.
/// An ActionBlock has an input queue you can post messages to
/// and an action that will be invoked for each received message
/// </summary>
public abstract class Actor
{
    private readonly ActionBlock<Message> _action;

    protected Actor()
    {
        _action = new ActionBlock<Message>(message =>
        {
            dynamic self = this;
            dynamic mess = message;
            self.Handle(mess);
        });
    }
    
    public Task Completion
    {
        get
        {
            _action.Complete();
            return _action.Completion;
        }
    }

    public void Send(Message message)
    {
        _action.Post(message);
    }
}