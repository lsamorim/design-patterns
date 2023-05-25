// See https://aka.ms/new-console-template for more information
using SOLID;
using SOLID.DependencyInversion;
using SOLID.InterfaceSegregation;
using SOLID.LiskovSubstitution;
using SOLID.OpenClosed;
using SOLID.SingleResponsability;

var options = new List<Option>
{
    new Option()
    {
        Text = $"S - {SingleResponsabilityExample.Title}",
        Key = ConsoleKey.S,
        Execute = SingleResponsabilityExample.Execute
    },
    new Option()
    {
        Text = $"O - {OpenClosedExample.Title}",
        Key = ConsoleKey.O,
        Execute = OpenClosedExample.Execute
    },
    new Option()
    {
        Text = $"L - {LiskovSubstitutionExample.Title}",
        Key = ConsoleKey.L,
        Execute = LiskovSubstitutionExample.Execute
    },
    new Option()
    {
        Text = $"I - {InterfaceSegregationExample.Title}",
        Key = ConsoleKey.I,
        Execute = InterfaceSegregationExample.Execute
    },
    new Option()
    {
        Text = $"D - {DependencyInversionExample.Title}",
        Key = ConsoleKey.D,
        Execute = DependencyInversionExample.Execute
    }
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


