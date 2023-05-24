namespace SOLID
{
    public class Option
    {
        public string Text { get; set; }

        public ConsoleKey Key { get; set; }

        public Action Execute { get; set; }
    }
}
