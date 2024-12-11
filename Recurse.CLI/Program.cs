using System.CommandLine;

namespace Recurse.CLI;

public static class Program
{
    public static async Task Main(string[] args)
    {
        // root commands are run when the app is called without any args
        var rootCommand = new RootCommand("Simple command-line app");

        rootCommand.SetHandler(() =>
        {
            Console.WriteLine("Hello, World!");
        });

        await rootCommand.InvokeAsync(args);
    }
}