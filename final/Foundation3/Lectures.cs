class Lectures:Event{
    //speaker, capacity
    public Lectures(){}

    string _speaker;
    int _capacity;

    public void SetDetails(string speaker, int capacity){
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetDetails(){
        string lecture = $"Speaker: {_speaker} | Event Capacity: {_capacity}";
        return lecture;
    }
}