// See https://aka.ms/new-console-template for more information
using CreationalDesignPatterns;
using CreationalDesignPatterns.FluentBuilder;
using CreationalDesignPatterns.FluentBuilderInheritanceRecursive;

var options = new List<Option>
{
    new Option()
    {
        Text = $"0 - {FluentBuilderExample.Title}",
        Key = ConsoleKey.NumPad0,
        Execute = FluentBuilderExample.Execute
    },
    new Option()
    {
        Text = $"1 - {FluentBuilderInheritanceRecursiveExample.Title}",
        Key = ConsoleKey.NumPad1,
        Execute = FluentBuilderInheritanceRecursiveExample.Execute
    },
};

while (true)
{
    Console.WriteLine("Select an option:");
    foreach (var optionToSelect in options)
    {
        Console.WriteLine(optionToSelect.Text);
    }

    var optionToExecute = Console.ReadKey();
    Console.Write("\b \b");

    if (optionToExecute.Key == ConsoleKey.Escape)
        break;

    Console.Clear();

    var option = options.Where(opt => opt.Key == optionToExecute.Key).FirstOrDefault();
    if (option != null)
        option.Execute();

    Console.Clear();
}