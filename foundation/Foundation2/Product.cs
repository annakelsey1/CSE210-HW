// “Product” Class:
// String ProductID  |  creates the product Id
// String PName  |  Product name
// Decimal Price  |  price of item
// Int Quantity  |  How many of each item
// Product(ID, PName, Price, Quantity)  |  Collecting everything into one place
// GetTotal()  |  Gets total cost


public class Product
{
    private string _pName;
    private string _productID;  
    private double _price; 
    private int _quantity;

    public Product(string pName, string productID, double price, int quantity)
    {
        _pName = pName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

  
    public double GetProductPrice()
    {
        return _price * _quantity;
    }

   
    public string GetPackingLabel()
    {
        return "Product Name: " + _pName + ", Product ID: " + _productID + ", Price: " + _price + ", Quantity: " + _quantity;
    }
}
