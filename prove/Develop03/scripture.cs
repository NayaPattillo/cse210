public class Scripture{
    private string _scripture1;
    private string _scripture2;

    public Scripture(){
        _scripture1 = "I Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.";
        //1Nephi 1:1
    }
    public Scripture(string _verse1, string _verse2){
        _verse1 = "And there came a voice unto me, saying: Enos, thy sins are forgiven thee, and thou shalt be blessed.";
        _verse2 = "And I Enos, knew that God could not lie; wherefore, my guilt was swept away.";
        _scripture2 = $"{_verse1} {_verse2}";
        //Enos 1:5-6
    }

    public string GetScripture1(){
        string text = _scripture1;
        return text;
    }
    public string GetScripture2(){
        string text = _scripture2;
        return text;
    }
}