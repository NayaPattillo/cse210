class Order{

    public Order(){}
    public string PackingLabel(){
        Product product = new Product();
        string packingLabel = product.GetProduct();
        return packingLabel;
    }
    public string ShippingLabel(){
        Customer customer = new Customer();
        string shippingLabel = customer.GetCustomer();
        return shippingLabel;
    }
}