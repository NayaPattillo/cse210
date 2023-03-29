class Comment{

    List<string> commentDetails = new List<string>();
    public string CommentDisplay(string name, string text){
        commentDetails.Add(name);
        commentDetails.Add(text);

        string display = $"{name}: {text}";

        return display;
    }

    
    List<string> commentList = new List<string>();
    public int CommentAmount(){
        int commentNum =  commentList.Count();
        return commentNum;
    }
}