public class Word{
    
    private List<string> scripture = new List<string>();
    
    public Word(string scriptureString){
        var words = scriptureString.Split(" ");
        foreach (string word in words){
            scripture.Add(word);
        }
    }
    public string GetReplacement(){
        var random = new Random();
        int index = scripture.Count;

        int wordIndex = random.Next(0, index);
        string randWord = (scripture[wordIndex]);
        scripture = scripture.Select( x => x.Replace(randWord, "_")).ToList();

        //scripture.ForEach(word => Console.WriteLine(word));

        string newScripture = string.Join(" ", scripture);
        return newScripture;
    }

}