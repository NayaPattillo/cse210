class Customer{

    List<string> customerList = new List<string>();
    private string _name;
    private string _address;
    
    public Customer(){}
    public void SetCustomer(string name, string address){
        _name = name;
        Address addAddress = new Address();
        address = addAddress.GetAddress();
        _address = address;
    }
    public string GetCustomer(){
        string customer = $"{_name}{_address}";
        customerList.Add(customer);
        return customer;
    }


}