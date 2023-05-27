namespace CreationalDesignPatterns.FluentBuilderInheritanceRecursive.PersonBuilders
{
    public abstract class PersonInfoBuilder<TSelf> : BasePersonBuilder
            where TSelf : PersonInfoBuilder<TSelf>
    {
        public TSelf Called(string name)
        {
            person.Name = name;
            return (TSelf)this;
        }
    }
}
