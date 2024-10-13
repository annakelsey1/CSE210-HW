// “Customer” Class:
//  	String CustomerName  |  Gets customer name
// 	String Address  |  Gets address
// 	Customer(CustomerName, Address)  |  stores the name and address together
// 	Bool USA  |  Keeps track of if the customer is in the US or not

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.InUS();
    }

    public string ShippingLabel()
    {
        return _customerName + "\n" + _address.GetAddress();
    }
}