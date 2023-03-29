class Comment{

    public Comment(){}

    List<string> commentDetails = new List<string>();
    private List<string> commentList = new List<string>();
    
    public string CommentDisplay(string name, string text){
        commentDetails.Add(name);
        commentDetails.Add(text);

        string display = $"{name}: {text}";

        return display;
    }
    
    public int CommentAmount(){
        int commentNum =  commentList.Count();
        return commentNum;
    }
}