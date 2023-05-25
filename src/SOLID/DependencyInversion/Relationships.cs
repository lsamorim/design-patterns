namespace SOLID.DependencyInversion
{
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();

        public List<(Person, Relationship, Person)> Relations => _relations;

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            foreach (var relation in Relations.Where(r => r.Item1.Name == name && r.Item2 == Relationship.Parent))
            {
                yield return relation.Item3;
            }
        }
    }
}
