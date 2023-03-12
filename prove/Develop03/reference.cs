public class Reference{
    private string _reverence1;
    private string _reverence2;

    public Reference(){
        _reverence1 = "1Nephi 1:1";
    }
    public Reference(string _verse1, string _verse2){
        _verse1 = "5";
        _verse2 = "6";
        _reverence2 = $"Enos 1:{_verse1}-{_verse2}";
    }

    public string GetReference1(){
        string text = _reverence1;
        return text;
    }
    public string GetReference2(){
        string text = _reverence2;
        return text;
    }
}