public class MathAssignment : Assignment{
    private string _textbook;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbook, string problems) : base(studentName, topic){
        _textbook = textbook;
        _problems = problems;
    }
    public string GetList(){
        return $"Section {_textbook} Problems {_problems}";
    }
}