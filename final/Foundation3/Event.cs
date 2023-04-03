class Event{
    //Title, Description, Date, Time, Address

    string _title;
    string _description;
    string _date;
    string _time;
    string _address;

    public Event(){}

    public void SetEvent(string title, string description, string date, string time, string address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetEvent(){
        string _event = $"{_title}: {_description} | {_date} . {_time} . {_address}";
        return _event;
    }
}