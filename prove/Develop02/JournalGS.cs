
class JournalGS
{
    List<string>entries;

    public JournalGS()
    {

     List <EntryGS> entries = new List<EntryGS>();
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
        List<String> records = new List<String>();
        foreach(Entry entry in entries ){
            records.Add(entry.getEntryAsCVS());
        }
        Console.WriteLine("journal ");
        String _filename = Console.ReadLine();


    }
 public void LoadFromCSV(){
    Console.WriteLine(" journal ");
    String _filename =Console.ReadLine();


    List<string> records =System.IO.File.ReadAllLines(_filename).ToList();
    foreach(String record in records ){
  String[] splitString = record.Split('|');
  Entry entry  =new Entry (splitString[0], splitString[1],splitString[2]);
  entries.Add(entry);

    }

 }

}

