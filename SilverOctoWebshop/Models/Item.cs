using System.Data.Common;

namespace Models;

public class Item
{
    public string Guid{ get; set;}
    public double Price{ get; set;}
    public string Category { get; set;}
    public string Description { get; set;}
}
