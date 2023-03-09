public class Word{
    
    private List<string> scripture = new List<string>();
    private string newScripture = "";
    
    public Word(string scriptureString){
        var words = scriptureString.Split(" ");
        foreach (string word in words){
            scripture.Add(word);
        }
    }
    public Word(){
        var random = new Random();
        int index = scripture.Count;
        int wordIndex = random.Next(0, index+1);
        string randWord = (scripture[wordIndex]);
        
        scripture.Remove(randWord);
        scripture.Add("_");
        newScripture = scripture.ToString();
    }

    public string GetReplacement(){
        string text = newScripture;
        return text;
    }

}