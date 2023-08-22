public class Reservation 
{
    public Order OrderedBy { get; set; }

    public bool IsOrderedBy(Order order)
    {
        if (order.IsAccepted)
            return true;
        if(OrderedBy == order)
            return true;
        return false;
    }
}




public class Order{
    public bool IsAccepted { get; set; }
}