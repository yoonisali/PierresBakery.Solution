namespace Bakery.Models
{
  public class Vendor
  {
    private static List<Vendor> _vendorList = new List<Vendor> { };

    public string Name { get; set; }
    public string Location { get; set; }
    public int Id { get; }
    public List<Order> orderList { get; set; }

    public Vendor(string name, string location)
    {
      Name = name;
      Location = location;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      orderList = new List<Order> { };
    }

    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }

    public static void ClearAll()
    {
      _vendorList.Clear();
    }

  }
}