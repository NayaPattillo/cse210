public class Reference{
    private string reverence1;
    private string reverence2;

    public Reference(){
        reverence1 = "1Nephi 1:1";
    }
    public Reference(string verse1, string verse2){
        verse1 = "5";
        verse2 = "6";
        reverence2 = $"Enos 1:{verse1}-{verse2}";
    }

    public string GetReference1(){
        string text = reverence1;
        return text;
    }
    public string GetReference2(){
        string text = reverence2;
        return text;
    }
}