namespace eCommerce.Enums
{
    public enum OrderStatus
    {
        Pending,
        Ordered,
        Delivered,
        Cancelled
    }
    public enum DeliveryStatus
    {
        Pending,
        OnGoing,
        Delivered
    }
    public enum PayMethod
    {
        Paypal
    }
    public enum ProductStatus
    {
        Available,
        NotAvailable,
        Expired
    }
}
