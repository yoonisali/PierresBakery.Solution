namespace Bakery.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> { };

    public string Item { get; set; }
    public string Amount { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }

    public Order(string item, string amount, string price, string date)
    {
      Item = item;
      Amount = amount;
      Price = price;
      Date = date;
      _orderList.Add(this);
      Id = _orderList.Count;
    }

    public static List<Order> GetAll()
    {
      return _orderList;
    }

    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}