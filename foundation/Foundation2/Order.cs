// “Order” Class:
// 	List<string> order = new List<string>();  |  Creates a new list named “order”
// 	For code that goes through the list of costs and adds them
// 	If then statement that determines shipping and adds to cost
// 	Packing Label  |  Puts the name and a for loop to list all products in order
// 	Shipping Label(name, address)  |  Creates a shipping label

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product i in _products)
        {
            totalCost += i.GetProductPrice();  
        }
        if (_customer.IsInUSA())
        {
            totalCost += 5;  
        }
        else
        {
            totalCost += 35;  
        }
        return totalCost;
    }

    public string PackingLabel()
    {
        string packingLabel = ""; 
        foreach (Product i in _products)
        {
            packingLabel += i.GetPackingLabel(); 
        }
        return packingLabel;
    }

    public string GenerateOrderSummary() 
    {
        string orderSummary = "";
        orderSummary += _customer.ShippingLabel();
        orderSummary += PackingLabel();

        return orderSummary;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double ShippingCost() 
    {
        if (_customer.IsInUSA())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }
}
