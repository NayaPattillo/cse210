class Video{

    List<string> videoDetails = new List<string>();
    public Video(){}
    public string VideoDisplay(string title, string author, string length){
        videoDetails.Add(title);
        videoDetails.Add(author);
        videoDetails.Add(length);
        
        string display = $"{title} | {length} by: {author}";

        return display;
    }

}