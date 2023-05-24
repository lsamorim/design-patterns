namespace SOLID.SingleResponsability
{
    public class BadJournal
    {
        private int _count = 0;
        private readonly List<string> _entries = new List<string>();

        public int AddEntry(string entry)
        {
            _entries.Add($"{++_count}: {entry}");
            return _count;
        }

        public void RemoveEntry(int index)
        {
            _entries.RemoveAt(index);
            _count--;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        public BadJournal Load(string filename)
        {
            return null;
        }
    }
}
