class EntryGS
{
    string date, prompt, response;


    public EntryGS(string _date ,string _prompt, string _response){

    }

    public void DisplayEntry()
    {

    }
    public string getEntryAsCSV()
    {
        return string.Format("{0}|{1}|{2}",date ,prompt, response);
        
    }
}
