namespace SOLID.SingleResponsability
{
    public class JournalPersistence
    {
        public void Save(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());
            }
        }

        public BadJournal Load(string filename)
        {
            return null;
        }
    }
}
