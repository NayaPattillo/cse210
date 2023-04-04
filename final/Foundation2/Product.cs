class Product{

    List<string> productList = new List<string>();

    private int _price;
    private int _quantity;
    private string _name;
    private string _id;

    public void SetProduct(string name, string id, int price, int quantity){
        _price = price;
        _quantity = quantity;
        _name = name;
        _id = id;
    }
    public string GetProduct(){
        string product = $"{_name}: {_id} | {_price}";
        productList.Add(product);
        return product;
    }
    
    public int CalcPrice(){
        int total = _price * _quantity;
        return total;
    }

}