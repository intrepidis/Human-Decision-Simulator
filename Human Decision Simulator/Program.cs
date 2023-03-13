const string id = "f2d3d8d0c346b195a65da423";

if (string.IsNullOrEmpty(Environment.ProcessPath))
{
    Console.WriteLine("ERROR: Program doesn't know its own path.");
    return;
}

if (args.Length > 0 && args[0] == id)
{
    for (int i = 0; i < 100; i++)
        if (i % 8 == 0)
            Thread.Yield();

    Environment.Exit(1);
    return;
}

var signal = new Mutex();
var manualResetEvent = new ManualResetEvent(false);

var stack = new Stack<int>();
stack.Push(-1);

var threadedMethod = new ParameterizedThreadStart(
    param =>
    {
        if (param == null)
        {
            Console.WriteLine("ERROR: Thread parameter was lost.");
            return;
        }

        var outValue = (int[])param;

        int exitCode;
        {
            var process = System.Diagnostics.Process.Start(Environment.ProcessPath, id);
            process.WaitForExit();
            exitCode = process.ExitCode;
        }
        signal.WaitOne();
        if (stack.Peek() == 0)
        {
            signal.ReleaseMutex();
            return;
        }
        outValue[0] = exitCode;
        stack.Push(stack.Pop() + 1);
        signal.ReleaseMutex();
        manualResetEvent.Set();
    });

int[] outValue;

outValue = new int[1];
new Thread(threadedMethod).Start(outValue);

outValue = new int[1];
new Thread(threadedMethod).Start(outValue);

manualResetEvent.WaitOne();

Console.WriteLine(outValue[0]);
