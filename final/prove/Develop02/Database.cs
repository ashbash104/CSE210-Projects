using System;

namespace Develop02
{
    //Databse class
    public class Database
{
  private List<JournalEntries> entries;

    public Database()
    {
        entries = new List<JournalEntries>();
    }
    public List<JournalEntries> SearchEntries(DateTime date,
                                            bool byTime)
{
    List<JournalEntries> found = new List<JournalEntries>();
    foreach (JournalEntries entry in JournalEntries)
    {
        if ((!byTime) && (entry.Occurs.Date == date.Date))
            found.Add(entry);
    }
    return found;
}
}

    internal class JournalEntries
    {
        public object Occurs { get; internal set; }
    }
}
