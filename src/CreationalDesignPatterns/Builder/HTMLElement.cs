using System.Text;

namespace CreationalDesignPatterns.Builder
{
    public class HTMLElement
    {
        public string? Name { get; set; }
        public string? Text { get; set; }

        public List<HTMLElement> Children { get; set; } = new List<HTMLElement>();

        private const int IndentSize = 2;

        private string ToStringImplementation(int indentLevel)
        {
            var sb = new StringBuilder();

            var indentText = new string(' ', IndentSize * indentLevel);

            sb.AppendLine($"{indentText}<{Name}>");

            if (!string.IsNullOrEmpty(Text))
            {
                sb.Append(new string(' ', IndentSize * (indentLevel + 1)));
                sb.AppendLine($"{Text}");
            }

            foreach (var child in Children)
            {
                sb.Append(child.ToStringImplementation(indentLevel + 1));
            }

            sb.AppendLine($"{indentText}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImplementation(0);
        }
    }
}
