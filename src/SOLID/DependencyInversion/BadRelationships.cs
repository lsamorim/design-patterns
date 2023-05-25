namespace SOLID.DependencyInversion
{
    public class BadRelationships
    {
        private List<(Person, Relationship, Person)> _relations = new List<(Person, Relationship, Person)>();
        
        public List<(Person, Relationship, Person)> Relations => _relations;

        public void AddParentAndChild(Person parent, Person child)
        {
            _relations.Add((parent, Relationship.Parent, child));
            _relations.Add((child, Relationship.Child, parent));
        }
    }
}
