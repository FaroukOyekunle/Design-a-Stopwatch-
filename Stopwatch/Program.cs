// See https://aka.ms/new-console-template for more information
using Stopwatch;

var stopWatch = new StopWatch();
var currentState = false;

while (true)
{
    if (!currentState)
        Console.WriteLine("Type s to Start,\n x to Stop \n r to Repeat \n e to Exit \n ");

    var userInput = Console.ReadLine();

    if (userInput.ToLower().Equals("s"))
    {
        stopWatch.Start();
        Console.WriteLine("StopWatch has started' \n x to Stop \n r to Repet \n any other key to Exit\n ");
        currentState = true;
    }

    if (userInput.ToLower().Equals("x"))
    {
        stopWatch.Stop();
        Console.WriteLine("The Total Time Span calculated was -> " + stopWatch.GetInterval());
        currentState = false;
    }

    if (userInput.ToLower().Equals("r"))
    {
        currentState = false;
        Console.WriteLine("StopWatch has been Restarted");
        continue;
    }

    if (!userInput.ToLower().Equals("s") && !userInput.ToLower().Equals("x") && !userInput.ToLower().Equals("r"))
    {
        break;
    }
}
