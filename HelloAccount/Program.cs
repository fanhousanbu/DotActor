// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using DA.Actors.Implements;
using DA.Messages.Implements;

var account = new AccountActor();
var output = new OutputActor();

Parallel.For(0, 10000, i =>
{
    account.Send(new Deposit {Amount = 50});
});
account.Send(new QueryBalance {Receiver = output});

await account.Completion;
await output.Completion;

Console.WriteLine($"Done!");

Console.ReadLine();