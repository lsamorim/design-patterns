using CreationalDesignPatterns.FluentBuilderInheritanceRecursive.PersonBuilders;

namespace CreationalDesignPatterns.FluentBuilderInheritanceRecursive
{
    public class Person
    {
        public string Name { get; set; } = string.Empty;

        public string Position { get; set; } = string.Empty;

        public static PersonBuilder New() => new PersonBuilder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}
