namespace SOLID.DependencyInversion
{
    public class BadResearch
    {
        private readonly BadRelationships _relationships;

        public BadResearch(BadRelationships relationships)
        {
            _relationships = relationships;
        }

        public void SearchAllChildrenOf(string name)
        {
            var relations = _relationships.Relations;
            foreach (var relation in relations.Where(r => r.Item1.Name == name && r.Item2 == Relationship.Parent))
            {
                Console.WriteLine($"{name} has a child called {relation.Item3.Name}");
            }
        }
    }
}
