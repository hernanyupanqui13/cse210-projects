class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
    }

    public double GetTotalCost() {
        double total = 0;
        int shippingCost = this.GetShippingCost();
        foreach (Product product in _products) {
            total += product.GetTotalCost();
        }
        total += shippingCost;
        return total;
    }

    public string GetPackingLabel() {
        string packingLabel = "";
        foreach (Product product in _products)
        {
           packingLabel += $"{product.GetName()} - {product.GetProductId()}";
           packingLabel += "\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel() {

        return "Shipping Details: " + 
            "\n----------------"+
            "\nName:" + 
            $"\n{_customer.GetName()}" + 
            "\n" +
            "\nAddress:" +
            $"\n{_customer.GetAddressAsString()}";
    }

    private int GetShippingCost() {
        return _customer.LivesInUSA() ? 5 : 35;
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }
}