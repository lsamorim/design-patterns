namespace CreationalDesignPatterns.Builder
{
    public class HTMLBuilder
    {
        private readonly string _rootName;
        private HTMLElement _rootElement;

        public HTMLBuilder(string rootName)
        {
            _rootName = rootName;
            _rootElement = new HTMLElement()
            {
                Name = _rootName,
            };
        }

        public void AddChild(string name, string text)
        {
            var element = new HTMLElement()
            {
                Text = text,
                Name = name
            };
            _rootElement.Children.Add(element);
        }

        public void Clear()
        {
            _rootElement = new HTMLElement()
            {
                Name = _rootName,
            };
        }

        public override string ToString()
        {
            return _rootElement.ToString();
        }
    }
}
