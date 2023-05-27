namespace CreationalDesignPatterns.FluentBuilderInheritanceRecursive.PersonBuilders
{
    public abstract class BasePersonBuilder
    {
        protected Person person = new Person();

        public Person Build() { return person; }
    }
}
