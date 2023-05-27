namespace CreationalDesignPatterns.FluentBuilderInheritanceRecursive.PersonBuilders
{
    public abstract class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>>
            where TSelf : PersonJobBuilder<TSelf>
    {
        public TSelf WorksAsA(string position)
        {
            person.Position = position;
            return (TSelf)this;
        }
    }
}
