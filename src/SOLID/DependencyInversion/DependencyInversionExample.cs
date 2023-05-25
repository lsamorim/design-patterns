namespace SOLID.DependencyInversion
{
    public static class DependencyInversionExample
    {
        public static string Title = "Dependency Inversion Principle";

        public static void Execute()
        {
            Console.WriteLine($"*** Start: {Title} ***\n");

            var parent = new Person { Name = "Homer" };
            var child1 = new Person { Name = "Bart" };
            var child2 = new Person { Name = "Lisa" };


            // Bad
            Console.WriteLine($"** Bad approach **\n");
            var badRelationships = new BadRelationships();
            badRelationships.AddParentAndChild(parent, child1);
            badRelationships.AddParentAndChild(parent, child2);

            var badResearch = new BadResearch(badRelationships);
            badResearch.SearchAllChildrenOf("Homer");

            Console.ReadKey();

            // Good
            Console.WriteLine($"\n** Good approach **\n");
            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);

            var research = new Research(relationships);
            research.SearchAllChildrenOf("Homer");

            Console.WriteLine($"\n*** End: {Title} ***\n");
            Console.ReadKey();
        }
    }
}
