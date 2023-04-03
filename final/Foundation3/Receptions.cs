class Receptions:Event{
    //email (RSVP)
    public Receptions(){}

    string _email;
    public void SetDetails(string email){
        _email = email;
    }
    public string GetDetails(){
        string reception = $"To RSVP message {_email}";
        return reception;
    }
}