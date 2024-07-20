public class Order {

    private List<Product> _products;
    private Customer _customer;


    public Order(string name, string streetAddress, string city, string state, string country) {
        _customer = new Customer(name, streetAddress, city, state, country);
        _products = new List<Product>();
    }


    public double TotalOrderCost() {
        return CalculateTotal() + CalculateShipping();
        
    }

    public double CalculateTotal() {
        double total = 0;
        foreach (Product product in _products) {
            total += product.TotalCost();
        }
        return total;
    }

    public double CalculateShipping() {
        if (_customer.LivesInUsa()) {
            return 5;
        }

        else {
            return 35;
        }


    }

    public void AddProduct(string name, string productId, double price, int quantity) {
        Product product = new Product(name, productId, price, quantity);
        _products.Add(product);
    }


    public string PackingLabel() {
        string packinglabel = "";
        packinglabel += "\nPacking Label:";
        foreach (Product product in _products) {
            packinglabel += $"\nID:{product.GetProductId()} -- {product.GetName()}";
        }
        return packinglabel;
    }

    public string ShippingLabel() {
        string shippingLabel = "";
        
        shippingLabel += "Ship to:";
        shippingLabel += $"\n{_customer.GetName()}";
        shippingLabel += $"\n{_customer.GetAddress()}\n";
        return shippingLabel;
    }

    public void DisplayAll() {

        Console.WriteLine(PackingLabel());
        Console.WriteLine($"Price: ${CalculateTotal()}\nShipping: ${CalculateShipping()}\nTotal: ${TotalOrderCost()}\n");
        Console.WriteLine(ShippingLabel());
    }

}