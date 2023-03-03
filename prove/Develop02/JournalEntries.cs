public class JournalEntries{
    List<string> Entries = new List<string>();
    public JournalEntries(){}
    Prompts _prompt = new Prompts();
    public void StoreEntry(){
        Entries.Add(_prompt.entry);
        Entries.Add(_prompt.dateText);
    }
    public void PrintEntries(){
        foreach (string _entry in Entries){
            Console.WriteLine(_entry);
        }
    }
}