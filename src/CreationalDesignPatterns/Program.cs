// See https://aka.ms/new-console-template for more information
using CreationalDesignPatterns;
using CreationalDesignPatterns.Builder;

var options = new List<Option>
{
    new Option()
    {
        Text = $"0 - {BuilderExample.Title}",
        Key = ConsoleKey.D0,
        Execute = BuilderExample.Execute
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