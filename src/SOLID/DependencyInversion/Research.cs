namespace SOLID.DependencyInversion
{
    public class Research
    {
        private readonly IRelationshipBrowser _relationshipBrowser;

        public Research(IRelationshipBrowser relationshipBrowser)
        {
            _relationshipBrowser = relationshipBrowser;
        }

        public void SearchAllChildrenOf(string name)
        {
            foreach (var child in _relationshipBrowser.FindAllChildrenOf(name))
            {
                Console.WriteLine($"{name} has a child called {child.Name}");
            }
        }
    }
}
