
class JournalGS
{
    List<string>entries;

    public JournalGS()
    {

     entries =new List<EntryGS>();
    }

    public void DisplayJournalEntries ()
    {

        foreach(Entry entry in entries)
        {
           entry.dispplayEntry();
           
        }

    }

    public void CreateJournalEntry()
    {

    }

    public void SaveToCSV()
    {

    }
 public void LoadFromCSV(){
    
 }

}

