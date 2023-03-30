class Address{

    List<string> addressList = new List<string>();

    string _street;
    string _city;
    string _state;
    string _country;
    int shipping;

    public Address(){}

    public void SetAddress(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetAddress(){
        string address = $"{_street}{_city}{_state}{_country}";
        addressList.Add(address);
        return address;
    }

}